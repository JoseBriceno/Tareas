<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio3
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUPRINCIPALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxTotalVentas = New System.Windows.Forms.TextBox()
        Me.LabelAlmacen = New System.Windows.Forms.Label()
        Me.txtSuperiores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUPRINCIPALToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(357, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUPRINCIPALToolStripMenuItem
        '
        Me.MENUPRINCIPALToolStripMenuItem.Name = "MENUPRINCIPALToolStripMenuItem"
        Me.MENUPRINCIPALToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.MENUPRINCIPALToolStripMenuItem.Text = "MENU PRINCIPAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INGRESE TOTAL VENTAS DEL MES"
        '
        'txtBoxTotalVentas
        '
        Me.txtBoxTotalVentas.Location = New System.Drawing.Point(207, 54)
        Me.txtBoxTotalVentas.Name = "txtBoxTotalVentas"
        Me.txtBoxTotalVentas.Size = New System.Drawing.Size(127, 20)
        Me.txtBoxTotalVentas.TabIndex = 4
        '
        'LabelAlmacen
        '
        Me.LabelAlmacen.AutoSize = True
        Me.LabelAlmacen.Location = New System.Drawing.Point(232, 38)
        Me.LabelAlmacen.Name = "LabelAlmacen"
        Me.LabelAlmacen.Size = New System.Drawing.Size(61, 13)
        Me.LabelAlmacen.TabIndex = 5
        Me.LabelAlmacen.Text = "ALMACEN:"
        '
        'txtSuperiores
        '
        Me.txtSuperiores.Location = New System.Drawing.Point(12, 131)
        Me.txtSuperiores.Multiline = True
        Me.txtSuperiores.Name = "txtSuperiores"
        Me.txtSuperiores.Size = New System.Drawing.Size(186, 96)
        Me.txtSuperiores.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LISTADO ALMACENES CON VENTAS SUPERIORES A LA MEDIA"
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(220, 131)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(114, 40)
        Me.ButtonMostrar.TabIndex = 8
        Me.ButtonMostrar.Text = "MOSTRAR"
        Me.ButtonMostrar.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(220, 187)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(114, 40)
        Me.ButtonClear.TabIndex = 9
        Me.ButtonClear.Text = "CLEAR"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Location = New System.Drawing.Point(44, 58)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(114, 40)
        Me.ButtonIngresar.TabIndex = 10
        Me.ButtonIngresar.Text = "INGRESAR"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'Ejercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 261)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSuperiores)
        Me.Controls.Add(Me.LabelAlmacen)
        Me.Controls.Add(Me.txtBoxTotalVentas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ejercicio3"
        Me.Text = "Ejercicio3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUPRINCIPALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxTotalVentas As TextBox
    Friend WithEvents LabelAlmacen As Label
    Friend WithEvents txtSuperiores As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonMostrar As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonIngresar As Button
End Class
