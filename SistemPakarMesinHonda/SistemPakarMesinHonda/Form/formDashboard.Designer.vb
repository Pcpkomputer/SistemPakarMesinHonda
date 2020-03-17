<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GejalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKerusakanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.FileToolStripMenuItem.Text = "Mulai Diagnosis"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GejalaToolStripMenuItem, Me.DataKerusakanToolStripMenuItem, Me.DataAturanToolStripMenuItem})
        Me.DataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'GejalaToolStripMenuItem
        '
        Me.GejalaToolStripMenuItem.Name = "GejalaToolStripMenuItem"
        Me.GejalaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GejalaToolStripMenuItem.Text = "Data Gejala"
        '
        'DataKerusakanToolStripMenuItem
        '
        Me.DataKerusakanToolStripMenuItem.Name = "DataKerusakanToolStripMenuItem"
        Me.DataKerusakanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataKerusakanToolStripMenuItem.Text = "Data Kerusakan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.LaporanToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DataAturanToolStripMenuItem
        '
        Me.DataAturanToolStripMenuItem.Name = "DataAturanToolStripMenuItem"
        Me.DataAturanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataAturanToolStripMenuItem.Text = "Data Aturan"
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemPakarMesinHonda.My.Resources.Resources.dashboardbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 714)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormDashboard"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GejalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKerusakanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataAturanToolStripMenuItem As ToolStripMenuItem
End Class
