Public Class Ejer4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Validamos que ningún campo que de vacio
        If txtUsuario.Text = "" Then
            MsgBox("El campo usuario se encuentra vacio")
        ElseIf txtContraseña.Text = "" Then
            MsgBox("El campo contraseña se encuentra vacio")
            'Si el usuario y contraseña son correctos mostrar mensaje de bienvenida: Bienvenido“Usuario_ingresado”. 



        ElseIf (txtContraseña.Text) And (txtContraseña.Text) Then
            Dim Us As String
            Us = txtUsuario.Text
            MsgBox("Bienvenido  " & Us)
        End If
    End Sub
    'Validamos que la contraseña sea solo numerica
    Private Sub e(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    ' Incorporar un checkbox que permita mostrar y ocultar la contraseña ingresada.
    Private Sub chkVer_CheckedChanged(sender As Object, e As EventArgs) Handles chkVer.CheckedChanged
        If (chkVer.Checked) Then
            txtContraseña.PasswordChar = "*"
        Else
            txtContraseña.PasswordChar = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class