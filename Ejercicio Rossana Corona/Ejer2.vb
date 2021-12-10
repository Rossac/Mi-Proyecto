Public Class Ejer2

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        Dim p As Integer
        Dim a As Integer
        Dim IMC As Integer

        a = Val(txtA.Text)
        a = Math.Round(a, 2)

        p = Val(txtP.Text)
        p = Math.Round(p, 2)

        IMC = p / (a ^ 2)
        IMC = Math.Round(IMC)
        If IMC < 18.49 Then
            lblR.Text = "IMC: " & IMC & "(Usted tiene Infrapeso)"

        ElseIf IMC > 18.5 And IMC < 24.99 Then
            lblR.Text = "IMC: " & IMC & "(Su peso es Normal)"

        ElseIf IMC > 25 And IMC < 29.99 Then
            lblR.Text = "IMC: " & IMC & "(Usted tiene Sobrepeso)"

        Else
            lblR.Text = "IMC: " & IMC & "Usted es Obeso"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtA.Text = String.Empty
        txtP.Text = String.Empty
        lblResultado.Text = ""
    End Sub

    
End Class
