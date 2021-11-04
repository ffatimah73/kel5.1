<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPetugas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPetugas))
        Dim KodePetugasLabel As System.Windows.Forms.Label
        Dim NamaPetugasLabel As System.Windows.Forms.Label
        Dim JabatanLabel As System.Windows.Forms.Label
        Dim SatuanKerjaLabel As System.Windows.Forms.Label
        Me.Kel_5DataSet = New Telusur.kel_5DataSet()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PetugasTableAdapter = New Telusur.kel_5DataSetTableAdapters.petugasTableAdapter()
        Me.TableAdapterManager = New Telusur.kel_5DataSetTableAdapters.TableAdapterManager()
        Me.PetugasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PetugasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KodePetugasTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPetugasTextBox = New System.Windows.Forms.TextBox()
        Me.JabatanTextBox = New System.Windows.Forms.TextBox()
        Me.SatuanKerjaTextBox = New System.Windows.Forms.TextBox()
        Me.PetugasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        KodePetugasLabel = New System.Windows.Forms.Label()
        NamaPetugasLabel = New System.Windows.Forms.Label()
        JabatanLabel = New System.Windows.Forms.Label()
        SatuanKerjaLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PetugasBindingNavigator.SuspendLayout()
        CType(Me.PetugasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kel_5DataSet
        '
        Me.Kel_5DataSet.DataSetName = "kel_5DataSet"
        Me.Kel_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PetugasBindingSource
        '
        Me.PetugasBindingSource.DataMember = "petugas"
        Me.PetugasBindingSource.DataSource = Me.Kel_5DataSet
        '
        'PetugasTableAdapter
        '
        Me.PetugasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.berkas_masukTableAdapter = Nothing
        Me.TableAdapterManager.pelayananTableAdapter = Nothing
        Me.TableAdapterManager.pengambilanTableAdapter = Nothing
        Me.TableAdapterManager.pengembalianTableAdapter = Nothing
        Me.TableAdapterManager.penggunaTableAdapter = Nothing
        Me.TableAdapterManager.petugasTableAdapter = Me.PetugasTableAdapter
        Me.TableAdapterManager.UpdateOrder = Telusur.kel_5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PetugasBindingNavigator
        '
        Me.PetugasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PetugasBindingNavigator.BindingSource = Me.PetugasBindingSource
        Me.PetugasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PetugasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PetugasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PetugasBindingNavigatorSaveItem})
        Me.PetugasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PetugasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PetugasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PetugasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PetugasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PetugasBindingNavigator.Name = "PetugasBindingNavigator"
        Me.PetugasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PetugasBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PetugasBindingNavigator.TabIndex = 0
        Me.PetugasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PetugasBindingNavigatorSaveItem
        '
        Me.PetugasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PetugasBindingNavigatorSaveItem.Image = CType(resources.GetObject("PetugasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PetugasBindingNavigatorSaveItem.Name = "PetugasBindingNavigatorSaveItem"
        Me.PetugasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PetugasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KodePetugasLabel
        '
        KodePetugasLabel.AutoSize = True
        KodePetugasLabel.Location = New System.Drawing.Point(12, 44)
        KodePetugasLabel.Name = "KodePetugasLabel"
        KodePetugasLabel.Size = New System.Drawing.Size(77, 13)
        KodePetugasLabel.TabIndex = 1
        KodePetugasLabel.Text = "Kode Petugas:"
        '
        'KodePetugasTextBox
        '
        Me.KodePetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "KodePetugas", True))
        Me.KodePetugasTextBox.Location = New System.Drawing.Point(98, 41)
        Me.KodePetugasTextBox.Name = "KodePetugasTextBox"
        Me.KodePetugasTextBox.Size = New System.Drawing.Size(224, 20)
        Me.KodePetugasTextBox.TabIndex = 2
        '
        'NamaPetugasLabel
        '
        NamaPetugasLabel.AutoSize = True
        NamaPetugasLabel.Location = New System.Drawing.Point(12, 70)
        NamaPetugasLabel.Name = "NamaPetugasLabel"
        NamaPetugasLabel.Size = New System.Drawing.Size(80, 13)
        NamaPetugasLabel.TabIndex = 3
        NamaPetugasLabel.Text = "Nama Petugas:"
        '
        'NamaPetugasTextBox
        '
        Me.NamaPetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "NamaPetugas", True))
        Me.NamaPetugasTextBox.Location = New System.Drawing.Point(98, 67)
        Me.NamaPetugasTextBox.Name = "NamaPetugasTextBox"
        Me.NamaPetugasTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NamaPetugasTextBox.TabIndex = 4
        '
        'JabatanLabel
        '
        JabatanLabel.AutoSize = True
        JabatanLabel.Location = New System.Drawing.Point(12, 96)
        JabatanLabel.Name = "JabatanLabel"
        JabatanLabel.Size = New System.Drawing.Size(48, 13)
        JabatanLabel.TabIndex = 5
        JabatanLabel.Text = "Jabatan:"
        '
        'JabatanTextBox
        '
        Me.JabatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "Jabatan", True))
        Me.JabatanTextBox.Location = New System.Drawing.Point(98, 93)
        Me.JabatanTextBox.Name = "JabatanTextBox"
        Me.JabatanTextBox.Size = New System.Drawing.Size(224, 20)
        Me.JabatanTextBox.TabIndex = 6
        '
        'SatuanKerjaLabel
        '
        SatuanKerjaLabel.AutoSize = True
        SatuanKerjaLabel.Location = New System.Drawing.Point(12, 122)
        SatuanKerjaLabel.Name = "SatuanKerjaLabel"
        SatuanKerjaLabel.Size = New System.Drawing.Size(71, 13)
        SatuanKerjaLabel.TabIndex = 7
        SatuanKerjaLabel.Text = "Satuan Kerja:"
        '
        'SatuanKerjaTextBox
        '
        Me.SatuanKerjaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "SatuanKerja", True))
        Me.SatuanKerjaTextBox.Location = New System.Drawing.Point(98, 119)
        Me.SatuanKerjaTextBox.Name = "SatuanKerjaTextBox"
        Me.SatuanKerjaTextBox.Size = New System.Drawing.Size(224, 20)
        Me.SatuanKerjaTextBox.TabIndex = 8
        '
        'PetugasDataGridView
        '
        Me.PetugasDataGridView.AutoGenerateColumns = False
        Me.PetugasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PetugasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PetugasDataGridView.DataSource = Me.PetugasBindingSource
        Me.PetugasDataGridView.Location = New System.Drawing.Point(15, 165)
        Me.PetugasDataGridView.Name = "PetugasDataGridView"
        Me.PetugasDataGridView.Size = New System.Drawing.Size(444, 260)
        Me.PetugasDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "KodePetugas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "KodePetugas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaPetugas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NamaPetugas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Jabatan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jabatan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SatuanKerja"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SatuanKerja"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FormPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 453)
        Me.Controls.Add(Me.PetugasDataGridView)
        Me.Controls.Add(KodePetugasLabel)
        Me.Controls.Add(Me.KodePetugasTextBox)
        Me.Controls.Add(NamaPetugasLabel)
        Me.Controls.Add(Me.NamaPetugasTextBox)
        Me.Controls.Add(JabatanLabel)
        Me.Controls.Add(Me.JabatanTextBox)
        Me.Controls.Add(SatuanKerjaLabel)
        Me.Controls.Add(Me.SatuanKerjaTextBox)
        Me.Controls.Add(Me.PetugasBindingNavigator)
        Me.Name = "FormPetugas"
        Me.Text = "FormPetugas"
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PetugasBindingNavigator.ResumeLayout(False)
        Me.PetugasBindingNavigator.PerformLayout()
        CType(Me.PetugasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kel_5DataSet As kel_5DataSet
    Friend WithEvents PetugasBindingSource As BindingSource
    Friend WithEvents PetugasTableAdapter As kel_5DataSetTableAdapters.petugasTableAdapter
    Friend WithEvents TableAdapterManager As kel_5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PetugasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PetugasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents KodePetugasTextBox As TextBox
    Friend WithEvents NamaPetugasTextBox As TextBox
    Friend WithEvents JabatanTextBox As TextBox
    Friend WithEvents SatuanKerjaTextBox As TextBox
    Friend WithEvents PetugasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
