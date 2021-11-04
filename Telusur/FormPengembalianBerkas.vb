Public Class FormPengembalianBerkas
    Private Sub PengembalianBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PengembalianBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PengembalianBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5DataSet)

    End Sub

    Private Sub FormPengembalianBerkas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5DataSet.pelayanan' table. You can move, or remove it, as needed.
        Me.PelayananTableAdapter.Fill(Me.Kel_5DataSet.pelayanan)
        'TODO: This line of code loads data into the 'Kel_5DataSet.petugas' table. You can move, or remove it, as needed.
        Me.PetugasTableAdapter.Fill(Me.Kel_5DataSet.petugas)
        'TODO: This line of code loads data into the 'Kel_5DataSet.pengembalian' table. You can move, or remove it, as needed.
        Me.PengembalianTableAdapter.Fill(Me.Kel_5DataSet.pengembalian)

    End Sub
End Class