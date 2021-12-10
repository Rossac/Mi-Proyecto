Public Class Ejer10
    Dim operacion As Double
    Dim dato As Double
    Dim datob As Double
    Dim resultado As Double

    Private Sub Bt0_Click(sender As Object, e As EventArgs) Handles Bt0.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "0"

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If operacion = 0 Then
            txtResultado.Clear()
            operacion = 8
        End If
        txtResultado.Text = txtResultado.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResultado.Text = txtResultado.Text & "9"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtResultado.Clear()


    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        operacion = 1
        dato = Val(txtResultado.Text)
        txtResultado.Clear()

    End Sub

    Private Sub btnMultipli_Click(sender As Object, e As EventArgs) Handles btnMultipli.Click
        operacion = 2
        dato = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        operacion = 3
        dato = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        operacion = 4
        dato = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        datob = Val(txtResultado.Text)
        Select Case operacion
            Case 1
                resultado = dato + datob
            Case 2
                resultado = dato * datob
            Case 3
                resultado = dato - datob
            Case 4
                resultado = dato / datob


        End Select
        txtResultado.Text = resultado
        operacion = 0








    End Sub
End Class
