<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFormulaireCompetence
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
        Me.btnEnregistrerCompetence = New System.Windows.Forms.Button()
        Me.btnAnnulerCompetence = New System.Windows.Forms.Button()
        Me.gbInformations = New System.Windows.Forms.GroupBox()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.txtLibelleCompetence = New System.Windows.Forms.TextBox()
        Me.lbLibelleCompetence = New System.Windows.Forms.Label()
        Me.txtCodeCompetence = New System.Windows.Forms.TextBox()
        Me.lbCodeCompetence = New System.Windows.Forms.Label()
        Me.gbContexte = New System.Windows.Forms.GroupBox()
        Me.dgvContexte = New System.Windows.Forms.DataGridView()
        Me.btnAnnulerContexte = New System.Windows.Forms.Button()
        Me.btnEnregistrerContexte = New System.Windows.Forms.Button()
        Me.txtLibelleContexte = New System.Windows.Forms.TextBox()
        Me.lbLibelleContexte = New System.Windows.Forms.Label()
        Me.btnSupprimerContexte = New System.Windows.Forms.Button()
        Me.btnModifierContexte = New System.Windows.Forms.Button()
        Me.gbElement = New System.Windows.Forms.GroupBox()
        Me.btnDescendreElement = New System.Windows.Forms.Button()
        Me.btnMonterElement = New System.Windows.Forms.Button()
        Me.btnAnnulerElement = New System.Windows.Forms.Button()
        Me.btnEnregistrerElement = New System.Windows.Forms.Button()
        Me.btnSupprimerElement = New System.Windows.Forms.Button()
        Me.btnModifierElement = New System.Windows.Forms.Button()
        Me.txtLibelleElement = New System.Windows.Forms.TextBox()
        Me.lbLibelleElement = New System.Windows.Forms.Label()
        Me.dgvElement = New System.Windows.Forms.DataGridView()
        Me.gbCritere = New System.Windows.Forms.GroupBox()
        Me.btnAnnulerCritere = New System.Windows.Forms.Button()
        Me.btnEnregistrerCritere = New System.Windows.Forms.Button()
        Me.txtLibelleCritere = New System.Windows.Forms.TextBox()
        Me.lbLibelleCritere = New System.Windows.Forms.Label()
        Me.btnDescendreCritere = New System.Windows.Forms.Button()
        Me.btnMonterCritere = New System.Windows.Forms.Button()
        Me.btnSupprimerCritere = New System.Windows.Forms.Button()
        Me.btnModifierCritere = New System.Windows.Forms.Button()
        Me.dgvCritere = New System.Windows.Forms.DataGridView()
        Me.PSELECTCritereElementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.IdELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTElementCompetenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCONTEXTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleCONTEXTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTContexteCompetenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_ContexteCompetenceTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_ContexteCompetenceTableAdapter()
        Me.P_SELECT_ElementCompetenceTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_ElementCompetenceTableAdapter()
        Me.P_SELECT_CritereElementTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_CritereElementTableAdapter()
        Me.IdCRITEREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCRITEREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleCRITEREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idELEMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbInformations.SuspendLayout()
        Me.gbContexte.SuspendLayout()
        CType(Me.dgvContexte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbElement.SuspendLayout()
        CType(Me.dgvElement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCritere.SuspendLayout()
        CType(Me.dgvCritere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTCritereElementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTElementCompetenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTContexteCompetenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.90909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.09091!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEnregistrerCompetence, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAnnulerCompetence, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(985, 538)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(220, 29)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnEnregistrerCompetence
        '
        Me.btnEnregistrerCompetence.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnregistrerCompetence.Location = New System.Drawing.Point(3, 3)
        Me.btnEnregistrerCompetence.Name = "btnEnregistrerCompetence"
        Me.btnEnregistrerCompetence.Size = New System.Drawing.Size(127, 23)
        Me.btnEnregistrerCompetence.TabIndex = 0
        Me.btnEnregistrerCompetence.Text = "Enregistrer compétence"
        '
        'btnAnnulerCompetence
        '
        Me.btnAnnulerCompetence.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnnulerCompetence.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulerCompetence.Location = New System.Drawing.Point(138, 3)
        Me.btnAnnulerCompetence.Name = "btnAnnulerCompetence"
        Me.btnAnnulerCompetence.Size = New System.Drawing.Size(77, 23)
        Me.btnAnnulerCompetence.TabIndex = 1
        Me.btnAnnulerCompetence.Text = "Annuler"
        '
        'gbInformations
        '
        Me.gbInformations.Controls.Add(Me.btnAnnuler)
        Me.gbInformations.Controls.Add(Me.btnModifier)
        Me.gbInformations.Controls.Add(Me.btnValider)
        Me.gbInformations.Controls.Add(Me.txtLibelleCompetence)
        Me.gbInformations.Controls.Add(Me.lbLibelleCompetence)
        Me.gbInformations.Controls.Add(Me.txtCodeCompetence)
        Me.gbInformations.Controls.Add(Me.lbCodeCompetence)
        Me.gbInformations.Location = New System.Drawing.Point(4, 4)
        Me.gbInformations.Name = "gbInformations"
        Me.gbInformations.Size = New System.Drawing.Size(623, 109)
        Me.gbInformations.TabIndex = 0
        Me.gbInformations.TabStop = False
        Me.gbInformations.Text = "Informations"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(543, 69)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 6
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(543, 40)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 5
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(543, 10)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 4
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'txtLibelleCompetence
        '
        Me.txtLibelleCompetence.Location = New System.Drawing.Point(148, 50)
        Me.txtLibelleCompetence.Multiline = True
        Me.txtLibelleCompetence.Name = "txtLibelleCompetence"
        Me.txtLibelleCompetence.Size = New System.Drawing.Size(388, 44)
        Me.txtLibelleCompetence.TabIndex = 3
        '
        'lbLibelleCompetence
        '
        Me.lbLibelleCompetence.AutoSize = True
        Me.lbLibelleCompetence.Location = New System.Drawing.Point(7, 53)
        Me.lbLibelleCompetence.Name = "lbLibelleCompetence"
        Me.lbLibelleCompetence.Size = New System.Drawing.Size(135, 13)
        Me.lbLibelleCompetence.TabIndex = 2
        Me.lbLibelleCompetence.Text = "Énoncé de la compétence:"
        '
        'txtCodeCompetence
        '
        Me.txtCodeCompetence.Location = New System.Drawing.Point(133, 17)
        Me.txtCodeCompetence.Name = "txtCodeCompetence"
        Me.txtCodeCompetence.Size = New System.Drawing.Size(89, 20)
        Me.txtCodeCompetence.TabIndex = 1
        '
        'lbCodeCompetence
        '
        Me.lbCodeCompetence.AutoSize = True
        Me.lbCodeCompetence.Location = New System.Drawing.Point(7, 20)
        Me.lbCodeCompetence.Name = "lbCodeCompetence"
        Me.lbCodeCompetence.Size = New System.Drawing.Size(123, 13)
        Me.lbCodeCompetence.TabIndex = 0
        Me.lbCodeCompetence.Text = "Code de la compétence:"
        '
        'gbContexte
        '
        Me.gbContexte.Controls.Add(Me.dgvContexte)
        Me.gbContexte.Controls.Add(Me.btnAnnulerContexte)
        Me.gbContexte.Controls.Add(Me.btnEnregistrerContexte)
        Me.gbContexte.Controls.Add(Me.txtLibelleContexte)
        Me.gbContexte.Controls.Add(Me.lbLibelleContexte)
        Me.gbContexte.Controls.Add(Me.btnSupprimerContexte)
        Me.gbContexte.Controls.Add(Me.btnModifierContexte)
        Me.gbContexte.Location = New System.Drawing.Point(4, 119)
        Me.gbContexte.Name = "gbContexte"
        Me.gbContexte.Size = New System.Drawing.Size(623, 413)
        Me.gbContexte.TabIndex = 1
        Me.gbContexte.TabStop = False
        Me.gbContexte.Text = "Contexte de réalisation"
        '
        'dgvContexte
        '
        Me.dgvContexte.AllowUserToAddRows = False
        Me.dgvContexte.AllowUserToDeleteRows = False
        Me.dgvContexte.AllowUserToResizeColumns = False
        Me.dgvContexte.AllowUserToResizeRows = False
        Me.dgvContexte.AutoGenerateColumns = False
        Me.dgvContexte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContexte.ColumnHeadersVisible = False
        Me.dgvContexte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCONTEXTEDataGridViewTextBoxColumn, Me.LibelleCONTEXTEDataGridViewTextBoxColumn})
        Me.dgvContexte.DataSource = Me.PSELECTContexteCompetenceBindingSource
        Me.dgvContexte.Location = New System.Drawing.Point(7, 20)
        Me.dgvContexte.MultiSelect = False
        Me.dgvContexte.Name = "dgvContexte"
        Me.dgvContexte.ReadOnly = True
        Me.dgvContexte.RowHeadersVisible = False
        Me.dgvContexte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContexte.Size = New System.Drawing.Size(529, 327)
        Me.dgvContexte.TabIndex = 0
        '
        'btnAnnulerContexte
        '
        Me.btnAnnulerContexte.Location = New System.Drawing.Point(543, 382)
        Me.btnAnnulerContexte.Name = "btnAnnulerContexte"
        Me.btnAnnulerContexte.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerContexte.TabIndex = 6
        Me.btnAnnulerContexte.Text = "Annuler"
        Me.btnAnnulerContexte.UseVisualStyleBackColor = True
        '
        'btnEnregistrerContexte
        '
        Me.btnEnregistrerContexte.Location = New System.Drawing.Point(543, 353)
        Me.btnEnregistrerContexte.Name = "btnEnregistrerContexte"
        Me.btnEnregistrerContexte.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerContexte.TabIndex = 5
        Me.btnEnregistrerContexte.Text = "Enregistrer"
        Me.btnEnregistrerContexte.UseVisualStyleBackColor = True
        '
        'txtLibelleContexte
        '
        Me.txtLibelleContexte.Location = New System.Drawing.Point(66, 353)
        Me.txtLibelleContexte.Multiline = True
        Me.txtLibelleContexte.Name = "txtLibelleContexte"
        Me.txtLibelleContexte.Size = New System.Drawing.Size(470, 39)
        Me.txtLibelleContexte.TabIndex = 4
        '
        'lbLibelleContexte
        '
        Me.lbLibelleContexte.AutoSize = True
        Me.lbLibelleContexte.Location = New System.Drawing.Point(8, 356)
        Me.lbLibelleContexte.Name = "lbLibelleContexte"
        Me.lbLibelleContexte.Size = New System.Drawing.Size(52, 13)
        Me.lbLibelleContexte.TabIndex = 3
        Me.lbLibelleContexte.Text = "Contexte:"
        '
        'btnSupprimerContexte
        '
        Me.btnSupprimerContexte.Location = New System.Drawing.Point(543, 50)
        Me.btnSupprimerContexte.Name = "btnSupprimerContexte"
        Me.btnSupprimerContexte.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerContexte.TabIndex = 2
        Me.btnSupprimerContexte.Text = "Supprimer"
        Me.btnSupprimerContexte.UseVisualStyleBackColor = True
        '
        'btnModifierContexte
        '
        Me.btnModifierContexte.Location = New System.Drawing.Point(543, 20)
        Me.btnModifierContexte.Name = "btnModifierContexte"
        Me.btnModifierContexte.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierContexte.TabIndex = 1
        Me.btnModifierContexte.Text = "Modifier"
        Me.btnModifierContexte.UseVisualStyleBackColor = True
        '
        'gbElement
        '
        Me.gbElement.Controls.Add(Me.btnDescendreElement)
        Me.gbElement.Controls.Add(Me.btnMonterElement)
        Me.gbElement.Controls.Add(Me.btnAnnulerElement)
        Me.gbElement.Controls.Add(Me.btnEnregistrerElement)
        Me.gbElement.Controls.Add(Me.btnSupprimerElement)
        Me.gbElement.Controls.Add(Me.btnModifierElement)
        Me.gbElement.Controls.Add(Me.txtLibelleElement)
        Me.gbElement.Controls.Add(Me.lbLibelleElement)
        Me.gbElement.Controls.Add(Me.dgvElement)
        Me.gbElement.Location = New System.Drawing.Point(633, 4)
        Me.gbElement.Name = "gbElement"
        Me.gbElement.Size = New System.Drawing.Size(581, 252)
        Me.gbElement.TabIndex = 2
        Me.gbElement.TabStop = False
        Me.gbElement.Text = "Élément de compétence"
        '
        'btnDescendreElement
        '
        Me.btnDescendreElement.Location = New System.Drawing.Point(502, 107)
        Me.btnDescendreElement.Name = "btnDescendreElement"
        Me.btnDescendreElement.Size = New System.Drawing.Size(75, 23)
        Me.btnDescendreElement.TabIndex = 4
        Me.btnDescendreElement.Text = "Descendre"
        Me.btnDescendreElement.UseVisualStyleBackColor = True
        '
        'btnMonterElement
        '
        Me.btnMonterElement.Location = New System.Drawing.Point(502, 78)
        Me.btnMonterElement.Name = "btnMonterElement"
        Me.btnMonterElement.Size = New System.Drawing.Size(75, 23)
        Me.btnMonterElement.TabIndex = 3
        Me.btnMonterElement.Text = "Monter"
        Me.btnMonterElement.UseVisualStyleBackColor = True
        '
        'btnAnnulerElement
        '
        Me.btnAnnulerElement.AllowDrop = True
        Me.btnAnnulerElement.Location = New System.Drawing.Point(502, 223)
        Me.btnAnnulerElement.Name = "btnAnnulerElement"
        Me.btnAnnulerElement.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerElement.TabIndex = 8
        Me.btnAnnulerElement.Text = "Annuler"
        Me.btnAnnulerElement.UseVisualStyleBackColor = True
        '
        'btnEnregistrerElement
        '
        Me.btnEnregistrerElement.Location = New System.Drawing.Point(502, 194)
        Me.btnEnregistrerElement.Name = "btnEnregistrerElement"
        Me.btnEnregistrerElement.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerElement.TabIndex = 7
        Me.btnEnregistrerElement.Text = "Enregistrer"
        Me.btnEnregistrerElement.UseVisualStyleBackColor = True
        '
        'btnSupprimerElement
        '
        Me.btnSupprimerElement.Location = New System.Drawing.Point(502, 49)
        Me.btnSupprimerElement.Name = "btnSupprimerElement"
        Me.btnSupprimerElement.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerElement.TabIndex = 2
        Me.btnSupprimerElement.Text = "Supprimer"
        Me.btnSupprimerElement.UseVisualStyleBackColor = True
        '
        'btnModifierElement
        '
        Me.btnModifierElement.Location = New System.Drawing.Point(502, 20)
        Me.btnModifierElement.Name = "btnModifierElement"
        Me.btnModifierElement.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierElement.TabIndex = 1
        Me.btnModifierElement.Text = "Modifier"
        Me.btnModifierElement.UseVisualStyleBackColor = True
        '
        'txtLibelleElement
        '
        Me.txtLibelleElement.Location = New System.Drawing.Point(64, 194)
        Me.txtLibelleElement.Multiline = True
        Me.txtLibelleElement.Name = "txtLibelleElement"
        Me.txtLibelleElement.Size = New System.Drawing.Size(432, 52)
        Me.txtLibelleElement.TabIndex = 6
        '
        'lbLibelleElement
        '
        Me.lbLibelleElement.AutoSize = True
        Me.lbLibelleElement.Location = New System.Drawing.Point(10, 194)
        Me.lbLibelleElement.Name = "lbLibelleElement"
        Me.lbLibelleElement.Size = New System.Drawing.Size(48, 13)
        Me.lbLibelleElement.TabIndex = 5
        Me.lbLibelleElement.Text = "Élément:"
        '
        'dgvElement
        '
        Me.dgvElement.AllowUserToAddRows = False
        Me.dgvElement.AllowUserToDeleteRows = False
        Me.dgvElement.AllowUserToResizeColumns = False
        Me.dgvElement.AllowUserToResizeRows = False
        Me.dgvElement.AutoGenerateColumns = False
        Me.dgvElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdELEMENTDataGridViewTextBoxColumn, Me.NumeroELEMENTDataGridViewTextBoxColumn, Me.LibelleELEMENTDataGridViewTextBoxColumn})
        Me.dgvElement.DataSource = Me.PSELECTElementCompetenceBindingSource
        Me.dgvElement.Location = New System.Drawing.Point(7, 19)
        Me.dgvElement.MultiSelect = False
        Me.dgvElement.Name = "dgvElement"
        Me.dgvElement.ReadOnly = True
        Me.dgvElement.RowHeadersVisible = False
        Me.dgvElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElement.Size = New System.Drawing.Size(489, 169)
        Me.dgvElement.TabIndex = 0
        '
        'gbCritere
        '
        Me.gbCritere.Controls.Add(Me.btnAnnulerCritere)
        Me.gbCritere.Controls.Add(Me.btnEnregistrerCritere)
        Me.gbCritere.Controls.Add(Me.txtLibelleCritere)
        Me.gbCritere.Controls.Add(Me.lbLibelleCritere)
        Me.gbCritere.Controls.Add(Me.btnDescendreCritere)
        Me.gbCritere.Controls.Add(Me.btnMonterCritere)
        Me.gbCritere.Controls.Add(Me.btnSupprimerCritere)
        Me.gbCritere.Controls.Add(Me.btnModifierCritere)
        Me.gbCritere.Controls.Add(Me.dgvCritere)
        Me.gbCritere.Location = New System.Drawing.Point(633, 262)
        Me.gbCritere.Name = "gbCritere"
        Me.gbCritere.Size = New System.Drawing.Size(581, 270)
        Me.gbCritere.TabIndex = 3
        Me.gbCritere.TabStop = False
        Me.gbCritere.Text = "Critère de performance"
        '
        'btnAnnulerCritere
        '
        Me.btnAnnulerCritere.Location = New System.Drawing.Point(502, 241)
        Me.btnAnnulerCritere.Name = "btnAnnulerCritere"
        Me.btnAnnulerCritere.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerCritere.TabIndex = 8
        Me.btnAnnulerCritere.Text = "Annuler"
        Me.btnAnnulerCritere.UseVisualStyleBackColor = True
        '
        'btnEnregistrerCritere
        '
        Me.btnEnregistrerCritere.Location = New System.Drawing.Point(502, 212)
        Me.btnEnregistrerCritere.Name = "btnEnregistrerCritere"
        Me.btnEnregistrerCritere.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerCritere.TabIndex = 7
        Me.btnEnregistrerCritere.Text = "Enregistrer"
        Me.btnEnregistrerCritere.UseVisualStyleBackColor = True
        '
        'txtLibelleCritere
        '
        Me.txtLibelleCritere.Location = New System.Drawing.Point(56, 210)
        Me.txtLibelleCritere.Multiline = True
        Me.txtLibelleCritere.Name = "txtLibelleCritere"
        Me.txtLibelleCritere.Size = New System.Drawing.Size(440, 54)
        Me.txtLibelleCritere.TabIndex = 6
        '
        'lbLibelleCritere
        '
        Me.lbLibelleCritere.AutoSize = True
        Me.lbLibelleCritere.Location = New System.Drawing.Point(10, 212)
        Me.lbLibelleCritere.Name = "lbLibelleCritere"
        Me.lbLibelleCritere.Size = New System.Drawing.Size(40, 13)
        Me.lbLibelleCritere.TabIndex = 5
        Me.lbLibelleCritere.Text = "Critère:"
        '
        'btnDescendreCritere
        '
        Me.btnDescendreCritere.Location = New System.Drawing.Point(502, 106)
        Me.btnDescendreCritere.Name = "btnDescendreCritere"
        Me.btnDescendreCritere.Size = New System.Drawing.Size(75, 23)
        Me.btnDescendreCritere.TabIndex = 4
        Me.btnDescendreCritere.Text = "Descendre"
        Me.btnDescendreCritere.UseVisualStyleBackColor = True
        '
        'btnMonterCritere
        '
        Me.btnMonterCritere.Location = New System.Drawing.Point(502, 77)
        Me.btnMonterCritere.Name = "btnMonterCritere"
        Me.btnMonterCritere.Size = New System.Drawing.Size(75, 23)
        Me.btnMonterCritere.TabIndex = 3
        Me.btnMonterCritere.Text = "Monter"
        Me.btnMonterCritere.UseVisualStyleBackColor = True
        '
        'btnSupprimerCritere
        '
        Me.btnSupprimerCritere.Location = New System.Drawing.Point(502, 48)
        Me.btnSupprimerCritere.Name = "btnSupprimerCritere"
        Me.btnSupprimerCritere.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerCritere.TabIndex = 2
        Me.btnSupprimerCritere.Text = "Supprimer"
        Me.btnSupprimerCritere.UseVisualStyleBackColor = True
        '
        'btnModifierCritere
        '
        Me.btnModifierCritere.Location = New System.Drawing.Point(502, 19)
        Me.btnModifierCritere.Name = "btnModifierCritere"
        Me.btnModifierCritere.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierCritere.TabIndex = 1
        Me.btnModifierCritere.Text = "Modifier"
        Me.btnModifierCritere.UseVisualStyleBackColor = True
        '
        'dgvCritere
        '
        Me.dgvCritere.AllowUserToAddRows = False
        Me.dgvCritere.AllowUserToDeleteRows = False
        Me.dgvCritere.AllowUserToResizeColumns = False
        Me.dgvCritere.AllowUserToResizeRows = False
        Me.dgvCritere.AutoGenerateColumns = False
        Me.dgvCritere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCritere.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCRITEREDataGridViewTextBoxColumn, Me.NumeroCRITEREDataGridViewTextBoxColumn, Me.LibelleCRITEREDataGridViewTextBoxColumn, Me.idELEMENT})
        Me.dgvCritere.DataSource = Me.PSELECTCritereElementBindingSource
        Me.dgvCritere.Location = New System.Drawing.Point(7, 19)
        Me.dgvCritere.MultiSelect = False
        Me.dgvCritere.Name = "dgvCritere"
        Me.dgvCritere.ReadOnly = True
        Me.dgvCritere.RowHeadersVisible = False
        Me.dgvCritere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCritere.Size = New System.Drawing.Size(489, 185)
        Me.dgvCritere.TabIndex = 0
        '
        'PSELECTCritereElementBindingSource
        '
        Me.PSELECTCritereElementBindingSource.DataMember = "P_SELECT_CritereElement"
        Me.PSELECTCritereElementBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdELEMENTDataGridViewTextBoxColumn
        '
        Me.IdELEMENTDataGridViewTextBoxColumn.DataPropertyName = "idELEMENT"
        Me.IdELEMENTDataGridViewTextBoxColumn.HeaderText = "idELEMENT"
        Me.IdELEMENTDataGridViewTextBoxColumn.Name = "IdELEMENTDataGridViewTextBoxColumn"
        Me.IdELEMENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdELEMENTDataGridViewTextBoxColumn.Visible = False
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
        'PSELECTElementCompetenceBindingSource
        '
        Me.PSELECTElementCompetenceBindingSource.DataMember = "P_SELECT_ElementCompetence"
        Me.PSELECTElementCompetenceBindingSource.DataSource = Me.SGPDataSet
        '
        'IdCONTEXTEDataGridViewTextBoxColumn
        '
        Me.IdCONTEXTEDataGridViewTextBoxColumn.DataPropertyName = "idCONTEXTE"
        Me.IdCONTEXTEDataGridViewTextBoxColumn.HeaderText = "idCONTEXTE"
        Me.IdCONTEXTEDataGridViewTextBoxColumn.Name = "IdCONTEXTEDataGridViewTextBoxColumn"
        Me.IdCONTEXTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCONTEXTEDataGridViewTextBoxColumn.Visible = False
        '
        'LibelleCONTEXTEDataGridViewTextBoxColumn
        '
        Me.LibelleCONTEXTEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleCONTEXTEDataGridViewTextBoxColumn.DataPropertyName = "libelleCONTEXTE"
        Me.LibelleCONTEXTEDataGridViewTextBoxColumn.HeaderText = "Libelle"
        Me.LibelleCONTEXTEDataGridViewTextBoxColumn.Name = "LibelleCONTEXTEDataGridViewTextBoxColumn"
        Me.LibelleCONTEXTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTContexteCompetenceBindingSource
        '
        Me.PSELECTContexteCompetenceBindingSource.DataMember = "P_SELECT_ContexteCompetence"
        Me.PSELECTContexteCompetenceBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_ContexteCompetenceTableAdapter
        '
        Me.P_SELECT_ContexteCompetenceTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_ElementCompetenceTableAdapter
        '
        Me.P_SELECT_ElementCompetenceTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_CritereElementTableAdapter
        '
        Me.P_SELECT_CritereElementTableAdapter.ClearBeforeFill = True
        '
        'IdCRITEREDataGridViewTextBoxColumn
        '
        Me.IdCRITEREDataGridViewTextBoxColumn.DataPropertyName = "idCRITERE"
        Me.IdCRITEREDataGridViewTextBoxColumn.HeaderText = "idCRITERE"
        Me.IdCRITEREDataGridViewTextBoxColumn.Name = "IdCRITEREDataGridViewTextBoxColumn"
        Me.IdCRITEREDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCRITEREDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroCRITEREDataGridViewTextBoxColumn
        '
        Me.NumeroCRITEREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroCRITEREDataGridViewTextBoxColumn.DataPropertyName = "numeroCRITERE"
        Me.NumeroCRITEREDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumeroCRITEREDataGridViewTextBoxColumn.Name = "NumeroCRITEREDataGridViewTextBoxColumn"
        Me.NumeroCRITEREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroCRITEREDataGridViewTextBoxColumn.Width = 69
        '
        'LibelleCRITEREDataGridViewTextBoxColumn
        '
        Me.LibelleCRITEREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleCRITEREDataGridViewTextBoxColumn.DataPropertyName = "libelleCRITERE"
        Me.LibelleCRITEREDataGridViewTextBoxColumn.HeaderText = "Critère"
        Me.LibelleCRITEREDataGridViewTextBoxColumn.Name = "LibelleCRITEREDataGridViewTextBoxColumn"
        Me.LibelleCRITEREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'idELEMENT
        '
        Me.idELEMENT.DataPropertyName = "idELEMENT"
        Me.idELEMENT.HeaderText = "idELEMENT"
        Me.idELEMENT.Name = "idELEMENT"
        Me.idELEMENT.ReadOnly = True
        Me.idELEMENT.Visible = False
        '
        'dlgFormulaireCompetence
        '
        Me.AcceptButton = Me.btnEnregistrerCompetence
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnulerCompetence
        Me.ClientSize = New System.Drawing.Size(1217, 577)
        Me.Controls.Add(Me.gbCritere)
        Me.Controls.Add(Me.gbElement)
        Me.Controls.Add(Me.gbContexte)
        Me.Controls.Add(Me.gbInformations)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFormulaireCompetence"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Création de compétence"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbInformations.ResumeLayout(False)
        Me.gbInformations.PerformLayout()
        Me.gbContexte.ResumeLayout(False)
        Me.gbContexte.PerformLayout()
        CType(Me.dgvContexte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbElement.ResumeLayout(False)
        Me.gbElement.PerformLayout()
        CType(Me.dgvElement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCritere.ResumeLayout(False)
        Me.gbCritere.PerformLayout()
        CType(Me.dgvCritere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTCritereElementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTElementCompetenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTContexteCompetenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnEnregistrerCompetence As System.Windows.Forms.Button
    Friend WithEvents btnAnnulerCompetence As System.Windows.Forms.Button
    Friend WithEvents gbInformations As System.Windows.Forms.GroupBox
    Friend WithEvents lbCodeCompetence As System.Windows.Forms.Label
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents txtLibelleCompetence As System.Windows.Forms.TextBox
    Friend WithEvents lbLibelleCompetence As System.Windows.Forms.Label
    Friend WithEvents txtCodeCompetence As System.Windows.Forms.TextBox
    Friend WithEvents gbContexte As System.Windows.Forms.GroupBox
    Friend WithEvents PSELECTContexteCompetenceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents P_SELECT_ContexteCompetenceTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_ContexteCompetenceTableAdapter
    Friend WithEvents gbElement As System.Windows.Forms.GroupBox
    Friend WithEvents dgvElement As System.Windows.Forms.DataGridView
    Friend WithEvents gbCritere As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCritere As System.Windows.Forms.DataGridView
    Friend WithEvents btnAnnulerContexte As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrerContexte As System.Windows.Forms.Button
    Friend WithEvents txtLibelleContexte As System.Windows.Forms.TextBox
    Friend WithEvents lbLibelleContexte As System.Windows.Forms.Label
    Friend WithEvents btnSupprimerContexte As System.Windows.Forms.Button
    Friend WithEvents btnModifierContexte As System.Windows.Forms.Button
    Friend WithEvents dgvContexte As System.Windows.Forms.DataGridView
    Friend WithEvents IdCONTEXTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleCONTEXTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtLibelleElement As System.Windows.Forms.TextBox
    Friend WithEvents lbLibelleElement As System.Windows.Forms.Label
    Friend WithEvents PSELECTElementCompetenceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ElementCompetenceTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_ElementCompetenceTableAdapter
    Friend WithEvents btnAnnulerElement As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrerElement As System.Windows.Forms.Button
    Friend WithEvents btnSupprimerElement As System.Windows.Forms.Button
    Friend WithEvents btnModifierElement As System.Windows.Forms.Button
    Friend WithEvents btnDescendreElement As System.Windows.Forms.Button
    Friend WithEvents btnMonterElement As System.Windows.Forms.Button
    Friend WithEvents btnSupprimerCritere As System.Windows.Forms.Button
    Friend WithEvents btnModifierCritere As System.Windows.Forms.Button
    Friend WithEvents PSELECTCritereElementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_CritereElementTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_CritereElementTableAdapter
    Friend WithEvents btnAnnulerCritere As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrerCritere As System.Windows.Forms.Button
    Friend WithEvents txtLibelleCritere As System.Windows.Forms.TextBox
    Friend WithEvents lbLibelleCritere As System.Windows.Forms.Label
    Friend WithEvents btnDescendreCritere As System.Windows.Forms.Button
    Friend WithEvents btnMonterCritere As System.Windows.Forms.Button
    Friend WithEvents IdELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCRITEREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroCRITEREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleCRITEREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idELEMENT As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
