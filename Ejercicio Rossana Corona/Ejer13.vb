Public Class Ejer13


    Function InvertirNumero(ByVal num As Integer) As Integer
        Dim dig As Integer
        Dim inv As Integer
        inv = 0
        While num > 0
            dig = num Mod 10
            inv = inv * 10 + dig
            num = num \ 10

        End While
        InvertirNumero = inv



    End Function





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = txtNumeroEntero.Text
        Dim inv As Integer
        inv = InvertirNumero(num)
        txtR.Text = inv



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNumeroEntero.Text = String.Empty
        txtR.Text = String.Empty
    End Sub
End Class