﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiscOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtRunNumber = New System.Windows.Forms.TextBox()
        Me.lblRunNumber = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMachineID = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkReduceOvenPoints = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProfileName6 = New System.Windows.Forms.Label()
        Me.txtProfileName5 = New System.Windows.Forms.Label()
        Me.txtProfileName4 = New System.Windows.Forms.Label()
        Me.txtProfileName3 = New System.Windows.Forms.Label()
        Me.txtProfileName2 = New System.Windows.Forms.Label()
        Me.txtProfileName1 = New System.Windows.Forms.Label()
        Me.txtProfileName0 = New System.Windows.Forms.Label()
        Me.txtLiquidus6 = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtLiquidus5 = New System.Windows.Forms.TextBox()
        Me.txtLiquidus4 = New System.Windows.Forms.TextBox()
        Me.txtLiquidus3 = New System.Windows.Forms.TextBox()
        Me.txtLiquidus2 = New System.Windows.Forms.TextBox()
        Me.txtLiquidus1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLiquidus0 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboOvenType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(280, 472)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(110, 37)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtRunNumber
        '
        Me.txtRunNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRunNumber.Location = New System.Drawing.Point(178, 87)
        Me.txtRunNumber.MaxLength = 30
        Me.txtRunNumber.Name = "txtRunNumber"
        Me.txtRunNumber.Size = New System.Drawing.Size(125, 22)
        Me.txtRunNumber.TabIndex = 2
        '
        'lblRunNumber
        '
        Me.lblRunNumber.AutoSize = True
        Me.lblRunNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunNumber.Location = New System.Drawing.Point(34, 90)
        Me.lblRunNumber.Name = "lblRunNumber"
        Me.lblRunNumber.Size = New System.Drawing.Size(123, 16)
        Me.lblRunNumber.TabIndex = 2
        Me.lblRunNumber.Text = "Adjust Run Number"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(322, 87)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(78, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Machine Identity"
        '
        'txtMachineID
        '
        Me.txtMachineID.AcceptsReturn = True
        Me.txtMachineID.AcceptsTab = True
        Me.txtMachineID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachineID.Location = New System.Drawing.Point(178, 49)
        Me.txtMachineID.Name = "txtMachineID"
        Me.txtMachineID.Size = New System.Drawing.Size(125, 22)
        Me.txtMachineID.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(62, 472)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 37)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Reduce oven points to two per second (.0 and .5)"
        '
        'chkReduceOvenPoints
        '
        Me.chkReduceOvenPoints.AutoSize = True
        Me.chkReduceOvenPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReduceOvenPoints.Location = New System.Drawing.Point(349, 146)
        Me.chkReduceOvenPoints.Name = "chkReduceOvenPoints"
        Me.chkReduceOvenPoints.Size = New System.Drawing.Size(15, 14)
        Me.chkReduceOvenPoints.TabIndex = 4
        Me.chkReduceOvenPoints.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProfileName6)
        Me.GroupBox1.Controls.Add(Me.txtProfileName5)
        Me.GroupBox1.Controls.Add(Me.txtProfileName4)
        Me.GroupBox1.Controls.Add(Me.txtProfileName3)
        Me.GroupBox1.Controls.Add(Me.txtProfileName2)
        Me.GroupBox1.Controls.Add(Me.txtProfileName1)
        Me.GroupBox1.Controls.Add(Me.txtProfileName0)
        Me.GroupBox1.Controls.Add(Me.txtLiquidus6)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.txtLiquidus5)
        Me.GroupBox1.Controls.Add(Me.txtLiquidus4)
        Me.GroupBox1.Controls.Add(Me.txtLiquidus3)
        Me.GroupBox1.Controls.Add(Me.txtLiquidus2)
        Me.GroupBox1.Controls.Add(Me.txtLiquidus1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLiquidus0)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 270)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liquidus Profiles"
        '
        'txtProfileName6
        '
        Me.txtProfileName6.AutoSize = True
        Me.txtProfileName6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileName6.Location = New System.Drawing.Point(79, 236)
        Me.txtProfileName6.Name = "txtProfileName6"
        Me.txtProfileName6.Size = New System.Drawing.Size(63, 16)
        Me.txtProfileName6.TabIndex = 15
        Me.txtProfileName6.Text = "Unknown"
        '
        'txtProfileName5
        '
        Me.txtProfileName5.AutoSize = True
        Me.txtProfileName5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileName5.Location = New System.Drawing.Point(79, 203)
        Me.txtProfileName5.Name = "txtProfileName5"
        Me.txtProfileName5.Size = New System.Drawing.Size(63, 16)
        Me.txtProfileName5.TabIndex = 15
        Me.txtProfileName5.Text = "Unknown"
        '
        'txtProfileName4
        '
        Me.txtProfileName4.AutoSize = True
        Me.txtProfileName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileName4.Location = New System.Drawing.Point(79, 170)
        Me.txtProfileName4.Name = "txtProfileName4"
        Me.txtProfileName4.Size = New System.Drawing.Size(63, 16)
        Me.txtProfileName4.TabIndex = 15
        Me.txtProfileName4.Text = "Unknown"
        '
        'txtProfileName3
        '
        Me.txtProfileName3.AutoSize = True
        Me.txtProfileName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileName3.Location = New System.Drawing.Point(79, 137)
        Me.txtProfileName3.Name = "txtProfileName3"
        Me.txtProfileName3.Size = New System.Drawing.Size(63, 16)
        Me.txtProfileName3.TabIndex = 15
        Me.txtProfileName3.Text = "Unknown"
        '
        'txtProfileName2
        '
        Me.txtProfileName2.AutoSize = True
        Me.txtProfileName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileName2.Location = New System.Drawing.Point(79, 104)
        Me.txtProfileName2.Name = "txtProfileName2"
        Me.txtProfileName2.Size = New System.Drawing.Size(63, 16)
        Me.txtProfileName2.TabIndex = 15
        Me.txtProfileName2.Text = "Unknown"
        '
        'txtProfileName1
        '
        Me.txtProfileName1.AutoSize = True
        Me.txtProfileName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileName1.Location = New System.Drawing.Point(79, 71)
        Me.txtProfileName1.Name = "txtProfileName1"
        Me.txtProfileName1.Size = New System.Drawing.Size(63, 16)
        Me.txtProfileName1.TabIndex = 15
        Me.txtProfileName1.Text = "Unknown"
        '
        'txtProfileName0
        '
        Me.txtProfileName0.AutoSize = True
        Me.txtProfileName0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileName0.Location = New System.Drawing.Point(79, 38)
        Me.txtProfileName0.Name = "txtProfileName0"
        Me.txtProfileName0.Size = New System.Drawing.Size(63, 16)
        Me.txtProfileName0.TabIndex = 14
        Me.txtProfileName0.Text = "Unknown"
        '
        'txtLiquidus6
        '
        Me.txtLiquidus6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquidus6.Location = New System.Drawing.Point(260, 233)
        Me.txtLiquidus6.Name = "txtLiquidus6"
        Me.txtLiquidus6.Size = New System.Drawing.Size(100, 22)
        Me.txtLiquidus6.TabIndex = 11
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(14, 236)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(56, 16)
        Me.lbl4.TabIndex = 12
        Me.lbl4.Text = "Profile 6"
        '
        'txtLiquidus5
        '
        Me.txtLiquidus5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquidus5.Location = New System.Drawing.Point(260, 200)
        Me.txtLiquidus5.Name = "txtLiquidus5"
        Me.txtLiquidus5.Size = New System.Drawing.Size(100, 22)
        Me.txtLiquidus5.TabIndex = 10
        '
        'txtLiquidus4
        '
        Me.txtLiquidus4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquidus4.Location = New System.Drawing.Point(260, 167)
        Me.txtLiquidus4.Name = "txtLiquidus4"
        Me.txtLiquidus4.Size = New System.Drawing.Size(100, 22)
        Me.txtLiquidus4.TabIndex = 9
        '
        'txtLiquidus3
        '
        Me.txtLiquidus3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquidus3.Location = New System.Drawing.Point(260, 134)
        Me.txtLiquidus3.Name = "txtLiquidus3"
        Me.txtLiquidus3.Size = New System.Drawing.Size(100, 22)
        Me.txtLiquidus3.TabIndex = 8
        '
        'txtLiquidus2
        '
        Me.txtLiquidus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquidus2.Location = New System.Drawing.Point(260, 101)
        Me.txtLiquidus2.Name = "txtLiquidus2"
        Me.txtLiquidus2.Size = New System.Drawing.Size(100, 22)
        Me.txtLiquidus2.TabIndex = 7
        '
        'txtLiquidus1
        '
        Me.txtLiquidus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquidus1.Location = New System.Drawing.Point(260, 68)
        Me.txtLiquidus1.Name = "txtLiquidus1"
        Me.txtLiquidus1.Size = New System.Drawing.Size(100, 22)
        Me.txtLiquidus1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Profile 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Profile 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Profile 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Profile 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Profile 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Profile 0"
        '
        'txtLiquidus0
        '
        Me.txtLiquidus0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquidus0.Location = New System.Drawing.Point(260, 35)
        Me.txtLiquidus0.Name = "txtLiquidus0"
        Me.txtLiquidus0.Size = New System.Drawing.Size(100, 22)
        Me.txtLiquidus0.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Oven Type"
        '
        'cboOvenType
        '
        Me.cboOvenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOvenType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOvenType.FormattingEnabled = True
        Me.cboOvenType.Items.AddRange(New Object() {"T-962", "T-962A"})
        Me.cboOvenType.Location = New System.Drawing.Point(178, 12)
        Me.cboOvenType.Name = "cboOvenType"
        Me.cboOvenType.Size = New System.Drawing.Size(121, 24)
        Me.cboOvenType.TabIndex = 0
        '
        'frmMiscOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 535)
        Me.Controls.Add(Me.cboOvenType)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkReduceOvenPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtMachineID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblRunNumber)
        Me.Controls.Add(Me.txtRunNumber)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmMiscOptions"
        Me.Text = "Miscellaneous Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents txtRunNumber As TextBox
    Friend WithEvents lblRunNumber As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMachineID As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents chkReduceOvenPoints As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLiquidus5 As TextBox
    Friend WithEvents txtLiquidus4 As TextBox
    Friend WithEvents txtLiquidus3 As TextBox
    Friend WithEvents txtLiquidus2 As TextBox
    Friend WithEvents txtLiquidus1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLiquidus0 As TextBox
    Friend WithEvents txtLiquidus6 As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtProfileName6 As Label
    Friend WithEvents txtProfileName5 As Label
    Friend WithEvents txtProfileName4 As Label
    Friend WithEvents txtProfileName3 As Label
    Friend WithEvents txtProfileName2 As Label
    Friend WithEvents txtProfileName1 As Label
    Friend WithEvents txtProfileName0 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboOvenType As ComboBox
End Class
