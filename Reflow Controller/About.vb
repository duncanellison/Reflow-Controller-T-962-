Public Class About

    Private Sub About_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblProgramName.Text = Application.ProductName
        lblVersion.Text = "Version : " & Application.ProductVersion
    End Sub

    
    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        Me.Close()
    End Sub
End Class