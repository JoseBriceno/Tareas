<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EJERCICIO1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULADORAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPERCALCULADORAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EJERCICIO1ToolStripMenuItem, Me.EJERCICIO2ToolStripMenuItem, Me.EJERCICIO3ToolStripMenuItem, Me.EJERCICIO4ToolStripMenuItem, Me.EJERCICIO5ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EJERCICIO1ToolStripMenuItem
        '
        Me.EJERCICIO1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULADORAToolStripMenuItem})
        Me.EJERCICIO1ToolStripMenuItem.Name = "EJERCICIO1ToolStripMenuItem"
        Me.EJERCICIO1ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO1ToolStripMenuItem.Text = "EJERCICIO 1"
        '
        'CALCULADORAToolStripMenuItem
        '
        Me.CALCULADORAToolStripMenuItem.Name = "CALCULADORAToolStripMenuItem"
        Me.CALCULADORAToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CALCULADORAToolStripMenuItem.Text = "CALCULADORA"
        '
        'EJERCICIO2ToolStripMenuItem
        '
        Me.EJERCICIO2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUPERCALCULADORAToolStripMenuItem})
        Me.EJERCICIO2ToolStripMenuItem.Name = "EJERCICIO2ToolStripMenuItem"
        Me.EJERCICIO2ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO2ToolStripMenuItem.Text = "EJERCICIO 2"
        '
        'SUPERCALCULADORAToolStripMenuItem
        '
        Me.SUPERCALCULADORAToolStripMenuItem.Name = "SUPERCALCULADORAToolStripMenuItem"
        Me.SUPERCALCULADORAToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SUPERCALCULADORAToolStripMenuItem.Text = "SUPER CALCULADORA"
        '
        'EJERCICIO3ToolStripMenuItem
        '
        Me.EJERCICIO3ToolStripMenuItem.Name = "EJERCICIO3ToolStripMenuItem"
        Me.EJERCICIO3ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO3ToolStripMenuItem.Text = "EJERCICIO 3"
        '
        'EJERCICIO4ToolStripMenuItem
        '
        Me.EJERCICIO4ToolStripMenuItem.Name = "EJERCICIO4ToolStripMenuItem"
        Me.EJERCICIO4ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO4ToolStripMenuItem.Text = "EJERCICIO 4"
        '
        'EJERCICIO5ToolStripMenuItem
        '
        Me.EJERCICIO5ToolStripMenuItem.Name = "EJERCICIO5ToolStripMenuItem"
        Me.EJERCICIO5ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO5ToolStripMenuItem.Text = "EJERCICIO 5"
        '
        'menuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 306)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuPrincipal"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EJERCICIO1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULADORAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPERCALCULADORAToolStripMenuItem As ToolStripMenuItem
End Class
