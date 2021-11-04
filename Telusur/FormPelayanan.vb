Public Class FormPelayanan
    Private Sub PelayananBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PelayananBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PelayananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5DataSet)

    End Sub

    Private Sub FormPelayanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5DataSet.pelayanan' table. You can move, or remove it, as needed.
        Me.PelayananTableAdapter.Fill(Me.Kel_5DataSet.pelayanan)

    End Sub
End Class