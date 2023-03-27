Public Class Form1
    Private Sub cmdBoton_Click(sender As Object, e As EventArgs) Handles cmdBoton.Click

        lblMensaje.Text = txtMensaje.Text
        txtMensaje.Text = " "
        txtMensaje.Focus()

    End Sub
End Class
