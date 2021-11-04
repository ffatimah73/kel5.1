<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelayanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelayanan))
        Dim KodePelayananLabel As System.Windows.Forms.Label
        Dim NamaPelayananLabel As System.Windows.Forms.Label
        Me.Kel_5DataSet = New Telusur.kel_5DataSet()
        Me.PelayananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelayananTableAdapter = New Telusur.kel_5DataSetTableAdapters.pelayananTableAdapter()
        Me.TableAdapterManager = New Telusur.kel_5DataSetTableAdapters.TableAdapterManager()
        Me.PelayananBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PelayananBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KodePelayananTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPelayananTextBox = New System.Windows.Forms.TextBox()
        Me.PelayananDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        KodePelayananLabel = New System.Windows.Forms.Label()
        NamaPelayananLabel = New System.Windows.Forms.Label()
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelayananBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PelayananBindingNavigator.SuspendLayout()
        CType(Me.PelayananDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kel_5DataSet
        '
        Me.Kel_5DataSet.DataSetName = "kel_5DataSet"
        Me.Kel_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.berkas_masukTableAdapter = Nothing
        Me.TableAdapterManager.pelayananTableAdapter = Me.PelayananTableAdapter
        Me.TableAdapterManager.pengambilanTableAdapter = Nothing
        Me.TableAdapterManager.pengembalianTableAdapter = Nothing
        Me.TableAdapterManager.penggunaTableAdapter = Nothing
        Me.TableAdapterManager.petugasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Telusur.kel_5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PelayananBindingNavigator
        '
        Me.PelayananBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PelayananBindingNavigator.BindingSource = Me.PelayananBindingSource
        Me.PelayananBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PelayananBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PelayananBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PelayananBindingNavigatorSaveItem})
        Me.PelayananBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PelayananBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PelayananBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PelayananBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PelayananBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PelayananBindingNavigator.Name = "PelayananBindingNavigator"
        Me.PelayananBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PelayananBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PelayananBindingNavigator.TabIndex = 0
        Me.PelayananBindingNavigator.Text = "BindingNavigator1"
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
        'PelayananBindingNavigatorSaveItem
        '
        Me.PelayananBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PelayananBindingNavigatorSaveItem.Image = CType(resources.GetObject("PelayananBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PelayananBindingNavigatorSaveItem.Name = "PelayananBindingNavigatorSaveItem"
        Me.PelayananBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PelayananBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KodePelayananLabel
        '
        KodePelayananLabel.AutoSize = True
        KodePelayananLabel.Location = New System.Drawing.Point(12, 45)
        KodePelayananLabel.Name = "KodePelayananLabel"
        KodePelayananLabel.Size = New System.Drawing.Size(88, 13)
        KodePelayananLabel.TabIndex = 1
        KodePelayananLabel.Text = "Kode Pelayanan:"
        '
        'KodePelayananTextBox
        '
        Me.KodePelayananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelayananBindingSource, "KodePelayanan", True))
        Me.KodePelayananTextBox.Location = New System.Drawing.Point(109, 42)
        Me.KodePelayananTextBox.Name = "KodePelayananTextBox"
        Me.KodePelayananTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodePelayananTextBox.TabIndex = 2
        '
        'NamaPelayananLabel
        '
        NamaPelayananLabel.AutoSize = True
        NamaPelayananLabel.Location = New System.Drawing.Point(12, 71)
        NamaPelayananLabel.Name = "NamaPelayananLabel"
        NamaPelayananLabel.Size = New System.Drawing.Size(91, 13)
        NamaPelayananLabel.TabIndex = 3
        NamaPelayananLabel.Text = "Nama Pelayanan:"
        '
        'NamaPelayananTextBox
        '
        Me.NamaPelayananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelayananBindingSource, "NamaPelayanan", True))
        Me.NamaPelayananTextBox.Location = New System.Drawing.Point(109, 68)
        Me.NamaPelayananTextBox.Name = "NamaPelayananTextBox"
        Me.NamaPelayananTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaPelayananTextBox.TabIndex = 4
        '
        'PelayananDataGridView
        '
        Me.PelayananDataGridView.AutoGenerateColumns = False
        Me.PelayananDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PelayananDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PelayananDataGridView.DataSource = Me.PelayananBindingSource
        Me.PelayananDataGridView.Location = New System.Drawing.Point(15, 132)
        Me.PelayananDataGridView.Name = "PelayananDataGridView"
        Me.PelayananDataGridView.Size = New System.Drawing.Size(245, 291)
        Me.PelayananDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "KodePelayanan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "KodePelayanan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaPelayanan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NamaPelayanan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FormPelayanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PelayananDataGridView)
        Me.Controls.Add(KodePelayananLabel)
        Me.Controls.Add(Me.KodePelayananTextBox)
        Me.Controls.Add(NamaPelayananLabel)
        Me.Controls.Add(Me.NamaPelayananTextBox)
        Me.Controls.Add(Me.PelayananBindingNavigator)
        Me.Name = "FormPelayanan"
        Me.Text = "FormPelayanan"
        CType(Me.Kel_5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelayananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelayananBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PelayananBindingNavigator.ResumeLayout(False)
        Me.PelayananBindingNavigator.PerformLayout()
        CType(Me.PelayananDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Kel_5DataSet As kel_5DataSet
    Friend WithEvents PelayananBindingSource As BindingSource
    Friend WithEvents PelayananTableAdapter As kel_5DataSetTableAdapters.pelayananTableAdapter
    Friend WithEvents TableAdapterManager As kel_5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PelayananBindingNavigator As BindingNavigator
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
    Friend WithEvents PelayananBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents KodePelayananTextBox As TextBox
    Friend WithEvents NamaPelayananTextBox As TextBox
    Friend WithEvents PelayananDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
