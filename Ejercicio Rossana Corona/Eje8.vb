Public Class Eje8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Len(txtTexto.Text)
        txtResultado.Text = CStr(Len(txtTexto.Text))
    End Sub
    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        txtResultado.Text = ""
        txtTexto.Text = ""
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txtResultado.Text = UCase(txtTexto.Text)
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txtResultado.Text = LCase(txtTexto.Text)
    End Sub

    Private Sub Negrita_CheckedChanged(sender As Object, e As EventArgs) Handles Negrita.CheckedChanged
        txtResultado.Font = New Font(txtTexto.Font, FontStyle.Bold)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        txtResultado.Font = New Font(txtTexto.Font, FontStyle.Italic)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        txtResultado.Font = New Font(txtTexto.Font, FontStyle.Regular)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim contv As Integer
        Dim vocales As String
        For i = 1 To txtTexto.Text.Length
            vocales = Mid(txtTexto.Text, 1, 1)
            If LCase(vocales) = "a" Or LCase(vocales) = "e" Or LCase(vocales) = "i" Or LCase(vocales) = "o" Or LCase(vocales) = "u" Then
                contv = contv = 1
            End If
        Next
        txtResultado.Text = contv
    End Sub
End Class