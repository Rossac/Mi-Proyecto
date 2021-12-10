Public Class Eje14

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Len(TextN.Text)
        txtCC.Text = CStr(Len(TextN.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextN.Text = ""
        txtCC.Text = ""
    End Sub
End Class
