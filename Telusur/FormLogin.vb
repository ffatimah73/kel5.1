Public Class FormLogin

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If PenggunaTableAdapter1.CekLogin(UsernameTextBox.Text, PasswordTextBox.Text) = 1 Then
            Me.Hide()
            Call BukaKunci()
        Else
            MsgBox("Username dan Password Salah")
        End If
    End Sub
    Sub BukaKunci()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.FilingToolStripMenuItem.Enabled = True
        FormMenuUtama.AssemblingToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub
End Class
