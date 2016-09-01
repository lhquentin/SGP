<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgListeHabilete
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gbListeHabilete = New System.Windows.Forms.GroupBox()
        Me.dgvHabilete = New System.Windows.Forms.DataGridView()
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTSectionHabileteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.gbListeSousHabilete = New System.Windows.Forms.GroupBox()
        Me.dgvSousHabilete = New System.Windows.Forms.DataGridView()
        Me.IdHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTHabileteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_HabileteTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_HabileteTableAdapter()
        Me.P_SELECT_SectionHabileteTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_SectionHabileteTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbListeHabilete.SuspendLayout()
        CType(Me.dgvHabilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTSectionHabileteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListeSousHabilete.SuspendLayout()
        CType(Me.dgvSousHabilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTHabileteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.36842!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.63158!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAjouter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(328, 364)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(190, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAjouter.Location = New System.Drawing.Point(3, 3)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(102, 23)
        Me.btnAjouter.TabIndex = 0
        Me.btnAjouter.Text = "Ajouter habileté(s)"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(115, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'gbListeHabilete
        '
        Me.gbListeHabilete.Controls.Add(Me.dgvHabilete)
        Me.gbListeHabilete.Location = New System.Drawing.Point(3, 2)
        Me.gbListeHabilete.Name = "gbListeHabilete"
        Me.gbListeHabilete.Size = New System.Drawing.Size(515, 176)
        Me.gbListeHabilete.TabIndex = 1
        Me.gbListeHabilete.TabStop = False
        Me.gbListeHabilete.Text = "Liste des habiletés"
        '
        'dgvHabilete
        '
        Me.dgvHabilete.AllowUserToAddRows = False
        Me.dgvHabilete.AllowUserToDeleteRows = False
        Me.dgvHabilete.AllowUserToResizeColumns = False
        Me.dgvHabilete.AllowUserToResizeRows = False
        Me.dgvHabilete.AutoGenerateColumns = False
        Me.dgvHabilete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHabilete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1, Me.VersionDataGridViewTextBoxColumn, Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn, Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn})
        Me.dgvHabilete.DataSource = Me.PSELECTSectionHabileteBindingSource
        Me.dgvHabilete.Location = New System.Drawing.Point(6, 19)
        Me.dgvHabilete.MultiSelect = False
        Me.dgvHabilete.Name = "dgvHabilete"
        Me.dgvHabilete.ReadOnly = True
        Me.dgvHabilete.RowHeadersVisible = False
        Me.dgvHabilete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHabilete.Size = New System.Drawing.Size(503, 151)
        Me.dgvHabilete.TabIndex = 0
        '
        'IdSECTIONHABILETEDataGridViewTextBoxColumn1
        '
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1.DataPropertyName = "idSECTION_HABILETE"
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1.HeaderText = "idSECTION_HABILETE"
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1.Name = "IdSECTIONHABILETEDataGridViewTextBoxColumn1"
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1.Visible = False
        '
        'VersionDataGridViewTextBoxColumn
        '
        Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "version"
        Me.VersionDataGridViewTextBoxColumn.HeaderText = "version"
        Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
        Me.VersionDataGridViewTextBoxColumn.ReadOnly = True
        Me.VersionDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroSECTIONHABILETEDataGridViewTextBoxColumn
        '
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn.DataPropertyName = "numeroSECTION_HABILETE"
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn.Name = "NumeroSECTIONHABILETEDataGridViewTextBoxColumn"
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn.Width = 69
        '
        'TitreSECTIONHABILETEDataGridViewTextBoxColumn
        '
        Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn.DataPropertyName = "titreSECTION_HABILETE"
        Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn.HeaderText = "Titre"
        Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn.Name = "TitreSECTIONHABILETEDataGridViewTextBoxColumn"
        Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTSectionHabileteBindingSource
        '
        Me.PSELECTSectionHabileteBindingSource.DataMember = "P_SELECT_SectionHabilete"
        Me.PSELECTSectionHabileteBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbListeSousHabilete
        '
        Me.gbListeSousHabilete.Controls.Add(Me.dgvSousHabilete)
        Me.gbListeSousHabilete.Location = New System.Drawing.Point(3, 184)
        Me.gbListeSousHabilete.Name = "gbListeSousHabilete"
        Me.gbListeSousHabilete.Size = New System.Drawing.Size(515, 176)
        Me.gbListeSousHabilete.TabIndex = 2
        Me.gbListeSousHabilete.TabStop = False
        Me.gbListeSousHabilete.Text = "Liste des sous-habiletés"
        '
        'dgvSousHabilete
        '
        Me.dgvSousHabilete.AllowUserToAddRows = False
        Me.dgvSousHabilete.AllowUserToDeleteRows = False
        Me.dgvSousHabilete.AllowUserToResizeColumns = False
        Me.dgvSousHabilete.AllowUserToResizeRows = False
        Me.dgvSousHabilete.AutoGenerateColumns = False
        Me.dgvSousHabilete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSousHabilete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHABILETEDataGridViewTextBoxColumn, Me.IdSECTIONHABILETEDataGridViewTextBoxColumn, Me.NumeroHABILETEDataGridViewTextBoxColumn, Me.LibelleHABILETEDataGridViewTextBoxColumn})
        Me.dgvSousHabilete.DataSource = Me.PSELECTHabileteBindingSource
        Me.dgvSousHabilete.Location = New System.Drawing.Point(6, 19)
        Me.dgvSousHabilete.Name = "dgvSousHabilete"
        Me.dgvSousHabilete.ReadOnly = True
        Me.dgvSousHabilete.RowHeadersVisible = False
        Me.dgvSousHabilete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSousHabilete.Size = New System.Drawing.Size(503, 151)
        Me.dgvSousHabilete.TabIndex = 0
        '
        'IdHABILETEDataGridViewTextBoxColumn
        '
        Me.IdHABILETEDataGridViewTextBoxColumn.DataPropertyName = "idHABILETE"
        Me.IdHABILETEDataGridViewTextBoxColumn.HeaderText = "idHABILETE"
        Me.IdHABILETEDataGridViewTextBoxColumn.Name = "IdHABILETEDataGridViewTextBoxColumn"
        Me.IdHABILETEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdHABILETEDataGridViewTextBoxColumn.Visible = False
        '
        'IdSECTIONHABILETEDataGridViewTextBoxColumn
        '
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn.DataPropertyName = "idSECTION_HABILETE"
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn.HeaderText = "idSECTION_HABILETE"
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn.Name = "IdSECTIONHABILETEDataGridViewTextBoxColumn"
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroHABILETEDataGridViewTextBoxColumn
        '
        Me.NumeroHABILETEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroHABILETEDataGridViewTextBoxColumn.DataPropertyName = "numeroHABILETE"
        Me.NumeroHABILETEDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumeroHABILETEDataGridViewTextBoxColumn.Name = "NumeroHABILETEDataGridViewTextBoxColumn"
        Me.NumeroHABILETEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroHABILETEDataGridViewTextBoxColumn.Width = 69
        '
        'LibelleHABILETEDataGridViewTextBoxColumn
        '
        Me.LibelleHABILETEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleHABILETEDataGridViewTextBoxColumn.DataPropertyName = "libelleHABILETE"
        Me.LibelleHABILETEDataGridViewTextBoxColumn.HeaderText = "Libellé"
        Me.LibelleHABILETEDataGridViewTextBoxColumn.Name = "LibelleHABILETEDataGridViewTextBoxColumn"
        Me.LibelleHABILETEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTHabileteBindingSource
        '
        Me.PSELECTHabileteBindingSource.DataMember = "P_SELECT_Habilete"
        Me.PSELECTHabileteBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_HabileteTableAdapter
        '
        Me.P_SELECT_HabileteTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_SectionHabileteTableAdapter
        '
        Me.P_SELECT_SectionHabileteTableAdapter.ClearBeforeFill = True
        '
        'dlgListeHabilete
        '
        Me.AcceptButton = Me.btnAjouter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(521, 396)
        Me.Controls.Add(Me.gbListeSousHabilete)
        Me.Controls.Add(Me.gbListeHabilete)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgListeHabilete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sélection d'habileté"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbListeHabilete.ResumeLayout(False)
        CType(Me.dgvHabilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTSectionHabileteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListeSousHabilete.ResumeLayout(False)
        CType(Me.dgvSousHabilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTHabileteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbListeHabilete As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHabilete As System.Windows.Forms.DataGridView
    Friend WithEvents gbListeSousHabilete As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSousHabilete As System.Windows.Forms.DataGridView
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents P_SELECT_HabileteTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_HabileteTableAdapter
    Friend WithEvents PSELECTHabileteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSECTIONHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTSectionHabileteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_SectionHabileteTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_SectionHabileteTableAdapter
    Friend WithEvents IdSECTIONHABILETEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroSECTIONHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreSECTIONHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
