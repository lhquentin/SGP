<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDonneesProgramme
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnAjouterCompetence = New System.Windows.Forms.Button()
        Me.gbCompetences = New System.Windows.Forms.GroupBox()
        Me.btnDetailsCompetence = New System.Windows.Forms.Button()
        Me.btnSupprimerCompetences = New System.Windows.Forms.Button()
        Me.dgvCompetences = New System.Windows.Forms.DataGridView()
        Me.IdCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTCompetencesProgrammeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.gbInfoProgramme = New System.Windows.Forms.GroupBox()
        Me.btnValiderInfos = New System.Windows.Forms.Button()
        Me.btnAnnulerInfos = New System.Windows.Forms.Button()
        Me.btnModifierInfos = New System.Windows.Forms.Button()
        Me.txtConditionAdmission = New System.Windows.Forms.TextBox()
        Me.btnIntentions = New System.Windows.Forms.Button()
        Me.btnBut = New System.Windows.Forms.Button()
        Me.nudDureeFormationSpecifique = New System.Windows.Forms.NumericUpDown()
        Me.nudUnites = New System.Windows.Forms.NumericUpDown()
        Me.nudVersion = New System.Windows.Forms.NumericUpDown()
        Me.cbTypeSanction = New System.Windows.Forms.ComboBox()
        Me.PSELECTTypeSanctionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbTypeProgramme = New System.Windows.Forms.ComboBox()
        Me.PSELECTTypeProgrammeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblconditionAdmission = New System.Windows.Forms.Label()
        Me.lbDureeFormationSpecifique = New System.Windows.Forms.Label()
        Me.lbUnites = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbTypeProgramme = New System.Windows.Forms.Label()
        Me.lbTypeSanction = New System.Windows.Forms.Label()
        Me.lbTitreProgramme = New System.Windows.Forms.Label()
        Me.lbCodeProgramme = New System.Windows.Forms.Label()
        Me.P_SELECT_Type_SanctionTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Type_SanctionTableAdapter()
        Me.P_SELECT_Type_ProgrammeTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Type_ProgrammeTableAdapter()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.P_SELECT_Competences_ProgrammeTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Competences_ProgrammeTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbCompetences.SuspendLayout()
        CType(Me.dgvCompetences, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTCompetencesProgrammeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfoProgramme.SuspendLayout()
        CType(Me.nudDureeFormationSpecifique, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTTypeSanctionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTTypeProgrammeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(606, 747)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'btnAjouterCompetence
        '
        Me.btnAjouterCompetence.Location = New System.Drawing.Point(585, 19)
        Me.btnAjouterCompetence.Name = "btnAjouterCompetence"
        Me.btnAjouterCompetence.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterCompetence.TabIndex = 1
        Me.btnAjouterCompetence.Text = "Ajouter"
        Me.btnAjouterCompetence.UseVisualStyleBackColor = True
        '
        'gbCompetences
        '
        Me.gbCompetences.Controls.Add(Me.btnDetailsCompetence)
        Me.gbCompetences.Controls.Add(Me.btnSupprimerCompetences)
        Me.gbCompetences.Controls.Add(Me.btnAjouterCompetence)
        Me.gbCompetences.Controls.Add(Me.dgvCompetences)
        Me.gbCompetences.Location = New System.Drawing.Point(12, 347)
        Me.gbCompetences.Name = "gbCompetences"
        Me.gbCompetences.Size = New System.Drawing.Size(666, 202)
        Me.gbCompetences.TabIndex = 6
        Me.gbCompetences.TabStop = False
        Me.gbCompetences.Text = "Compétences"
        '
        'btnDetailsCompetence
        '
        Me.btnDetailsCompetence.Location = New System.Drawing.Point(585, 77)
        Me.btnDetailsCompetence.Name = "btnDetailsCompetence"
        Me.btnDetailsCompetence.Size = New System.Drawing.Size(75, 23)
        Me.btnDetailsCompetence.TabIndex = 3
        Me.btnDetailsCompetence.Text = "Détails"
        Me.btnDetailsCompetence.UseVisualStyleBackColor = True
        '
        'btnSupprimerCompetences
        '
        Me.btnSupprimerCompetences.Location = New System.Drawing.Point(585, 48)
        Me.btnSupprimerCompetences.Name = "btnSupprimerCompetences"
        Me.btnSupprimerCompetences.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerCompetences.TabIndex = 2
        Me.btnSupprimerCompetences.Text = "Supprimer"
        Me.btnSupprimerCompetences.UseVisualStyleBackColor = True
        '
        'dgvCompetences
        '
        Me.dgvCompetences.AllowUserToAddRows = False
        Me.dgvCompetences.AllowUserToDeleteRows = False
        Me.dgvCompetences.AllowUserToResizeColumns = False
        Me.dgvCompetences.AllowUserToResizeRows = False
        Me.dgvCompetences.AutoGenerateColumns = False
        Me.dgvCompetences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompetences.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCOMPETENCEDataGridViewTextBoxColumn, Me.CodeCOMPETENCEDataGridViewTextBoxColumn, Me.NomCOMPETENCEDataGridViewTextBoxColumn})
        Me.dgvCompetences.DataSource = Me.PSELECTCompetencesProgrammeBindingSource
        Me.dgvCompetences.Location = New System.Drawing.Point(6, 19)
        Me.dgvCompetences.MultiSelect = False
        Me.dgvCompetences.Name = "dgvCompetences"
        Me.dgvCompetences.ReadOnly = True
        Me.dgvCompetences.RowHeadersVisible = False
        Me.dgvCompetences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompetences.Size = New System.Drawing.Size(573, 177)
        Me.dgvCompetences.TabIndex = 0
        '
        'IdCOMPETENCEDataGridViewTextBoxColumn
        '
        Me.IdCOMPETENCEDataGridViewTextBoxColumn.DataPropertyName = "idCOMPETENCE"
        Me.IdCOMPETENCEDataGridViewTextBoxColumn.HeaderText = "idCOMPETENCE"
        Me.IdCOMPETENCEDataGridViewTextBoxColumn.Name = "IdCOMPETENCEDataGridViewTextBoxColumn"
        Me.IdCOMPETENCEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCOMPETENCEDataGridViewTextBoxColumn.Visible = False
        '
        'CodeCOMPETENCEDataGridViewTextBoxColumn
        '
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.DataPropertyName = "codeCOMPETENCE"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.Name = "CodeCOMPETENCEDataGridViewTextBoxColumn"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomCOMPETENCEDataGridViewTextBoxColumn
        '
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.DataPropertyName = "nomCOMPETENCE"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.HeaderText = "Compétence"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.Name = "NomCOMPETENCEDataGridViewTextBoxColumn"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTCompetencesProgrammeBindingSource
        '
        Me.PSELECTCompetencesProgrammeBindingSource.DataMember = "P_SELECT_Competences_Programme"
        Me.PSELECTCompetencesProgrammeBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbInfoProgramme
        '
        Me.gbInfoProgramme.Controls.Add(Me.btnValiderInfos)
        Me.gbInfoProgramme.Controls.Add(Me.btnAnnulerInfos)
        Me.gbInfoProgramme.Controls.Add(Me.btnModifierInfos)
        Me.gbInfoProgramme.Controls.Add(Me.txtConditionAdmission)
        Me.gbInfoProgramme.Controls.Add(Me.btnIntentions)
        Me.gbInfoProgramme.Controls.Add(Me.btnBut)
        Me.gbInfoProgramme.Controls.Add(Me.nudDureeFormationSpecifique)
        Me.gbInfoProgramme.Controls.Add(Me.nudUnites)
        Me.gbInfoProgramme.Controls.Add(Me.nudVersion)
        Me.gbInfoProgramme.Controls.Add(Me.cbTypeSanction)
        Me.gbInfoProgramme.Controls.Add(Me.cbTypeProgramme)
        Me.gbInfoProgramme.Controls.Add(Me.txtTitre)
        Me.gbInfoProgramme.Controls.Add(Me.txtCode)
        Me.gbInfoProgramme.Controls.Add(Me.lblconditionAdmission)
        Me.gbInfoProgramme.Controls.Add(Me.lbDureeFormationSpecifique)
        Me.gbInfoProgramme.Controls.Add(Me.lbUnites)
        Me.gbInfoProgramme.Controls.Add(Me.lbVersion)
        Me.gbInfoProgramme.Controls.Add(Me.lbTypeProgramme)
        Me.gbInfoProgramme.Controls.Add(Me.lbTypeSanction)
        Me.gbInfoProgramme.Controls.Add(Me.lbTitreProgramme)
        Me.gbInfoProgramme.Controls.Add(Me.lbCodeProgramme)
        Me.gbInfoProgramme.Location = New System.Drawing.Point(12, 12)
        Me.gbInfoProgramme.Name = "gbInfoProgramme"
        Me.gbInfoProgramme.Size = New System.Drawing.Size(666, 329)
        Me.gbInfoProgramme.TabIndex = 5
        Me.gbInfoProgramme.TabStop = False
        Me.gbInfoProgramme.Text = "Informations Générales"
        '
        'btnValiderInfos
        '
        Me.btnValiderInfos.Location = New System.Drawing.Point(423, 300)
        Me.btnValiderInfos.Name = "btnValiderInfos"
        Me.btnValiderInfos.Size = New System.Drawing.Size(75, 23)
        Me.btnValiderInfos.TabIndex = 20
        Me.btnValiderInfos.Text = "Valider"
        Me.btnValiderInfos.UseVisualStyleBackColor = True
        '
        'btnAnnulerInfos
        '
        Me.btnAnnulerInfos.Location = New System.Drawing.Point(504, 300)
        Me.btnAnnulerInfos.Name = "btnAnnulerInfos"
        Me.btnAnnulerInfos.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerInfos.TabIndex = 19
        Me.btnAnnulerInfos.Text = "Annuler"
        Me.btnAnnulerInfos.UseVisualStyleBackColor = True
        '
        'btnModifierInfos
        '
        Me.btnModifierInfos.Location = New System.Drawing.Point(585, 300)
        Me.btnModifierInfos.Name = "btnModifierInfos"
        Me.btnModifierInfos.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierInfos.TabIndex = 18
        Me.btnModifierInfos.Text = "Modifier"
        Me.btnModifierInfos.UseVisualStyleBackColor = True
        '
        'txtConditionAdmission
        '
        Me.txtConditionAdmission.Location = New System.Drawing.Point(126, 114)
        Me.txtConditionAdmission.Multiline = True
        Me.txtConditionAdmission.Name = "txtConditionAdmission"
        Me.txtConditionAdmission.Size = New System.Drawing.Size(492, 126)
        Me.txtConditionAdmission.TabIndex = 17
        '
        'btnIntentions
        '
        Me.btnIntentions.Location = New System.Drawing.Point(408, 246)
        Me.btnIntentions.Name = "btnIntentions"
        Me.btnIntentions.Size = New System.Drawing.Size(117, 24)
        Me.btnIntentions.TabIndex = 16
        Me.btnIntentions.Text = "Intentions éducatives"
        Me.btnIntentions.UseVisualStyleBackColor = True
        '
        'btnBut
        '
        Me.btnBut.Location = New System.Drawing.Point(168, 246)
        Me.btnBut.Name = "btnBut"
        Me.btnBut.Size = New System.Drawing.Size(112, 24)
        Me.btnBut.TabIndex = 15
        Me.btnBut.Text = "Buts du programme"
        Me.btnBut.UseVisualStyleBackColor = True
        '
        'nudDureeFormationSpecifique
        '
        Me.nudDureeFormationSpecifique.Location = New System.Drawing.Point(178, 76)
        Me.nudDureeFormationSpecifique.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nudDureeFormationSpecifique.Name = "nudDureeFormationSpecifique"
        Me.nudDureeFormationSpecifique.Size = New System.Drawing.Size(56, 20)
        Me.nudDureeFormationSpecifique.TabIndex = 14
        '
        'nudUnites
        '
        Me.nudUnites.DecimalPlaces = 2
        Me.nudUnites.Increment = New Decimal(New Integer() {33, 0, 0, 131072})
        Me.nudUnites.Location = New System.Drawing.Point(423, 76)
        Me.nudUnites.Name = "nudUnites"
        Me.nudUnites.Size = New System.Drawing.Size(50, 20)
        Me.nudUnites.TabIndex = 13
        '
        'nudVersion
        '
        Me.nudVersion.Location = New System.Drawing.Point(603, 76)
        Me.nudVersion.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.nudVersion.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudVersion.Name = "nudVersion"
        Me.nudVersion.Size = New System.Drawing.Size(52, 20)
        Me.nudVersion.TabIndex = 12
        Me.nudVersion.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'cbTypeSanction
        '
        Me.cbTypeSanction.DataSource = Me.PSELECTTypeSanctionBindingSource
        Me.cbTypeSanction.DisplayMember = "libelleTYPE_SANCTION"
        Me.cbTypeSanction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeSanction.FormattingEnabled = True
        Me.cbTypeSanction.Location = New System.Drawing.Point(108, 47)
        Me.cbTypeSanction.Name = "cbTypeSanction"
        Me.cbTypeSanction.Size = New System.Drawing.Size(190, 21)
        Me.cbTypeSanction.TabIndex = 11
        Me.cbTypeSanction.ValueMember = "idTYPE_SANCTION"
        '
        'PSELECTTypeSanctionBindingSource
        '
        Me.PSELECTTypeSanctionBindingSource.DataMember = "P_SELECT_Type_Sanction"
        Me.PSELECTTypeSanctionBindingSource.DataSource = Me.SGPDataSet
        '
        'cbTypeProgramme
        '
        Me.cbTypeProgramme.DataSource = Me.PSELECTTypeProgrammeBindingSource
        Me.cbTypeProgramme.DisplayMember = "libelleTYPE_PROGRAMME"
        Me.cbTypeProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeProgramme.FormattingEnabled = True
        Me.cbTypeProgramme.Location = New System.Drawing.Point(459, 47)
        Me.cbTypeProgramme.Name = "cbTypeProgramme"
        Me.cbTypeProgramme.Size = New System.Drawing.Size(196, 21)
        Me.cbTypeProgramme.TabIndex = 10
        Me.cbTypeProgramme.ValueMember = "idTYPE_PROGRAMME"
        '
        'PSELECTTypeProgrammeBindingSource
        '
        Me.PSELECTTypeProgrammeBindingSource.DataMember = "P_SELECT_Type_Programme"
        Me.PSELECTTypeProgrammeBindingSource.DataSource = Me.SGPDataSet
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(382, 17)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(220, 20)
        Me.txtTitre.TabIndex = 9
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(51, 17)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(81, 20)
        Me.txtCode.TabIndex = 8
        '
        'lblconditionAdmission
        '
        Me.lblconditionAdmission.AutoSize = True
        Me.lblconditionAdmission.Location = New System.Drawing.Point(7, 179)
        Me.lblconditionAdmission.Name = "lblconditionAdmission"
        Me.lblconditionAdmission.Size = New System.Drawing.Size(113, 13)
        Me.lblconditionAdmission.TabIndex = 7
        Me.lblconditionAdmission.Text = "Conditions d'admission"
        '
        'lbDureeFormationSpecifique
        '
        Me.lbDureeFormationSpecifique.AutoSize = True
        Me.lbDureeFormationSpecifique.Location = New System.Drawing.Point(7, 78)
        Me.lbDureeFormationSpecifique.Name = "lbDureeFormationSpecifique"
        Me.lbDureeFormationSpecifique.Size = New System.Drawing.Size(165, 13)
        Me.lbDureeFormationSpecifique.TabIndex = 6
        Me.lbDureeFormationSpecifique.Text = "Durée de la formation spécifique :"
        '
        'lbUnites
        '
        Me.lbUnites.AutoSize = True
        Me.lbUnites.Location = New System.Drawing.Point(346, 78)
        Me.lbUnites.Name = "lbUnites"
        Me.lbUnites.Size = New System.Drawing.Size(72, 13)
        Me.lbUnites.TabIndex = 5
        Me.lbUnites.Text = "Unités totale :"
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(549, 78)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(48, 13)
        Me.lbVersion.TabIndex = 4
        Me.lbVersion.Text = "Version :"
        '
        'lbTypeProgramme
        '
        Me.lbTypeProgramme.AutoSize = True
        Me.lbTypeProgramme.Location = New System.Drawing.Point(346, 50)
        Me.lbTypeProgramme.Name = "lbTypeProgramme"
        Me.lbTypeProgramme.Size = New System.Drawing.Size(107, 13)
        Me.lbTypeProgramme.TabIndex = 3
        Me.lbTypeProgramme.Text = "Type de programme :"
        '
        'lbTypeSanction
        '
        Me.lbTypeSanction.AutoSize = True
        Me.lbTypeSanction.Location = New System.Drawing.Point(7, 50)
        Me.lbTypeSanction.Name = "lbTypeSanction"
        Me.lbTypeSanction.Size = New System.Drawing.Size(95, 13)
        Me.lbTypeSanction.TabIndex = 2
        Me.lbTypeSanction.Text = "Type de sanction :"
        '
        'lbTitreProgramme
        '
        Me.lbTitreProgramme.AutoSize = True
        Me.lbTitreProgramme.Location = New System.Drawing.Point(346, 20)
        Me.lbTitreProgramme.Name = "lbTitreProgramme"
        Me.lbTitreProgramme.Size = New System.Drawing.Size(34, 13)
        Me.lbTitreProgramme.TabIndex = 1
        Me.lbTitreProgramme.Text = "Titre :"
        '
        'lbCodeProgramme
        '
        Me.lbCodeProgramme.AutoSize = True
        Me.lbCodeProgramme.Location = New System.Drawing.Point(7, 20)
        Me.lbCodeProgramme.Name = "lbCodeProgramme"
        Me.lbCodeProgramme.Size = New System.Drawing.Size(38, 13)
        Me.lbCodeProgramme.TabIndex = 0
        Me.lbCodeProgramme.Text = "Code :"
        '
        'P_SELECT_Type_SanctionTableAdapter
        '
        Me.P_SELECT_Type_SanctionTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_Type_ProgrammeTableAdapter
        '
        Me.P_SELECT_Type_ProgrammeTableAdapter.ClearBeforeFill = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(521, 555)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(602, 555)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 8
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(440, 555)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 9
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'P_SELECT_Competences_ProgrammeTableAdapter
        '
        Me.P_SELECT_Competences_ProgrammeTableAdapter.ClearBeforeFill = True
        '
        'dlgDonneesProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 590)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.gbCompetences)
        Me.Controls.Add(Me.gbInfoProgramme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgDonneesProgramme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Données du programme"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbCompetences.ResumeLayout(False)
        CType(Me.dgvCompetences, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTCompetencesProgrammeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfoProgramme.ResumeLayout(False)
        Me.gbInfoProgramme.PerformLayout()
        CType(Me.nudDureeFormationSpecifique, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTTypeSanctionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTTypeProgrammeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btnAjouterCompetence As System.Windows.Forms.Button
    Friend WithEvents gbCompetences As System.Windows.Forms.GroupBox
    Friend WithEvents btnSupprimerCompetences As System.Windows.Forms.Button
    Friend WithEvents dgvCompetences As System.Windows.Forms.DataGridView
    Friend WithEvents gbInfoProgramme As System.Windows.Forms.GroupBox
    Friend WithEvents txtConditionAdmission As System.Windows.Forms.TextBox
    Friend WithEvents btnIntentions As System.Windows.Forms.Button
    Friend WithEvents btnBut As System.Windows.Forms.Button
    Friend WithEvents nudDureeFormationSpecifique As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudUnites As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudVersion As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbTypeSanction As System.Windows.Forms.ComboBox
    Friend WithEvents cbTypeProgramme As System.Windows.Forms.ComboBox
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblconditionAdmission As System.Windows.Forms.Label
    Friend WithEvents lbDureeFormationSpecifique As System.Windows.Forms.Label
    Friend WithEvents lbUnites As System.Windows.Forms.Label
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents lbTypeProgramme As System.Windows.Forms.Label
    Friend WithEvents lbTypeSanction As System.Windows.Forms.Label
    Friend WithEvents lbTitreProgramme As System.Windows.Forms.Label
    Friend WithEvents lbCodeProgramme As System.Windows.Forms.Label
    Friend WithEvents PSELECTTypeSanctionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents PSELECTTypeProgrammeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_Type_SanctionTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Type_SanctionTableAdapter
    Friend WithEvents P_SELECT_Type_ProgrammeTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Type_ProgrammeTableAdapter
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnDetailsCompetence As System.Windows.Forms.Button
    Friend WithEvents btnValiderInfos As System.Windows.Forms.Button
    Friend WithEvents btnAnnulerInfos As System.Windows.Forms.Button
    Friend WithEvents btnModifierInfos As System.Windows.Forms.Button
    Friend WithEvents IdCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTCompetencesProgrammeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_Competences_ProgrammeTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Competences_ProgrammeTableAdapter
End Class
