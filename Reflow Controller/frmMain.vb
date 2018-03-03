﻿
' This program is intended for use with a T-962 Reflow Oven
' Written by : Duncan Ellison
' V1.0.0
' Master Copy held at : https://subversion.assembla.com/svn/colnewater/T-962ReflowController
'----------------------------------------------------------------------------------


Imports System.IO.Ports
Imports System.Threading
Imports System.Threading.Thread
Imports System.String
Imports ReflowController.GlobalParameters
Imports ReflowController.GlobalFunctions



Public Class frmMain

    ' Receive buffer Variables
    Dim RXArray(2047) As Char               ' Text buffer. Must be global to be accessible from other threads.
    Dim RXCnt As Integer = 0                ' Receive buffer pointer. Must be global too.
    Dim ReadBuffer As String = ""
    Dim Terminator() As Char = {vbCr, ","}
    Dim tokens As String()
    Dim command As String()
    Dim RxString As String = ""
    Dim flgRxStringComplete As Boolean = False

    ' Make a new System.IO.Ports.SerialPort instance, which is able to fire events.
    Dim WithEvents COMPort As New SerialPort

    '--------------------------------------------------------------------------------
    ' FORM LOAD/ CLOSE
    '------------------------------------------------------------------------------
    ' ON LOAD
    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Display the s/w version
        ToolStripStatusLabel1.Text = "Software Version : " & Application.ProductVersion

        ToolStripStatusLabel2.Text = "           Status : Standby"

        txtPhase.ForeColor = Color.DimGray
        txtPhase.Text = "Standby"
        txtProfileSelected.Text = ""

        ' COM PORT SET UP
        ' This subroutine is activated when the form is loaded. It does all the basic initializations.
        ' Note! Baud Rates above 115.2 KBaud requires a special UART like e.g. 16C650, 16C750, 16C850 or 16C950 and a special driver.
        ' Note that the standard UART 16C550 has no hardware flow control - except for UART's from Texas Instruments.
        ' The minimum FIFO size is calculated on the basis of a 1.4 mS response time, which is the absolute minimum for Windows applications.

        For Each COMString As String In My.Computer.Ports.SerialPortNames ' Load all available COM ports.
            COMPortsBox.Items.Add(COMString)
        Next

        COMPortsBox.Sorted = True

        BaudRateBox.Items.Add("110")
        BaudRateBox.Items.Add("300")
        BaudRateBox.Items.Add("600")
        BaudRateBox.Items.Add("1200")
        BaudRateBox.Items.Add("1800")
        BaudRateBox.Items.Add("2400")
        BaudRateBox.Items.Add("4800")
        BaudRateBox.Items.Add("7200")
        BaudRateBox.Items.Add("9600")
        BaudRateBox.Items.Add("14400")
        BaudRateBox.Items.Add("19200")      ' Min. FIFO size 3 Bytes (8030 or 8530)
        BaudRateBox.Items.Add("38400")
        BaudRateBox.Items.Add("57600")      ' Min. FIFO size 8 bytes
        BaudRateBox.Items.Add("115200")     ' Min. FIFO size 16 bytes (16C550)
        BaudRateBox.Items.Add("230400")     ' Min. FIFO size 32 bytes (16C650)
        BaudRateBox.Items.Add("460800")     ' Min. FIFO size 64 bytes (16C750)
        BaudRateBox.Items.Add("921600")     ' Min. FIFO size 128 bytes (16C850 or 16C950)

        imgConnectStatus.Image = My.Resources.Red_Light

        'Retrieve settings from last time run or set defaults if not available
        COMPortsBox.Text = My.Settings.lastCOMPort.ToString

        ' Make sure we start up from a known condition
        txtPhase.Text = "Standby"
        txtPhase.ForeColor = Color.LightBlue

        'Set Max text to "-" as it may be random at this point
        txtMaxTemp.Text = "Max Oven : - °C" & vbCrLf & "Max Profile : - °C"

        If flgShowTCMax Then
            txtMaxTC.Visible = True
        Else
            txtMaxTC.Visible = False
        End If

        ' Set up seconds timer for 1S tick
        Timer1.Interval = 1000

        'Set the toolstrip
        ToolStripStatusLabel4.Text = ""

        'Set the maximum width of the graph
        MaxTimePoints = 470
        ProfileChart.ChartAreas("OvenTemp").AxisX.Maximum = MaxTimePoints

        ' Get the machine ID from the app settings
        GlobalParameters.MachineID = My.Settings.MachineID

        'Get the stored run number from the app settings
        RunNumber = My.Settings.RunNumber
        txtRunNumber.Text = RunNumber.ToString.Trim

        'Get the user option to reduce the number of over points to 2 per second
        flgReducePoints = My.Settings.flgReducePoints

        'Get stored Liquidus temps 
        Profile0Liquidus = My.Settings.Profile0Liquidus
        Profile1Liquidus = My.Settings.Profile1Liquidus
        Profile2Liquidus = My.Settings.Profile2Liquidus
        Profile3Liquidus = My.Settings.Profile3Liquidus
        Profile4Liquidus = My.Settings.Profile4Liquidus
        Profile5Liquidus = My.Settings.Profile5Liquidus
        Profile6Liquidus = My.Settings.Profile6Liquidus

        ' Get stored profile names
        ProfileName0 = My.Settings.ProfileName0
        ProfileName1 = My.Settings.ProfileName1
        ProfileName2 = My.Settings.ProfileName2
        ProfileName3 = My.Settings.ProfileName3
        ProfileName4 = My.Settings.ProfileName4
        ProfileName5 = My.Settings.ProfileName5
        ProfileName6 = My.Settings.ProfileName6

        'Get oven type
        If IsNullOrEmpty(My.Settings.OvenType) Then My.Settings.OvenType = "T-962"
        GlobalParameters.OvenType = My.Settings.OvenType
        GlobalFunctions.SetTCNames()

        'Set Max TC to "-" as it may be random at this point
        txtMaxTC.Text = TC1Name & ": - °C " & vbCrLf & TC2Name & ": - °C " & vbCrLf & TC3Name & ": - °C " & vbCrLf & TC4Name & ": - °C " _
                            & vbCrLf & "TAL : " & LiquidusTime.ToString.Trim & "S"

        ' Set headings above text box depending on oven type
        lblHeaderTC1.Text = GlobalParameters.TC1Name
        lblHeaderTC2.Text = GlobalParameters.TC2Name
        lblHeaderTC3.Text = GlobalParameters.TC3Name
        lblHeaderTC4.Text = GlobalParameters.TC4Name

        'Get other settings 
        If My.Settings.flgShowAirThermocouples = True Then
            flgShowAirThermocouples = True
        Else
            flgShowAirThermocouples = False
        End If

        If My.Settings.flgShowBoardThermocouples = True Then
            flgShowBoardThermocouples = True
        Else
            flgShowBoardThermocouples = False
        End If

        If My.Settings.flgShowTCMax Then
            flgShowTCMax = True
        Else
            flgShowTCMax = False
        End If

        'Re-initialize the array holding the results
        Array.Clear(profileTempStore, 0, profileTempStore.Length)
        idxProfileTempStore = 0

    End Sub

    ' ON APP CLOSE
    Private Sub FormIsClosing(ByVal sender As Object, ByVal e As ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' This subroutine is activated when the form is closed. It closes the COM port. Without such a close command,
        ' the garbage collector may close the COM port while it is still in use!

        If MessageBox.Show("Do you really want to close the Reflow Controller ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            ' Save settings and close down the program gracefully
            My.Settings.lastComPort = COMPortsBox.Text
            My.Settings.lastBaudRate = BaudRateBox.Text
            My.Settings.flgShowAirThermocouples = GlobalParameters.flgShowAirThermocouples
            My.Settings.flgShowBoardThermocouples = GlobalParameters.flgShowBoardThermocouples
            My.Settings.flgShowTCMax = GlobalParameters.flgShowTCMax
            My.Settings.MachineID = GlobalParameters.MachineID
            My.Settings.OvenType = GlobalParameters.OvenType
            My.Settings.flgReducePoints = GlobalParameters.flgReducePoints
            My.Settings.Profile0Liquidus = GlobalParameters.Profile0Liquidus
            My.Settings.Profile1Liquidus = GlobalParameters.Profile1Liquidus
            My.Settings.Profile2Liquidus = GlobalParameters.Profile2Liquidus
            My.Settings.Profile3Liquidus = GlobalParameters.Profile3Liquidus
            My.Settings.Profile4Liquidus = GlobalParameters.Profile4Liquidus
            My.Settings.Profile5Liquidus = GlobalParameters.Profile5Liquidus
            My.Settings.Profile6Liquidus = GlobalParameters.Profile6Liquidus

            My.Settings.ProfileName0 = ProfileName0
            My.Settings.ProfileName1 = ProfileName1
            My.Settings.ProfileName2 = ProfileName2
            My.Settings.ProfileName3 = ProfileName3
            My.Settings.ProfileName4 = ProfileName4
            My.Settings.ProfileName5 = ProfileName5
            My.Settings.ProfileName6 = ProfileName6

            ' Close COM port on a new thread when the form is terminated with [X]
            Dim t As New Thread(AddressOf ClosePort)
            t.Start()
        End If
    End Sub

    '------------------------------------------------------------------------------
    ' MESSAGE HANDLING
    '------------------------------------------------------------------------------

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Dim RXByte As Byte
        Try
            Do
                '----- Start of communication protocol handling -----------------------------------------------------------
                Try
                    Do
                        RXByte = COMPort.ReadByte
                        Select Case ChrW(RXByte)
                            Case vbLf
                                flgRxStringComplete = True
                                Exit Do
                            Case vbCr
                                flgRxStringComplete = True
                                Exit Do
                            Case Else
                                RXArray(RXCnt) = ChrW(RXByte)
                                RXCnt = RXCnt + 1
                        End Select
                    Loop Until (COMPort.BytesToRead = 0)
                Catch ex As Exception
                    imgConnectStatus.Image = My.Resources.Red_Light
                End Try


                If flgRxStringComplete Then
                    ' We carried on reading until we hit a <LF>, so now we have a full command 
                    ' Copy it to a safe place, so that we can continue to manipulate the buffer pointers
                    RxString = ConvertCharArrayToString(RXArray, RXCnt)

                    ' Zero the incoming array pointer
                    RXCnt = 0
                    flgRxStringComplete = False

                    ' Check for a blank line
                    If RxString.Length = 0 Then
                        Continue Do
                    End If

                    'Tokenize the input line
                    tokens = RxString.Split(Terminator)

                    ''Decide whether to Display the string in the UI text box
                    If tokens.Length = 11 Then
                        'It's probably a reflow or bake message
                        Select Case tokens(10).ToLower.Trim
                            Case "reflow", "bake", "bake-preheat", "standby"
                                If tokens(0).ToString.Trim.EndsWith("0") OrElse tokens(0).ToString.Trim.EndsWith("5") Then
                                    Me.Invoke(New MethodInvoker(AddressOf Display))                ' Always display n.0 and n.5
                                Else
                                    If Not flgReducePoints Then
                                        Me.Invoke(New MethodInvoker(AddressOf Display)) ' Start "Display" on the UI thread
                                    End If
                                    ' Do nothing
                                End If
                            Case Else
                                Me.Invoke(New MethodInvoker(AddressOf Display))
                        End Select
                    Else
                        ' It's somthing else, just display it
                        Me.Invoke(New MethodInvoker(AddressOf Display)) ' Start "Display" on the UI thread
                    End If

                    ' Now parse the recieved data and do something useful with it

                    'Check for 'Stopping bake/reflow' message
                    If RxString.ToLower.Trim = "stopping bake/reflow" Then
                        txtPhase.Invoke(Sub() txtPhase.Text = "MANUAL STOP") ' Cross thread call
                        Timer1.Stop()
                        'Change button back to 'reflow' so we can start the next cycle
                        btnReflow.Invoke(Sub() btnReflow.Text = "REFLOW")   ' Cross thread call
                        btnReflow.Invoke(Sub() btnReflow.BackColor = Color.YellowGreen)
                        ' Reenable the profile change cbo and the save log button
                        cboProfile.Invoke(Sub() cboProfile.Enabled = True)
                        btnSaveLog.Invoke(Sub() btnSaveLog.Enabled = True)
                    End If

                    'Check for 'Bake complete' message
                    If RxString.ToLower.Trim = "bake complete" Then
                        txtPhase.Invoke(Sub() txtPhase.Text = "BAKE COMPLETE") ' Cross thread call
                        Timer1.Stop()
                        'Change button back to 'reflow' so we can start the next cycle
                        btnReflow.Invoke(Sub() btnReflow.Text = "REFLOW")   ' Cross thread call
                        btnReflow.Invoke(Sub() btnReflow.BackColor = Color.YellowGreen)
                        ' Reenable the profile change cbo and the save log button
                        cboProfile.Invoke(Sub() cboProfile.Enabled = True)
                        btnSaveLog.Invoke(Sub() btnSaveLog.Enabled = True)
                    End If

                    'Check for 'Reflow done' message
                    If RxString.ToLower.Trim = "reflow done" Then
                        txtPhase.Invoke(Sub() txtPhase.Text = "COMPLETE") ' Cross thread call
                        'Stop the run timer
                        Timer1.Stop()
                        'Change button back to 'reflow' so we can start the next cycle
                        btnReflow.Invoke(Sub() btnReflow.Text = "REFLOW")   ' Cross thread call
                        btnReflow.Invoke(Sub() btnReflow.BackColor = Color.YellowGreen)
                        ' Re-enable the profile change cbo and the save log button
                        cboProfile.Invoke(Sub() cboProfile.Enabled = True)
                        btnSaveLog.Invoke(Sub() btnSaveLog.Enabled = True)
                    End If

                    'Check for 'Selected Profile n: xxxxxxxxx' message ' this means profile was changed by the command line and we need to match it in the UI
                    If Mid(RxString.ToLower.Trim, 1, 16) = "selected profile" Then
                        Dim myProfile As Int16 = Convert.ToInt16(Mid(RxString.ToLower.Trim, 18, 1))
                        If (myProfile > 0 AndAlso myProfile < 7) Then
                            cboProfile.Invoke(Sub() cboProfile.SelectedIndex = myProfile)
                        End If
                        'Also set string to say which profile this is 
                        Dim testString() As String = RxString.Split(":")
                        Dim ProfileName As String = testString(1).Trim
                        txtProfileSelected.Invoke(Sub() txtProfileSelected.Text = ProfileName) ' Cross thread call
                        ' Now we have captured this name, store it in the app settings
                        Select Case myProfile
                            Case 0
                                GlobalParameters.ProfileName0 = ProfileName
                            Case 1
                                GlobalParameters.ProfileName1 = ProfileName
                            Case 2
                                GlobalParameters.ProfileName2 = ProfileName
                            Case 3
                                GlobalParameters.ProfileName3 = ProfileName
                            Case 4
                                GlobalParameters.ProfileName4 = ProfileName
                            Case 5
                                GlobalParameters.ProfileName5 = ProfileName
                            Case 6
                                GlobalParameters.ProfileName6 = ProfileName
                        End Select

                    End If

                    ' Check for bake, reflow and pre-heat message
                    Try
                        If tokens.Length >= 10 Then
                            If tokens(10).ToLower.Trim = "reflow" Or tokens(10) = "bake-preheat" Or tokens(10) = "standby" Then
                                If tokens(0).ToString.Trim.EndsWith("0") OrElse tokens(0).ToString.Trim.EndsWith("5") Then
                                    Me.Invoke(New MethodInvoker(AddressOf ProcessProfileMsg))
                                Else
                                    If flgReducePoints Then
                                        'Do Nothing
                                    Else
                                        Me.Invoke(New MethodInvoker(AddressOf ProcessProfileMsg))
                                    End If
                                End If
                            End If
                        End If
                    Catch
                        'Will get here if tokens(10) does not exist 
                    End Try

                End If
                '----- End of communication protocol handling -------------------------------------------------------------
            Loop Until (COMPort.BytesToRead = 0)  ' Don't return if more bytes have become available in the meantime
        Catch
        End Try

    End Sub

    ' Process incoming message from the controller
    Private Sub ProcessProfileMsg()
        Try
            Select Case tokens(10).ToLower.Trim
                ' *** MANUAL MODE - PREHEAT PHASE ***
                Case "bake-preheat"
                    txtPhase.Text = "Preheat"
                    txtPhase.ForeColor = Color.Orange
                    updateGraph("Target", tokens(0), tokens(5))
                    updateTemp(tokens(5))
                    updateGraph("OvenTemp", tokens(0), tokens(6))
                    If flgShowAirThermocouples Then
                        updateGraph("TC1", tokens(0), tokens(1))
                        updateGraph("TC2", tokens(0), tokens(2))
                    End If
                    If flgShowBoardThermocouples Then
                        updateGraph("TC3", tokens(0), tokens(3))
                        updateGraph("TC4", tokens(0), tokens(4))
                    End If
                    updateTemp(tokens(6))
                    UpdateTempBar(tokens(7))
                    UpdateFanBar(tokens(8))
                    UpdateProbes(tokens(6), tokens(1), tokens(2), tokens(3), tokens(4))

                ' *** MANUAL MODE - BAKE PHASE ***
                Case "bake"
                    txtPhase.Text = "Bake"
                    txtPhase.ForeColor = Color.Red
                    updateGraph("Target", tokens(0), tokens(5))
                    updateTemp(tokens(5))
                    updateGraph("OvenTemp", tokens(0), tokens(6))
                    If flgShowAirThermocouples Then
                        updateGraph("TC1", tokens(0), tokens(1))
                        updateGraph("TC2", tokens(0), tokens(2))
                    End If
                    If flgShowBoardThermocouples Then
                        updateGraph("TC3", tokens(0), tokens(3))
                        updateGraph("TC4", tokens(0), tokens(4))
                    End If
                    updateTemp(tokens(6))
                    UpdateTempBar(tokens(7))
                    UpdateFanBar(tokens(8))
                    UpdateProbes(tokens(6), tokens(1), tokens(2), tokens(3), tokens(4))

                ' *** AUTO REFLOW MODE ***
                Case "reflow"
                    'Store the data
                    If idxProfileTempStore < profileTempStoreSize Then
                        If RxString.Length > 1 Then                         ' remove blank lines
                            profileTempStore(idxProfileTempStore) = RxString
                            idxProfileTempStore = idxProfileTempStore + 1
                        End If
                    Else
                        idxProfileTempStore = 0                             ' If exceeded the buffer length, wrap round
                    End If

                    'Set banner
                    txtPhase.Text = "Reflow"
                    txtPhase.ForeColor = Color.Red
                    ' Update Graph
                    updateGraph("Target", tokens(0), tokens(5))
                    updateTemp(tokens(5))
                    updateGraph("OvenTemp", tokens(0), tokens(6))
                    If flgShowAirThermocouples Then
                        updateGraph("TC1", tokens(0), tokens(1))
                        updateGraph("TC2", tokens(0), tokens(2))
                    End If
                    If flgShowBoardThermocouples Then
                        updateGraph("TC3", tokens(0), tokens(3))
                        updateGraph("TC4", tokens(0), tokens(4))
                    End If
                    updateTemp(tokens(6))
                    UpdateTempBar(tokens(7))
                    UpdateFanBar(tokens(8))
                    UpdateProbes(tokens(6), tokens(1), tokens(2), tokens(3), tokens(4)) ' 6 = Current calculated temp, rest are TC1 - 4
                Case "standby"
                    txtPhase.Text = "Standby"
                    txtPhase.ForeColor = Color.Blue
                    updateTemp(tokens(6))
                    UpdateTempBar(tokens(7))
                    UpdateFanBar(tokens(8))
                    UpdateProbes(tokens(6), tokens(1), tokens(2), tokens(3), tokens(4))
            End Select
        Catch
            ' Do Nothing
        End Try
    End Sub

    ' Text display routine, which appends the received string to any text in the Received TextBox.
    Private Sub Display()
        If RxString.Length > 1 Then
            txtBoxReceived.AppendText(RxString & vbLf)
        End If
    End Sub

    ' Checks for a <CR> in the input string and on finding it, send the whole string plus CR to the device
    Private Sub txtBoxTransmit_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBoxTransmit.KeyDown

        If e.KeyCode = Keys.Up Then
            txtBoxTransmit.Text = LastCommand
        End If

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            LastCommand = txtBoxTransmit.Text
            command = txtBoxTransmit.Text.Split(Terminator)

            Select Case command(0)
                Case "Special"                                           '  "Look for a special commend and treat it differently"
                    ProcessSpecialCommand()
                Case Else                   ' It was a regular command, so just send
                    Dim SendText As String = txtBoxTransmit.Text.ToString & vbLf
                    SendCommand(SendText)
                    txtBoxTransmit.Text = ""
            End Select
        End If
    End Sub

    ' Process Special Commands
    Private Sub ProcessSpecialCommand()
        Dim SendText As String = ""
        MsgBox("You entered an unsupported command")

    End Sub


    '------------------------------------------------------------------------------
    ' SERIAL PORT ROUTINES
    '------------------------------------------------------------------------------
    'Check which COM ports are still available BEFORE allowing the user to select one
    Private Sub PortSelectionMouseOver(ByVal sender As Object, ByVal e As EventArgs) Handles COMPortsBox.MouseClick
        COMPortsBox.Items.Clear()
        For Each COMString As String In My.Computer.Ports.SerialPortNames ' Load all available COM ports.
            COMPortsBox.Items.Add(COMString)
        Next
    End Sub

    ' This subroutine handles a change of COM ports.
    Private Sub PortSelection(ByVal sender As Object, ByVal e As EventArgs) Handles COMPortsBox.SelectedIndexChanged
        If COMPort.IsOpen Then
            Try
                COMPort.RtsEnable = False
                COMPort.DtrEnable = False
                ClosePort()
            Catch
                MsgBox("Error closing COM Port")
            End Try

            ' NOTE. Because of the use of Invoke, the port should normally be closed from a different thread, 
            ' but to ensure that the following delay works, this is not done in this case.
            ' Empty the message queue before the UI thread goes to sleep to update the modem lamps and the ComboBox.
            Application.DoEvents()
            Sleep(200)                      ' Wait 0.2 second for port to close as this does not happen immediately.
        End If

        ' If this is the very first time, we need to set the defaults, 
        If BaudRateBox.Text = "" Then
            BaudRateBox.Text = "115200"
        End If

        Try
            With COMPort
                .PortName = COMPortsBox.Text
                .BaudRate = CInt(BaudRateBox.Text)                  ' ! Needs to be 9600 for T962
                .DataBits = 8                                       ' ! Needs to be 8 for T-962
                .StopBits = StopBits.One                            ' ! Needs to be 1 for T-962
                .Parity = Parity.None                               ' ! Needs to be None for T-962
                .Handshake = Handshake.None                         ' ! Needs to be 'None' for T-962
                .WriteTimeout = 2000                                ' Max time to wait for CTS = 2 sec.
                .ReadBufferSize = 3000                              ' Necessary buffer size for 16C950 UART at 921.6 kbit/s = 16384
                .WriteBufferSize = 3000
                AddHandler .DataReceived, AddressOf DataReceivedHandler
            End With

            COMPort.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Check if we successfully opened the COM port and if yes, then set the green light
        If COMPort.IsOpen Then
            imgConnectStatus.Image = My.Resources.Green_Light
            ToolStripStatusLabel2.Text = "    Status : Connected"
        Else
            imgConnectStatus.Image = My.Resources.Red_Light
            ToolStripStatusLabel2.Text = "    Status : Not Connected"
        End If
    End Sub

    ' Close COM Port
    Private Sub ClosePort()
        ' This subroutine is used to close the COM port. Because the program uses Invoke instead of BeginInvoke, this
        ' routine is usually called on a separate (new) thread to prevent a close-down deadlock.
        If COMPort.IsOpen Then
            Try
                COMPort.Close()
                imgConnectStatus.Image = My.Resources.Red_Light
                ToolStripStatusLabel2.Text = "    Status : Not Connected"
            Catch
            End Try

        End If
    End Sub

    ' This subroutine handles a change in Baud Rate.
    Private Sub BaudRateSelection(ByVal sender As Object, ByVal e As EventArgs)
        COMPort.BaudRate = CInt(BaudRateBox.Text)
    End Sub

    '------------------------------------------------------------------------------
    ' UI INTERACTION
    '------------------------------------------------------------------------------

    Private Sub btnSaveLog_Click(sender As Object, e As EventArgs) Handles btnSaveLog.Click
        SaveLog()
    End Sub

    ' This routine writes out the array profileTempStore
    Private Sub SaveLog()
        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Text Files (*.log)|*.log"
        SaveFileDialog1.Title = "Save Log File"
        SaveFileDialog1.FileName = "Run" & MachineID.ToString.Trim & "-" & RunNumber.ToString("D7")
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK _
            And SaveFileDialog1.FileName.Length > 0 Then
            'Put up Wait cursor and disable UI
            Me.Cursor = Cursors.WaitCursor
            DisableControls()

            'Write out the file
            IO.File.WriteAllLines(SaveFileDialog1.FileName, profileTempStore)

            'Re-enable the cursor and UI
            Me.Cursor = Cursors.Arrow
            EnableControls()
        End If
    End Sub

    ' STANDBY TRACING
    Private Sub chkStandbyTracing_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkStandbyTracing.CheckedChanged

        Dim result As String

        If COMPort.IsOpen Then
            If chkStandbyTracing.Checked = True Then
                SendCommand("quiet")
            Else
                SendCommand("quiet")
            End If
            Application.DoEvents()
        Else
            result = MessageBox.Show("Connect to the Controller first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    ' REFLOW BUTTON
    Private Sub btnReflow_Click(sender As Object, e As EventArgs) Handles btnReflow.Click

        Select Case btnReflow.Text
            Case "STOP"
                btnReflow.BackColor = Color.YellowGreen
                btnReflow.Text = "REFLOW"
                SendCommand("stop" & vbLf)
                Timer1.Stop()
                ' Re-enable the profile cbo and save log button
                cboProfile.Enabled = True
                btnSaveLog.Enabled = True
            Case "REFLOW"
                btnReflow.Text = "STOP"
                btnReflow.BackColor = Color.Red
                RunTime = 0
                Timer1.Start()
                ' Prevent the user from altering the profile or trying to save the log whilst it is running
                cboProfile.Enabled = False
                btnSaveLog.Enabled = False
                'Increment the run number
                RunNumber = RunNumber + 1
                txtRunNumber.Text = RunNumber.ToString.Trim
                'Re-initialize the array holding the results
                Array.Clear(ProfileTempStore, 0, ProfileTempStore.Length)
                idxProfileTempStore = 0
                ' Launch the reflow
                SendCommand("reflow" & vbLf)

        End Select


    End Sub

    ' PROFILE CHANGE
    Private Sub cboProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProfile.SelectedIndexChanged

        Select Case cboProfile.Text.ToLower
            Case "0"
                SendCommand("select profile 0")
                SetLiquidusLine(Profile0Liquidus)
            Case "1"
                SendCommand("select profile 1")
                SetLiquidusLine(Profile1Liquidus)
            Case "2"
                SendCommand("select profile 2")
                SetLiquidusLine(Profile2Liquidus)
            Case "3"
                SendCommand("select profile 3")
                SetLiquidusLine(Profile3Liquidus)
            Case "4"
                SendCommand("select profile 4")
                SetLiquidusLine(Profile4Liquidus)
            Case "5"
                SendCommand("select profile 5")
                SetLiquidusLine(Profile5Liquidus)
            Case "6"
                SendCommand("select profile 6")
                SetLiquidusLine(Profile6Liquidus)
        End Select

    End Sub

    ' CLEAR BUTTON
    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        txtBoxReceived.Text = ""
        ProfileChart.Series("OvenTemp").Points.Clear()
        ProfileChart.Series("Target").Points.Clear()
        ProfileChart.Series("TC1").Points.Clear()
        ProfileChart.Series("TC2").Points.Clear()
        ProfileChart.Series("TC3").Points.Clear()
        ProfileChart.Series("TC4").Points.Clear()
        txtPhase.ForeColor = Color.DimGray
        txtPhase.Text = "Standby"
        MaxTempAchieved = 0
        MaxProfileTemp = 0
        txtMaxTemp.Text = "Max Oven : - °C" & vbCrLf & "Max Profile : - °C"
        txtMaxTC.Text = TC1Name & ": - °C " & vbCrLf & TC2Name & ": - °C " & vbCrLf & TC3Name & ": - °C " & vbCrLf & TC4Name & ": - °C " _
                            & vbCrLf & "TAL : " & LiquidusTime.ToString.Trim & "S"
        MaxTempTC1 = 0
        MaxTempTC2 = 0
        MaxTempTC3 = 0
        MaxTempTC4 = 0
        LiquidusTime = 0
        LiquidusStart = 0
        LiquidusEnd = 0
        LiquidusAchieved = False
        RunTime = 0
        ToolStripStatusLabel2.Text = "    Status : Standby"
    End Sub

    ' DISABLE USER CONTROLS
    Private Sub DisableControls()
        txtBoxTransmit.Enabled = False
        COMPortsBox.Enabled = False
        BaudRateBox.Enabled = False
        txtBoxReceived.Enabled = False
        ClearButton.Enabled = False
        ProfileChart.Enabled = False
    End Sub

    ' ENABLE USER CONTROLS
    Private Sub EnableControls()
        txtBoxTransmit.Enabled = True
        COMPortsBox.Enabled = True
        BaudRateBox.Enabled = True
        txtBoxReceived.Enabled = True
        ClearButton.Enabled = True
        ProfileChart.Enabled = True
    End Sub

    '------------------------------------------------------------------------------
    ' TOOLSTRIP
    '------------------------------------------------------------------------------

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim AboutForm As New About
        AboutForm.Show()
    End Sub

    Private Sub CommandsToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles CommandsToolStripMenuItem.Click
        Dim HelpForm As New CommandHelp
        HelpForm.Show()
    End Sub

    Private Sub LoadProfileToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles LoadProfileToolStripMenuItem1.Click
        Dim Result As DialogResult
        Dim OpenFileDialog1 As New OpenFileDialog

        'Check if connected to the controller first 
        If COMPort.IsOpen Then
            Try
                'Set Defaults
                OpenFileDialog1.Filter = "Oven Profile (*.pfl)|*.pfl"
                OpenFileDialog1.FilterIndex = 1
                OpenFileDialog1.Multiselect = False

                ' Call ShowDialog.
                Result = OpenFileDialog1.ShowDialog()

                ' Test result
                Dim mypath As String = ""

                If Result = Windows.Forms.DialogResult.OK Then
                    ' Get the file name.
                    mypath = OpenFileDialog1.FileName
                End If


                'Erase the old profile
                'ProfileChart.Series("Profile").Points.Clear()
                ProfileChart.Series("Profile").ChartType = DataVisualization.Charting.SeriesChartType.Range
                ProfileChart.Series("Profile").Color = Color.LightGreen
                ProfileChart.Series("Profile").BorderWidth = 2
                ProfileChart.Series("Profile").BackImageTransparentColor = Color.LightGreen

                'Put up Wait cursor and disable UI
                Me.Cursor = Cursors.WaitCursor
                DisableControls()

                ' Read the profile and add it to the chart
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(mypath)
                    MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(",")
                    Dim currentRow() As String
                    While Not MyReader.EndOfData
                        Try
                            currentRow = MyReader.ReadFields()
                            Select Case currentRow(0).ToLower
                                Case "name"
                                    If Not IsNullOrEmpty(currentRow(1)) Then
                                        ToolStripStatusLabel4.Text = currentRow(1).Trim
                                    End If
                                Case "minfanspeed"
                                    SendCommand("setting 0 " & currentRow(1).Trim.ToString & vbCrLf)
                                Case "profile"
                                    Dim myprofile As Integer = 0
                                    myprofile = Convert.ToInt32(currentRow(1))
                                    If myprofile > -1 AndAlso myprofile < 7 Then
                                        cboProfile.SelectedIndex = myprofile
                                    End If
                                Case "maxtimepoints"
                                    ProfileChart.ChartAreas("OvenTemp").AxisX.Maximum = currentRow(1)
                                    MaxTimePoints = currentRow(1)
                                Case "chart"
                                    ' This is a chart record, convert to integers to enter into chart points
                                    Dim intpoint = Convert.ToInt32(currentRow(1))       'Point number
                                    Dim inttime = Convert.ToInt32(currentRow(2))        'Time in Seconds
                                    Dim intlo = Convert.ToInt32(currentRow(3))          'Low bound of range
                                    Dim inthi = Convert.ToInt32(currentRow(4))          'High bound of range
                                    'Enter onto chart
                                    ProfileChart.Series("Profile").Points.InsertXY(intpoint, inttime, intlo, inthi)
                                Case "liquidus"
                                    ' Clear the last line (if there was one)
                                    Me.ProfileChart.Series("Liquidus").Points.Clear()
                                    ' Insert the new line
                                    Try
                                        Dim liquidus As Double = Convert.ToInt32(currentRow(1))
                                        ProfileChart.Series("Liquidus").Points.AddXY(0, liquidus)
                                        ProfileChart.Series("Liquidus").Points.AddXY(MaxTimePoints, liquidus)
                                    Catch
                                        txtBoxReceived.AppendText("*** BAD LIQUIDUS INPUT ***" & vbCrLf)
                                    End Try

                                Case "command"
                                    ' TODO
                                Case Else
                                    Result = MessageBox.Show("Bad record in profile file", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            End Select

                        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                            MsgBox("Line " & ex.Message & " in profile is invalid.  Skipping")
                        End Try
                    End While
                End Using

            Catch ex As Exception
                MsgBox("Error processing profile file" & vbCrLf & vbCrLf & ex.Message)
            End Try
        Else
            imgConnectStatus.Image = My.Resources.Red_Light
            ToolStripStatusLabel2.Text = "    Status : Disconnected"
            Result = MessageBox.Show("You must connect to a controller before loading a profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        'End wait cursor and re-enable controls
        Me.Cursor = Cursors.Arrow
        EnableControls()
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        MsgBox("Sorry, this isn't fully implemented yet")
        ' This subroutine saves the content of the Received TextBox
        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        SaveFileDialog1.Title = "Save Received As"
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK _
            And SaveFileDialog1.FileName.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txtBoxReceived.Text, False) ' Overwrite file
        End If
    End Sub

    ' Handles changes to the status of the show all TC's 
    Private Sub tsmiShowAllThermocouplesOnGraph_Click(sender As Object, e As EventArgs) Handles tsmiTemperatureDisplay.Click
        Dim myfrmThermoDisplay As New frmThermoDisplay()
        myfrmThermoDisplay.ShowDialog()
    End Sub

    '------------------------------------------------------------------------------
    ' MISCELLANEOUS PROCEDURES
    '------------------------------------------------------------------------------
    ' Loops for a specified period of time (milliseconds)
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    'Updates the graph
    Private Sub updateGraph(ByVal mySeries, ByVal myTime, ByVal myTemp)

        myTime = myTime.ToString.Trim
        myTemp = myTemp.ToString.Trim

        Dim WorkTemp As Single
        Dim WorkTime As Single

        Try
            WorkTemp = Convert.ToSingle(myTemp)
            WorkTime = Convert.ToSingle(myTime)
        Catch
            Dim one As String = 1
            ' Bad Data from the controller
        End Try

        Select Case mySeries
            Case "OvenTemp"
                If WorkTemp > MaxTempAchieved Then
                    MaxTempAchieved = WorkTemp
                End If

                If LiquidusTemp > 0 Then
                    If WorkTemp >= LiquidusTemp Then
                        If LiquidusAchieved = False Then        ' Determine the Liquidus start time, this should happen the moment Liquidus is acheived
                            LiquidusStart = myTime
                            LiquidusAchieved = True
                        Else                                    ' We are still above liquidus, need to starting counting the seconds
                            LiquidusTime = myTime - LiquidusStart
                        End If
                    Else
                        LiquidusAchieved = False
                    End If
                End If

            Case "Target"
                If WorkTemp > MaxProfileTemp Then
                    MaxProfileTemp = WorkTemp
                End If
            Case "TC1"
                If WorkTemp > MaxTempTC1 Then
                    MaxTempTC1 = WorkTemp
                End If
            Case "TC2"
                If WorkTemp > MaxTempTC2 Then
                    MaxTempTC2 = WorkTemp
                End If
            Case "TC3"
                If WorkTemp > MaxTempTC3 Then
                    MaxTempTC3 = WorkTemp
                End If
            Case "TC4"
                If WorkTemp > MaxTempTC4 Then
                    MaxTempTC4 = WorkTemp
                End If
        End Select

        'Update Maximum Temperature reached
        txtMaxTemp.Text = "Max Oven : " & MaxTempAchieved.ToString.TrimEnd & " °C" & vbCrLf & "Max Profile : " & MaxProfileTemp.ToString.TrimEnd & " °C"

        If flgShowTCMax Then
            txtMaxTC.Visible = True
            'Set Max TC temperatures
            txtMaxTC.Text = TC1Name & " : " & MaxTempTC1 & "°C" & vbCrLf & TC2Name & " : " & MaxTempTC2 & "°C" & vbCrLf & TC3Name & " : " & MaxTempTC3 & "°C" & vbCrLf & TC4Name & " : " & MaxTempTC4 & "°C" _
                & vbCrLf & "TAL : " & LiquidusTime.ToString.Trim & "S"
        Else
            txtMaxTC.Visible = False
        End If

        ' Add Oven point to Graph
        Try
            ProfileChart.Series(mySeries).Points.AddXY(WorkTime, WorkTemp)
        Catch
            MsgBox("Unable to update graph")
        End Try

    End Sub

    'Updates the Temperature display in the top RH corner
    Private Sub updateTemp(ByVal Temp)

        Dim intTemp As Integer = CType(Temp, Integer)
        txtTemp.Text = intTemp.ToString & "°C"

        Select Case intTemp
            Case 0 To 50
                txtTemp.BackColor = Color.Green
            Case 51 To 100
                txtTemp.BackColor = Color.Orange
            Case 101 To 150
                txtTemp.BackColor = Color.OrangeRed
            Case 151 To 200
                txtTemp.BackColor = Color.Red
            Case 201 To 999
                txtTemp.BackColor = Color.DarkRed
        End Select

    End Sub

    'updates temp bar
    Private Sub UpdateTempBar(temp As Int16)
        Dim percent As Int16 = temp / 254 * 100
        barHeat.Value = percent
        lblHeat.Text = percent.ToString & "%"
    End Sub

    'updates fan bar
    Private Sub UpdateFanBar(speed As Int16)
        Dim percent As Int16 = speed / 254 * 100
        barFan.Value = percent
        lblFan.Text = percent.ToString & "%"
    End Sub

    'Updates probes graph
    Private Sub UpdateProbes(strCalcTemp As String, strTC1 As String, strTC2 As String, strTC3 As String, strTC4 As String)
        'CalcTemp is the calculated temperature being used by the over

        Dim TC1 As Double = Convert.ToDouble(strTC1.Trim)
        Dim TC2 As Double = Convert.ToDouble(strTC2.Trim)
        Dim TC3 As Double = Convert.ToDouble(strTC3.Trim)
        Dim TC4 As Double = Convert.ToDouble(strTC4.Trim)
        Dim OvenTemp As Double = Convert.ToDouble(strCalcTemp.Trim)

        Dim Average As Double = 0

        If (TC3 = 0 AndAlso TC4 = 0) Then
            ' If only getting a reading from TC1 and TC2, then disable TC3 and TC4
            lblTC3Head.Enabled = False
            lblTC4Head.Enabled = False
            lblTC3.Enabled = False
            lblTC4.Enabled = False

            '   Average = (TC1 + TC2) / 2
        Else
            ' Here we are getting input from all four TCs 
            lblTC3Head.Enabled = True
            lblTC4Head.Enabled = True
            '  Average = (TC1 + TC2 + TC3 + TC4) / 4
        End If

        Dim TC1delta As Double = TC1 - OvenTemp
        Dim TC2delta As Double = TC2 - OvenTemp
        Dim TC3delta As Double = TC3 - OvenTemp
        Dim TC4delta As Double = TC4 - OvenTemp

        lblTC1.Text = TC1delta.ToString("##.#")
        lblTC2.Text = TC2delta.ToString("##.#")

        If lblTC3.Enabled = True Then
            lblTC3.Text = TC3delta.ToString("##.#")
        Else
            lblTC3.Text = "-"
        End If

        If lblTC3.Enabled = True Then
            lblTC4.Text = TC4delta.ToString("##.#")
        Else
            lblTC3.Text = "-"
        End If



    End Sub

    'Send command To the controller
    Private Sub SendCommand(TextToSend As String)
        If COMPort.IsOpen Then
            Try
                COMPort.Write(TextToSend)
            Catch ex As Exception
                MsgBox(ex.Message & " Communications Error - Check Cable")
            End Try
        Else
            imgConnectStatus.Image = My.Resources.Red_Light
            ToolStripStatusLabel2.Text = "    Status : Disconnected"
            MsgBox("COM port is closed. Please select a COM port")

        End If
    End Sub

    ' Timer for Run Time counter (in Seconds)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RunTime = RunTime + 1
        ToolStripStatusLabel2.Text = "            Run Time = " & RunTime.ToString
    End Sub

    Private Sub SaveProfileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("Sorry, this isn't implemented yet")
    End Sub

    ' Save log
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveLog()
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click

        Dim OpenFileDialog2 As New OpenFileDialog()
        Dim result As String
        ' Call ShowDialog
        OpenFileDialog2.Filter = "Log Files (*.log)|*.log"
        OpenFileDialog2.Title = "Open Log File"
        result = OpenFileDialog2.ShowDialog()

        ' Test result
        Dim mypath As String = ""

        If Result = Windows.Forms.DialogResult.OK Then
            ' Get the file name.
            mypath = OpenFileDialog2.FileName
        End If

        'Erase the old profile
        ProfileChart.Series("OvenTemp").Points.Clear()
        ProfileChart.Series("Target").Points.Clear()
        ProfileChart.Series("TC1").Points.Clear()
        ProfileChart.Series("TC2").Points.Clear()
        ProfileChart.Series("TC3").Points.Clear()
        ProfileChart.Series("TC4").Points.Clear()

        'Put up Wait cursor and disable UI
        Me.Cursor = Cursors.WaitCursor
        DisableControls()

        ' Read the profile and add it to the chart
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(mypath)
            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow() As String
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Select Case currentRow(10).ToLower
                        Case "reflow"
                            'Deal with target chart points
                            Dim Time = Convert.ToDouble(currentRow(0))        'Time in Seconds
                            Dim Target = Convert.ToDouble(currentRow(5))
                            Dim Actual = Convert.ToDouble(currentRow(6))
                            Dim TC1 = Convert.ToDouble(currentRow(1))
                            Dim TC2 = Convert.ToDouble(currentRow(2))
                            Dim TC3 = Convert.ToDouble(currentRow(3))
                            Dim TC4 = Convert.ToDouble(currentRow(4))
                            'Enter onto chart
                            ProfileChart.Series("Target").Points.AddXY(Time, Target)
                            ProfileChart.Series("OvenTemp").Points.AddXY(Time, Actual)
                            ProfileChart.Series("TC1").Points.AddXY(Time, TC1)
                            ProfileChart.Series("TC2").Points.AddXY(Time, TC2)
                            ProfileChart.Series("TC3").Points.AddXY(Time, TC3)
                            ProfileChart.Series("TC4").Points.AddXY(Time, TC4)
                        Case Else
                            MsgBox("Line " & currentRow.ToString & " in file is invalid.  Skipping")
                    End Select

                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & " in file is invalid.  Skipping")
                End Try
            End While
        End Using

        'Disable Wait cursor and enable UI
        Me.Cursor = Cursors.Arrow
        EnableControls()

    End Sub

    'This item allows you to manually set a liquidus line on the chart
    Private Sub SetLiquidusTemperatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetLiquidusTemperatureToolStripMenuItem.Click
        Dim myfrmSetLiquidus As New frmSetLiquidus()
        myfrmSetLiquidus.ShowDialog()
    End Sub

    Private Sub MiscOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiscOptionsToolStripMenuItem.Click
        Dim myfrmMiscOptions As New frmMiscOptions
        myfrmMiscOptions.ShowDialog()
    End Sub


End Class



