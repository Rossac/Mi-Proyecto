Public Class Eje3

    Private Sub Eje3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

        TextBox1.Text = DateTime.Now.ToString("HH:mm")

        If (TextBox1.Text = DateTime.Now.ToString("HH:mm") = 7 / 24 Or TextBox1.Text = DateTime.Now.ToString("HH:mm") > 10 / 24) Then
            lblR.Text = "Desayuno, Menu= Arepa, pan, jugo"
        ElseIf (TextBox1.Text = DateTime.Now.ToString("HH:mm") = 10 / 24 Or TextBox1.Text = DateTime.Now.ToString("HH:mm") = 15 / 24) Then
            lblR.Text = "Almuerzo, Menu= Sopa, Arroz, pollo"
        End If

    End Sub
End Class