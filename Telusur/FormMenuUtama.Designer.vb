<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelayananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengambilanBerkasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianBerkasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssemblingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BerkasMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.FilingToolStripMenuItem, Me.AssemblingToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PetugasToolStripMenuItem, Me.PelayananToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.PetugasToolStripMenuItem.Text = "Petugas"
        '
        'PelayananToolStripMenuItem
        '
        Me.PelayananToolStripMenuItem.Name = "PelayananToolStripMenuItem"
        Me.PelayananToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.PelayananToolStripMenuItem.Text = "Pelayanan"
        '
        'FilingToolStripMenuItem
        '
        Me.FilingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengambilanBerkasToolStripMenuItem, Me.PengembalianBerkasToolStripMenuItem})
        Me.FilingToolStripMenuItem.Name = "FilingToolStripMenuItem"
        Me.FilingToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.FilingToolStripMenuItem.Text = "Filing"
        '
        'PengambilanBerkasToolStripMenuItem
        '
        Me.PengambilanBerkasToolStripMenuItem.Name = "PengambilanBerkasToolStripMenuItem"
        Me.PengambilanBerkasToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PengambilanBerkasToolStripMenuItem.Text = "Pengambilan Berkas"
        '
        'PengembalianBerkasToolStripMenuItem
        '
        Me.PengembalianBerkasToolStripMenuItem.Name = "PengembalianBerkasToolStripMenuItem"
        Me.PengembalianBerkasToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PengembalianBerkasToolStripMenuItem.Text = "Pengembalian Berkas"
        '
        'AssemblingToolStripMenuItem
        '
        Me.AssemblingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BerkasMasukToolStripMenuItem})
        Me.AssemblingToolStripMenuItem.Name = "AssemblingToolStripMenuItem"
        Me.AssemblingToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AssemblingToolStripMenuItem.Text = "Assembling"
        '
        'BerkasMasukToolStripMenuItem
        '
        Me.BerkasMasukToolStripMenuItem.Name = "BerkasMasukToolStripMenuItem"
        Me.BerkasMasukToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BerkasMasukToolStripMenuItem.Text = "Berkas Masuk"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.Text = "Form Menu Utama Sistem Informasi Pengambilan dan Pengembalian BRM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelayananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengambilanBerkasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianBerkasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssemblingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BerkasMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
End Class
