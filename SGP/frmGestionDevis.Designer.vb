<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDevis
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
        Me.gbRechercheDevis = New System.Windows.Forms.GroupBox()
        Me.rbDevisNonOfficiels = New System.Windows.Forms.RadioButton()
        Me.rbDevisOfficiels = New System.Windows.Forms.RadioButton()
        Me.rbDevisTous = New System.Windows.Forms.RadioButton()
        Me.cbRechercheProgramme = New System.Windows.Forms.ComboBox()
        Me.PSELECTProgrammeListeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.lbProgramme = New System.Windows.Forms.Label()
        Me.gbResultats = New System.Windows.Forms.GroupBox()
        Me.btnGenerer = New System.Windows.Forms.Button()
        Me.btnDetailsDevis = New System.Windows.Forms.Button()
        Me.btnAjouterDevis = New System.Windows.Forms.Button()
        Me.dgvDevis = New System.Windows.Forms.DataGridView()
        Me.IdDEVISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfficialisationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTDevisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_Programme_ListeTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Programme_ListeTableAdapter()
        Me.P_SELECT_DevisTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_DevisTableAdapter()
        Me.P_SELECT_Programme_Liste_EnseignantTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Programme_Liste_EnseignantTableAdapter()
        Me.TableAdapterManager = New SGP.SGPDataSetTableAdapters.TableAdapterManager()
        Me.P_SELECT_Devis_EnseignantTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Devis_EnseignantTableAdapter()
        Me.gbRechercheDevis.SuspendLayout()
        CType(Me.PSELECTProgrammeListeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultats.SuspendLayout()
        CType(Me.dgvDevis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTDevisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRechercheDevis
        '
        Me.gbRechercheDevis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRechercheDevis.Controls.Add(Me.rbDevisNonOfficiels)
        Me.gbRechercheDevis.Controls.Add(Me.rbDevisOfficiels)
        Me.gbRechercheDevis.Controls.Add(Me.rbDevisTous)
        Me.gbRechercheDevis.Controls.Add(Me.cbRechercheProgramme)
        Me.gbRechercheDevis.Controls.Add(Me.lbProgramme)
        Me.gbRechercheDevis.Location = New System.Drawing.Point(12, 13)
        Me.gbRechercheDevis.Name = "gbRechercheDevis"
        Me.gbRechercheDevis.Size = New System.Drawing.Size(721, 88)
        Me.gbRechercheDevis.TabIndex = 0
        Me.gbRechercheDevis.TabStop = False
        Me.gbRechercheDevis.Text = "Recherche"
        '
        'rbDevisNonOfficiels
        '
        Me.rbDevisNonOfficiels.AutoSize = True
        Me.rbDevisNonOfficiels.Location = New System.Drawing.Point(258, 51)
        Me.rbDevisNonOfficiels.Name = "rbDevisNonOfficiels"
        Me.rbDevisNonOfficiels.Size = New System.Drawing.Size(111, 17)
        Me.rbDevisNonOfficiels.TabIndex = 6
        Me.rbDevisNonOfficiels.TabStop = True
        Me.rbDevisNonOfficiels.Text = "Devis non officiels"
        Me.rbDevisNonOfficiels.UseVisualStyleBackColor = True
        '
        'rbDevisOfficiels
        '
        Me.rbDevisOfficiels.AutoSize = True
        Me.rbDevisOfficiels.Location = New System.Drawing.Point(135, 51)
        Me.rbDevisOfficiels.Name = "rbDevisOfficiels"
        Me.rbDevisOfficiels.Size = New System.Drawing.Size(90, 17)
        Me.rbDevisOfficiels.TabIndex = 5
        Me.rbDevisOfficiels.TabStop = True
        Me.rbDevisOfficiels.Text = "Devis officiels"
        Me.rbDevisOfficiels.UseVisualStyleBackColor = True
        '
        'rbDevisTous
        '
        Me.rbDevisTous.AutoSize = True
        Me.rbDevisTous.Location = New System.Drawing.Point(9, 51)
        Me.rbDevisTous.Name = "rbDevisTous"
        Me.rbDevisTous.Size = New System.Drawing.Size(93, 17)
        Me.rbDevisTous.TabIndex = 4
        Me.rbDevisTous.TabStop = True
        Me.rbDevisTous.Text = "Tous les devis"
        Me.rbDevisTous.UseVisualStyleBackColor = True
        '
        'cbRechercheProgramme
        '
        Me.cbRechercheProgramme.DataSource = Me.PSELECTProgrammeListeBindingSource
        Me.cbRechercheProgramme.DisplayMember = "Programme"
        Me.cbRechercheProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRechercheProgramme.FormattingEnabled = True
        Me.cbRechercheProgramme.Location = New System.Drawing.Point(78, 21)
        Me.cbRechercheProgramme.Name = "cbRechercheProgramme"
        Me.cbRechercheProgramme.Size = New System.Drawing.Size(291, 21)
        Me.cbRechercheProgramme.TabIndex = 2
        Me.cbRechercheProgramme.ValueMember = "idPROGRAMME"
        '
        'PSELECTProgrammeListeBindingSource
        '
        Me.PSELECTProgrammeListeBindingSource.DataMember = "P_SELECT_Programme_Liste"
        Me.PSELECTProgrammeListeBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbProgramme
        '
        Me.lbProgramme.AutoSize = True
        Me.lbProgramme.Location = New System.Drawing.Point(6, 24)
        Me.lbProgramme.Name = "lbProgramme"
        Me.lbProgramme.Size = New System.Drawing.Size(66, 13)
        Me.lbProgramme.TabIndex = 1
        Me.lbProgramme.Text = "Programme :"
        '
        'gbResultats
        '
        Me.gbResultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbResultats.Controls.Add(Me.btnGenerer)
        Me.gbResultats.Controls.Add(Me.btnDetailsDevis)
        Me.gbResultats.Controls.Add(Me.btnAjouterDevis)
        Me.gbResultats.Controls.Add(Me.dgvDevis)
        Me.gbResultats.Location = New System.Drawing.Point(12, 107)
        Me.gbResultats.Name = "gbResultats"
        Me.gbResultats.Size = New System.Drawing.Size(721, 312)
        Me.gbResultats.TabIndex = 1
        Me.gbResultats.TabStop = False
        Me.gbResultats.Text = "Résultats"
        '
        'btnGenerer
        '        
        Me.btnGenerer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerer.Location = New System.Drawing.Point(640, 128)
        Me.btnGenerer.Name = "btnGenerer"
        Me.btnGenerer.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerer.TabIndex = 3
        Me.btnGenerer.Text = "Générer"
        Me.btnGenerer.UseVisualStyleBackColor = True
        '
        'btnDetailsDevis
        '
        Me.btnDetailsDevis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetailsDevis.Location = New System.Drawing.Point(640, 48)
        Me.btnDetailsDevis.Name = "btnDetailsDevis"
        Me.btnDetailsDevis.Size = New System.Drawing.Size(75, 23)
        Me.btnDetailsDevis.TabIndex = 2
        Me.btnDetailsDevis.Text = "Détails"
        Me.btnDetailsDevis.UseVisualStyleBackColor = True
        '
        'btnAjouterDevis
        '
        Me.btnAjouterDevis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouterDevis.Location = New System.Drawing.Point(640, 19)
        Me.btnAjouterDevis.Name = "btnAjouterDevis"
        Me.btnAjouterDevis.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterDevis.TabIndex = 1
        Me.btnAjouterDevis.Text = "Nouveau"
        Me.btnAjouterDevis.UseVisualStyleBackColor = True
        '
        'dgvDevis
        '
        Me.dgvDevis.AllowUserToAddRows = False
        Me.dgvDevis.AllowUserToDeleteRows = False
        Me.dgvDevis.AllowUserToResizeColumns = False
        Me.dgvDevis.AllowUserToResizeRows = False
        Me.dgvDevis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDevis.AutoGenerateColumns = False
        Me.dgvDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDEVISDataGridViewTextBoxColumn, Me.ProgrammeDataGridViewTextBoxColumn, Me.DateOfficialisationDataGridViewTextBoxColumn, Me.CommentaireDataGridViewTextBoxColumn})
        Me.dgvDevis.DataSource = Me.PSELECTDevisBindingSource
        Me.dgvDevis.Location = New System.Drawing.Point(9, 19)
        Me.dgvDevis.MultiSelect = False
        Me.dgvDevis.Name = "dgvDevis"
        Me.dgvDevis.ReadOnly = True
        Me.dgvDevis.RowHeadersVisible = False
        Me.dgvDevis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDevis.Size = New System.Drawing.Size(625, 287)
        Me.dgvDevis.TabIndex = 0
        '
        'IdDEVISDataGridViewTextBoxColumn
        '
        Me.IdDEVISDataGridViewTextBoxColumn.DataPropertyName = "idDEVIS"
        Me.IdDEVISDataGridViewTextBoxColumn.HeaderText = "idDEVIS"
        Me.IdDEVISDataGridViewTextBoxColumn.Name = "IdDEVISDataGridViewTextBoxColumn"
        Me.IdDEVISDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDEVISDataGridViewTextBoxColumn.Visible = False
        '
        'ProgrammeDataGridViewTextBoxColumn
        '
        Me.ProgrammeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProgrammeDataGridViewTextBoxColumn.DataPropertyName = "Programme"
        Me.ProgrammeDataGridViewTextBoxColumn.HeaderText = "Programme"
        Me.ProgrammeDataGridViewTextBoxColumn.Name = "ProgrammeDataGridViewTextBoxColumn"
        Me.ProgrammeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfficialisationDataGridViewTextBoxColumn
        '
        Me.DateOfficialisationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateOfficialisationDataGridViewTextBoxColumn.DataPropertyName = "dateOfficialisation"
        Me.DateOfficialisationDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.DateOfficialisationDataGridViewTextBoxColumn.HeaderText = "Date d'officialisation"
        Me.DateOfficialisationDataGridViewTextBoxColumn.Name = "DateOfficialisationDataGridViewTextBoxColumn"
        Me.DateOfficialisationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentaireDataGridViewTextBoxColumn
        '
        Me.CommentaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CommentaireDataGridViewTextBoxColumn.DataPropertyName = "commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.CommentaireDataGridViewTextBoxColumn.HeaderText = "Commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.Name = "CommentaireDataGridViewTextBoxColumn"
        Me.CommentaireDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTDevisBindingSource
        '
        Me.PSELECTDevisBindingSource.DataMember = "P_SELECT_Devis"
        Me.PSELECTDevisBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_Programme_ListeTableAdapter
        '
        Me.P_SELECT_Programme_ListeTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_DevisTableAdapter
        '
        Me.P_SELECT_DevisTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_Programme_Liste_EnseignantTableAdapter
        '
        Me.P_SELECT_Programme_Liste_EnseignantTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SGP.SGPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'P_SELECT_Devis_EnseignantTableAdapter
        '
        Me.P_SELECT_Devis_EnseignantTableAdapter.ClearBeforeFill = True
        '
        'frmGestionDevis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 427)
        Me.Controls.Add(Me.gbRechercheDevis)
        Me.Controls.Add(Me.gbResultats)
        Me.Name = "frmGestionDevis"
        Me.Text = "Gestion des devis"
        Me.gbRechercheDevis.ResumeLayout(False)
        Me.gbRechercheDevis.PerformLayout()
        CType(Me.PSELECTProgrammeListeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultats.ResumeLayout(False)
        CType(Me.dgvDevis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTDevisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRechercheDevis As System.Windows.Forms.GroupBox
    Friend WithEvents cbRechercheProgramme As System.Windows.Forms.ComboBox
    Friend WithEvents lbProgramme As System.Windows.Forms.Label
    Friend WithEvents gbResultats As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDevis As System.Windows.Forms.DataGridView
    Friend WithEvents btnDetailsDevis As System.Windows.Forms.Button
    Friend WithEvents btnAjouterDevis As System.Windows.Forms.Button
    Friend WithEvents rbDevisNonOfficiels As System.Windows.Forms.RadioButton
    Friend WithEvents rbDevisOfficiels As System.Windows.Forms.RadioButton
    Friend WithEvents rbDevisTous As System.Windows.Forms.RadioButton
    Friend WithEvents PSELECTProgrammeListeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents PSELECTDevisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_Programme_ListeTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Programme_ListeTableAdapter
    Friend WithEvents P_SELECT_DevisTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_DevisTableAdapter
    Friend WithEvents P_SELECT_Programme_Liste_EnseignantTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Programme_Liste_EnseignantTableAdapter
    Friend WithEvents TableAdapterManager As SGP.SGPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P_SELECT_Devis_EnseignantTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Devis_EnseignantTableAdapter
    Friend WithEvents IdDEVISDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgrammeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfficialisationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGenerer As System.Windows.Forms.Button
End Class
