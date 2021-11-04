<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengambilanBerkas
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NoRMLabel As System.Windows.Forms.Label
        Dim NamaPasienLabel As System.Windows.Forms.Label
        Dim NamaPetugasLabel As System.Windows.Forms.Label
        Dim TujuanBerkasLabel As System.Windows.Forms.Label
        Dim TglJamAmbilLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengambilanBerkas))
        Me.Kel_5DataSet = New Telusur.kel_5DataSet()
        Me.PengambilanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PengambilanTableAdapter = New Telusur.kel_5DataSetTableAdapters.pengambilanTableAdapter()
        Me.TableAdapterManager = New Telusur.kel_5DataSetTableAdapters.TableAdapterManager()
        Me.PelayananTableAdapter = New Telusur.kel_5DataSetTableAdapters.pelayananTableAdapter()
        Me.PetugasTableAdapter = New Telusur.kel_5DataSetTableAdapters.petugasTableAdapter()
        Me.PengambilanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PengambilanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NoRMTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPasienTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPetugasComboBox = New System.Windows.Forms.ComboBox()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TujuanBerkasComboBox = New System.Windows.Forms.ComboBox()
        Me.PelayananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TglJamAmbilDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.PengambilanDataGridView = New System.Windows.Forms.DataGridView()
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
        TujuanBerkasLabel = New System.Windows.Forms.Label()
        TglJamAmbilLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengambilanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengambilanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PengambilanBindingNavigator.SuspendLayout()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengambilanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(13, 35)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'NoRMLabel
        '
        NoRMLabel.AutoSize = True
        NoRMLabel.Location = New System.Drawing.Point(13, 61)
        NoRMLabel.Name = "NoRMLabel"
        NoRMLabel.Size = New System.Drawing.Size(44, 13)
        NoRMLabel.TabIndex = 3
        NoRMLabel.Text = "No RM:"
        '
        'NamaPasienLabel
        '
        NamaPasienLabel.AutoSize = True
        NamaPasienLabel.Location = New System.Drawing.Point(13, 87)
        NamaPasienLabel.Name = "NamaPasienLabel"
        NamaPasienLabel.Size = New System.Drawing.Size(73, 13)
        NamaPasienLabel.TabIndex = 5
        NamaPasienLabel.Text = "Nama Pasien:"
        '
        'NamaPetugasLabel
        '
        NamaPetugasLabel.AutoSize = True
        NamaPetugasLabel.Location = New System.Drawing.Point(13, 113)
        NamaPetugasLabel.Name = "NamaPetugasLabel"
        NamaPetugasLabel.Size = New System.Drawing.Size(80, 13)
        NamaPetugasLabel.TabIndex = 7
        NamaPetugasLabel.Text = "Nama Petugas:"
        '
        'TujuanBerkasLabel
        '
        TujuanBerkasLabel.AutoSize = True
        TujuanBerkasLabel.Location = New System.Drawing.Point(13, 140)
        TujuanBerkasLabel.Name = "TujuanBerkasLabel"
        TujuanBerkasLabel.Size = New System.Drawing.Size(79, 13)
        TujuanBerkasLabel.TabIndex = 9
        TujuanBerkasLabel.Text = "Tujuan Berkas:"
        '
        'TglJamAmbilLabel
        '
        TglJamAmbilLabel.AutoSize = True
        TglJamAmbilLabel.Location = New System.Drawing.Point(13, 168)
        TglJamAmbilLabel.Name = "TglJamAmbilLabel"
        TglJamAmbilLabel.Size = New System.Drawing.Size(75, 13)
        TglJamAmbilLabel.TabIndex = 11
        TglJamAmbilLabel.Text = "Tgl Jam Ambil:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(13, 193)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(65, 13)
        KeteranganLabel.TabIndex = 13
        KeteranganLabel.Text = "Keterangan:"
        '
        'Kel_5DataSet
        '
        Me.Kel_5DataSet.DataSetName = "kel_5DataSet"
        Me.Kel_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PengambilanBindingSource
        '
        Me.PengambilanBindingSource.DataMember = "pengambilan"
        Me.PengambilanBindingSource.DataSource = Me.Kel_5DataSet
        '
        'PengambilanTableAdapter
        '
        Me.PengambilanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.berkas_masukTableAdapter = Nothing
        Me.TableAdapterManager.pelayananTableAdapter = Me.PelayananTableAdapter
        Me.TableAdapterManager.pengambilanTableAdapter = Me.PengambilanTableAdapter
        Me.TableAdapterManager.pengembalianTableAdapter = Nothing
        Me.TableAdapterManager.penggunaTableAdapter = Nothing
        Me.TableAdapterManager.petugasTableAdapter = Me.PetugasTableAdapter
        Me.TableAdapterManager.UpdateOrder = Telusur.kel_5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PelayananTableAdapter
        '
        Me.PelayananTableAdapter.ClearBeforeFill = True
        '
        'PetugasTableAdapter
        '
        Me.PetugasTableAdapter.ClearBeforeFill = True
        '
        'PengambilanBindingNavigator
        '
        Me.PengambilanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PengambilanBindingNavigator.BindingSource = Me.PengambilanBindingSource
        Me.PengambilanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PengambilanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PengambilanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PengambilanBindingNavigatorSaveItem})
        Me.PengambilanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PengambilanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PengambilanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PengambilanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PengambilanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PengambilanBindingNavigator.Name = "PengambilanBindingNavigator"
        Me.PengambilanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PengambilanBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PengambilanBindingNavigator.TabIndex = 0
        Me.PengambilanBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PengambilanBindingNavigatorSaveItem
        '
        Me.PengambilanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PengambilanBindingNavigatorSaveItem.Image = CType(resources.GetObject("PengambilanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PengambilanBindingNavigatorSaveItem.Name = "PengambilanBindingNavigatorSaveItem"
        Me.PengambilanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PengambilanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengambilanBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(99, 32)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'NoRMTextBox
        '
        Me.NoRMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengambilanBindingSource, "NoRM", True))
        Me.NoRMTextBox.Location = New System.Drawing.Point(99, 58)
        Me.NoRMTextBox.Name = "NoRMTextBox"
        Me.NoRMTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NoRMTextBox.TabIndex = 4
        '
        'NamaPasienTextBox
        '
        Me.NamaPasienTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengambilanBindingSource, "NamaPasien", True))
        Me.NamaPasienTextBox.Location = New System.Drawing.Point(99, 84)
        Me.NamaPasienTextBox.Name = "NamaPasienTextBox"
        Me.NamaPasienTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaPasienTextBox.TabIndex = 6
        '
        'NamaPetugasComboBox
        '
        Me.NamaPetugasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengambilanBindingSource, "NamaPetugas", True))
        Me.NamaPetugasComboBox.DataSource = Me.PetugasBindingSource
        Me.NamaPetugasComboBox.DisplayMember = "NamaPetugas"
        Me.NamaPetugasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NamaPetugasComboBox.FormattingEnabled = True
        Me.NamaPetugasComboBox.Location = New System.Drawing.Point(99, 110)
        Me.NamaPetugasComboBox.Name = "NamaPetugasComboBox"
        Me.NamaPetugasComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NamaPetugasComboBox.TabIndex = 8
        Me.NamaPetugasComboBox.ValueMember = "KodePetugas"
        '
        'PetugasBindingSource
        '
        Me.PetugasBindingSource.DataMember = "petugas"
        Me.PetugasBindingSource.DataSource = Me.Kel_5DataSet
        '
        'TujuanBerkasComboBox
        '
        Me.TujuanBerkasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengambilanBindingSource, "TujuanBerkas", True))
        Me.TujuanBerkasComboBox.DataSource = Me.PelayananBindingSource
        Me.TujuanBerkasComboBox.DisplayMember = "NamaPelayanan"
        Me.TujuanBerkasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TujuanBerkasComboBox.FormattingEnabled = True
        Me.TujuanBerkasComboBox.Location = New System.Drawing.Point(99, 137)
        Me.TujuanBerkasComboBox.Name = "TujuanBerkasComboBox"
        Me.TujuanBerkasComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TujuanBerkasComboBox.TabIndex = 10
        Me.TujuanBerkasComboBox.ValueMember = "KodePelayanan"
        '
        'PelayananBindingSource
        '
        Me.PelayananBindingSource.DataMember = "pelayanan"
        Me.PelayananBindingSource.DataSource = Me.Kel_5DataSet
        '
        'TglJamAmbilDateTimePicker
        '
        Me.TglJamAmbilDateTimePicker.CustomFormat = "dd MMM yyyy hh:mm"
        Me.TglJamAmbilDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PengambilanBindingSource, "TglJamAmbil", True))
        Me.TglJamAmbilDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglJamAmbilDateTimePicker.Location = New System.Drawing.Point(99, 164)
        Me.TglJamAmbilDateTimePicker.Name = "TglJamAmbilDateTimePicker"
        Me.TglJamAmbilDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TglJamAmbilDateTimePicker.TabIndex = 12
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengambilanBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(99, 190)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KeteranganTextBox.TabIndex = 14
        '
        'PengambilanDataGridView
        '
        Me.PengambilanDataGridView.AutoGenerateColumns = False
        Me.PengambilanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PengambilanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PengambilanDataGridView.DataSource = Me.PengambilanBindingSource
        Me.PengambilanDataGridView.Location = New System.Drawing.Point(16, 229)
        Me.PengambilanDataGridView.Name = "PengambilanDataGridView"
        Me.PengambilanDataGridView.Size = New System.Drawing.Size(638, 228)
        Me.PengambilanDataGridView.TabIndex = 15
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TujuanBerkas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TujuanBerkas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TglJamAmbil"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TglJamAmbil"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Keterangan"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Keterangan"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'FormPengambilanBerkas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.PengambilanDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NoRMLabel)
        Me.Controls.Add(Me.NoRMTextBox)
        Me.Controls.Add(NamaPasienLabel)
        Me.Controls.Add(Me.NamaPasienTextBox)
        Me.Controls.Add(NamaPetugasLabel)
        Me.Controls.Add(Me.NamaPetugasComboBox)
        Me.Controls.Add(TujuanBerkasLabel)
        Me.Controls.Add(Me.TujuanBerkasComboBox)
        Me.Controls.Add(TglJamAmbilLabel)
        Me.Controls.Add(Me.TglJamAmbilDateTimePicker)
        Me.Controls.Add(KeteranganLabel)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Me.PengambilanBindingNavigator)
        Me.Name = "FormPengambilanBerkas"
        Me.Text = "FormPengambilanBerkas"
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengambilanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengambilanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PengambilanBindingNavigator.ResumeLayout(False)
        Me.PengambilanBindingNavigator.PerformLayout()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengambilanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kel_5DataSet As kel_5DataSet
    Friend WithEvents PengambilanBindingSource As BindingSource
    Friend WithEvents PengambilanTableAdapter As kel_5DataSetTableAdapters.pengambilanTableAdapter
    Friend WithEvents TableAdapterManager As kel_5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PengambilanBindingNavigator As BindingNavigator
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
    Friend WithEvents PengambilanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NoRMTextBox As TextBox
    Friend WithEvents NamaPasienTextBox As TextBox
    Friend WithEvents NamaPetugasComboBox As ComboBox
    Friend WithEvents TujuanBerkasComboBox As ComboBox
    Friend WithEvents TglJamAmbilDateTimePicker As DateTimePicker
    Friend WithEvents KeteranganTextBox As TextBox
    Friend WithEvents PetugasTableAdapter As kel_5DataSetTableAdapters.petugasTableAdapter
    Friend WithEvents PetugasBindingSource As BindingSource
    Friend WithEvents PelayananTableAdapter As kel_5DataSetTableAdapters.pelayananTableAdapter
    Friend WithEvents PelayananBindingSource As BindingSource
    Friend WithEvents PengambilanDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
