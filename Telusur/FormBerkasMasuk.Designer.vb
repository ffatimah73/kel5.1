<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBerkasMasuk
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
        Dim AsalBerkasLabel As System.Windows.Forms.Label
        Dim TglJamKembaliLabel As System.Windows.Forms.Label
        Dim TglJamPulangLabel As System.Windows.Forms.Label
        Dim LamaPengembalianLabel As System.Windows.Forms.Label
        Dim KelengkapanLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBerkasMasuk))
        Me.Kel_5DataSet = New Telusur.kel_5DataSet()
        Me.Berkas_masukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Berkas_masukTableAdapter = New Telusur.kel_5DataSetTableAdapters.berkas_masukTableAdapter()
        Me.TableAdapterManager = New Telusur.kel_5DataSetTableAdapters.TableAdapterManager()
        Me.PelayananTableAdapter = New Telusur.kel_5DataSetTableAdapters.pelayananTableAdapter()
        Me.PetugasTableAdapter = New Telusur.kel_5DataSetTableAdapters.petugasTableAdapter()
        Me.Berkas_masukBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Berkas_masukBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NoRMTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPasienTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPetugasComboBox = New System.Windows.Forms.ComboBox()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsalBerkasComboBox = New System.Windows.Forms.ComboBox()
        Me.PelayananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TglJamKembaliDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TglJamPulangDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LamaPengembalianTextBox = New System.Windows.Forms.TextBox()
        Me.KelengkapanComboBox = New System.Windows.Forms.ComboBox()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.Berkas_masukDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        NoRMLabel = New System.Windows.Forms.Label()
        NamaPasienLabel = New System.Windows.Forms.Label()
        NamaPetugasLabel = New System.Windows.Forms.Label()
        AsalBerkasLabel = New System.Windows.Forms.Label()
        TglJamKembaliLabel = New System.Windows.Forms.Label()
        TglJamPulangLabel = New System.Windows.Forms.Label()
        LamaPengembalianLabel = New System.Windows.Forms.Label()
        KelengkapanLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Berkas_masukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Berkas_masukBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Berkas_masukBindingNavigator.SuspendLayout()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Berkas_masukDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(14, 32)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'NoRMLabel
        '
        NoRMLabel.AutoSize = True
        NoRMLabel.Location = New System.Drawing.Point(14, 58)
        NoRMLabel.Name = "NoRMLabel"
        NoRMLabel.Size = New System.Drawing.Size(44, 13)
        NoRMLabel.TabIndex = 3
        NoRMLabel.Text = "No RM:"
        '
        'NamaPasienLabel
        '
        NamaPasienLabel.AutoSize = True
        NamaPasienLabel.Location = New System.Drawing.Point(14, 84)
        NamaPasienLabel.Name = "NamaPasienLabel"
        NamaPasienLabel.Size = New System.Drawing.Size(73, 13)
        NamaPasienLabel.TabIndex = 5
        NamaPasienLabel.Text = "Nama Pasien:"
        '
        'NamaPetugasLabel
        '
        NamaPetugasLabel.AutoSize = True
        NamaPetugasLabel.Location = New System.Drawing.Point(14, 110)
        NamaPetugasLabel.Name = "NamaPetugasLabel"
        NamaPetugasLabel.Size = New System.Drawing.Size(80, 13)
        NamaPetugasLabel.TabIndex = 7
        NamaPetugasLabel.Text = "Nama Petugas:"
        '
        'AsalBerkasLabel
        '
        AsalBerkasLabel.AutoSize = True
        AsalBerkasLabel.Location = New System.Drawing.Point(14, 137)
        AsalBerkasLabel.Name = "AsalBerkasLabel"
        AsalBerkasLabel.Size = New System.Drawing.Size(66, 13)
        AsalBerkasLabel.TabIndex = 9
        AsalBerkasLabel.Text = "Asal Berkas:"
        '
        'TglJamKembaliLabel
        '
        TglJamKembaliLabel.AutoSize = True
        TglJamKembaliLabel.Location = New System.Drawing.Point(14, 165)
        TglJamKembaliLabel.Name = "TglJamKembaliLabel"
        TglJamKembaliLabel.Size = New System.Drawing.Size(87, 13)
        TglJamKembaliLabel.TabIndex = 11
        TglJamKembaliLabel.Text = "Tgl Jam Kembali:"
        '
        'TglJamPulangLabel
        '
        TglJamPulangLabel.AutoSize = True
        TglJamPulangLabel.Location = New System.Drawing.Point(14, 191)
        TglJamPulangLabel.Name = "TglJamPulangLabel"
        TglJamPulangLabel.Size = New System.Drawing.Size(83, 13)
        TglJamPulangLabel.TabIndex = 13
        TglJamPulangLabel.Text = "Tgl Jam Pulang:"
        '
        'LamaPengembalianLabel
        '
        LamaPengembalianLabel.AutoSize = True
        LamaPengembalianLabel.Location = New System.Drawing.Point(14, 216)
        LamaPengembalianLabel.Name = "LamaPengembalianLabel"
        LamaPengembalianLabel.Size = New System.Drawing.Size(106, 13)
        LamaPengembalianLabel.TabIndex = 15
        LamaPengembalianLabel.Text = "Lama Pengembalian:"
        '
        'KelengkapanLabel
        '
        KelengkapanLabel.AutoSize = True
        KelengkapanLabel.Location = New System.Drawing.Point(14, 242)
        KelengkapanLabel.Name = "KelengkapanLabel"
        KelengkapanLabel.Size = New System.Drawing.Size(73, 13)
        KelengkapanLabel.TabIndex = 17
        KelengkapanLabel.Text = "Kelengkapan:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(14, 269)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(65, 13)
        KeteranganLabel.TabIndex = 19
        KeteranganLabel.Text = "Keterangan:"
        '
        'Kel_5DataSet
        '
        Me.Kel_5DataSet.DataSetName = "kel_5DataSet"
        Me.Kel_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Berkas_masukBindingSource
        '
        Me.Berkas_masukBindingSource.DataMember = "berkas_masuk"
        Me.Berkas_masukBindingSource.DataSource = Me.Kel_5DataSet
        '
        'Berkas_masukTableAdapter
        '
        Me.Berkas_masukTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.berkas_masukTableAdapter = Me.Berkas_masukTableAdapter
        Me.TableAdapterManager.pelayananTableAdapter = Me.PelayananTableAdapter
        Me.TableAdapterManager.pengambilanTableAdapter = Nothing
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
        'Berkas_masukBindingNavigator
        '
        Me.Berkas_masukBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Berkas_masukBindingNavigator.BindingSource = Me.Berkas_masukBindingSource
        Me.Berkas_masukBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Berkas_masukBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Berkas_masukBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Berkas_masukBindingNavigatorSaveItem})
        Me.Berkas_masukBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Berkas_masukBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Berkas_masukBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Berkas_masukBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Berkas_masukBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Berkas_masukBindingNavigator.Name = "Berkas_masukBindingNavigator"
        Me.Berkas_masukBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Berkas_masukBindingNavigator.Size = New System.Drawing.Size(997, 25)
        Me.Berkas_masukBindingNavigator.TabIndex = 0
        Me.Berkas_masukBindingNavigator.Text = "BindingNavigator1"
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
        'Berkas_masukBindingNavigatorSaveItem
        '
        Me.Berkas_masukBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Berkas_masukBindingNavigatorSaveItem.Image = CType(resources.GetObject("Berkas_masukBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Berkas_masukBindingNavigatorSaveItem.Name = "Berkas_masukBindingNavigatorSaveItem"
        Me.Berkas_masukBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Berkas_masukBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(126, 29)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'NoRMTextBox
        '
        Me.NoRMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "NoRM", True))
        Me.NoRMTextBox.Location = New System.Drawing.Point(126, 55)
        Me.NoRMTextBox.Name = "NoRMTextBox"
        Me.NoRMTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NoRMTextBox.TabIndex = 4
        '
        'NamaPasienTextBox
        '
        Me.NamaPasienTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "NamaPasien", True))
        Me.NamaPasienTextBox.Location = New System.Drawing.Point(126, 81)
        Me.NamaPasienTextBox.Name = "NamaPasienTextBox"
        Me.NamaPasienTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaPasienTextBox.TabIndex = 6
        '
        'NamaPetugasComboBox
        '
        Me.NamaPetugasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "NamaPetugas", True))
        Me.NamaPetugasComboBox.DataSource = Me.PetugasBindingSource
        Me.NamaPetugasComboBox.DisplayMember = "NamaPetugas"
        Me.NamaPetugasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NamaPetugasComboBox.FormattingEnabled = True
        Me.NamaPetugasComboBox.Location = New System.Drawing.Point(126, 107)
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
        'AsalBerkasComboBox
        '
        Me.AsalBerkasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "AsalBerkas", True))
        Me.AsalBerkasComboBox.DataSource = Me.PelayananBindingSource
        Me.AsalBerkasComboBox.DisplayMember = "NamaPelayanan"
        Me.AsalBerkasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AsalBerkasComboBox.FormattingEnabled = True
        Me.AsalBerkasComboBox.Location = New System.Drawing.Point(126, 134)
        Me.AsalBerkasComboBox.Name = "AsalBerkasComboBox"
        Me.AsalBerkasComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AsalBerkasComboBox.TabIndex = 10
        Me.AsalBerkasComboBox.ValueMember = "KodePelayanan"
        '
        'PelayananBindingSource
        '
        Me.PelayananBindingSource.DataMember = "pelayanan"
        Me.PelayananBindingSource.DataSource = Me.Kel_5DataSet
        '
        'TglJamKembaliDateTimePicker
        '
        Me.TglJamKembaliDateTimePicker.CustomFormat = "dd MMM yyyy hh:mm"
        Me.TglJamKembaliDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Berkas_masukBindingSource, "TglJamKembali", True))
        Me.TglJamKembaliDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglJamKembaliDateTimePicker.Location = New System.Drawing.Point(126, 161)
        Me.TglJamKembaliDateTimePicker.Name = "TglJamKembaliDateTimePicker"
        Me.TglJamKembaliDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TglJamKembaliDateTimePicker.TabIndex = 12
        '
        'TglJamPulangDateTimePicker
        '
        Me.TglJamPulangDateTimePicker.CustomFormat = "dd MMM yyyy hh:mm"
        Me.TglJamPulangDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Berkas_masukBindingSource, "TglJamPulang", True))
        Me.TglJamPulangDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglJamPulangDateTimePicker.Location = New System.Drawing.Point(126, 187)
        Me.TglJamPulangDateTimePicker.Name = "TglJamPulangDateTimePicker"
        Me.TglJamPulangDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TglJamPulangDateTimePicker.TabIndex = 14
        '
        'LamaPengembalianTextBox
        '
        Me.LamaPengembalianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "LamaPengembalian", True))
        Me.LamaPengembalianTextBox.Location = New System.Drawing.Point(126, 213)
        Me.LamaPengembalianTextBox.Name = "LamaPengembalianTextBox"
        Me.LamaPengembalianTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LamaPengembalianTextBox.TabIndex = 16
        '
        'KelengkapanComboBox
        '
        Me.KelengkapanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "Kelengkapan", True))
        Me.KelengkapanComboBox.FormattingEnabled = True
        Me.KelengkapanComboBox.Items.AddRange(New Object() {"Lengkap", "Tidak Lengkap"})
        Me.KelengkapanComboBox.Location = New System.Drawing.Point(126, 239)
        Me.KelengkapanComboBox.Name = "KelengkapanComboBox"
        Me.KelengkapanComboBox.Size = New System.Drawing.Size(200, 21)
        Me.KelengkapanComboBox.TabIndex = 18
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Berkas_masukBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(126, 266)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KeteranganTextBox.TabIndex = 20
        '
        'Berkas_masukDataGridView
        '
        Me.Berkas_masukDataGridView.AutoGenerateColumns = False
        Me.Berkas_masukDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Berkas_masukDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Berkas_masukDataGridView.DataSource = Me.Berkas_masukBindingSource
        Me.Berkas_masukDataGridView.Location = New System.Drawing.Point(17, 302)
        Me.Berkas_masukDataGridView.Name = "Berkas_masukDataGridView"
        Me.Berkas_masukDataGridView.Size = New System.Drawing.Size(943, 244)
        Me.Berkas_masukDataGridView.TabIndex = 21
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TglJamPulang"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TglJamPulang"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LamaPengembalian"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LamaPengembalian"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Kelengkapan"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Kelengkapan"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Keterangan"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Keterangan"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'FormBerkasMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 566)
        Me.Controls.Add(Me.Berkas_masukDataGridView)
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
        Me.Controls.Add(TglJamPulangLabel)
        Me.Controls.Add(Me.TglJamPulangDateTimePicker)
        Me.Controls.Add(LamaPengembalianLabel)
        Me.Controls.Add(Me.LamaPengembalianTextBox)
        Me.Controls.Add(KelengkapanLabel)
        Me.Controls.Add(Me.KelengkapanComboBox)
        Me.Controls.Add(KeteranganLabel)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Me.Berkas_masukBindingNavigator)
        Me.Name = "FormBerkasMasuk"
        Me.Text = "FormBerkasMasuk"
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Berkas_masukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Berkas_masukBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Berkas_masukBindingNavigator.ResumeLayout(False)
        Me.Berkas_masukBindingNavigator.PerformLayout()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Berkas_masukDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kel_5DataSet As kel_5DataSet
    Friend WithEvents Berkas_masukBindingSource As BindingSource
    Friend WithEvents Berkas_masukTableAdapter As kel_5DataSetTableAdapters.berkas_masukTableAdapter
    Friend WithEvents TableAdapterManager As kel_5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Berkas_masukBindingNavigator As BindingNavigator
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
    Friend WithEvents Berkas_masukBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NoRMTextBox As TextBox
    Friend WithEvents NamaPasienTextBox As TextBox
    Friend WithEvents NamaPetugasComboBox As ComboBox
    Friend WithEvents AsalBerkasComboBox As ComboBox
    Friend WithEvents TglJamKembaliDateTimePicker As DateTimePicker
    Friend WithEvents TglJamPulangDateTimePicker As DateTimePicker
    Friend WithEvents LamaPengembalianTextBox As TextBox
    Friend WithEvents KelengkapanComboBox As ComboBox
    Friend WithEvents KeteranganTextBox As TextBox
    Friend WithEvents PelayananTableAdapter As kel_5DataSetTableAdapters.pelayananTableAdapter
    Friend WithEvents Berkas_masukDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents PelayananBindingSource As BindingSource
    Friend WithEvents PetugasTableAdapter As kel_5DataSetTableAdapters.petugasTableAdapter
    Friend WithEvents PetugasBindingSource As BindingSource
End Class
