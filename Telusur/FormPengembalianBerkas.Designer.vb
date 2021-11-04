<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengembalianBerkas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengembalianBerkas))
        Dim IdLabel As System.Windows.Forms.Label
        Dim NoRMLabel As System.Windows.Forms.Label
        Dim NamaPasienLabel As System.Windows.Forms.Label
        Dim NamaPetugasLabel As System.Windows.Forms.Label
        Dim AsalBerkasLabel As System.Windows.Forms.Label
        Dim TglJamKembaliLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Me.Kel_5DataSet = New Telusur.kel_5DataSet()
        Me.PengembalianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PengembalianTableAdapter = New Telusur.kel_5DataSetTableAdapters.pengembalianTableAdapter()
        Me.TableAdapterManager = New Telusur.kel_5DataSetTableAdapters.TableAdapterManager()
        Me.PengembalianBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PengembalianBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NoRMTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPasienTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPetugasComboBox = New System.Windows.Forms.ComboBox()
        Me.AsalBerkasComboBox = New System.Windows.Forms.ComboBox()
        Me.TglJamKembaliDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.PengembalianDataGridView = New System.Windows.Forms.DataGridView()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PetugasTableAdapter = New Telusur.kel_5DataSetTableAdapters.petugasTableAdapter()
        Me.PelayananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelayananTableAdapter = New Telusur.kel_5DataSetTableAdapters.pelayananTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        NoRMLabel = New System.Windows.Forms.Label()
        NamaPasienLabel = New System.Windows.Forms.Label()
        NamaPetugasLabel = New System.Windows.Forms.Label()
        AsalBerkasLabel = New System.Windows.Forms.Label()
        TglJamKembaliLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengembalianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengembalianBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PengembalianBindingNavigator.SuspendLayout()
        CType(Me.PengembalianDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kel_5DataSet
        '
        Me.Kel_5DataSet.DataSetName = "kel_5DataSet"
        Me.Kel_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PengembalianBindingSource
        '
        Me.PengembalianBindingSource.DataMember = "pengembalian"
        Me.PengembalianBindingSource.DataSource = Me.Kel_5DataSet
        '
        'PengembalianTableAdapter
        '
        Me.PengembalianTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.berkas_masukTableAdapter = Nothing
        Me.TableAdapterManager.pelayananTableAdapter = Me.PelayananTableAdapter
        Me.TableAdapterManager.pengambilanTableAdapter = Nothing
        Me.TableAdapterManager.pengembalianTableAdapter = Me.PengembalianTableAdapter
        Me.TableAdapterManager.penggunaTableAdapter = Nothing
        Me.TableAdapterManager.petugasTableAdapter = Me.PetugasTableAdapter
        Me.TableAdapterManager.UpdateOrder = Telusur.kel_5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PengembalianBindingNavigator
        '
        Me.PengembalianBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PengembalianBindingNavigator.BindingSource = Me.PengembalianBindingSource
        Me.PengembalianBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PengembalianBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PengembalianBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PengembalianBindingNavigatorSaveItem})
        Me.PengembalianBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PengembalianBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PengembalianBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PengembalianBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PengembalianBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PengembalianBindingNavigator.Name = "PengembalianBindingNavigator"
        Me.PengembalianBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PengembalianBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PengembalianBindingNavigator.TabIndex = 0
        Me.PengembalianBindingNavigator.Text = "BindingNavigator1"
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
        'PengembalianBindingNavigatorSaveItem
        '
        Me.PengembalianBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PengembalianBindingNavigatorSaveItem.Image = CType(resources.GetObject("PengembalianBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PengembalianBindingNavigatorSaveItem.Name = "PengembalianBindingNavigatorSaveItem"
        Me.PengembalianBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PengembalianBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(17, 40)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengembalianBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(110, 37)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'NoRMLabel
        '
        NoRMLabel.AutoSize = True
        NoRMLabel.Location = New System.Drawing.Point(17, 66)
        NoRMLabel.Name = "NoRMLabel"
        NoRMLabel.Size = New System.Drawing.Size(44, 13)
        NoRMLabel.TabIndex = 3
        NoRMLabel.Text = "No RM:"
        '
        'NoRMTextBox
        '
        Me.NoRMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengembalianBindingSource, "NoRM", True))
        Me.NoRMTextBox.Location = New System.Drawing.Point(110, 63)
        Me.NoRMTextBox.Name = "NoRMTextBox"
        Me.NoRMTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NoRMTextBox.TabIndex = 4
        '
        'NamaPasienLabel
        '
        NamaPasienLabel.AutoSize = True
        NamaPasienLabel.Location = New System.Drawing.Point(17, 92)
        NamaPasienLabel.Name = "NamaPasienLabel"
        NamaPasienLabel.Size = New System.Drawing.Size(73, 13)
        NamaPasienLabel.TabIndex = 5
        NamaPasienLabel.Text = "Nama Pasien:"
        '
        'NamaPasienTextBox
        '
        Me.NamaPasienTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengembalianBindingSource, "NamaPasien", True))
        Me.NamaPasienTextBox.Location = New System.Drawing.Point(110, 89)
        Me.NamaPasienTextBox.Name = "NamaPasienTextBox"
        Me.NamaPasienTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaPasienTextBox.TabIndex = 6
        '
        'NamaPetugasLabel
        '
        NamaPetugasLabel.AutoSize = True
        NamaPetugasLabel.Location = New System.Drawing.Point(17, 118)
        NamaPetugasLabel.Name = "NamaPetugasLabel"
        NamaPetugasLabel.Size = New System.Drawing.Size(80, 13)
        NamaPetugasLabel.TabIndex = 7
        NamaPetugasLabel.Text = "Nama Petugas:"
        '
        'NamaPetugasComboBox
        '
        Me.NamaPetugasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengembalianBindingSource, "NamaPetugas", True))
        Me.NamaPetugasComboBox.DataSource = Me.PetugasBindingSource
        Me.NamaPetugasComboBox.DisplayMember = "NamaPetugas"
        Me.NamaPetugasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NamaPetugasComboBox.FormattingEnabled = True
        Me.NamaPetugasComboBox.Location = New System.Drawing.Point(110, 115)
        Me.NamaPetugasComboBox.Name = "NamaPetugasComboBox"
        Me.NamaPetugasComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NamaPetugasComboBox.TabIndex = 8
        Me.NamaPetugasComboBox.ValueMember = "KodePetugas"
        '
        'AsalBerkasLabel
        '
        AsalBerkasLabel.AutoSize = True
        AsalBerkasLabel.Location = New System.Drawing.Point(17, 145)
        AsalBerkasLabel.Name = "AsalBerkasLabel"
        AsalBerkasLabel.Size = New System.Drawing.Size(66, 13)
        AsalBerkasLabel.TabIndex = 9
        AsalBerkasLabel.Text = "Asal Berkas:"
        '
        'AsalBerkasComboBox
        '
        Me.AsalBerkasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengembalianBindingSource, "AsalBerkas", True))
        Me.AsalBerkasComboBox.DataSource = Me.PelayananBindingSource
        Me.AsalBerkasComboBox.DisplayMember = "NamaPelayanan"
        Me.AsalBerkasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AsalBerkasComboBox.FormattingEnabled = True
        Me.AsalBerkasComboBox.Location = New System.Drawing.Point(110, 142)
        Me.AsalBerkasComboBox.Name = "AsalBerkasComboBox"
        Me.AsalBerkasComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AsalBerkasComboBox.TabIndex = 10
        Me.AsalBerkasComboBox.ValueMember = "KodePelayanan"
        '
        'TglJamKembaliLabel
        '
        TglJamKembaliLabel.AutoSize = True
        TglJamKembaliLabel.Location = New System.Drawing.Point(17, 173)
        TglJamKembaliLabel.Name = "TglJamKembaliLabel"
        TglJamKembaliLabel.Size = New System.Drawing.Size(87, 13)
        TglJamKembaliLabel.TabIndex = 11
        TglJamKembaliLabel.Text = "Tgl Jam Kembali:"
        '
        'TglJamKembaliDateTimePicker
        '
        Me.TglJamKembaliDateTimePicker.CustomFormat = "dd MMM yyyy hh:mm"
        Me.TglJamKembaliDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PengembalianBindingSource, "TglJamKembali", True))
        Me.TglJamKembaliDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglJamKembaliDateTimePicker.Location = New System.Drawing.Point(110, 169)
        Me.TglJamKembaliDateTimePicker.Name = "TglJamKembaliDateTimePicker"
        Me.TglJamKembaliDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TglJamKembaliDateTimePicker.TabIndex = 12
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(17, 198)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(65, 13)
        KeteranganLabel.TabIndex = 13
        KeteranganLabel.Text = "Keterangan:"
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengembalianBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(110, 195)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KeteranganTextBox.TabIndex = 14
        '
        'PengembalianDataGridView
        '
        Me.PengembalianDataGridView.AutoGenerateColumns = False
        Me.PengembalianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PengembalianDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PengembalianDataGridView.DataSource = Me.PengembalianBindingSource
        Me.PengembalianDataGridView.Location = New System.Drawing.Point(20, 234)
        Me.PengembalianDataGridView.Name = "PengembalianDataGridView"
        Me.PengembalianDataGridView.Size = New System.Drawing.Size(642, 221)
        Me.PengembalianDataGridView.TabIndex = 15
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
        'PelayananBindingSource
        '
        Me.PelayananBindingSource.DataMember = "pelayanan"
        Me.PelayananBindingSource.DataSource = Me.Kel_5DataSet
        '
        'PelayananTableAdapter
        '
        Me.PelayananTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NoRM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NoRM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NamaPasien"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NamaPasien"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NamaPetugas"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NamaPetugas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AsalBerkas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "AsalBerkas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TglJamKembali"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TglJamKembali"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Keterangan"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Keterangan"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'FormPengembalianBerkas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.PengembalianDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NoRMLabel)
        Me.Controls.Add(Me.NoRMTextBox)
        Me.Controls.Add(NamaPasienLabel)
        Me.Controls.Add(Me.NamaPasienTextBox)
        Me.Controls.Add(NamaPetugasLabel)
        Me.Controls.Add(Me.NamaPetugasComboBox)
        Me.Controls.Add(AsalBerkasLabel)
        Me.Controls.Add(Me.AsalBerkasComboBox)
        Me.Controls.Add(TglJamKembaliLabel)
        Me.Controls.Add(Me.TglJamKembaliDateTimePicker)
        Me.Controls.Add(KeteranganLabel)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Me.PengembalianBindingNavigator)
        Me.Name = "FormPengembalianBerkas"
        Me.Text = "FormPengembalianBerkas"
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengembalianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengembalianBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PengembalianBindingNavigator.ResumeLayout(False)
        Me.PengembalianBindingNavigator.PerformLayout()
        CType(Me.PengembalianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kel_5DataSet As kel_5DataSet
    Friend WithEvents PengembalianBindingSource As BindingSource
    Friend WithEvents PengembalianTableAdapter As kel_5DataSetTableAdapters.pengembalianTableAdapter
    Friend WithEvents TableAdapterManager As kel_5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PengembalianBindingNavigator As BindingNavigator
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
    Friend WithEvents PengembalianBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NoRMTextBox As TextBox
    Friend WithEvents NamaPasienTextBox As TextBox
    Friend WithEvents NamaPetugasComboBox As ComboBox
    Friend WithEvents AsalBerkasComboBox As ComboBox
    Friend WithEvents TglJamKembaliDateTimePicker As DateTimePicker
    Friend WithEvents KeteranganTextBox As TextBox
    Friend WithEvents PetugasTableAdapter As kel_5DataSetTableAdapters.petugasTableAdapter
    Friend WithEvents PengembalianDataGridView As DataGridView
    Friend WithEvents PetugasBindingSource As BindingSource
    Friend WithEvents PelayananTableAdapter As kel_5DataSetTableAdapters.pelayananTableAdapter
    Friend WithEvents PelayananBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
