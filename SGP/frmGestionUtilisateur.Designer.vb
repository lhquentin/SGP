<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionUtilisateur
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
        Me.gbRechercheUtilisateur = New System.Windows.Forms.GroupBox()
        Me.lbTypeUtilisateur = New System.Windows.Forms.Label()
        Me.cbRoleRecherche = New System.Windows.Forms.ComboBox()
        Me.PSELECTRoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.txtUtilisateurRecherche = New System.Windows.Forms.TextBox()
        Me.lbUtilisateur = New System.Windows.Forms.Label()
        Me.gbUtilisateurs = New System.Windows.Forms.GroupBox()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnCréer = New System.Windows.Forms.Button()
        Me.dgvUtilisateur = New System.Windows.Forms.DataGridView()
        Me.IdUTILISATEURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilisateurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleROLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTUtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbDetailsUtilisateur = New System.Windows.Forms.GroupBox()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.cbProgramme = New System.Windows.Forms.ComboBox()
        Me.PSELECTTitreProgrammeListeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.txtCourriel = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lbRole = New System.Windows.Forms.Label()
        Me.lbNom = New System.Windows.Forms.Label()
        Me.lbProgramme = New System.Windows.Forms.Label()
        Me.lbCourriel = New System.Windows.Forms.Label()
        Me.lbPrenom = New System.Windows.Forms.Label()
        Me.P_SELECT_RoleTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_RoleTableAdapter()
        Me.P_SELECT_UtilisateurTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_UtilisateurTableAdapter()
        Me.P_SELECT_TitreProgrammeListeTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_TitreProgrammeListeTableAdapter()
        Me.gbRechercheUtilisateur.SuspendLayout()
        CType(Me.PSELECTRoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUtilisateurs.SuspendLayout()
        CType(Me.dgvUtilisateur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetailsUtilisateur.SuspendLayout()
        CType(Me.PSELECTTitreProgrammeListeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRechercheUtilisateur
        '
        Me.gbRechercheUtilisateur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRechercheUtilisateur.Controls.Add(Me.lbTypeUtilisateur)
        Me.gbRechercheUtilisateur.Controls.Add(Me.cbRoleRecherche)
        Me.gbRechercheUtilisateur.Controls.Add(Me.txtUtilisateurRecherche)
        Me.gbRechercheUtilisateur.Controls.Add(Me.lbUtilisateur)
        Me.gbRechercheUtilisateur.Location = New System.Drawing.Point(12, 12)
        Me.gbRechercheUtilisateur.Name = "gbRechercheUtilisateur"
        Me.gbRechercheUtilisateur.Size = New System.Drawing.Size(610, 80)
        Me.gbRechercheUtilisateur.TabIndex = 0
        Me.gbRechercheUtilisateur.TabStop = False
        Me.gbRechercheUtilisateur.Text = "Recherche"
        '
        'lbTypeUtilisateur
        '
        Me.lbTypeUtilisateur.AutoSize = True
        Me.lbTypeUtilisateur.Location = New System.Drawing.Point(7, 48)
        Me.lbTypeUtilisateur.Name = "lbTypeUtilisateur"
        Me.lbTypeUtilisateur.Size = New System.Drawing.Size(35, 13)
        Me.lbTypeUtilisateur.TabIndex = 3
        Me.lbTypeUtilisateur.Text = "Rôle :"
        '
        'cbRoleRecherche
        '
        Me.cbRoleRecherche.DataSource = Me.PSELECTRoleBindingSource
        Me.cbRoleRecherche.DisplayMember = "libelleROLE"
        Me.cbRoleRecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoleRecherche.FormattingEnabled = True
        Me.cbRoleRecherche.Location = New System.Drawing.Point(71, 45)
        Me.cbRoleRecherche.Name = "cbRoleRecherche"
        Me.cbRoleRecherche.Size = New System.Drawing.Size(127, 21)
        Me.cbRoleRecherche.TabIndex = 2
        Me.cbRoleRecherche.ValueMember = "idROLE"
        '
        'PSELECTRoleBindingSource
        '
        Me.PSELECTRoleBindingSource.DataMember = "P_SELECT_Role"
        Me.PSELECTRoleBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUtilisateurRecherche
        '
        Me.txtUtilisateurRecherche.Location = New System.Drawing.Point(71, 19)
        Me.txtUtilisateurRecherche.Name = "txtUtilisateurRecherche"
        Me.txtUtilisateurRecherche.Size = New System.Drawing.Size(194, 20)
        Me.txtUtilisateurRecherche.TabIndex = 1
        '
        'lbUtilisateur
        '
        Me.lbUtilisateur.AutoSize = True
        Me.lbUtilisateur.Location = New System.Drawing.Point(6, 22)
        Me.lbUtilisateur.Name = "lbUtilisateur"
        Me.lbUtilisateur.Size = New System.Drawing.Size(59, 13)
        Me.lbUtilisateur.TabIndex = 0
        Me.lbUtilisateur.Text = "Utilisateur :"
        '
        'gbUtilisateurs
        '
        Me.gbUtilisateurs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbUtilisateurs.Controls.Add(Me.btnSupprimer)
        Me.gbUtilisateurs.Controls.Add(Me.btnModifier)
        Me.gbUtilisateurs.Controls.Add(Me.btnCréer)
        Me.gbUtilisateurs.Controls.Add(Me.dgvUtilisateur)
        Me.gbUtilisateurs.Location = New System.Drawing.Point(12, 98)
        Me.gbUtilisateurs.Name = "gbUtilisateurs"
        Me.gbUtilisateurs.Size = New System.Drawing.Size(610, 257)
        Me.gbUtilisateurs.TabIndex = 1
        Me.gbUtilisateurs.TabStop = False
        Me.gbUtilisateurs.Text = "Résultats"
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSupprimer.Location = New System.Drawing.Point(529, 77)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimer.TabIndex = 3
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifier.Location = New System.Drawing.Point(529, 48)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 2
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnCréer
        '
        Me.btnCréer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCréer.Location = New System.Drawing.Point(529, 19)
        Me.btnCréer.Name = "btnCréer"
        Me.btnCréer.Size = New System.Drawing.Size(75, 23)
        Me.btnCréer.TabIndex = 1
        Me.btnCréer.Text = "Créer"
        Me.btnCréer.UseVisualStyleBackColor = True
        '
        'dgvUtilisateur
        '
        Me.dgvUtilisateur.AllowUserToAddRows = False
        Me.dgvUtilisateur.AllowUserToDeleteRows = False
        Me.dgvUtilisateur.AllowUserToResizeColumns = False
        Me.dgvUtilisateur.AllowUserToResizeRows = False
        Me.dgvUtilisateur.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUtilisateur.AutoGenerateColumns = False
        Me.dgvUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUtilisateur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUTILISATEURDataGridViewTextBoxColumn, Me.UtilisateurDataGridViewTextBoxColumn, Me.LibelleROLEDataGridViewTextBoxColumn})
        Me.dgvUtilisateur.DataSource = Me.PSELECTUtilisateurBindingSource
        Me.dgvUtilisateur.Location = New System.Drawing.Point(0, 19)
        Me.dgvUtilisateur.MultiSelect = False
        Me.dgvUtilisateur.Name = "dgvUtilisateur"
        Me.dgvUtilisateur.ReadOnly = True
        Me.dgvUtilisateur.RowHeadersVisible = False
        Me.dgvUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUtilisateur.Size = New System.Drawing.Size(523, 238)
        Me.dgvUtilisateur.TabIndex = 0
        '
        'IdUTILISATEURDataGridViewTextBoxColumn
        '
        Me.IdUTILISATEURDataGridViewTextBoxColumn.DataPropertyName = "idUTILISATEUR"
        Me.IdUTILISATEURDataGridViewTextBoxColumn.HeaderText = "idUTILISATEUR"
        Me.IdUTILISATEURDataGridViewTextBoxColumn.Name = "IdUTILISATEURDataGridViewTextBoxColumn"
        Me.IdUTILISATEURDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUTILISATEURDataGridViewTextBoxColumn.Visible = False
        '
        'UtilisateurDataGridViewTextBoxColumn
        '
        Me.UtilisateurDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UtilisateurDataGridViewTextBoxColumn.DataPropertyName = "Utilisateur"
        Me.UtilisateurDataGridViewTextBoxColumn.HeaderText = "Utilisateur"
        Me.UtilisateurDataGridViewTextBoxColumn.Name = "UtilisateurDataGridViewTextBoxColumn"
        Me.UtilisateurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibelleROLEDataGridViewTextBoxColumn
        '
        Me.LibelleROLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleROLEDataGridViewTextBoxColumn.DataPropertyName = "libelleROLE"
        Me.LibelleROLEDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.LibelleROLEDataGridViewTextBoxColumn.HeaderText = "Rôle"
        Me.LibelleROLEDataGridViewTextBoxColumn.Name = "LibelleROLEDataGridViewTextBoxColumn"
        Me.LibelleROLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTUtilisateurBindingSource
        '
        Me.PSELECTUtilisateurBindingSource.DataMember = "P_SELECT_Utilisateur"
        Me.PSELECTUtilisateurBindingSource.DataSource = Me.SGPDataSet
        '
        'gbDetailsUtilisateur
        '
        Me.gbDetailsUtilisateur.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetailsUtilisateur.Controls.Add(Me.btnEnregistrer)
        Me.gbDetailsUtilisateur.Controls.Add(Me.btnAnnuler)
        Me.gbDetailsUtilisateur.Controls.Add(Me.cbProgramme)
        Me.gbDetailsUtilisateur.Controls.Add(Me.cbRole)
        Me.gbDetailsUtilisateur.Controls.Add(Me.txtCourriel)
        Me.gbDetailsUtilisateur.Controls.Add(Me.txtNom)
        Me.gbDetailsUtilisateur.Controls.Add(Me.txtPrenom)
        Me.gbDetailsUtilisateur.Controls.Add(Me.lbRole)
        Me.gbDetailsUtilisateur.Controls.Add(Me.lbNom)
        Me.gbDetailsUtilisateur.Controls.Add(Me.lbProgramme)
        Me.gbDetailsUtilisateur.Controls.Add(Me.lbCourriel)
        Me.gbDetailsUtilisateur.Controls.Add(Me.lbPrenom)
        Me.gbDetailsUtilisateur.Location = New System.Drawing.Point(12, 361)
        Me.gbDetailsUtilisateur.Name = "gbDetailsUtilisateur"
        Me.gbDetailsUtilisateur.Size = New System.Drawing.Size(610, 131)
        Me.gbDetailsUtilisateur.TabIndex = 2
        Me.gbDetailsUtilisateur.TabStop = False
        Me.gbDetailsUtilisateur.Text = "Détails"
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnregistrer.Location = New System.Drawing.Point(529, 18)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrer.TabIndex = 13
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnuler.Location = New System.Drawing.Point(529, 47)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 12
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'cbProgramme
        '
        Me.cbProgramme.DataSource = Me.PSELECTTitreProgrammeListeBindingSource
        Me.cbProgramme.DisplayMember = "Programme"
        Me.cbProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgramme.FormattingEnabled = True
        Me.cbProgramme.Location = New System.Drawing.Point(79, 82)
        Me.cbProgramme.Name = "cbProgramme"
        Me.cbProgramme.Size = New System.Drawing.Size(214, 21)
        Me.cbProgramme.TabIndex = 10
        Me.cbProgramme.ValueMember = "Code"
        Me.cbProgramme.Visible = False
        '
        'PSELECTTitreProgrammeListeBindingSource
        '
        Me.PSELECTTitreProgrammeListeBindingSource.DataMember = "P_SELECT_TitreProgrammeListe"
        Me.PSELECTTitreProgrammeListeBindingSource.DataSource = Me.SGPDataSet
        '
        'cbRole
        '
        Me.cbRole.DataSource = Me.PSELECTRoleBindingSource
        Me.cbRole.DisplayMember = "libelleROLE"
        Me.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Location = New System.Drawing.Point(362, 54)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(133, 21)
        Me.cbRole.TabIndex = 9
        Me.cbRole.ValueMember = "idROLE"
        '
        'txtCourriel
        '
        Me.txtCourriel.Location = New System.Drawing.Point(61, 54)
        Me.txtCourriel.Name = "txtCourriel"
        Me.txtCourriel.Size = New System.Drawing.Size(232, 20)
        Me.txtCourriel.TabIndex = 8
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(289, 25)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(206, 20)
        Me.txtNom.TabIndex = 7
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(61, 25)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(177, 20)
        Me.txtPrenom.TabIndex = 6
        '
        'lbRole
        '
        Me.lbRole.AutoSize = True
        Me.lbRole.ForeColor = System.Drawing.Color.Black
        Me.lbRole.Location = New System.Drawing.Point(321, 62)
        Me.lbRole.Name = "lbRole"
        Me.lbRole.Size = New System.Drawing.Size(35, 13)
        Me.lbRole.TabIndex = 4
        Me.lbRole.Text = "Rôle :"
        '
        'lbNom
        '
        Me.lbNom.AutoSize = True
        Me.lbNom.Location = New System.Drawing.Point(248, 28)
        Me.lbNom.Name = "lbNom"
        Me.lbNom.Size = New System.Drawing.Size(35, 13)
        Me.lbNom.TabIndex = 3
        Me.lbNom.Text = "Nom :"
        '
        'lbProgramme
        '
        Me.lbProgramme.AutoSize = True
        Me.lbProgramme.Location = New System.Drawing.Point(7, 85)
        Me.lbProgramme.Name = "lbProgramme"
        Me.lbProgramme.Size = New System.Drawing.Size(66, 13)
        Me.lbProgramme.TabIndex = 2
        Me.lbProgramme.Text = "Programme :"
        Me.lbProgramme.Visible = False
        '
        'lbCourriel
        '
        Me.lbCourriel.AutoSize = True
        Me.lbCourriel.Location = New System.Drawing.Point(7, 57)
        Me.lbCourriel.Name = "lbCourriel"
        Me.lbCourriel.Size = New System.Drawing.Size(48, 13)
        Me.lbCourriel.TabIndex = 1
        Me.lbCourriel.Text = "Courriel :"
        '
        'lbPrenom
        '
        Me.lbPrenom.AutoSize = True
        Me.lbPrenom.Location = New System.Drawing.Point(6, 28)
        Me.lbPrenom.Name = "lbPrenom"
        Me.lbPrenom.Size = New System.Drawing.Size(49, 13)
        Me.lbPrenom.TabIndex = 0
        Me.lbPrenom.Text = "Prénom :"
        '
        'P_SELECT_RoleTableAdapter
        '
        Me.P_SELECT_RoleTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_UtilisateurTableAdapter
        '
        Me.P_SELECT_UtilisateurTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_TitreProgrammeListeTableAdapter
        '
        Me.P_SELECT_TitreProgrammeListeTableAdapter.ClearBeforeFill = True
        '
        'frmGestionUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 507)
        Me.Controls.Add(Me.gbDetailsUtilisateur)
        Me.Controls.Add(Me.gbUtilisateurs)
        Me.Controls.Add(Me.gbRechercheUtilisateur)
        Me.Name = "frmGestionUtilisateur"
        Me.Text = "Gestion des utilisateurs"
        Me.gbRechercheUtilisateur.ResumeLayout(False)
        Me.gbRechercheUtilisateur.PerformLayout()
        CType(Me.PSELECTRoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUtilisateurs.ResumeLayout(False)
        CType(Me.dgvUtilisateur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetailsUtilisateur.ResumeLayout(False)
        Me.gbDetailsUtilisateur.PerformLayout()
        CType(Me.PSELECTTitreProgrammeListeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRechercheUtilisateur As System.Windows.Forms.GroupBox
    Friend WithEvents gbUtilisateurs As System.Windows.Forms.GroupBox
    Friend WithEvents gbDetailsUtilisateur As System.Windows.Forms.GroupBox
    Friend WithEvents lbTypeUtilisateur As System.Windows.Forms.Label
    Friend WithEvents cbRoleRecherche As System.Windows.Forms.ComboBox
    Friend WithEvents txtUtilisateurRecherche As System.Windows.Forms.TextBox
    Friend WithEvents lbUtilisateur As System.Windows.Forms.Label
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnCréer As System.Windows.Forms.Button
    Friend WithEvents dgvUtilisateur As System.Windows.Forms.DataGridView
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents cbProgramme As System.Windows.Forms.ComboBox
    Friend WithEvents cbRole As System.Windows.Forms.ComboBox
    Friend WithEvents txtCourriel As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lbRole As System.Windows.Forms.Label
    Friend WithEvents lbNom As System.Windows.Forms.Label
    Friend WithEvents lbProgramme As System.Windows.Forms.Label
    Friend WithEvents lbCourriel As System.Windows.Forms.Label
    Friend WithEvents lbPrenom As System.Windows.Forms.Label
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents PSELECTRoleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_RoleTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_RoleTableAdapter
    Friend WithEvents IdUTILISATEURDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilisateurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleROLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTUtilisateurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_UtilisateurTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_UtilisateurTableAdapter
    Friend WithEvents PSELECTTitreProgrammeListeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_TitreProgrammeListeTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_TitreProgrammeListeTableAdapter
End Class
