<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejer12
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.Button()
        Me.txtCalcular = New System.Windows.Forms.Button()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "12. Desarrollar un programa que contenga un" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " método llamado Celsius que reciba u" & _
    "n valor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "representado en grados Celsius y retorne el " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "valor representado en gr" & _
    "ados Fahrenheit."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Celcius"
        '
        'txtCelcius
        '
        Me.txtCelcius.Location = New System.Drawing.Point(73, 96)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(99, 20)
        Me.txtCelcius.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.SystemColors.Control
        Me.txt2.Location = New System.Drawing.Point(174, 170)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(124, 50)
        Me.txt2.TabIndex = 5
        Me.txt2.Text = "Reiniciar "
        Me.txt2.UseVisualStyleBackColor = False
        '
        'txtCalcular
        '
        Me.txtCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCalcular.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalcular.ForeColor = System.Drawing.SystemColors.Control
        Me.txtCalcular.Location = New System.Drawing.Point(12, 167)
        Me.txtCalcular.Name = "txtCalcular"
        Me.txtCalcular.Size = New System.Drawing.Size(141, 53)
        Me.txtCalcular.TabIndex = 4
        Me.txtCalcular.Text = "Calcular "
        Me.txtCalcular.UseVisualStyleBackColor = False
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(73, 141)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(85, 20)
        Me.txtR.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ejercicio_Rossana_Corona.My.Resources.Resources.descarga__2_
        Me.PictureBox1.Location = New System.Drawing.Point(198, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Ejer12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(333, 252)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txtCalcular)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Ejer12"
        Me.Text = "Ejercicio 12"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCelcius As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.Button
    Friend WithEvents txtCalcular As System.Windows.Forms.Button
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
