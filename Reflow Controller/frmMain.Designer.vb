﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, "0,0")
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, "0,0")
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, "0,0")
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.COMPortsBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BaudRateBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxReceived = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.txtBoxTransmit = New System.Windows.Forms.TextBox()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.ProfileChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtPhase = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTemp = New System.Windows.Forms.Label()
        Me.chkStandbyTracing = New System.Windows.Forms.CheckBox()
        Me.btnReflow = New System.Windows.Forms.Button()
        Me.cboProfile = New System.Windows.Forms.ComboBox()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.txtProfileSelected = New System.Windows.Forms.Label()
        Me.txtMaxTemp = New System.Windows.Forms.TextBox()
        Me.barFan = New System.Windows.Forms.ProgressBar()
        Me.barHeat = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFan = New System.Windows.Forms.Label()
        Me.lblHeat = New System.Windows.Forms.Label()
        Me.lblTC1Head = New System.Windows.Forms.Label()
        Me.lblTC2Head = New System.Windows.Forms.Label()
        Me.lblTC3Head = New System.Windows.Forms.Label()
        Me.lblTC4Head = New System.Windows.Forms.Label()
        Me.lblTC1 = New System.Windows.Forms.Label()
        Me.lblTC2 = New System.Windows.Forms.Label()
        Me.lblTC3 = New System.Windows.Forms.Label()
        Me.lblTC4 = New System.Windows.Forms.Label()
        Me.lblDegreesC = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.btnSaveLog = New System.Windows.Forms.Button()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadProfileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTemperatureDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetLiquidusTemperatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.imgConnectStatus = New System.Windows.Forms.PictureBox()
        Me.lblRun = New System.Windows.Forms.Label()
        Me.txtRunNumber = New System.Windows.Forms.Label()
        Me.txtMaxTC = New System.Windows.Forms.TextBox()
        Me.lblDeltas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHeaderTC1 = New System.Windows.Forms.Label()
        Me.lblHeaderTC2 = New System.Windows.Forms.Label()
        Me.lblHeaderTC3 = New System.Windows.Forms.Label()
        Me.lblHeaderTC4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ProfileChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgConnectStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1057, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel3.Text = "                                                      "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'COMPortsBox
        '
        Me.COMPortsBox.FormattingEnabled = True
        Me.COMPortsBox.Location = New System.Drawing.Point(580, 664)
        Me.COMPortsBox.Name = "COMPortsBox"
        Me.COMPortsBox.Size = New System.Drawing.Size(115, 21)
        Me.COMPortsBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(521, 668)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "COM Port"
        '
        'BaudRateBox
        '
        Me.BaudRateBox.FormattingEnabled = True
        Me.BaudRateBox.Location = New System.Drawing.Point(828, 664)
        Me.BaudRateBox.Name = "BaudRateBox"
        Me.BaudRateBox.Size = New System.Drawing.Size(115, 21)
        Me.BaudRateBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(754, 669)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Baud Rate"
        '
        'txtBoxReceived
        '
        Me.txtBoxReceived.BackColor = System.Drawing.Color.White
        Me.txtBoxReceived.CausesValidation = False
        Me.txtBoxReceived.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxReceived.Location = New System.Drawing.Point(306, 460)
        Me.txtBoxReceived.MaxLength = 70000
        Me.txtBoxReceived.Multiline = True
        Me.txtBoxReceived.Name = "txtBoxReceived"
        Me.txtBoxReceived.ReadOnly = True
        Me.txtBoxReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBoxReceived.Size = New System.Drawing.Size(697, 187)
        Me.txtBoxReceived.TabIndex = 1
        Me.txtBoxReceived.Text = "   4.0,   34.5,  34.2,  34.0,  34.2,   40,  34.1,  117,  10,   32.3, REFLOW" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(828, 406)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(79, 26)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Reset"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'txtBoxTransmit
        '
        Me.txtBoxTransmit.AcceptsReturn = True
        Me.txtBoxTransmit.AcceptsTab = True
        Me.txtBoxTransmit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTransmit.Location = New System.Drawing.Point(379, 408)
        Me.txtBoxTransmit.Name = "txtBoxTransmit"
        Me.txtBoxTransmit.Size = New System.Drawing.Size(400, 22)
        Me.txtBoxTransmit.TabIndex = 0
        '
        'txtTransmit
        '
        Me.txtTransmit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransmit.Location = New System.Drawing.Point(729, 502)
        Me.txtTransmit.Multiline = True
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(293, 68)
        Me.txtTransmit.TabIndex = 0
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(303, 410)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(70, 16)
        Me.Label79.TabIndex = 6
        Me.Label79.Text = "Command"
        '
        'ProfileChart
        '
        Me.ProfileChart.BackColor = System.Drawing.Color.Transparent
        Me.ProfileChart.BackImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProfileChart.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProfileChart.BorderlineColor = System.Drawing.Color.Maroon
        Me.ProfileChart.BorderSkin.BorderWidth = 2
        Me.ProfileChart.BorderSkin.PageColor = System.Drawing.Color.LightSkyBlue
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.Interval = 20.0R
        ChartArea1.AxisX.IsInterlaced = True
        ChartArea1.AxisX.IsStartedFromZero = False
        ChartArea1.AxisX.LineWidth = 2
        ChartArea1.AxisX.MajorGrid.Interval = 10.0R
        ChartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Maroon
        ChartArea1.AxisX.MajorTickMark.Interval = 10.0R
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkRed
        ChartArea1.AxisX.MajorTickMark.LineWidth = 2
        ChartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea1.AxisX.Maximum = 470.0R
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.AxisX.MinorGrid.Enabled = True
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.Maroon
        ChartArea1.AxisY.Crossing = -1.7976931348623157E+308R
        ChartArea1.AxisY.Interval = 20.0R
        ChartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea1.AxisY.MajorGrid.Interval = 20.0R
        ChartArea1.AxisY.MajorGrid.IntervalOffset = 0R
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightPink
        ChartArea1.AxisY.MajorTickMark.Interval = 20.0R
        ChartArea1.AxisY.MajorTickMark.IntervalOffset = 0R
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkRed
        ChartArea1.AxisY.Maximum = 280.0R
        ChartArea1.AxisY.Minimum = 20.0R
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.Maroon
        ChartArea1.BackColor = System.Drawing.Color.Gainsboro
        ChartArea1.BorderColor = System.Drawing.Color.Gray
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.BorderWidth = 3
        ChartArea1.Name = "OvenTemp"
        Me.ProfileChart.ChartAreas.Add(ChartArea1)
        Me.ProfileChart.Location = New System.Drawing.Point(-41, 46)
        Me.ProfileChart.Name = "ProfileChart"
        Me.ProfileChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.BorderWidth = 2
        Series1.ChartArea = "OvenTemp"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.Name = "Profile"
        DataPoint3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.Points.Add(DataPoint3)
        Series1.YValuesPerPoint = 2
        Series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series2.BorderWidth = 2
        Series2.ChartArea = "OvenTemp"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.LightSeaGreen
        Series2.Name = "TC1"
        Series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series3.BorderWidth = 2
        Series3.ChartArea = "OvenTemp"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.Purple
        Series3.Name = "TC2"
        Series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series4.BorderWidth = 2
        Series4.ChartArea = "OvenTemp"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.Blue
        Series4.Name = "TC3"
        Series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series5.BorderWidth = 2
        Series5.ChartArea = "OvenTemp"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series5.Name = "TC4"
        Series6.BorderWidth = 2
        Series6.ChartArea = "OvenTemp"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Color = System.Drawing.Color.ForestGreen
        Series6.Name = "Target"
        Series7.BorderColor = System.Drawing.Color.Transparent
        Series7.BorderWidth = 2
        Series7.ChartArea = "OvenTemp"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Color = System.Drawing.Color.Firebrick
        Series7.MarkerSize = 0
        Series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series7.Name = "OvenTemp"
        Series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series8.BorderWidth = 2
        Series8.ChartArea = "OvenTemp"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Color = System.Drawing.Color.Gold
        Series8.LegendText = "Liquidus"
        Series8.Name = "Liquidus"
        Me.ProfileChart.Series.Add(Series1)
        Me.ProfileChart.Series.Add(Series2)
        Me.ProfileChart.Series.Add(Series3)
        Me.ProfileChart.Series.Add(Series4)
        Me.ProfileChart.Series.Add(Series5)
        Me.ProfileChart.Series.Add(Series6)
        Me.ProfileChart.Series.Add(Series7)
        Me.ProfileChart.Series.Add(Series8)
        Me.ProfileChart.Size = New System.Drawing.Size(1090, 365)
        Me.ProfileChart.TabIndex = 175
        Me.ProfileChart.Text = "Oven Temp"
        '
        'txtPhase
        '
        Me.txtPhase.AutoSize = True
        Me.txtPhase.BackColor = System.Drawing.Color.Transparent
        Me.txtPhase.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhase.Location = New System.Drawing.Point(649, 22)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.Size = New System.Drawing.Size(100, 34)
        Me.txtPhase.TabIndex = 176
        Me.txtPhase.Text = "Phase"
        Me.txtPhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'txtTemp
        '
        Me.txtTemp.AutoSize = True
        Me.txtTemp.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTemp.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.ForeColor = System.Drawing.Color.White
        Me.txtTemp.Location = New System.Drawing.Point(886, 13)
        Me.txtTemp.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(117, 44)
        Me.txtTemp.TabIndex = 178
        Me.txtTemp.Text = "Temp"
        '
        'chkStandbyTracing
        '
        Me.chkStandbyTracing.AutoSize = True
        Me.chkStandbyTracing.Location = New System.Drawing.Point(306, 669)
        Me.chkStandbyTracing.Name = "chkStandbyTracing"
        Me.chkStandbyTracing.Size = New System.Drawing.Size(163, 17)
        Me.chkStandbyTracing.TabIndex = 180
        Me.chkStandbyTracing.Text = "Toggle standby mode tracing"
        Me.chkStandbyTracing.UseVisualStyleBackColor = True
        '
        'btnReflow
        '
        Me.btnReflow.BackColor = System.Drawing.Color.YellowGreen
        Me.btnReflow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReflow.Location = New System.Drawing.Point(38, 557)
        Me.btnReflow.Name = "btnReflow"
        Me.btnReflow.Size = New System.Drawing.Size(222, 121)
        Me.btnReflow.TabIndex = 182
        Me.btnReflow.Text = "REFLOW"
        Me.btnReflow.UseVisualStyleBackColor = False
        '
        'cboProfile
        '
        Me.cboProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProfile.FormattingEnabled = True
        Me.cboProfile.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.cboProfile.Location = New System.Drawing.Point(166, 30)
        Me.cboProfile.Name = "cboProfile"
        Me.cboProfile.Size = New System.Drawing.Size(49, 24)
        Me.cboProfile.TabIndex = 183
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.Location = New System.Drawing.Point(111, 36)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(46, 16)
        Me.lblProfile.TabIndex = 184
        Me.lblProfile.Text = "Profile"
        '
        'txtProfileSelected
        '
        Me.txtProfileSelected.AutoSize = True
        Me.txtProfileSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileSelected.Location = New System.Drawing.Point(228, 35)
        Me.txtProfileSelected.Name = "txtProfileSelected"
        Me.txtProfileSelected.Size = New System.Drawing.Size(110, 16)
        Me.txtProfileSelected.TabIndex = 185
        Me.txtProfileSelected.Text = "Profile goes here"
        '
        'txtMaxTemp
        '
        Me.txtMaxTemp.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtMaxTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxTemp.Location = New System.Drawing.Point(57, 78)
        Me.txtMaxTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaxTemp.MinimumSize = New System.Drawing.Size(4, 40)
        Me.txtMaxTemp.Multiline = True
        Me.txtMaxTemp.Name = "txtMaxTemp"
        Me.txtMaxTemp.ReadOnly = True
        Me.txtMaxTemp.Size = New System.Drawing.Size(151, 40)
        Me.txtMaxTemp.TabIndex = 188
        Me.txtMaxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'barFan
        '
        Me.barFan.BackColor = System.Drawing.Color.LightGray
        Me.barFan.Location = New System.Drawing.Point(38, 451)
        Me.barFan.Name = "barFan"
        Me.barFan.Size = New System.Drawing.Size(100, 11)
        Me.barFan.Step = 1
        Me.barFan.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barFan.TabIndex = 189
        '
        'barHeat
        '
        Me.barHeat.BackColor = System.Drawing.Color.LightGray
        Me.barHeat.ForeColor = System.Drawing.Color.DarkRed
        Me.barHeat.Location = New System.Drawing.Point(160, 451)
        Me.barHeat.Name = "barHeat"
        Me.barHeat.Size = New System.Drawing.Size(100, 11)
        Me.barHeat.Step = 1
        Me.barHeat.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barHeat.TabIndex = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 426)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Fan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Heat"
        '
        'lblFan
        '
        Me.lblFan.AutoSize = True
        Me.lblFan.BackColor = System.Drawing.SystemColors.Control
        Me.lblFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFan.Location = New System.Drawing.Point(96, 426)
        Me.lblFan.Name = "lblFan"
        Me.lblFan.Size = New System.Drawing.Size(27, 16)
        Me.lblFan.TabIndex = 194
        Me.lblFan.Text = "0%"
        '
        'lblHeat
        '
        Me.lblHeat.AutoSize = True
        Me.lblHeat.BackColor = System.Drawing.SystemColors.Control
        Me.lblHeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeat.Location = New System.Drawing.Point(221, 426)
        Me.lblHeat.Name = "lblHeat"
        Me.lblHeat.Size = New System.Drawing.Size(27, 16)
        Me.lblHeat.TabIndex = 195
        Me.lblHeat.Text = "0%"
        '
        'lblTC1Head
        '
        Me.lblTC1Head.AutoSize = True
        Me.lblTC1Head.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC1Head.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblTC1Head.Location = New System.Drawing.Point(46, 500)
        Me.lblTC1Head.MaximumSize = New System.Drawing.Size(41, 16)
        Me.lblTC1Head.MinimumSize = New System.Drawing.Size(41, 16)
        Me.lblTC1Head.Name = "lblTC1Head"
        Me.lblTC1Head.Size = New System.Drawing.Size(41, 16)
        Me.lblTC1Head.TabIndex = 196
        Me.lblTC1Head.Text = "▲TC1"
        '
        'lblTC2Head
        '
        Me.lblTC2Head.AutoSize = True
        Me.lblTC2Head.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC2Head.ForeColor = System.Drawing.Color.Purple
        Me.lblTC2Head.Location = New System.Drawing.Point(165, 500)
        Me.lblTC2Head.MaximumSize = New System.Drawing.Size(41, 16)
        Me.lblTC2Head.MinimumSize = New System.Drawing.Size(41, 16)
        Me.lblTC2Head.Name = "lblTC2Head"
        Me.lblTC2Head.Size = New System.Drawing.Size(41, 16)
        Me.lblTC2Head.TabIndex = 197
        Me.lblTC2Head.Text = "▲TC2"
        '
        'lblTC3Head
        '
        Me.lblTC3Head.AutoSize = True
        Me.lblTC3Head.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC3Head.ForeColor = System.Drawing.Color.Blue
        Me.lblTC3Head.Location = New System.Drawing.Point(45, 524)
        Me.lblTC3Head.MaximumSize = New System.Drawing.Size(41, 16)
        Me.lblTC3Head.MinimumSize = New System.Drawing.Size(41, 16)
        Me.lblTC3Head.Name = "lblTC3Head"
        Me.lblTC3Head.Size = New System.Drawing.Size(41, 16)
        Me.lblTC3Head.TabIndex = 199
        Me.lblTC3Head.Text = "▲TC3"
        '
        'lblTC4Head
        '
        Me.lblTC4Head.AutoSize = True
        Me.lblTC4Head.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC4Head.ForeColor = System.Drawing.Color.Orange
        Me.lblTC4Head.Location = New System.Drawing.Point(165, 524)
        Me.lblTC4Head.MaximumSize = New System.Drawing.Size(41, 16)
        Me.lblTC4Head.MinimumSize = New System.Drawing.Size(41, 16)
        Me.lblTC4Head.Name = "lblTC4Head"
        Me.lblTC4Head.Size = New System.Drawing.Size(41, 16)
        Me.lblTC4Head.TabIndex = 200
        Me.lblTC4Head.Text = "▲TC4"
        '
        'lblTC1
        '
        Me.lblTC1.AutoSize = True
        Me.lblTC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC1.Location = New System.Drawing.Point(88, 500)
        Me.lblTC1.Name = "lblTC1"
        Me.lblTC1.Size = New System.Drawing.Size(12, 16)
        Me.lblTC1.TabIndex = 201
        Me.lblTC1.Text = "-"
        '
        'lblTC2
        '
        Me.lblTC2.AutoSize = True
        Me.lblTC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC2.Location = New System.Drawing.Point(207, 500)
        Me.lblTC2.Name = "lblTC2"
        Me.lblTC2.Size = New System.Drawing.Size(12, 16)
        Me.lblTC2.TabIndex = 201
        Me.lblTC2.Text = "-"
        '
        'lblTC3
        '
        Me.lblTC3.AutoSize = True
        Me.lblTC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC3.Location = New System.Drawing.Point(88, 524)
        Me.lblTC3.Name = "lblTC3"
        Me.lblTC3.Size = New System.Drawing.Size(12, 16)
        Me.lblTC3.TabIndex = 201
        Me.lblTC3.Text = "-"
        '
        'lblTC4
        '
        Me.lblTC4.AutoSize = True
        Me.lblTC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC4.Location = New System.Drawing.Point(207, 524)
        Me.lblTC4.Name = "lblTC4"
        Me.lblTC4.Size = New System.Drawing.Size(12, 16)
        Me.lblTC4.TabIndex = 202
        Me.lblTC4.Text = "-"
        '
        'lblDegreesC
        '
        Me.lblDegreesC.AutoSize = True
        Me.lblDegreesC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegreesC.ForeColor = System.Drawing.Color.Firebrick
        Me.lblDegreesC.Location = New System.Drawing.Point(9, 37)
        Me.lblDegreesC.Name = "lblDegreesC"
        Me.lblDegreesC.Size = New System.Drawing.Size(23, 16)
        Me.lblDegreesC.TabIndex = 203
        Me.lblDegreesC.Text = "°C"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.Firebrick
        Me.lblSeconds.Location = New System.Drawing.Point(38, 393)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(43, 16)
        Me.lblSeconds.TabIndex = 204
        Me.lblSeconds.Text = "Secs"
        '
        'btnSaveLog
        '
        Me.btnSaveLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLog.Location = New System.Drawing.Point(924, 406)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(79, 26)
        Me.btnSaveLog.TabIndex = 205
        Me.btnSaveLog.Text = "Save Log"
        Me.btnSaveLog.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadProfileToolStripMenuItem, Me.SaveConfigToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadProfileToolStripMenuItem
        '
        Me.LoadProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadProfileToolStripMenuItem1})
        Me.LoadProfileToolStripMenuItem.Name = "LoadProfileToolStripMenuItem"
        Me.LoadProfileToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LoadProfileToolStripMenuItem.Text = "Profiles"
        '
        'LoadProfileToolStripMenuItem1
        '
        Me.LoadProfileToolStripMenuItem1.Name = "LoadProfileToolStripMenuItem1"
        Me.LoadProfileToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.LoadProfileToolStripMenuItem1.Text = "Load Profile"
        '
        'SaveConfigToolStripMenuItem
        '
        Me.SaveConfigToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.SaveConfigToolStripMenuItem.Name = "SaveConfigToolStripMenuItem"
        Me.SaveConfigToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SaveConfigToolStripMenuItem.Text = "Results"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTemperatureDisplay, Me.SetLiquidusTemperatureToolStripMenuItem, Me.MiscOptionsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'tsmiTemperatureDisplay
        '
        Me.tsmiTemperatureDisplay.Name = "tsmiTemperatureDisplay"
        Me.tsmiTemperatureDisplay.Size = New System.Drawing.Size(193, 22)
        Me.tsmiTemperatureDisplay.Text = "Thermocouple Display"
        Me.tsmiTemperatureDisplay.ToolTipText = "Allows you to change the way temperatures are displayed on the graph"
        '
        'SetLiquidusTemperatureToolStripMenuItem
        '
        Me.SetLiquidusTemperatureToolStripMenuItem.Name = "SetLiquidusTemperatureToolStripMenuItem"
        Me.SetLiquidusTemperatureToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SetLiquidusTemperatureToolStripMenuItem.Text = "Liquidus temperature"
        '
        'MiscOptionsToolStripMenuItem
        '
        Me.MiscOptionsToolStripMenuItem.Name = "MiscOptionsToolStripMenuItem"
        Me.MiscOptionsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.MiscOptionsToolStripMenuItem.Text = "Misc Options"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.CommandsToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'CommandsToolStripMenuItem
        '
        Me.CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem"
        Me.CommandsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CommandsToolStripMenuItem.Text = "Commands"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(150, 24)
        Me.MenuStrip1.TabIndex = 173
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'imgConnectStatus
        '
        Me.imgConnectStatus.InitialImage = Global.ReflowController.My.Resources.Resources.Red_Light
        Me.imgConnectStatus.Location = New System.Drawing.Point(964, 664)
        Me.imgConnectStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.imgConnectStatus.MaximumSize = New System.Drawing.Size(19, 18)
        Me.imgConnectStatus.MinimumSize = New System.Drawing.Size(19, 18)
        Me.imgConnectStatus.Name = "imgConnectStatus"
        Me.imgConnectStatus.Size = New System.Drawing.Size(19, 18)
        Me.imgConnectStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgConnectStatus.TabIndex = 22
        Me.imgConnectStatus.TabStop = False
        '
        'lblRun
        '
        Me.lblRun.AutoSize = True
        Me.lblRun.BackColor = System.Drawing.Color.Transparent
        Me.lblRun.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRun.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblRun.Location = New System.Drawing.Point(404, 21)
        Me.lblRun.Name = "lblRun"
        Me.lblRun.Size = New System.Drawing.Size(96, 34)
        Me.lblRun.TabIndex = 206
        Me.lblRun.Text = "Run #"
        '
        'txtRunNumber
        '
        Me.txtRunNumber.AutoSize = True
        Me.txtRunNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtRunNumber.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRunNumber.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.txtRunNumber.Location = New System.Drawing.Point(496, 20)
        Me.txtRunNumber.Name = "txtRunNumber"
        Me.txtRunNumber.Size = New System.Drawing.Size(69, 34)
        Me.txtRunNumber.TabIndex = 207
        Me.txtRunNumber.Text = "nnn"
        Me.txtRunNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMaxTC
        '
        Me.txtMaxTC.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtMaxTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxTC.Location = New System.Drawing.Point(839, 78)
        Me.txtMaxTC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaxTC.MinimumSize = New System.Drawing.Size(4, 40)
        Me.txtMaxTC.Multiline = True
        Me.txtMaxTC.Name = "txtMaxTC"
        Me.txtMaxTC.ReadOnly = True
        Me.txtMaxTC.Size = New System.Drawing.Size(134, 83)
        Me.txtMaxTC.TabIndex = 208
        Me.txtMaxTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDeltas
        '
        Me.lblDeltas.AutoSize = True
        Me.lblDeltas.Location = New System.Drawing.Point(48, 483)
        Me.lblDeltas.Name = "lblDeltas"
        Me.lblDeltas.Size = New System.Drawing.Size(160, 13)
        Me.lblDeltas.TabIndex = 209
        Me.lblDeltas.Text = "Delta from oven calculated temp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(489, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 210
        Me.Label3.Text = "Command"
        '
        'lblHeaderTC1
        '
        Me.lblHeaderTC1.AutoSize = True
        Me.lblHeaderTC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTC1.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblHeaderTC1.Location = New System.Drawing.Point(384, 441)
        Me.lblHeaderTC1.MaximumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC1.MinimumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC1.Name = "lblHeaderTC1"
        Me.lblHeaderTC1.Size = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC1.TabIndex = 211
        Me.lblHeaderTC1.Text = "TC1"
        Me.lblHeaderTC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderTC2
        '
        Me.lblHeaderTC2.AutoSize = True
        Me.lblHeaderTC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTC2.ForeColor = System.Drawing.Color.Purple
        Me.lblHeaderTC2.Location = New System.Drawing.Point(440, 441)
        Me.lblHeaderTC2.MaximumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC2.MinimumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC2.Name = "lblHeaderTC2"
        Me.lblHeaderTC2.Size = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC2.TabIndex = 212
        Me.lblHeaderTC2.Text = "TC2"
        Me.lblHeaderTC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderTC3
        '
        Me.lblHeaderTC3.AutoSize = True
        Me.lblHeaderTC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTC3.ForeColor = System.Drawing.Color.Blue
        Me.lblHeaderTC3.Location = New System.Drawing.Point(495, 441)
        Me.lblHeaderTC3.MaximumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC3.MinimumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC3.Name = "lblHeaderTC3"
        Me.lblHeaderTC3.Size = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC3.TabIndex = 213
        Me.lblHeaderTC3.Text = "TC3"
        Me.lblHeaderTC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderTC4
        '
        Me.lblHeaderTC4.AutoSize = True
        Me.lblHeaderTC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTC4.ForeColor = System.Drawing.Color.Orange
        Me.lblHeaderTC4.Location = New System.Drawing.Point(549, 441)
        Me.lblHeaderTC4.MaximumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC4.MinimumSize = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC4.Name = "lblHeaderTC4"
        Me.lblHeaderTC4.Size = New System.Drawing.Size(47, 16)
        Me.lblHeaderTC4.TabIndex = 214
        Me.lblHeaderTC4.Text = "TC4"
        Me.lblHeaderTC4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(330, 441)
        Me.Label10.MaximumSize = New System.Drawing.Size(45, 16)
        Me.Label10.MinimumSize = New System.Drawing.Size(45, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 215
        Me.Label10.Text = "Time"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(603, 441)
        Me.Label11.MaximumSize = New System.Drawing.Size(45, 16)
        Me.Label11.MinimumSize = New System.Drawing.Size(45, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 216
        Me.Label11.Text = "Target"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(653, 441)
        Me.Label12.MaximumSize = New System.Drawing.Size(45, 16)
        Me.Label12.MinimumSize = New System.Drawing.Size(45, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 217
        Me.Label12.Text = "Actual"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(704, 441)
        Me.Label6.MaximumSize = New System.Drawing.Size(45, 16)
        Me.Label6.MinimumSize = New System.Drawing.Size(45, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Heat"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(751, 441)
        Me.Label7.MaximumSize = New System.Drawing.Size(45, 16)
        Me.Label7.MinimumSize = New System.Drawing.Size(45, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 219
        Me.Label7.Text = "Fan"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1057, 730)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblHeaderTC4)
        Me.Controls.Add(Me.lblHeaderTC3)
        Me.Controls.Add(Me.lblHeaderTC2)
        Me.Controls.Add(Me.lblHeaderTC1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDeltas)
        Me.Controls.Add(Me.txtMaxTC)
        Me.Controls.Add(Me.txtRunNumber)
        Me.Controls.Add(Me.lblRun)
        Me.Controls.Add(Me.btnSaveLog)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblDegreesC)
        Me.Controls.Add(Me.lblTC4)
        Me.Controls.Add(Me.lblTC3)
        Me.Controls.Add(Me.lblTC2)
        Me.Controls.Add(Me.lblTC1)
        Me.Controls.Add(Me.lblTC4Head)
        Me.Controls.Add(Me.lblTC3Head)
        Me.Controls.Add(Me.lblTC2Head)
        Me.Controls.Add(Me.lblTC1Head)
        Me.Controls.Add(Me.lblHeat)
        Me.Controls.Add(Me.lblFan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barHeat)
        Me.Controls.Add(Me.barFan)
        Me.Controls.Add(Me.txtMaxTemp)
        Me.Controls.Add(Me.txtProfileSelected)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.cboProfile)
        Me.Controls.Add(Me.btnReflow)
        Me.Controls.Add(Me.chkStandbyTracing)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.txtPhase)
        Me.Controls.Add(Me.imgConnectStatus)
        Me.Controls.Add(Me.COMPortsBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.txtBoxTransmit)
        Me.Controls.Add(Me.txtBoxReceived)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BaudRateBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ProfileChart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Reflow Controller"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ProfileChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgConnectStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents COMPortsBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BaudRateBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBoxReceived As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents txtBoxTransmit As System.Windows.Forms.TextBox
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents imgConnectStatus As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProfileChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents txtPhase As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtTemp As System.Windows.Forms.Label
    Friend WithEvents chkStandbyTracing As System.Windows.Forms.CheckBox
    Friend WithEvents btnReflow As Button
    Friend WithEvents cboProfile As ComboBox
    Friend WithEvents lblProfile As Label
    Friend WithEvents txtProfileSelected As Label
    Friend WithEvents txtMaxTemp As TextBox
    Friend WithEvents barFan As ProgressBar
    Friend WithEvents barHeat As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFan As Label
    Friend WithEvents lblHeat As Label
    Friend WithEvents lblTC1Head As Label
    Friend WithEvents lblTC2Head As Label
    Friend WithEvents lblTC3Head As Label
    Friend WithEvents lblTC4Head As Label
    Friend WithEvents lblTC1 As Label
    Friend WithEvents lblTC2 As Label
    Friend WithEvents lblTC3 As Label
    Friend WithEvents lblTC4 As Label
    Friend WithEvents lblDegreesC As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents btnSaveLog As Button
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadProfileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiTemperatureDisplay As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CommandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SetLiquidusTemperatureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRun As Label
    Friend WithEvents txtRunNumber As Label
    Friend WithEvents txtMaxTC As TextBox
    Friend WithEvents MiscOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDeltas As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHeaderTC1 As Label
    Friend WithEvents lblHeaderTC2 As Label
    Friend WithEvents lblHeaderTC3 As Label
    Friend WithEvents lblHeaderTC4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
