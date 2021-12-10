Imports System.Windows.Forms

Public Class MDIParent1
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EjercicioN1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN1ToolStripMenuItem.Click
        Dim form1 As Form = New Ejer1
        form1.Show(Me)
    End Sub
    Private Sub EjercicioN2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN2ToolStripMenuItem.Click
        Dim form2 As Form = New Ejer2
        form2.Show(Me)
    End Sub
    Private Sub EjercicioN3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN3ToolStripMenuItem.Click
        Dim form3 As Form = New Eje3
        form3.Show(Me)
    End Sub
    Private Sub EjercicioN4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN4ToolStripMenuItem.Click
        Dim form4 As Form = New Ejer4
        form4.Show(Me)
    End Sub
    Private Sub EjercicioN5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN5ToolStripMenuItem.Click
        Dim form5 As Form = New Eje5
        form5.Show(Me)
    End Sub
   
    Private Sub EjercicioN7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN7ToolStripMenuItem.Click
        Dim form7 As Form = New Ejer7
        form7.Show(Me)
    End Sub
    Private Sub EjercicioN8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN8ToolStripMenuItem.Click
        Dim form8 As Form = New Eje8
        form8.Show(Me)
    End Sub
    Private Sub EjercicioN9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN9ToolStripMenuItem.Click
        Dim form9 As Form = New Ejer9
        form9.Show(Me)
    End Sub
    
    Private Sub EjercicioN10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN10ToolStripMenuItem.Click
        Dim form10 As Form = New Ejer10
        form10.Show(Me)
    End Sub

    Private Sub EjercicioN12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN12ToolStripMenuItem.Click
        Dim form12 As Form = New Ejer12
        form12.Show(Me)
    End Sub
    Private Sub EjercicioN13ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN13ToolStripMenuItem.Click
        Dim form13 As Form = New Ejer13
        form13.Show(Me)
    End Sub
    Private Sub EjercicioN16ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN16ToolStripMenuItem.Click
        Dim form16 As Form = New Eje16
        form16.Show(Me)
    End Sub

    Private Sub EjercicioN3ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EjercicioN3ToolStripMenuItem.Click
        Dim form3 As Form = New Eje3
        form3.Show(Me)
    End Sub

    Private Sub EjercicioN14ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN14ToolStripMenuItem.Click
        Dim form14 As Form = New Eje14
        form14.Show(Me)
    End Sub

    Private Sub EjercicioN17ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN17ToolStripMenuItem.Click

    End Sub

    Private Sub EjercicioN18ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjercicioN18ToolStripMenuItem.Click
        Dim form18 As Form = New Eje18
        form18.Show(Me)
    End Sub
End Class
