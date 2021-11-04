Public Class FormPetugas
    Private Sub PetugasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PetugasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PetugasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5DataSet)

    End Sub

    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5DataSet.petugas' table. You can move, or remove it, as needed.
        Me.PetugasTableAdapter.Fill(Me.Kel_5DataSet.petugas)

    End Sub
End Class