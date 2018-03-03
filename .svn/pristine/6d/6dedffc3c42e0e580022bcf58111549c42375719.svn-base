Imports System.Deployment
Public Class frmSetLiquidus

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtSetLiquidus.Text = GlobalParameters.LiquidusTemp.ToString

        ' Centre to parent
        Me.CenterToParent()

        'Now Show
        Me.Show()

        ' Now set focus on the input box
        txtSetLiquidus.Focus()
    End Sub


    Private Sub txtSetLiquidus_KeyDown(sender As Object, e As EventArgs) Handles txtSetLiquidus.KeyDown
        perform_tab_on_enter(e)
    End Sub


    Public Sub perform_tab_on_enter(ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound 
    End Sub


    Private Sub btnSetLiquidusCancel_Click(sender As Object, e As EventArgs) Handles btnSetLiquidusCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSetLiquidus_Click(sender As Object, e As EventArgs) Handles btnSetLiquidus.Click
        If txtSetLiquidus.Text IsNot "" Then
            Try
                ' Clear the last line
                frmMain.ProfileChart.Series("Liquidus").Points.Clear()
                ' Set the new one
                GlobalParameters.LiquidusTemp = Convert.ToDouble(txtSetLiquidus.Text.Trim)
                GlobalFunctions.SetLiquidusLine(GlobalParameters.LiquidusTemp)
                Me.Close()
            Catch
                MsgBox("Incorrect Input")
            End Try
        End If

    End Sub


End Class