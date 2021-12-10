Public Class Ejer7

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Dim date1 As Date = CDate(Me.DateTimePicker1.Value)
            Dim date2 As Date = CDate(Me.DateTimePicker2.Value)
            If date2.Year < date1.Year Then
                Me.btnCalcular.Text = "Rango de fecha es valido"
            ElseIf date2.Month < date1.Month Then
                Me.btnCalcular.Text = "Rango de fecha es invalido"

            End If
            Dim Value As Double
            Value = Int(date2.Year - date1.Year)
            Select Case Value
                Case 1
                    lblResultado.Text = "Su edad es I"
                Case 2
                    lblResultado.Text = "Su edad es II"
                Case 3 : lblResultado.Text = "Su edad es III"
                Case 4 : lblResultado.Text = "Su edad es IV"
                Case 5 : lblResultado.Text = "Su edad es V"
                Case 6 : lblResultado.Text = "Su edad es VI"
                Case 7 : lblResultado.Text = "Su edad es VII"
                Case 8 : lblResultado.Text = "Su edad es VIII"
                Case 9 : lblResultado.Text = "Su edad es IX"
                Case 10 : lblResultado.Text = "Su edad es X"
                Case 10 : lblResultado.Text = "Su edad es X"
                Case 11 : lblResultado.Text = "Su edad es XI"
                Case 12 : lblResultado.Text = "Su edad es XII"
                Case 13 : lblResultado.Text = "Su edad es XII"
                Case 14 : lblResultado.Text = "Su edad es XIV"
                Case 15 : lblResultado.Text = "Su edad es XV"
                Case 16 : lblResultado.Text = "Su edad es XVI"
                Case 17 : lblResultado.Text = "Su edad es XVII"
                Case 18 : lblResultado.Text = "Su edad es XVIII"
                Case 19 : lblResultado.Text = "Su edad es XIX"
                Case 20 : lblResultado.Text = "Su edad es XX"
                Case 21 : lblResultado.Text = "Su edad es XXI"
                Case 22 : lblResultado.Text = "Su edad es XXII"
                Case 30 : lblResultado.Text = "Su edad es XXX"
                Case 40 : lblResultado.Text = "Su edad es XI"
                Case 50 : lblResultado.Text = "Su edad es L"
                Case 60 : lblResultado.Text = "Su edad es LX"
                Case 70 : lblResultado.Text = "Su edad es LXX"

            End Select




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblResultado.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""






    End Sub
End Class
