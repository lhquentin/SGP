<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFormulaireCours
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
        Me.btnEnregistrerCours = New System.Windows.Forms.Button()
        Me.btnAnnulerCours = New System.Windows.Forms.Button()
        Me.gbFormation = New System.Windows.Forms.GroupBox()
        Me.nudSession = New System.Windows.Forms.NumericUpDown()
        Me.lbSessionCours = New System.Windows.Forms.Label()
        Me.txtTitreCours = New System.Windows.Forms.TextBox()
        Me.btnDescription = New System.Windows.Forms.Button()
        Me.txtCodeCours = New System.Windows.Forms.TextBox()
        Me.lbTitreCours = New System.Windows.Forms.Label()
        Me.lbCodeCours = New System.Windows.Forms.Label()
        Me.gbPondUniHor = New System.Windows.Forms.GroupBox()
        Me.lbHeuresValeur = New System.Windows.Forms.Label()
        Me.lbUnitesValeur = New System.Windows.Forms.Label()
        Me.lbHeures = New System.Windows.Forms.Label()
        Me.lbUnites = New System.Windows.Forms.Label()
        Me.nudPersonnel = New System.Windows.Forms.NumericUpDown()
        Me.lbPersonnel = New System.Windows.Forms.Label()
        Me.nudLaboratoire = New System.Windows.Forms.NumericUpDown()
        Me.lbLaboratoire = New System.Windows.Forms.Label()
        Me.nudTheorique = New System.Windows.Forms.NumericUpDown()
        Me.lbTheorique = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.gbActivite = New System.Windows.Forms.GroupBox()
        Me.btnAnnulerActivite = New System.Windows.Forms.Button()
        Me.btnEnregistrerActivite = New System.Windows.Forms.Button()
        Me.txtActivite = New System.Windows.Forms.TextBox()
        Me.lbActivite = New System.Windows.Forms.Label()
        Me.btnSupprimerActivite = New System.Windows.Forms.Button()
        Me.btnModifierActivite = New System.Windows.Forms.Button()
        Me.dgvActivite = New System.Windows.Forms.DataGridView()
        Me.IdACTIVITEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionACTIVITEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTActiviteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.gbIntention = New System.Windows.Forms.GroupBox()
        Me.btnEnleverIntention = New System.Windows.Forms.Button()
        Me.btnAjouterIntention = New System.Windows.Forms.Button()
        Me.dgvIntention = New System.Windows.Forms.DataGridView()
        Me.IdINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTIntentionCoursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbHabilete = New System.Windows.Forms.GroupBox()
        Me.btnEnleverHabilete = New System.Windows.Forms.Button()
        Me.btnAjouterHabilete = New System.Windows.Forms.Button()
        Me.dgvHabilete = New System.Windows.Forms.DataGridView()
        Me.IdHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSECTIONHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleHABILETEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTHabileteCoursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbElement = New System.Windows.Forms.GroupBox()
        Me.btnEnleverElement = New System.Windows.Forms.Button()
        Me.btnAjouterElement = New System.Windows.Forms.Button()
        Me.dgvElement = New System.Windows.Forms.DataGridView()
        Me.IdELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTElementCoursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbPrealable = New System.Windows.Forms.GroupBox()
        Me.btnModifierPrealable = New System.Windows.Forms.Button()
        Me.btnEnleverPrealable = New System.Windows.Forms.Button()
        Me.btnAjouterPrealable = New System.Windows.Forms.Button()
        Me.dgvPrealable = New System.Windows.Forms.DataGridView()
        Me.P_SELECT_ActiviteTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_ActiviteTableAdapter()
        Me.P_SELECT_IntentionCoursTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_IntentionCoursTableAdapter()
        Me.P_SELECT_ElementCoursTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_ElementCoursTableAdapter()
        Me.P_SELECT_HabileteCoursTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_HabileteCoursTableAdapter()
        Me.PSELECTPrealableCoursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_PrealableCoursTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_PrealableCoursTableAdapter()
        Me.IdCOURSREQUISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTypePrealableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbFormation.SuspendLayout()
        CType(Me.nudSession, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPondUniHor.SuspendLayout()
        CType(Me.nudPersonnel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLaboratoire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTheorique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbActivite.SuspendLayout()
        CType(Me.dgvActivite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTActiviteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbIntention.SuspendLayout()
        CType(Me.dgvIntention, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTIntentionCoursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHabilete.SuspendLayout()
        CType(Me.dgvHabilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTHabileteCoursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbElement.SuspendLayout()
        CType(Me.dgvElement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTElementCoursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPrealable.SuspendLayout()
        CType(Me.dgvPrealable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTPrealableCoursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEnregistrerCours, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAnnulerCours, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1017, 621)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(174, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnEnregistrerCours
        '
        Me.btnEnregistrerCours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnregistrerCours.Location = New System.Drawing.Point(3, 3)
        Me.btnEnregistrerCours.Name = "btnEnregistrerCours"
        Me.btnEnregistrerCours.Size = New System.Drawing.Size(94, 23)
        Me.btnEnregistrerCours.TabIndex = 0
        Me.btnEnregistrerCours.Text = "Enregistrer cours"
        '
        'btnAnnulerCours
        '
        Me.btnAnnulerCours.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnnulerCours.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulerCours.Location = New System.Drawing.Point(103, 3)
        Me.btnAnnulerCours.Name = "btnAnnulerCours"
        Me.btnAnnulerCours.Size = New System.Drawing.Size(67, 23)
        Me.btnAnnulerCours.TabIndex = 1
        Me.btnAnnulerCours.Text = "Annuler"
        '
        'gbFormation
        '
        Me.gbFormation.Controls.Add(Me.nudSession)
        Me.gbFormation.Controls.Add(Me.lbSessionCours)
        Me.gbFormation.Controls.Add(Me.txtTitreCours)
        Me.gbFormation.Controls.Add(Me.btnDescription)
        Me.gbFormation.Controls.Add(Me.txtCodeCours)
        Me.gbFormation.Controls.Add(Me.lbTitreCours)
        Me.gbFormation.Controls.Add(Me.lbCodeCours)
        Me.gbFormation.Location = New System.Drawing.Point(3, 1)
        Me.gbFormation.Name = "gbFormation"
        Me.gbFormation.Size = New System.Drawing.Size(591, 80)
        Me.gbFormation.TabIndex = 1
        Me.gbFormation.TabStop = False
        Me.gbFormation.Text = "Formation"
        '
        'nudSession
        '
        Me.nudSession.Location = New System.Drawing.Point(66, 51)
        Me.nudSession.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudSession.Name = "nudSession"
        Me.nudSession.Size = New System.Drawing.Size(29, 20)
        Me.nudSession.TabIndex = 5
        '
        'lbSessionCours
        '
        Me.lbSessionCours.AutoSize = True
        Me.lbSessionCours.Location = New System.Drawing.Point(13, 53)
        Me.lbSessionCours.Name = "lbSessionCours"
        Me.lbSessionCours.Size = New System.Drawing.Size(47, 13)
        Me.lbSessionCours.TabIndex = 4
        Me.lbSessionCours.Text = "Session:"
        '
        'txtTitreCours
        '
        Me.txtTitreCours.Location = New System.Drawing.Point(296, 17)
        Me.txtTitreCours.Name = "txtTitreCours"
        Me.txtTitreCours.Size = New System.Drawing.Size(289, 20)
        Me.txtTitreCours.TabIndex = 3
        '
        'btnDescription
        '
        Me.btnDescription.Location = New System.Drawing.Point(458, 48)
        Me.btnDescription.Name = "btnDescription"
        Me.btnDescription.Size = New System.Drawing.Size(127, 23)
        Me.btnDescription.TabIndex = 3
        Me.btnDescription.Text = "Description du cours"
        Me.btnDescription.UseVisualStyleBackColor = True
        '
        'txtCodeCours
        '
        Me.txtCodeCours.Location = New System.Drawing.Point(95, 17)
        Me.txtCodeCours.Name = "txtCodeCours"
        Me.txtCodeCours.Size = New System.Drawing.Size(100, 20)
        Me.txtCodeCours.TabIndex = 2
        '
        'lbTitreCours
        '
        Me.lbTitreCours.AutoSize = True
        Me.lbTitreCours.Location = New System.Drawing.Point(211, 20)
        Me.lbTitreCours.Name = "lbTitreCours"
        Me.lbTitreCours.Size = New System.Drawing.Size(75, 13)
        Me.lbTitreCours.TabIndex = 1
        Me.lbTitreCours.Text = "Titre du cours:"
        '
        'lbCodeCours
        '
        Me.lbCodeCours.AutoSize = True
        Me.lbCodeCours.Location = New System.Drawing.Point(10, 20)
        Me.lbCodeCours.Name = "lbCodeCours"
        Me.lbCodeCours.Size = New System.Drawing.Size(79, 13)
        Me.lbCodeCours.TabIndex = 0
        Me.lbCodeCours.Text = "Code du cours:"
        '
        'gbPondUniHor
        '
        Me.gbPondUniHor.Controls.Add(Me.lbHeuresValeur)
        Me.gbPondUniHor.Controls.Add(Me.lbUnitesValeur)
        Me.gbPondUniHor.Controls.Add(Me.lbHeures)
        Me.gbPondUniHor.Controls.Add(Me.lbUnites)
        Me.gbPondUniHor.Controls.Add(Me.nudPersonnel)
        Me.gbPondUniHor.Controls.Add(Me.lbPersonnel)
        Me.gbPondUniHor.Controls.Add(Me.nudLaboratoire)
        Me.gbPondUniHor.Controls.Add(Me.lbLaboratoire)
        Me.gbPondUniHor.Controls.Add(Me.nudTheorique)
        Me.gbPondUniHor.Controls.Add(Me.lbTheorique)
        Me.gbPondUniHor.Location = New System.Drawing.Point(3, 87)
        Me.gbPondUniHor.Name = "gbPondUniHor"
        Me.gbPondUniHor.Size = New System.Drawing.Size(591, 47)
        Me.gbPondUniHor.TabIndex = 2
        Me.gbPondUniHor.TabStop = False
        Me.gbPondUniHor.Text = "Pondérations / Unités / Heures"
        '
        'lbHeuresValeur
        '
        Me.lbHeuresValeur.AutoSize = True
        Me.lbHeuresValeur.Location = New System.Drawing.Point(543, 20)
        Me.lbHeuresValeur.Name = "lbHeuresValeur"
        Me.lbHeuresValeur.Size = New System.Drawing.Size(13, 13)
        Me.lbHeuresValeur.TabIndex = 10
        Me.lbHeuresValeur.Text = "0"
        '
        'lbUnitesValeur
        '
        Me.lbUnitesValeur.AutoSize = True
        Me.lbUnitesValeur.Location = New System.Drawing.Point(357, 20)
        Me.lbUnitesValeur.Name = "lbUnitesValeur"
        Me.lbUnitesValeur.Size = New System.Drawing.Size(13, 13)
        Me.lbUnitesValeur.TabIndex = 9
        Me.lbUnitesValeur.Text = "0"
        '
        'lbHeures
        '
        Me.lbHeures.AutoSize = True
        Me.lbHeures.Location = New System.Drawing.Point(454, 20)
        Me.lbHeures.Name = "lbHeures"
        Me.lbHeures.Size = New System.Drawing.Size(83, 13)
        Me.lbHeures.TabIndex = 8
        Me.lbHeures.Text = "Heures contact:"
        '
        'lbUnites
        '
        Me.lbUnites.AutoSize = True
        Me.lbUnites.Location = New System.Drawing.Point(311, 20)
        Me.lbUnites.Name = "lbUnites"
        Me.lbUnites.Size = New System.Drawing.Size(40, 13)
        Me.lbUnites.TabIndex = 6
        Me.lbUnites.Text = "Unités:"
        '
        'nudPersonnel
        '
        Me.nudPersonnel.Location = New System.Drawing.Point(240, 18)
        Me.nudPersonnel.Name = "nudPersonnel"
        Me.nudPersonnel.Size = New System.Drawing.Size(29, 20)
        Me.nudPersonnel.TabIndex = 5
        '
        'lbPersonnel
        '
        Me.lbPersonnel.AutoSize = True
        Me.lbPersonnel.Location = New System.Drawing.Point(186, 20)
        Me.lbPersonnel.Name = "lbPersonnel"
        Me.lbPersonnel.Size = New System.Drawing.Size(57, 13)
        Me.lbPersonnel.TabIndex = 4
        Me.lbPersonnel.Text = "Personnel:"
        '
        'nudLaboratoire
        '
        Me.nudLaboratoire.Location = New System.Drawing.Point(154, 18)
        Me.nudLaboratoire.Name = "nudLaboratoire"
        Me.nudLaboratoire.Size = New System.Drawing.Size(29, 20)
        Me.nudLaboratoire.TabIndex = 3
        '
        'lbLaboratoire
        '
        Me.lbLaboratoire.AutoSize = True
        Me.lbLaboratoire.Location = New System.Drawing.Point(94, 20)
        Me.lbLaboratoire.Name = "lbLaboratoire"
        Me.lbLaboratoire.Size = New System.Drawing.Size(63, 13)
        Me.lbLaboratoire.TabIndex = 2
        Me.lbLaboratoire.Text = "Laboratoire:"
        '
        'nudTheorique
        '
        Me.nudTheorique.Location = New System.Drawing.Point(62, 18)
        Me.nudTheorique.Name = "nudTheorique"
        Me.nudTheorique.Size = New System.Drawing.Size(29, 20)
        Me.nudTheorique.TabIndex = 1
        '
        'lbTheorique
        '
        Me.lbTheorique.AutoSize = True
        Me.lbTheorique.Location = New System.Drawing.Point(7, 20)
        Me.lbTheorique.Name = "lbTheorique"
        Me.lbTheorique.Size = New System.Drawing.Size(58, 13)
        Me.lbTheorique.TabIndex = 0
        Me.lbTheorique.Text = "Théorique:"
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(355, 140)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 4
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(437, 140)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 5
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(518, 140)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 6
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'gbActivite
        '
        Me.gbActivite.Controls.Add(Me.btnAnnulerActivite)
        Me.gbActivite.Controls.Add(Me.btnEnregistrerActivite)
        Me.gbActivite.Controls.Add(Me.txtActivite)
        Me.gbActivite.Controls.Add(Me.lbActivite)
        Me.gbActivite.Controls.Add(Me.btnSupprimerActivite)
        Me.gbActivite.Controls.Add(Me.btnModifierActivite)
        Me.gbActivite.Controls.Add(Me.dgvActivite)
        Me.gbActivite.Location = New System.Drawing.Point(3, 162)
        Me.gbActivite.Name = "gbActivite"
        Me.gbActivite.Size = New System.Drawing.Size(591, 236)
        Me.gbActivite.TabIndex = 7
        Me.gbActivite.TabStop = False
        Me.gbActivite.Text = "Activités d'apprentissage"
        '
        'btnAnnulerActivite
        '
        Me.btnAnnulerActivite.Location = New System.Drawing.Point(510, 203)
        Me.btnAnnulerActivite.Name = "btnAnnulerActivite"
        Me.btnAnnulerActivite.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerActivite.TabIndex = 6
        Me.btnAnnulerActivite.Text = "Annuler"
        Me.btnAnnulerActivite.UseVisualStyleBackColor = True
        '
        'btnEnregistrerActivite
        '
        Me.btnEnregistrerActivite.Location = New System.Drawing.Point(510, 174)
        Me.btnEnregistrerActivite.Name = "btnEnregistrerActivite"
        Me.btnEnregistrerActivite.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerActivite.TabIndex = 5
        Me.btnEnregistrerActivite.Text = "Enregistrer"
        Me.btnEnregistrerActivite.UseVisualStyleBackColor = True
        '
        'txtActivite
        '
        Me.txtActivite.Location = New System.Drawing.Point(58, 176)
        Me.txtActivite.Multiline = True
        Me.txtActivite.Name = "txtActivite"
        Me.txtActivite.Size = New System.Drawing.Size(446, 54)
        Me.txtActivite.TabIndex = 4
        '
        'lbActivite
        '
        Me.lbActivite.AutoSize = True
        Me.lbActivite.Location = New System.Drawing.Point(7, 179)
        Me.lbActivite.Name = "lbActivite"
        Me.lbActivite.Size = New System.Drawing.Size(45, 13)
        Me.lbActivite.TabIndex = 3
        Me.lbActivite.Text = "Activité:"
        '
        'btnSupprimerActivite
        '
        Me.btnSupprimerActivite.Location = New System.Drawing.Point(510, 48)
        Me.btnSupprimerActivite.Name = "btnSupprimerActivite"
        Me.btnSupprimerActivite.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerActivite.TabIndex = 2
        Me.btnSupprimerActivite.Text = "Supprimer"
        Me.btnSupprimerActivite.UseVisualStyleBackColor = True
        '
        'btnModifierActivite
        '
        Me.btnModifierActivite.Location = New System.Drawing.Point(510, 19)
        Me.btnModifierActivite.Name = "btnModifierActivite"
        Me.btnModifierActivite.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierActivite.TabIndex = 1
        Me.btnModifierActivite.Text = "Modifier"
        Me.btnModifierActivite.UseVisualStyleBackColor = True
        '
        'dgvActivite
        '
        Me.dgvActivite.AllowUserToAddRows = False
        Me.dgvActivite.AllowUserToDeleteRows = False
        Me.dgvActivite.AllowUserToResizeColumns = False
        Me.dgvActivite.AllowUserToResizeRows = False
        Me.dgvActivite.AutoGenerateColumns = False
        Me.dgvActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivite.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdACTIVITEDataGridViewTextBoxColumn, Me.DescriptionACTIVITEDataGridViewTextBoxColumn})
        Me.dgvActivite.DataSource = Me.PSELECTActiviteBindingSource
        Me.dgvActivite.Location = New System.Drawing.Point(3, 19)
        Me.dgvActivite.MultiSelect = False
        Me.dgvActivite.Name = "dgvActivite"
        Me.dgvActivite.ReadOnly = True
        Me.dgvActivite.RowHeadersVisible = False
        Me.dgvActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivite.Size = New System.Drawing.Size(501, 150)
        Me.dgvActivite.TabIndex = 0
        '
        'IdACTIVITEDataGridViewTextBoxColumn
        '
        Me.IdACTIVITEDataGridViewTextBoxColumn.DataPropertyName = "idACTIVITE"
        Me.IdACTIVITEDataGridViewTextBoxColumn.HeaderText = "idACTIVITE"
        Me.IdACTIVITEDataGridViewTextBoxColumn.Name = "IdACTIVITEDataGridViewTextBoxColumn"
        Me.IdACTIVITEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdACTIVITEDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionACTIVITEDataGridViewTextBoxColumn
        '
        Me.DescriptionACTIVITEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionACTIVITEDataGridViewTextBoxColumn.DataPropertyName = "descriptionACTIVITE"
        Me.DescriptionACTIVITEDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionACTIVITEDataGridViewTextBoxColumn.Name = "DescriptionACTIVITEDataGridViewTextBoxColumn"
        Me.DescriptionACTIVITEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTActiviteBindingSource
        '
        Me.PSELECTActiviteBindingSource.DataMember = "P_SELECT_Activite"
        Me.PSELECTActiviteBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbIntention
        '
        Me.gbIntention.Controls.Add(Me.btnEnleverIntention)
        Me.gbIntention.Controls.Add(Me.btnAjouterIntention)
        Me.gbIntention.Controls.Add(Me.dgvIntention)
        Me.gbIntention.Location = New System.Drawing.Point(3, 398)
        Me.gbIntention.Name = "gbIntention"
        Me.gbIntention.Size = New System.Drawing.Size(591, 220)
        Me.gbIntention.TabIndex = 8
        Me.gbIntention.TabStop = False
        Me.gbIntention.Text = "Intentions éducatives"
        '
        'btnEnleverIntention
        '
        Me.btnEnleverIntention.Location = New System.Drawing.Point(510, 48)
        Me.btnEnleverIntention.Name = "btnEnleverIntention"
        Me.btnEnleverIntention.Size = New System.Drawing.Size(75, 23)
        Me.btnEnleverIntention.TabIndex = 2
        Me.btnEnleverIntention.Text = "Enlever"
        Me.btnEnleverIntention.UseVisualStyleBackColor = True
        '
        'btnAjouterIntention
        '
        Me.btnAjouterIntention.Location = New System.Drawing.Point(510, 19)
        Me.btnAjouterIntention.Name = "btnAjouterIntention"
        Me.btnAjouterIntention.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterIntention.TabIndex = 1
        Me.btnAjouterIntention.Text = "Ajouter"
        Me.btnAjouterIntention.UseVisualStyleBackColor = True
        '
        'dgvIntention
        '
        Me.dgvIntention.AllowUserToAddRows = False
        Me.dgvIntention.AllowUserToDeleteRows = False
        Me.dgvIntention.AllowUserToResizeColumns = False
        Me.dgvIntention.AllowUserToResizeRows = False
        Me.dgvIntention.AutoGenerateColumns = False
        Me.dgvIntention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIntention.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdINTENTIONDataGridViewTextBoxColumn, Me.TitreINTENTIONDataGridViewTextBoxColumn})
        Me.dgvIntention.DataSource = Me.PSELECTIntentionCoursBindingSource
        Me.dgvIntention.Location = New System.Drawing.Point(3, 19)
        Me.dgvIntention.MultiSelect = False
        Me.dgvIntention.Name = "dgvIntention"
        Me.dgvIntention.ReadOnly = True
        Me.dgvIntention.RowHeadersVisible = False
        Me.dgvIntention.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIntention.Size = New System.Drawing.Size(501, 195)
        Me.dgvIntention.TabIndex = 0
        '
        'IdINTENTIONDataGridViewTextBoxColumn
        '
        Me.IdINTENTIONDataGridViewTextBoxColumn.DataPropertyName = "idINTENTION"
        Me.IdINTENTIONDataGridViewTextBoxColumn.HeaderText = "idINTENTION"
        Me.IdINTENTIONDataGridViewTextBoxColumn.Name = "IdINTENTIONDataGridViewTextBoxColumn"
        Me.IdINTENTIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdINTENTIONDataGridViewTextBoxColumn.Visible = False
        '
        'TitreINTENTIONDataGridViewTextBoxColumn
        '
        Me.TitreINTENTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitreINTENTIONDataGridViewTextBoxColumn.DataPropertyName = "titreINTENTION"
        Me.TitreINTENTIONDataGridViewTextBoxColumn.HeaderText = "Intention"
        Me.TitreINTENTIONDataGridViewTextBoxColumn.Name = "TitreINTENTIONDataGridViewTextBoxColumn"
        Me.TitreINTENTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTIntentionCoursBindingSource
        '
        Me.PSELECTIntentionCoursBindingSource.DataMember = "P_SELECT_IntentionCours"
        Me.PSELECTIntentionCoursBindingSource.DataSource = Me.SGPDataSet
        '
        'gbHabilete
        '
        Me.gbHabilete.Controls.Add(Me.btnEnleverHabilete)
        Me.gbHabilete.Controls.Add(Me.btnAjouterHabilete)
        Me.gbHabilete.Controls.Add(Me.dgvHabilete)
        Me.gbHabilete.Location = New System.Drawing.Point(600, 1)
        Me.gbHabilete.Name = "gbHabilete"
        Me.gbHabilete.Size = New System.Drawing.Size(591, 209)
        Me.gbHabilete.TabIndex = 9
        Me.gbHabilete.TabStop = False
        Me.gbHabilete.Text = "Habiletés du profil TIC"
        '
        'btnEnleverHabilete
        '
        Me.btnEnleverHabilete.Location = New System.Drawing.Point(512, 46)
        Me.btnEnleverHabilete.Name = "btnEnleverHabilete"
        Me.btnEnleverHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnEnleverHabilete.TabIndex = 2
        Me.btnEnleverHabilete.Text = "Enlever"
        Me.btnEnleverHabilete.UseVisualStyleBackColor = True
        '
        'btnAjouterHabilete
        '
        Me.btnAjouterHabilete.Location = New System.Drawing.Point(512, 17)
        Me.btnAjouterHabilete.Name = "btnAjouterHabilete"
        Me.btnAjouterHabilete.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterHabilete.TabIndex = 1
        Me.btnAjouterHabilete.Text = "Ajouter"
        Me.btnAjouterHabilete.UseVisualStyleBackColor = True
        '
        'dgvHabilete
        '
        Me.dgvHabilete.AllowUserToAddRows = False
        Me.dgvHabilete.AllowUserToDeleteRows = False
        Me.dgvHabilete.AllowUserToResizeColumns = False
        Me.dgvHabilete.AllowUserToResizeRows = False
        Me.dgvHabilete.AutoGenerateColumns = False
        Me.dgvHabilete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHabilete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHABILETEDataGridViewTextBoxColumn, Me.IdSECTIONHABILETEDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn, Me.LibelleHABILETEDataGridViewTextBoxColumn})
        Me.dgvHabilete.DataSource = Me.PSELECTHabileteCoursBindingSource
        Me.dgvHabilete.Location = New System.Drawing.Point(6, 17)
        Me.dgvHabilete.MultiSelect = False
        Me.dgvHabilete.Name = "dgvHabilete"
        Me.dgvHabilete.ReadOnly = True
        Me.dgvHabilete.RowHeadersVisible = False
        Me.dgvHabilete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHabilete.Size = New System.Drawing.Size(500, 187)
        Me.dgvHabilete.TabIndex = 0
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
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeDataGridViewTextBoxColumn.Width = 57
        '
        'LibelleHABILETEDataGridViewTextBoxColumn
        '
        Me.LibelleHABILETEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleHABILETEDataGridViewTextBoxColumn.DataPropertyName = "libelleHABILETE"
        Me.LibelleHABILETEDataGridViewTextBoxColumn.HeaderText = "Libellé"
        Me.LibelleHABILETEDataGridViewTextBoxColumn.Name = "LibelleHABILETEDataGridViewTextBoxColumn"
        Me.LibelleHABILETEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTHabileteCoursBindingSource
        '
        Me.PSELECTHabileteCoursBindingSource.DataMember = "P_SELECT_HabileteCours"
        Me.PSELECTHabileteCoursBindingSource.DataSource = Me.SGPDataSet
        '
        'gbElement
        '
        Me.gbElement.Controls.Add(Me.btnEnleverElement)
        Me.gbElement.Controls.Add(Me.btnAjouterElement)
        Me.gbElement.Controls.Add(Me.dgvElement)
        Me.gbElement.Location = New System.Drawing.Point(600, 211)
        Me.gbElement.Name = "gbElement"
        Me.gbElement.Size = New System.Drawing.Size(591, 217)
        Me.gbElement.TabIndex = 10
        Me.gbElement.TabStop = False
        Me.gbElement.Text = "Éléments de compétence"
        '
        'btnEnleverElement
        '
        Me.btnEnleverElement.Location = New System.Drawing.Point(512, 48)
        Me.btnEnleverElement.Name = "btnEnleverElement"
        Me.btnEnleverElement.Size = New System.Drawing.Size(75, 23)
        Me.btnEnleverElement.TabIndex = 2
        Me.btnEnleverElement.Text = "Enlever"
        Me.btnEnleverElement.UseVisualStyleBackColor = True
        '
        'btnAjouterElement
        '
        Me.btnAjouterElement.Location = New System.Drawing.Point(512, 19)
        Me.btnAjouterElement.Name = "btnAjouterElement"
        Me.btnAjouterElement.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterElement.TabIndex = 1
        Me.btnAjouterElement.Text = "Ajouter"
        Me.btnAjouterElement.UseVisualStyleBackColor = True
        '
        'dgvElement
        '
        Me.dgvElement.AllowUserToAddRows = False
        Me.dgvElement.AllowUserToDeleteRows = False
        Me.dgvElement.AllowUserToResizeColumns = False
        Me.dgvElement.AllowUserToResizeRows = False
        Me.dgvElement.AutoGenerateColumns = False
        Me.dgvElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdELEMENTDataGridViewTextBoxColumn, Me.CodeCOMPETENCEDataGridViewTextBoxColumn, Me.NumeroELEMENTDataGridViewTextBoxColumn, Me.LibelleELEMENTDataGridViewTextBoxColumn})
        Me.dgvElement.DataSource = Me.PSELECTElementCoursBindingSource
        Me.dgvElement.Location = New System.Drawing.Point(6, 18)
        Me.dgvElement.MultiSelect = False
        Me.dgvElement.Name = "dgvElement"
        Me.dgvElement.ReadOnly = True
        Me.dgvElement.RowHeadersVisible = False
        Me.dgvElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElement.Size = New System.Drawing.Size(500, 192)
        Me.dgvElement.TabIndex = 0
        '
        'IdELEMENTDataGridViewTextBoxColumn
        '
        Me.IdELEMENTDataGridViewTextBoxColumn.DataPropertyName = "idELEMENT"
        Me.IdELEMENTDataGridViewTextBoxColumn.HeaderText = "idELEMENT"
        Me.IdELEMENTDataGridViewTextBoxColumn.Name = "IdELEMENTDataGridViewTextBoxColumn"
        Me.IdELEMENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdELEMENTDataGridViewTextBoxColumn.Visible = False
        '
        'CodeCOMPETENCEDataGridViewTextBoxColumn
        '
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.DataPropertyName = "codeCOMPETENCE"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.HeaderText = "Compétence"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.Name = "CodeCOMPETENCEDataGridViewTextBoxColumn"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.Width = 92
        '
        'NumeroELEMENTDataGridViewTextBoxColumn
        '
        Me.NumeroELEMENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroELEMENTDataGridViewTextBoxColumn.DataPropertyName = "numeroELEMENT"
        Me.NumeroELEMENTDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumeroELEMENTDataGridViewTextBoxColumn.Name = "NumeroELEMENTDataGridViewTextBoxColumn"
        Me.NumeroELEMENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroELEMENTDataGridViewTextBoxColumn.Width = 69
        '
        'LibelleELEMENTDataGridViewTextBoxColumn
        '
        Me.LibelleELEMENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleELEMENTDataGridViewTextBoxColumn.DataPropertyName = "libelleELEMENT"
        Me.LibelleELEMENTDataGridViewTextBoxColumn.HeaderText = "Élément"
        Me.LibelleELEMENTDataGridViewTextBoxColumn.Name = "LibelleELEMENTDataGridViewTextBoxColumn"
        Me.LibelleELEMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTElementCoursBindingSource
        '
        Me.PSELECTElementCoursBindingSource.DataMember = "P_SELECT_ElementCours"
        Me.PSELECTElementCoursBindingSource.DataSource = Me.SGPDataSet
        '
        'gbPrealable
        '
        Me.gbPrealable.Controls.Add(Me.btnModifierPrealable)
        Me.gbPrealable.Controls.Add(Me.btnEnleverPrealable)
        Me.gbPrealable.Controls.Add(Me.btnAjouterPrealable)
        Me.gbPrealable.Controls.Add(Me.dgvPrealable)
        Me.gbPrealable.Location = New System.Drawing.Point(600, 427)
        Me.gbPrealable.Name = "gbPrealable"
        Me.gbPrealable.Size = New System.Drawing.Size(591, 191)
        Me.gbPrealable.TabIndex = 11
        Me.gbPrealable.TabStop = False
        Me.gbPrealable.Text = "Préalable"
        '
        'btnModifierPrealable
        '
        Me.btnModifierPrealable.Location = New System.Drawing.Point(512, 77)
        Me.btnModifierPrealable.Name = "btnModifierPrealable"
        Me.btnModifierPrealable.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierPrealable.TabIndex = 3
        Me.btnModifierPrealable.Text = "Modifier"
        Me.btnModifierPrealable.UseVisualStyleBackColor = True
        '
        'btnEnleverPrealable
        '
        Me.btnEnleverPrealable.Location = New System.Drawing.Point(512, 48)
        Me.btnEnleverPrealable.Name = "btnEnleverPrealable"
        Me.btnEnleverPrealable.Size = New System.Drawing.Size(75, 23)
        Me.btnEnleverPrealable.TabIndex = 2
        Me.btnEnleverPrealable.Text = "Enlever"
        Me.btnEnleverPrealable.UseVisualStyleBackColor = True
        '
        'btnAjouterPrealable
        '
        Me.btnAjouterPrealable.Location = New System.Drawing.Point(512, 19)
        Me.btnAjouterPrealable.Name = "btnAjouterPrealable"
        Me.btnAjouterPrealable.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterPrealable.TabIndex = 1
        Me.btnAjouterPrealable.Text = "Ajouter"
        Me.btnAjouterPrealable.UseVisualStyleBackColor = True
        '
        'dgvPrealable
        '
        Me.dgvPrealable.AllowUserToAddRows = False
        Me.dgvPrealable.AllowUserToDeleteRows = False
        Me.dgvPrealable.AllowUserToResizeColumns = False
        Me.dgvPrealable.AllowUserToResizeRows = False
        Me.dgvPrealable.AutoGenerateColumns = False
        Me.dgvPrealable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrealable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCOURSREQUISDataGridViewTextBoxColumn, Me.CodeCOURSDataGridViewTextBoxColumn, Me.IdTypePrealableDataGridViewTextBoxColumn})
        Me.dgvPrealable.DataSource = Me.PSELECTPrealableCoursBindingSource
        Me.dgvPrealable.Location = New System.Drawing.Point(6, 19)
        Me.dgvPrealable.MultiSelect = False
        Me.dgvPrealable.Name = "dgvPrealable"
        Me.dgvPrealable.ReadOnly = True
        Me.dgvPrealable.RowHeadersVisible = False
        Me.dgvPrealable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrealable.Size = New System.Drawing.Size(500, 166)
        Me.dgvPrealable.TabIndex = 0
        '
        'P_SELECT_ActiviteTableAdapter
        '
        Me.P_SELECT_ActiviteTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_IntentionCoursTableAdapter
        '
        Me.P_SELECT_IntentionCoursTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_ElementCoursTableAdapter
        '
        Me.P_SELECT_ElementCoursTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_HabileteCoursTableAdapter
        '
        Me.P_SELECT_HabileteCoursTableAdapter.ClearBeforeFill = True
        '
        'PSELECTPrealableCoursBindingSource
        '
        Me.PSELECTPrealableCoursBindingSource.DataMember = "P_SELECT_PrealableCours"
        Me.PSELECTPrealableCoursBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_PrealableCoursTableAdapter
        '
        Me.P_SELECT_PrealableCoursTableAdapter.ClearBeforeFill = True
        '
        'IdCOURSREQUISDataGridViewTextBoxColumn
        '
        Me.IdCOURSREQUISDataGridViewTextBoxColumn.DataPropertyName = "idCOURS_REQUIS"
        Me.IdCOURSREQUISDataGridViewTextBoxColumn.HeaderText = "idCOURS_REQUIS"
        Me.IdCOURSREQUISDataGridViewTextBoxColumn.Name = "IdCOURSREQUISDataGridViewTextBoxColumn"
        Me.IdCOURSREQUISDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCOURSREQUISDataGridViewTextBoxColumn.Visible = False
        '
        'CodeCOURSDataGridViewTextBoxColumn
        '
        Me.CodeCOURSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodeCOURSDataGridViewTextBoxColumn.DataPropertyName = "codeCOURS"
        Me.CodeCOURSDataGridViewTextBoxColumn.HeaderText = "Cours"
        Me.CodeCOURSDataGridViewTextBoxColumn.Name = "CodeCOURSDataGridViewTextBoxColumn"
        Me.CodeCOURSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTypePrealableDataGridViewTextBoxColumn
        '
        Me.IdTypePrealableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdTypePrealableDataGridViewTextBoxColumn.DataPropertyName = "idTypePrealable"
        Me.IdTypePrealableDataGridViewTextBoxColumn.HeaderText = "Préalable"
        Me.IdTypePrealableDataGridViewTextBoxColumn.Name = "IdTypePrealableDataGridViewTextBoxColumn"
        Me.IdTypePrealableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dlgFormulaireCours
        '
        Me.AcceptButton = Me.btnEnregistrerCours
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnulerCours
        Me.ClientSize = New System.Drawing.Size(1194, 650)
        Me.Controls.Add(Me.gbPrealable)
        Me.Controls.Add(Me.gbElement)
        Me.Controls.Add(Me.gbHabilete)
        Me.Controls.Add(Me.gbIntention)
        Me.Controls.Add(Me.gbActivite)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.gbPondUniHor)
        Me.Controls.Add(Me.gbFormation)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFormulaireCours"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formulaire de cours"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbFormation.ResumeLayout(False)
        Me.gbFormation.PerformLayout()
        CType(Me.nudSession, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPondUniHor.ResumeLayout(False)
        Me.gbPondUniHor.PerformLayout()
        CType(Me.nudPersonnel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLaboratoire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTheorique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbActivite.ResumeLayout(False)
        Me.gbActivite.PerformLayout()
        CType(Me.dgvActivite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTActiviteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbIntention.ResumeLayout(False)
        CType(Me.dgvIntention, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTIntentionCoursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHabilete.ResumeLayout(False)
        CType(Me.dgvHabilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTHabileteCoursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbElement.ResumeLayout(False)
        CType(Me.dgvElement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTElementCoursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPrealable.ResumeLayout(False)
        CType(Me.dgvPrealable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTPrealableCoursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnEnregistrerCours As System.Windows.Forms.Button
    Friend WithEvents btnAnnulerCours As System.Windows.Forms.Button
    Friend WithEvents gbFormation As System.Windows.Forms.GroupBox
    Friend WithEvents nudSession As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbSessionCours As System.Windows.Forms.Label
    Friend WithEvents txtTitreCours As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeCours As System.Windows.Forms.TextBox
    Friend WithEvents lbTitreCours As System.Windows.Forms.Label
    Friend WithEvents lbCodeCours As System.Windows.Forms.Label
    Friend WithEvents gbPondUniHor As System.Windows.Forms.GroupBox
    Friend WithEvents lbHeures As System.Windows.Forms.Label
    Friend WithEvents lbUnites As System.Windows.Forms.Label
    Friend WithEvents nudPersonnel As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbPersonnel As System.Windows.Forms.Label
    Friend WithEvents nudLaboratoire As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbLaboratoire As System.Windows.Forms.Label
    Friend WithEvents nudTheorique As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbTheorique As System.Windows.Forms.Label
    Friend WithEvents btnDescription As System.Windows.Forms.Button
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents gbActivite As System.Windows.Forms.GroupBox
    Friend WithEvents dgvActivite As System.Windows.Forms.DataGridView
    Friend WithEvents txtActivite As System.Windows.Forms.TextBox
    Friend WithEvents lbActivite As System.Windows.Forms.Label
    Friend WithEvents btnSupprimerActivite As System.Windows.Forms.Button
    Friend WithEvents btnModifierActivite As System.Windows.Forms.Button
    Friend WithEvents btnAnnulerActivite As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrerActivite As System.Windows.Forms.Button
    Friend WithEvents gbIntention As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnleverIntention As System.Windows.Forms.Button
    Friend WithEvents btnAjouterIntention As System.Windows.Forms.Button
    Friend WithEvents dgvIntention As System.Windows.Forms.DataGridView
    Friend WithEvents gbHabilete As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHabilete As System.Windows.Forms.DataGridView
    Friend WithEvents btnEnleverHabilete As System.Windows.Forms.Button
    Friend WithEvents btnAjouterHabilete As System.Windows.Forms.Button
    Friend WithEvents gbElement As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnleverElement As System.Windows.Forms.Button
    Friend WithEvents btnAjouterElement As System.Windows.Forms.Button
    Friend WithEvents dgvElement As System.Windows.Forms.DataGridView
    Friend WithEvents gbPrealable As System.Windows.Forms.GroupBox
    Friend WithEvents btnModifierPrealable As System.Windows.Forms.Button
    Friend WithEvents btnEnleverPrealable As System.Windows.Forms.Button
    Friend WithEvents btnAjouterPrealable As System.Windows.Forms.Button
    Friend WithEvents dgvPrealable As System.Windows.Forms.DataGridView
    Friend WithEvents lbHeuresValeur As System.Windows.Forms.Label
    Friend WithEvents lbUnitesValeur As System.Windows.Forms.Label
    Friend WithEvents IdACTIVITEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionACTIVITEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTActiviteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents P_SELECT_ActiviteTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_ActiviteTableAdapter
    Friend WithEvents IdINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTIntentionCoursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_IntentionCoursTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_IntentionCoursTableAdapter
    Friend WithEvents IdELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTElementCoursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ElementCoursTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_ElementCoursTableAdapter
    Friend WithEvents P_SELECT_HabileteCoursTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_HabileteCoursTableAdapter
    Friend WithEvents PSELECTHabileteCoursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSECTIONHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleHABILETEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCOURSREQUISDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTypePrealableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTPrealableCoursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_PrealableCoursTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_PrealableCoursTableAdapter

End Class
