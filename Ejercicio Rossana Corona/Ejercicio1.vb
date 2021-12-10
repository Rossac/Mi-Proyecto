Public Class Ejercicio1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bs As Integer
        Dim alt As Integer

        bs = txtbs.Text
        alt = txtalt.Text
        txtResultado.Text = bs * alt / 2

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
