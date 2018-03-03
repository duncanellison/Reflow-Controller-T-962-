Public Class frmMiscOptions

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtMachineID.Text = GlobalParameters.MachineID
        txtRunNumber.Text = GlobalParameters.RunNumber.ToString
        If GlobalParameters.flgReducePoints Then
            chkReduceOvenPoints.Checked = True
        Else
            chkReduceOvenPoints.Checked = False
        End If

        Select Case GlobalParameters.OvenType
            Case "T-962"
                cboOvenType.SelectedItem = "T-962"
            Case "T-962A"
                cboOvenType.SelectedItem = "T-962A"
        End Select


        ' Populate the Liquidus 
        txtLiquidus0.Text = GlobalParameters.Profile0Liquidus
        txtLiquidus1.Text = GlobalParameters.Profile1Liquidus
        txtLiquidus2.Text = GlobalParameters.Profile2Liquidus
        txtLiquidus3.Text = GlobalParameters.Profile3Liquidus
        txtLiquidus4.Text = GlobalParameters.Profile4Liquidus
        txtLiquidus5.Text = GlobalParameters.Profile5Liquidus
        txtLiquidus6.Text = GlobalParameters.Profile6Liquidus

        txtProfileName0.Text = GlobalParameters.ProfileName0
        txtProfileName1.Text = GlobalParameters.ProfileName1
        txtProfileName2.Text = GlobalParameters.ProfileName2
        txtProfileName3.Text = GlobalParameters.ProfileName3
        txtProfileName4.Text = GlobalParameters.ProfileName4
        txtProfileName5.Text = GlobalParameters.ProfileName5
        txtProfileName6.Text = GlobalParameters.ProfileName6

        ' Center to the parent screen
        Me.CenterToParent()

        ' Now show it
        Me.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        GlobalParameters.MachineID = txtMachineID.Text
        GlobalParameters.RunNumber = Convert.ToInt32(txtRunNumber.Text.Trim)
        If chkReduceOvenPoints.Checked = True Then
            GlobalParameters.flgReducePoints = True
        Else
            GlobalParameters.flgReducePoints = False
        End If

        GlobalParameters.OvenType = cboOvenType.SelectedItem.ToString

        GlobalFunctions.SetTCNames()
        Dim mytext As String = GlobalParameters.TC1Name & ": - °C " & vbCrLf & GlobalParameters.TC2Name & ": - °C " & vbCrLf & GlobalParameters.TC3Name & ": - °C " & vbCrLf & GlobalParameters.TC4Name & ": - °C " _
                            & vbCrLf & "TAL : - S"

        ' Set the text on the main form via a delegate
        frmMain.txtMaxTC.Invoke(Sub() frmMain.txtMaxTC.Text = mytext)



        ' Store the Liquidus
        Try
            GlobalParameters.Profile0Liquidus = Convert.ToDouble(txtLiquidus0.Text)
            GlobalParameters.Profile1Liquidus = Convert.ToDouble(txtLiquidus1.Text)
            GlobalParameters.Profile2Liquidus = Convert.ToDouble(txtLiquidus2.Text)
            GlobalParameters.Profile3Liquidus = Convert.ToDouble(txtLiquidus3.Text)
            GlobalParameters.Profile4Liquidus = Convert.ToDouble(txtLiquidus4.Text)
            GlobalParameters.Profile5Liquidus = Convert.ToDouble(txtLiquidus5.Text)
            GlobalParameters.Profile6Liquidus = Convert.ToDouble(txtLiquidus6.Text)
            Me.Close()
        Catch
            MsgBox("Error in Liquidus Parameters, please try again")
        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.RunNumber = 0
        frmMain.txtRunNumber.Invoke(Sub() frmMain.txtRunNumber.Text = My.Settings.RunNumber.ToString)

    End Sub

    Private Sub cboOvenType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOvenType.SelectedIndexChanged

        Select Case cboOvenType.SelectedItem
            Case "T-962"
                GlobalParameters.OvenType = "T-962"
            Case "T-962A"
                GlobalParameters.OvenType = "T-962A"
        End Select

        GlobalFunctions.SetTCNames()

        ' Change the headers above the text box to match the Oven type
        frmMain.lblHeaderTC1.Invoke(Sub() frmMain.lblHeaderTC1.Text = GlobalParameters.TC1Name)
        frmMain.lblHeaderTC2.Invoke(Sub() frmMain.lblHeaderTC2.Text = GlobalParameters.TC2Name)
        frmMain.lblHeaderTC3.Invoke(Sub() frmMain.lblHeaderTC3.Text = GlobalParameters.TC3Name)
        frmMain.lblHeaderTC4.Invoke(Sub() frmMain.lblHeaderTC4.Text = GlobalParameters.TC4Name)

    End Sub

    Private Sub txtRunNumber_TextChanged(sender As Object, e As EventArgs) Handles txtRunNumber.TextChanged
        My.Settings.RunNumber = Convert.ToDouble(txtRunNumber.Text)
        frmMain.txtRunNumber.Invoke(Sub() frmMain.txtRunNumber.Text = My.Settings.RunNumber.ToString)
    End Sub
End Class