Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaPanel1, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaAdvenceButton1, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaAdvenceButton2, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaAdvenceButton3, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaAdvenceButton4, Color.Black, 40, 13, Guna.UI.WinForms.VerHorAlign.VerticalRight)
    End Sub

    Private Sub GunaAdvenceButton1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.CheckedChanged
        If GunaAdvenceButton1.Checked Then
            Page1.BringToFront()
        End If
    End Sub

    Private Sub GunaAdvenceButton2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.CheckedChanged
        If GunaAdvenceButton2.Checked Then
            Page2.BringToFront()
        End If
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Close()
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
