Public Class Ejer1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bs As Integer = txtbs.Text
        Dim alt As Integer = txtalt.Text

        lblResultado.Text = bs * alt / 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtalt.Text = String.Empty
        txtbs.Text = String.Empty
        lblResultado.Text = ""
    End Sub
End Class
