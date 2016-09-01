<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionHabilete
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
        Me.gbSectionHabilete = New System.Windows.Forms.GroupBox()
        Me.btnDescendreSectionHabilete = New System.Windows.Forms.Button()
        Me.btnMonterSectionHabilete = New System.Windows.Forms.Button()
        Me.btnAnnulerSectionHabilete = New System.Windows.Forms.Button()
        Me.btnEnregistrerSectionHabilete = New System.Windows.Forms.Button()
        Me.txtTitreSectionHabilete = New System.Windows.Forms.TextBox()
        Me.lbTitreSectionHabilete = New System.Windows.Forms.Label()
        Me.btnSupprimerSectionHabilete = New System.Windows.Forms.Button()
        Me.btnModifierSectionHabilete = New System.Windows.Forms.Button()
        Me.dgvSectionHabilete = New System.Windows.Forms.DataGridView()
        Me.btnAjouterSectionHabilete = New System.Windows.Forms.Button()
        Me.gbHabilete = New System.Windows.Forms.GroupBox()
        Me.btnDescendreHabilete = New System.Windows.Forms.Button()
        Me.btnMonterHabilete = New System.Windows.Forms.Button()
        Me.btnAnnulerHabilete = New System.Windows.Forms.Button()
        Me.btnEnregistrerHabilete = New System.Windows.Forms.Button()
        Me.txtLibelleHabilete = New System.Windows.Forms.TextBox()
        Me.lbLibelleHabilete = New System.Windows.Forms.Label()
        Me.btnSupprimerHabilete = New System.Windows.Forms.Button()
        Me.btnModifierHabilete = New System.Windows.Forms.Button()
        Me.dgvHabilete = New System.Windows.Forms.DataGridView()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.IdHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTHabileteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.P_SELECT_HabileteTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_HabileteTableAdapter()
        Me.PSELECTSectionHabileteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_SectionHabileteTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_SectionHabileteTableAdapter()
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbSectionHabilete.SuspendLayout()
        CType(Me.dgvSectionHabilete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHabilete.SuspendLayout()
        CType(Me.dgvHabilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTHabileteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTSectionHabileteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSectionHabilete
        '
        Me.gbSectionHabilete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSectionHabilete.Controls.Add(Me.btnDescendreSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.btnMonterSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.btnAnnulerSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.btnEnregistrerSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.txtTitreSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.lbTitreSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.btnSupprimerSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.btnModifierSectionHabilete)
        Me.gbSectionHabilete.Controls.Add(Me.dgvSectionHabilete)
        Me.gbSectionHabilete.Location = New System.Drawing.Point(3, 41)
        Me.gbSectionHabilete.Name = "gbSectionHabilete"
        Me.gbSectionHabilete.Size = New System.Drawing.Size(580, 272)
        Me.gbSectionHabilete.TabIndex = 1
        Me.gbSectionHabilete.TabStop = False
        Me.gbSectionHabilete.Text = "Habileté"
        '
        'btnDescendreSectionHabilete
        '
        Me.btnDescendreSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDescendreSectionHabilete.Location = New System.Drawing.Point(499, 106)
        Me.btnDescendreSectionHabilete.Name = "btnDescendreSectionHabilete"
        Me.btnDescendreSectionHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnDescendreSectionHabilete.TabIndex = 11
        Me.btnDescendreSectionHabilete.Text = "Descendre"
        Me.btnDescendreSectionHabilete.UseVisualStyleBackColor = True
        '
        'btnMonterSectionHabilete
        '
        Me.btnMonterSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMonterSectionHabilete.Location = New System.Drawing.Point(499, 77)
        Me.btnMonterSectionHabilete.Name = "btnMonterSectionHabilete"
        Me.btnMonterSectionHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnMonterSectionHabilete.TabIndex = 10
        Me.btnMonterSectionHabilete.Text = "Monter"
        Me.btnMonterSectionHabilete.UseVisualStyleBackColor = True
        '
        'btnAnnulerSectionHabilete
        '
        Me.btnAnnulerSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulerSectionHabilete.Location = New System.Drawing.Point(499, 244)
        Me.btnAnnulerSectionHabilete.Name = "btnAnnulerSectionHabilete"
        Me.btnAnnulerSectionHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerSectionHabilete.TabIndex = 8
        Me.btnAnnulerSectionHabilete.Text = "Annuler"
        Me.btnAnnulerSectionHabilete.UseVisualStyleBackColor = True
        '
        'btnEnregistrerSectionHabilete
        '
        Me.btnEnregistrerSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnregistrerSectionHabilete.Location = New System.Drawing.Point(499, 218)
        Me.btnEnregistrerSectionHabilete.Name = "btnEnregistrerSectionHabilete"
        Me.btnEnregistrerSectionHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerSectionHabilete.TabIndex = 7
        Me.btnEnregistrerSectionHabilete.Text = "Enregistrer"
        Me.btnEnregistrerSectionHabilete.UseVisualStyleBackColor = True
        '
        'txtTitreSectionHabilete
        '
        Me.txtTitreSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTitreSectionHabilete.Location = New System.Drawing.Point(43, 220)
        Me.txtTitreSectionHabilete.Name = "txtTitreSectionHabilete"
        Me.txtTitreSectionHabilete.Size = New System.Drawing.Size(450, 20)
        Me.txtTitreSectionHabilete.TabIndex = 6
        '
        'lbTitreSectionHabilete
        '
        Me.lbTitreSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbTitreSectionHabilete.AutoSize = True
        Me.lbTitreSectionHabilete.Location = New System.Drawing.Point(6, 223)
        Me.lbTitreSectionHabilete.Name = "lbTitreSectionHabilete"
        Me.lbTitreSectionHabilete.Size = New System.Drawing.Size(31, 13)
        Me.lbTitreSectionHabilete.TabIndex = 5
        Me.lbTitreSectionHabilete.Text = "Titre:"
        '
        'btnSupprimerSectionHabilete
        '
        Me.btnSupprimerSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSupprimerSectionHabilete.Location = New System.Drawing.Point(499, 48)
        Me.btnSupprimerSectionHabilete.Name = "btnSupprimerSectionHabilete"
        Me.btnSupprimerSectionHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerSectionHabilete.TabIndex = 2
        Me.btnSupprimerSectionHabilete.Text = "Supprimer"
        Me.btnSupprimerSectionHabilete.UseVisualStyleBackColor = True
        '
        'btnModifierSectionHabilete
        '
        Me.btnModifierSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifierSectionHabilete.Location = New System.Drawing.Point(499, 19)
        Me.btnModifierSectionHabilete.Name = "btnModifierSectionHabilete"
        Me.btnModifierSectionHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierSectionHabilete.TabIndex = 1
        Me.btnModifierSectionHabilete.Text = "Modifier"
        Me.btnModifierSectionHabilete.UseVisualStyleBackColor = True
        '
        'dgvSectionHabilete
        '
        Me.dgvSectionHabilete.AllowUserToAddRows = False
        Me.dgvSectionHabilete.AllowUserToDeleteRows = False
        Me.dgvSectionHabilete.AllowUserToResizeColumns = False
        Me.dgvSectionHabilete.AllowUserToResizeRows = False
        Me.dgvSectionHabilete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSectionHabilete.AutoGenerateColumns = False
        Me.dgvSectionHabilete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSectionHabilete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSECTIONHABILETEDataGridViewTextBoxColumn1, Me.VersionDataGridViewTextBoxColumn, Me.NumeroSECTIONHABILETEDataGridViewTextBoxColumn, Me.TitreSECTIONHABILETEDataGridViewTextBoxColumn})
        Me.dgvSectionHabilete.DataSource = Me.PSELECTSectionHabileteBindingSource
        Me.dgvSectionHabilete.Location = New System.Drawing.Point(6, 19)
        Me.dgvSectionHabilete.MultiSelect = False
        Me.dgvSectionHabilete.Name = "dgvSectionHabilete"
        Me.dgvSectionHabilete.ReadOnly = True
        Me.dgvSectionHabilete.RowHeadersVisible = False
        Me.dgvSectionHabilete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSectionHabilete.Size = New System.Drawing.Size(487, 198)
        Me.dgvSectionHabilete.TabIndex = 0
        '
        'btnAjouterSectionHabilete
        '
        Me.btnAjouterSectionHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouterSectionHabilete.Location = New System.Drawing.Point(418, 12)
        Me.btnAjouterSectionHabilete.Name = "btnAjouterSectionHabilete"
        Me.btnAjouterSectionHabilete.Size = New System.Drawing.Size(156, 23)
        Me.btnAjouterSectionHabilete.TabIndex = 9
        Me.btnAjouterSectionHabilete.Text = "Ajouter une habileté existente"
        Me.btnAjouterSectionHabilete.UseVisualStyleBackColor = True
        '
        'gbHabilete
        '
        Me.gbHabilete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbHabilete.Controls.Add(Me.btnDescendreHabilete)
        Me.gbHabilete.Controls.Add(Me.btnMonterHabilete)
        Me.gbHabilete.Controls.Add(Me.btnAnnulerHabilete)
        Me.gbHabilete.Controls.Add(Me.btnEnregistrerHabilete)
        Me.gbHabilete.Controls.Add(Me.txtLibelleHabilete)
        Me.gbHabilete.Controls.Add(Me.lbLibelleHabilete)
        Me.gbHabilete.Controls.Add(Me.btnSupprimerHabilete)
        Me.gbHabilete.Controls.Add(Me.btnModifierHabilete)
        Me.gbHabilete.Controls.Add(Me.dgvHabilete)
        Me.gbHabilete.Location = New System.Drawing.Point(3, 314)
        Me.gbHabilete.Name = "gbHabilete"
        Me.gbHabilete.Size = New System.Drawing.Size(580, 273)
        Me.gbHabilete.TabIndex = 2
        Me.gbHabilete.TabStop = False
        Me.gbHabilete.Text = "Sous-habileté"
        '
        'btnDescendreHabilete
        '
        Me.btnDescendreHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDescendreHabilete.Location = New System.Drawing.Point(499, 106)
        Me.btnDescendreHabilete.Name = "btnDescendreHabilete"
        Me.btnDescendreHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnDescendreHabilete.TabIndex = 10
        Me.btnDescendreHabilete.Text = "Descendre"
        Me.btnDescendreHabilete.UseVisualStyleBackColor = True
        '
        'btnMonterHabilete
        '
        Me.btnMonterHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMonterHabilete.Location = New System.Drawing.Point(499, 77)
        Me.btnMonterHabilete.Name = "btnMonterHabilete"
        Me.btnMonterHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnMonterHabilete.TabIndex = 9
        Me.btnMonterHabilete.Text = "Monter"
        Me.btnMonterHabilete.UseVisualStyleBackColor = True
        '
        'btnAnnulerHabilete
        '
        Me.btnAnnulerHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulerHabilete.Location = New System.Drawing.Point(499, 244)
        Me.btnAnnulerHabilete.Name = "btnAnnulerHabilete"
        Me.btnAnnulerHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerHabilete.TabIndex = 8
        Me.btnAnnulerHabilete.Text = "Annuler"
        Me.btnAnnulerHabilete.UseVisualStyleBackColor = True
        '
        'btnEnregistrerHabilete
        '
        Me.btnEnregistrerHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnregistrerHabilete.Location = New System.Drawing.Point(499, 218)
        Me.btnEnregistrerHabilete.Name = "btnEnregistrerHabilete"
        Me.btnEnregistrerHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerHabilete.TabIndex = 7
        Me.btnEnregistrerHabilete.Text = "Enregistrer"
        Me.btnEnregistrerHabilete.UseVisualStyleBackColor = True
        '
        'txtLibelleHabilete
        '
        Me.txtLibelleHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLibelleHabilete.Location = New System.Drawing.Point(56, 220)
        Me.txtLibelleHabilete.Name = "txtLibelleHabilete"
        Me.txtLibelleHabilete.Size = New System.Drawing.Size(437, 20)
        Me.txtLibelleHabilete.TabIndex = 6
        '
        'lbLibelleHabilete
        '
        Me.lbLibelleHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbLibelleHabilete.AutoSize = True
        Me.lbLibelleHabilete.Location = New System.Drawing.Point(10, 223)
        Me.lbLibelleHabilete.Name = "lbLibelleHabilete"
        Me.lbLibelleHabilete.Size = New System.Drawing.Size(40, 13)
        Me.lbLibelleHabilete.TabIndex = 5
        Me.lbLibelleHabilete.Text = "Libellé:"
        '
        'btnSupprimerHabilete
        '
        Me.btnSupprimerHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSupprimerHabilete.Location = New System.Drawing.Point(499, 48)
        Me.btnSupprimerHabilete.Name = "btnSupprimerHabilete"
        Me.btnSupprimerHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerHabilete.TabIndex = 2
        Me.btnSupprimerHabilete.Text = "Supprimer"
        Me.btnSupprimerHabilete.UseVisualStyleBackColor = True
        '
        'btnModifierHabilete
        '
        Me.btnModifierHabilete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifierHabilete.Location = New System.Drawing.Point(499, 19)
        Me.btnModifierHabilete.Name = "btnModifierHabilete"
        Me.btnModifierHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierHabilete.TabIndex = 1
        Me.btnModifierHabilete.Text = "Modifier"
        Me.btnModifierHabilete.UseVisualStyleBackColor = True
        '
        'dgvHabilete
        '
        Me.dgvHabilete.AllowUserToAddRows = False
        Me.dgvHabilete.AllowUserToDeleteRows = False
        Me.dgvHabilete.AllowUserToResizeColumns = False
        Me.dgvHabilete.AllowUserToResizeRows = False
        Me.dgvHabilete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHabilete.AutoGenerateColumns = False
        Me.dgvHabilete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHabilete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHABILETEDataGridViewTextBoxColumn, Me.IdSECTIONHABILETEDataGridViewTextBoxColumn, Me.NumeroHABILETEDataGridViewTextBoxColumn, Me.LibelleHABILETEDataGridViewTextBoxColumn})
        Me.dgvHabilete.DataSource = Me.PSELECTHabileteBindingSource
        Me.dgvHabilete.Location = New System.Drawing.Point(6, 19)
        Me.dgvHabilete.MultiSelect = False
        Me.dgvHabilete.Name = "dgvHabilete"
        Me.dgvHabilete.ReadOnly = True
        Me.dgvHabilete.RowHeadersVisible = False
        Me.dgvHabilete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHabilete.Size = New System.Drawing.Size(487, 198)
        Me.dgvHabilete.TabIndex = 0
        '
        'btnFermer
        '
        Me.btnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFermer.Location = New System.Drawing.Point(502, 592)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(75, 23)
        Me.btnFermer.TabIndex = 3
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
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
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_SELECT_HabileteTableAdapter
        '
        Me.P_SELECT_HabileteTableAdapter.ClearBeforeFill = True
        '
        'PSELECTSectionHabileteBindingSource
        '
        Me.PSELECTSectionHabileteBindingSource.DataMember = "P_SELECT_SectionHabilete"
        Me.PSELECTSectionHabileteBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_SectionHabileteTableAdapter
        '
        Me.P_SELECT_SectionHabileteTableAdapter.ClearBeforeFill = True
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
        'frmGestionHabilete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 618)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.gbHabilete)
        Me.Controls.Add(Me.btnAjouterSectionHabilete)
        Me.Controls.Add(Me.gbSectionHabilete)
        Me.Name = "frmGestionHabilete"
        Me.Text = "Gestion des habiletés"
        Me.gbSectionHabilete.ResumeLayout(False)
        Me.gbSectionHabilete.PerformLayout()
        CType(Me.dgvSectionHabilete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHabilete.ResumeLayout(False)
        Me.gbHabilete.PerformLayout()
        CType(Me.dgvHabilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTHabileteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTSectionHabileteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSectionHabilete As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSectionHabilete As System.Windows.Forms.DataGridView
    Friend WithEvents btnAnnulerSectionHabilete As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrerSectionHabilete As System.Windows.Forms.Button
    Friend WithEvents txtTitreSectionHabilete As System.Windows.Forms.TextBox
    Friend WithEvents lbTitreSectionHabilete As System.Windows.Forms.Label
    Friend WithEvents btnSupprimerSectionHabilete As System.Windows.Forms.Button
    Friend WithEvents btnModifierSectionHabilete As System.Windows.Forms.Button
    Friend WithEvents gbHabilete As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnnulerHabilete As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrerHabilete As System.Windows.Forms.Button
    Friend WithEvents txtLibelleHabilete As System.Windows.Forms.TextBox
    Friend WithEvents lbLibelleHabilete As System.Windows.Forms.Label
    Friend WithEvents btnSupprimerHabilete As System.Windows.Forms.Button
    Friend WithEvents btnModifierHabilete As System.Windows.Forms.Button
    Friend WithEvents dgvHabilete As System.Windows.Forms.DataGridView
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents btnAjouterSectionHabilete As System.Windows.Forms.Button
    Friend WithEvents P_SELECT_HabileteTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_HabileteTableAdapter
    Friend WithEvents PSELECTHabileteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSECTIONHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDescendreSectionHabilete As System.Windows.Forms.Button
    Friend WithEvents btnMonterSectionHabilete As System.Windows.Forms.Button
    Friend WithEvents btnDescendreHabilete As System.Windows.Forms.Button
    Friend WithEvents btnMonterHabilete As System.Windows.Forms.Button
    Friend WithEvents IdSECTIONHABILETEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroSECTIONHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreSECTIONHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTSectionHabileteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_SectionHabileteTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_SectionHabileteTableAdapter
End Class
