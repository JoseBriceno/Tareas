<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio2
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
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.txtBoXA = New System.Windows.Forms.TextBox()
        Me.ButtonClean = New System.Windows.Forms.Button()
        Me.TextBoxRESULT1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUPRINCIPALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRESULT2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(115, 233)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(109, 54)
        Me.ButtonCalcular.TabIndex = 0
        Me.ButtonCalcular.Text = "SUPER CALCULAR"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'txtBoXA
        '
        Me.txtBoXA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoXA.Location = New System.Drawing.Point(129, 56)
        Me.txtBoXA.Multiline = True
        Me.txtBoXA.Name = "txtBoXA"
        Me.txtBoXA.Size = New System.Drawing.Size(66, 54)
        Me.txtBoXA.TabIndex = 1
        '
        'ButtonClean
        '
        Me.ButtonClean.Location = New System.Drawing.Point(230, 233)
        Me.ButtonClean.Name = "ButtonClean"
        Me.ButtonClean.Size = New System.Drawing.Size(109, 54)
        Me.ButtonClean.TabIndex = 3
        Me.ButtonClean.Text = "LIMPIAR"
        Me.ButtonClean.UseVisualStyleBackColor = True
        '
        'TextBoxRESULT1
        '
        Me.TextBoxRESULT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRESULT1.Location = New System.Drawing.Point(115, 130)
        Me.TextBoxRESULT1.Multiline = True
        Me.TextBoxRESULT1.Name = "TextBoxRESULT1"
        Me.TextBoxRESULT1.Size = New System.Drawing.Size(224, 39)
        Me.TextBoxRESULT1.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUPRINCIPALToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(379, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUPRINCIPALToolStripMenuItem
        '
        Me.MENUPRINCIPALToolStripMenuItem.Name = "MENUPRINCIPALToolStripMenuItem"
        Me.MENUPRINCIPALToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.MENUPRINCIPALToolStripMenuItem.Text = "MENU PRINCIPAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "INGRESE VALORES"
        '
        'TextBoxC
        '
        Me.TextBoxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxC.Location = New System.Drawing.Point(273, 56)
        Me.TextBoxC.Multiline = True
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(66, 54)
        Me.TextBoxC.TabIndex = 7
        '
        'TextBoxB
        '
        Me.TextBoxB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxB.Location = New System.Drawing.Point(201, 56)
        Me.TextBoxB.Multiline = True
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(66, 54)
        Me.TextBoxB.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "C"
        '
        'TextBoxRESULT2
        '
        Me.TextBoxRESULT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRESULT2.Location = New System.Drawing.Point(115, 175)
        Me.TextBoxRESULT2.Multiline = True
        Me.TextBoxRESULT2.Name = "TextBoxRESULT2"
        Me.TextBoxRESULT2.Size = New System.Drawing.Size(224, 39)
        Me.TextBoxRESULT2.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "RESULTADO 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "RESULTADO 2"
        '
        'Ejercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 290)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxRESULT2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxB)
        Me.Controls.Add(Me.TextBoxC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxRESULT1)
        Me.Controls.Add(Me.ButtonClean)
        Me.Controls.Add(Me.txtBoXA)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ejercicio2"
        Me.Text = "Ejercicio2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents txtBoXA As TextBox
    Friend WithEvents ButtonClean As Button
    Friend WithEvents TextBoxRESULT1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUPRINCIPALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxRESULT2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
