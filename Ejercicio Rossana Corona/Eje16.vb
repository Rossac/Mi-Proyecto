Public Class Eje16
    Function P(ByVal valor As Integer) As Integer
        Return P
    End Function
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor = Convert.ToDouble(txtV.Text)
        Dim nombre = txtProducto.Text
        txtValorf.Text = Iva(valor) & "  Iva(%12)"
    End Sub
    Function Iva(ByVal P As Decimal) As Decimal

        Dim i As Decimal

        i = 12% / 100 * P
        Return i

    End Function
End Class