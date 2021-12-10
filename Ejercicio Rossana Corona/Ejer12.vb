Public Class Ejer12

    Function Celsius(ByVal g As Double) As Double
        Return Celsius

    End Function
    Private Sub txtCalcular_Click(sender As Object, e As EventArgs) Handles txtCalcular.Click
        Dim g As Double = Convert.ToDouble(txtCelcius.Text)
        txtR.Text() = total(g) & "°F"
    End Sub
    Public Function total(ByVal Celsius As Double) As Double
        Dim c As Double

        c = Trim(Celsius * (9 / 5) + 32)
        Return c
    End Function

    Private Sub txt2_Click(sender As Object, e As EventArgs) Handles txt2.Click
        txtCelcius.Text = String.Empty
        txtR.Text = String.Empty
    End Sub
End Class