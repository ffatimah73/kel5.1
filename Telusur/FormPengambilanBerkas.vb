Public Class FormPengambilanBerkas
    Private Sub PengambilanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PengambilanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PengambilanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5DataSet)

    End Sub

    Private Sub FormPengambilanBerkas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5DataSet.pelayanan' table. You can move, or remove it, as needed.
        Me.PelayananTableAdapter.Fill(Me.Kel_5DataSet.pelayanan)
        'TODO: This line of code loads data into the 'Kel_5DataSet.petugas' table. You can move, or remove it, as needed.
        Me.PetugasTableAdapter.Fill(Me.Kel_5DataSet.petugas)
        'TODO: This line of code loads data into the 'Kel_5DataSet.pengambilan' table. You can move, or remove it, as needed.
        Me.PengambilanTableAdapter.Fill(Me.Kel_5DataSet.pengambilan)

    End Sub

End Class