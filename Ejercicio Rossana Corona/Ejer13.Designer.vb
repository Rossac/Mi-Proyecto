<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejer13
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
        Me.txtNumeroEntero = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 95)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "13. Elaborar un programa que contenga " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "un método que reciba un número entero " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y" & _
    " retorne el número con sus dígitos invertidos. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Por ejemplo si el número ingres" & _
    "ado es 9876 se " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "deberá retornar 6789."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero"
        '
        'txtNumeroEntero
        '
        Me.txtNumeroEntero.Location = New System.Drawing.Point(85, 123)
        Me.txtNumeroEntero.Name = "txtNumeroEntero"
        Me.txtNumeroEntero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroEntero.TabIndex = 2
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(85, 163)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(100, 20)
        Me.txtR.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(12, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Invertir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Inverso"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(177, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 57)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Reiniciar "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Ejer13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(320, 305)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txtNumeroEntero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Ejer13"
        Me.Text = "Ejer13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroEntero As System.Windows.Forms.TextBox
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
