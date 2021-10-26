<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtnumero1 = New System.Windows.Forms.TextBox()
        Me.txtnumero2 = New System.Windows.Forms.TextBox()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.suma = New System.Windows.Forms.Button()
        Me.Resta = New System.Windows.Forms.Button()
        Me.Multiplicar = New System.Windows.Forms.Button()
        Me.dividir = New System.Windows.Forms.Button()
        Me.lbfecha = New System.Windows.Forms.Label()
        Me.lbmjs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 2"
        '
        'txtnumero1
        '
        Me.txtnumero1.Location = New System.Drawing.Point(208, 36)
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.Size = New System.Drawing.Size(194, 22)
        Me.txtnumero1.TabIndex = 2
        '
        'txtnumero2
        '
        Me.txtnumero2.Location = New System.Drawing.Point(208, 91)
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.Size = New System.Drawing.Size(194, 22)
        Me.txtnumero2.TabIndex = 3
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(208, 163)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(194, 22)
        Me.txtresultado.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado"
        '
        'suma
        '
        Me.suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.suma.Location = New System.Drawing.Point(468, 45)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(74, 67)
        Me.suma.TabIndex = 9
        Me.suma.Text = "+"
        Me.suma.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resta.Location = New System.Drawing.Point(561, 46)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(74, 67)
        Me.Resta.TabIndex = 7
        Me.Resta.Text = "-"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Multiplicar
        '
        Me.Multiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicar.Location = New System.Drawing.Point(468, 132)
        Me.Multiplicar.Name = "Multiplicar"
        Me.Multiplicar.Size = New System.Drawing.Size(74, 67)
        Me.Multiplicar.TabIndex = 8
        Me.Multiplicar.Text = "*"
        Me.Multiplicar.UseVisualStyleBackColor = True
        '
        'dividir
        '
        Me.dividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividir.Location = New System.Drawing.Point(561, 132)
        Me.dividir.Name = "dividir"
        Me.dividir.Size = New System.Drawing.Size(74, 67)
        Me.dividir.TabIndex = 9
        Me.dividir.Text = "/"
        Me.dividir.UseVisualStyleBackColor = True
        '
        'lbfecha
        '
        Me.lbfecha.AutoSize = True
        Me.lbfecha.Location = New System.Drawing.Point(205, 225)
        Me.lbfecha.Name = "lbfecha"
        Me.lbfecha.Size = New System.Drawing.Size(51, 17)
        Me.lbfecha.TabIndex = 10
        Me.lbfecha.Text = "Label4"
        '
        'lbmjs
        '
        Me.lbmjs.AutoSize = True
        Me.lbmjs.Location = New System.Drawing.Point(205, 287)
        Me.lbmjs.Name = "lbmjs"
        Me.lbmjs.Size = New System.Drawing.Size(0, 17)
        Me.lbmjs.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 510)
        Me.Controls.Add(Me.lbmjs)
        Me.Controls.Add(Me.lbfecha)
        Me.Controls.Add(Me.dividir)
        Me.Controls.Add(Me.Multiplicar)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.txtnumero2)
        Me.Controls.Add(Me.txtnumero1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnumero1 As TextBox
    Friend WithEvents txtnumero2 As TextBox
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents suma As Button
    Friend WithEvents Resta As Button
    Friend WithEvents Multiplicar As Button
    Friend WithEvents dividir As Button
    Friend WithEvents lbfecha As Label
    Friend WithEvents lbmjs As Label
End Class
