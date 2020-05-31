<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDescuento = New System.Windows.Forms.CheckBox()
        Me.comboDescuento = New System.Windows.Forms.ComboBox()
        Me.cbISV = New System.Windows.Forms.CheckBox()
        Me.comboISV = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboISV)
        Me.GroupBox1.Controls.Add(Me.cbISV)
        Me.GroupBox1.Controls.Add(Me.comboDescuento)
        Me.GroupBox1.Controls.Add(Me.cbDescuento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS REQUERIDOS"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(111, 34)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(111, 75)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRECIO UNITARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CANTIDAD"
        '
        'cbDescuento
        '
        Me.cbDescuento.AutoSize = True
        Me.cbDescuento.Location = New System.Drawing.Point(9, 117)
        Me.cbDescuento.Name = "cbDescuento"
        Me.cbDescuento.Size = New System.Drawing.Size(141, 17)
        Me.cbDescuento.TabIndex = 1
        Me.cbDescuento.Text = "APLICAR DESCUENTO"
        Me.cbDescuento.UseVisualStyleBackColor = True
        '
        'comboDescuento
        '
        Me.comboDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDescuento.Enabled = False
        Me.comboDescuento.FormattingEnabled = True
        Me.comboDescuento.Items.AddRange(New Object() {"DESCUENTO SOCIO", "DESCUENTO ESTUDIO", "DESCUENTO STAFF", "DESCUENTO VIP ", "DESCUENTO ESPECIAL", "DESCUENTO NORMAL"})
        Me.comboDescuento.Location = New System.Drawing.Point(9, 140)
        Me.comboDescuento.Name = "comboDescuento"
        Me.comboDescuento.Size = New System.Drawing.Size(121, 21)
        Me.comboDescuento.TabIndex = 1
        '
        'cbISV
        '
        Me.cbISV.AutoSize = True
        Me.cbISV.Location = New System.Drawing.Point(9, 167)
        Me.cbISV.Name = "cbISV"
        Me.cbISV.Size = New System.Drawing.Size(91, 17)
        Me.cbISV.TabIndex = 4
        Me.cbISV.Text = "APLICAR ISV"
        Me.cbISV.UseVisualStyleBackColor = True
        '
        'comboISV
        '
        Me.comboISV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboISV.Enabled = False
        Me.comboISV.FormattingEnabled = True
        Me.comboISV.Items.AddRange(New Object() {"15%", "17%"})
        Me.comboISV.Location = New System.Drawing.Point(9, 190)
        Me.comboISV.Name = "comboISV"
        Me.comboISV.Size = New System.Drawing.Size(121, 21)
        Me.comboISV.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtISV)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 231)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLE FACTURA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DESCUENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "SUB TOTAL"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(111, 75)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 2
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(111, 34)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ISV 15%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL"
        '
        'txtISV
        '
        Me.txtISV.Location = New System.Drawing.Point(111, 118)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(100, 20)
        Me.txtISV.TabIndex = 6
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(111, 164)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(87, 266)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(199, 266)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(313, 266)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FACTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 305)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FACTURA"
        Me.Text = "FACTURA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents comboISV As ComboBox
    Friend WithEvents cbISV As CheckBox
    Friend WithEvents comboDescuento As ComboBox
    Friend WithEvents cbDescuento As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
End Class
