Public Class FormMenuUtama
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        FilingToolStripMenuItem.Enabled = False
        AssemblingToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetugasToolStripMenuItem.Click
        FormPetugas.ShowDialog()
    End Sub

    Private Sub PelayananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelayananToolStripMenuItem.Click
        FormPelayanan.ShowDialog()
    End Sub

    Private Sub PengambilanBerkasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengambilanBerkasToolStripMenuItem.Click
        FormPengambilanBerkas.ShowDialog()
    End Sub

    Private Sub PengembalianBerkasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianBerkasToolStripMenuItem.Click
        FormPengembalianBerkas.ShowDialog()
    End Sub

    Private Sub BerkasMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BerkasMasukToolStripMenuItem.Click
        FormBerkasMasuk.ShowDialog()
    End Sub
End Class
