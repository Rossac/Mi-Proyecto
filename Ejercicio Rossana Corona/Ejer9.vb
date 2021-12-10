Public Class Ejer9

    Public Sub CrearDVG()

        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).HeaderText = "Multiplicando"
        DataGridView1.Columns(0).HeaderText = "Multiplicador"
        DataGridView1.Columns(0).HeaderText = "Resultado"
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim N As Integer
        N = Val(txtN.Text)
        For i = 1 To 10
            DataGridView1.Rows.Add(N, i, N * i)



        Next
    End Sub

   


End Class
