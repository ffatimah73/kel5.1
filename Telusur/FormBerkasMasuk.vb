Public Class FormBerkasMasuk
    Private Sub Berkas_masukBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Berkas_masukBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Berkas_masukBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5DataSet)

    End Sub

    Private Sub FormBerkasMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5DataSet.petugas' table. You can move, or remove it, as needed.
        Me.PetugasTableAdapter.Fill(Me.Kel_5DataSet.petugas)
        'TODO: This line of code loads data into the 'Kel_5DataSet.pelayanan' table. You can move, or remove it, as needed.
        Me.PelayananTableAdapter.Fill(Me.Kel_5DataSet.pelayanan)
        'TODO: This line of code loads data into the 'Kel_5DataSet.berkas_masuk' table. You can move, or remove it, as needed.
        Me.Berkas_masukTableAdapter.Fill(Me.Kel_5DataSet.berkas_masuk)

    End Sub

    Private Sub TglJamPulangDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles TglJamPulangDateTimePicker.ValueChanged
        LamaPengembalianTextBox.Text = DateDiff(DateInterval.Hour, TglJamPulangDateTimePicker.Value, TglJamKembaliDateTimePicker.Value()) & " Jam"
    End Sub
End Class