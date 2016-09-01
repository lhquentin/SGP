<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDonneesDevis
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
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.lbProgramme = New System.Windows.Forms.Label()
        Me.lbCommentaire = New System.Windows.Forms.Label()
        Me.btnProfilDiplome = New System.Windows.Forms.Button()
        Me.btnEpreuveSynthese = New System.Windows.Forms.Button()
        Me.btnSanteSecurite = New System.Windows.Forms.Button()
        Me.chbOfficiel = New System.Windows.Forms.CheckBox()
        Me.txtCommentaire = New System.Windows.Forms.TextBox()
        Me.cbProgramme = New System.Windows.Forms.ComboBox()
        Me.PSELECTProgrammeListeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.gbInfoDevis = New System.Windows.Forms.GroupBox()
        Me.btnModifierInfos = New System.Windows.Forms.Button()
        Me.btnValiderInfos = New System.Windows.Forms.Button()
        Me.btnAnnulerInfos = New System.Windows.Forms.Button()
        Me.gbIntentions = New System.Windows.Forms.GroupBox()
        Me.dgvIntentions = New System.Windows.Forms.DataGridView()
        Me.IdINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTIntentionDevisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSupprimerIntention = New System.Windows.Forms.Button()
        Me.btnAjouterIntention = New System.Windows.Forms.Button()
        Me.gbCours = New System.Windows.Forms.GroupBox()
        Me.btnDetailsCours = New System.Windows.Forms.Button()
        Me.btnSupprimerCours = New System.Windows.Forms.Button()
        Me.btnAjouterCours = New System.Windows.Forms.Button()
        Me.dgvCours = New System.Windows.Forms.DataGridView()
        Me.IdCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTCoursDevisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.P_SELECT_Programme_ListeTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Programme_ListeTableAdapter()
        Me.P_SELECT_CoursDevisTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_CoursDevisTableAdapter()
        Me.P_SELECT_IntentionDevisTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_IntentionDevisTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PSELECTProgrammeListeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfoDevis.SuspendLayout()
        Me.gbIntentions.SuspendLayout()
        CType(Me.dgvIntentions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTIntentionDevisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCours.SuspendLayout()
        CType(Me.dgvCours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTCoursDevisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnValider, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAnnuler, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(952, 406)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnValider
        '
        Me.btnValider.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnValider.Location = New System.Drawing.Point(3, 3)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(67, 23)
        Me.btnValider.TabIndex = 0
        Me.btnValider.Text = "OK"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.Location = New System.Drawing.Point(76, 3)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(67, 23)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Annuler"
        '
        'lbProgramme
        '
        Me.lbProgramme.AutoSize = True
        Me.lbProgramme.Location = New System.Drawing.Point(6, 25)
        Me.lbProgramme.Name = "lbProgramme"
        Me.lbProgramme.Size = New System.Drawing.Size(66, 13)
        Me.lbProgramme.TabIndex = 1
        Me.lbProgramme.Text = "Programme :"
        '
        'lbCommentaire
        '
        Me.lbCommentaire.AutoSize = True
        Me.lbCommentaire.Location = New System.Drawing.Point(6, 135)
        Me.lbCommentaire.Name = "lbCommentaire"
        Me.lbCommentaire.Size = New System.Drawing.Size(79, 13)
        Me.lbCommentaire.TabIndex = 2
        Me.lbCommentaire.Text = "Commentaires :"
        '
        'btnProfilDiplome
        '
        Me.btnProfilDiplome.Location = New System.Drawing.Point(6, 70)
        Me.btnProfilDiplome.Name = "btnProfilDiplome"
        Me.btnProfilDiplome.Size = New System.Drawing.Size(103, 37)
        Me.btnProfilDiplome.TabIndex = 3
        Me.btnProfilDiplome.Text = "Profil du diplômé"
        Me.btnProfilDiplome.UseVisualStyleBackColor = True
        '
        'btnEpreuveSynthese
        '
        Me.btnEpreuveSynthese.Location = New System.Drawing.Point(197, 70)
        Me.btnEpreuveSynthese.Name = "btnEpreuveSynthese"
        Me.btnEpreuveSynthese.Size = New System.Drawing.Size(103, 37)
        Me.btnEpreuveSynthese.TabIndex = 4
        Me.btnEpreuveSynthese.Text = "Nature de l'épreuve synthèse"
        Me.btnEpreuveSynthese.UseVisualStyleBackColor = True
        '
        'btnSanteSecurite
        '
        Me.btnSanteSecurite.Location = New System.Drawing.Point(366, 70)
        Me.btnSanteSecurite.Name = "btnSanteSecurite"
        Me.btnSanteSecurite.Size = New System.Drawing.Size(128, 37)
        Me.btnSanteSecurite.TabIndex = 5
        Me.btnSanteSecurite.Text = "Santé et sécurité au travail"
        Me.btnSanteSecurite.UseVisualStyleBackColor = True
        '
        'chbOfficiel
        '
        Me.chbOfficiel.AutoSize = True
        Me.chbOfficiel.Location = New System.Drawing.Point(6, 162)
        Me.chbOfficiel.Name = "chbOfficiel"
        Me.chbOfficiel.Size = New System.Drawing.Size(86, 17)
        Me.chbOfficiel.TabIndex = 6
        Me.chbOfficiel.Text = "Devis officiel"
        Me.chbOfficiel.UseVisualStyleBackColor = True
        '
        'txtCommentaire
        '
        Me.txtCommentaire.Location = New System.Drawing.Point(91, 132)
        Me.txtCommentaire.Name = "txtCommentaire"
        Me.txtCommentaire.Size = New System.Drawing.Size(403, 20)
        Me.txtCommentaire.TabIndex = 7
        '
        'cbProgramme
        '
        Me.cbProgramme.DataSource = Me.PSELECTProgrammeListeBindingSource
        Me.cbProgramme.DisplayMember = "Programme"
        Me.cbProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProgramme.FormattingEnabled = True
        Me.cbProgramme.Location = New System.Drawing.Point(78, 22)
        Me.cbProgramme.Name = "cbProgramme"
        Me.cbProgramme.Size = New System.Drawing.Size(310, 21)
        Me.cbProgramme.TabIndex = 8
        Me.cbProgramme.ValueMember = "idPROGRAMME"
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
        'gbInfoDevis
        '
        Me.gbInfoDevis.Controls.Add(Me.btnModifierInfos)
        Me.gbInfoDevis.Controls.Add(Me.btnValiderInfos)
        Me.gbInfoDevis.Controls.Add(Me.btnAnnulerInfos)
        Me.gbInfoDevis.Controls.Add(Me.chbOfficiel)
        Me.gbInfoDevis.Controls.Add(Me.txtCommentaire)
        Me.gbInfoDevis.Controls.Add(Me.cbProgramme)
        Me.gbInfoDevis.Controls.Add(Me.lbProgramme)
        Me.gbInfoDevis.Controls.Add(Me.btnEpreuveSynthese)
        Me.gbInfoDevis.Controls.Add(Me.btnSanteSecurite)
        Me.gbInfoDevis.Controls.Add(Me.lbCommentaire)
        Me.gbInfoDevis.Controls.Add(Me.btnProfilDiplome)
        Me.gbInfoDevis.Location = New System.Drawing.Point(12, 12)
        Me.gbInfoDevis.Name = "gbInfoDevis"
        Me.gbInfoDevis.Size = New System.Drawing.Size(500, 233)
        Me.gbInfoDevis.TabIndex = 9
        Me.gbInfoDevis.TabStop = False
        Me.gbInfoDevis.Text = "Informations générales"
        '
        'btnModifierInfos
        '
        Me.btnModifierInfos.Location = New System.Drawing.Point(419, 204)
        Me.btnModifierInfos.Name = "btnModifierInfos"
        Me.btnModifierInfos.Size = New System.Drawing.Size(75, 23)
        Me.btnModifierInfos.TabIndex = 11
        Me.btnModifierInfos.Text = "Modifier"
        Me.btnModifierInfos.UseVisualStyleBackColor = True
        '
        'btnValiderInfos
        '
        Me.btnValiderInfos.Location = New System.Drawing.Point(257, 204)
        Me.btnValiderInfos.Name = "btnValiderInfos"
        Me.btnValiderInfos.Size = New System.Drawing.Size(75, 23)
        Me.btnValiderInfos.TabIndex = 10
        Me.btnValiderInfos.Text = "Valider"
        Me.btnValiderInfos.UseVisualStyleBackColor = True
        '
        'btnAnnulerInfos
        '
        Me.btnAnnulerInfos.Location = New System.Drawing.Point(338, 204)
        Me.btnAnnulerInfos.Name = "btnAnnulerInfos"
        Me.btnAnnulerInfos.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerInfos.TabIndex = 9
        Me.btnAnnulerInfos.Text = "Annuler"
        Me.btnAnnulerInfos.UseVisualStyleBackColor = True
        '
        'gbIntentions
        '
        Me.gbIntentions.Controls.Add(Me.dgvIntentions)
        Me.gbIntentions.Controls.Add(Me.btnSupprimerIntention)
        Me.gbIntentions.Controls.Add(Me.btnAjouterIntention)
        Me.gbIntentions.Location = New System.Drawing.Point(518, 12)
        Me.gbIntentions.Name = "gbIntentions"
        Me.gbIntentions.Size = New System.Drawing.Size(580, 185)
        Me.gbIntentions.TabIndex = 10
        Me.gbIntentions.TabStop = False
        Me.gbIntentions.Text = "Intentions Éducatives"
        '
        'dgvIntentions
        '
        Me.dgvIntentions.AllowUserToAddRows = False
        Me.dgvIntentions.AllowUserToDeleteRows = False
        Me.dgvIntentions.AllowUserToResizeColumns = False
        Me.dgvIntentions.AllowUserToResizeRows = False
        Me.dgvIntentions.AutoGenerateColumns = False
        Me.dgvIntentions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIntentions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdINTENTIONDataGridViewTextBoxColumn, Me.TitreINTENTIONDataGridViewTextBoxColumn})
        Me.dgvIntentions.DataSource = Me.PSELECTIntentionDevisBindingSource
        Me.dgvIntentions.Location = New System.Drawing.Point(6, 19)
        Me.dgvIntentions.MultiSelect = False
        Me.dgvIntentions.Name = "dgvIntentions"
        Me.dgvIntentions.ReadOnly = True
        Me.dgvIntentions.RowHeadersVisible = False
        Me.dgvIntentions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIntentions.Size = New System.Drawing.Size(487, 160)
        Me.dgvIntentions.TabIndex = 3
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
        Me.TitreINTENTIONDataGridViewTextBoxColumn.HeaderText = "Intentions Éducatives"
        Me.TitreINTENTIONDataGridViewTextBoxColumn.Name = "TitreINTENTIONDataGridViewTextBoxColumn"
        Me.TitreINTENTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTIntentionDevisBindingSource
        '
        Me.PSELECTIntentionDevisBindingSource.DataMember = "P_SELECT_IntentionDevis"
        Me.PSELECTIntentionDevisBindingSource.DataSource = Me.SGPDataSet
        '
        'btnSupprimerIntention
        '
        Me.btnSupprimerIntention.Location = New System.Drawing.Point(499, 48)
        Me.btnSupprimerIntention.Name = "btnSupprimerIntention"
        Me.btnSupprimerIntention.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerIntention.TabIndex = 2
        Me.btnSupprimerIntention.Text = "Supprimer"
        Me.btnSupprimerIntention.UseVisualStyleBackColor = True
        '
        'btnAjouterIntention
        '
        Me.btnAjouterIntention.Location = New System.Drawing.Point(499, 19)
        Me.btnAjouterIntention.Name = "btnAjouterIntention"
        Me.btnAjouterIntention.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterIntention.TabIndex = 1
        Me.btnAjouterIntention.Text = "Ajouter"
        Me.btnAjouterIntention.UseVisualStyleBackColor = True
        '
        'gbCours
        '
        Me.gbCours.Controls.Add(Me.btnDetailsCours)
        Me.gbCours.Controls.Add(Me.btnSupprimerCours)
        Me.gbCours.Controls.Add(Me.btnAjouterCours)
        Me.gbCours.Controls.Add(Me.dgvCours)
        Me.gbCours.Location = New System.Drawing.Point(518, 203)
        Me.gbCours.Name = "gbCours"
        Me.gbCours.Size = New System.Drawing.Size(580, 185)
        Me.gbCours.TabIndex = 11
        Me.gbCours.TabStop = False
        Me.gbCours.Text = "Cours"
        '
        'btnDetailsCours
        '
        Me.btnDetailsCours.Location = New System.Drawing.Point(499, 77)
        Me.btnDetailsCours.Name = "btnDetailsCours"
        Me.btnDetailsCours.Size = New System.Drawing.Size(75, 23)
        Me.btnDetailsCours.TabIndex = 3
        Me.btnDetailsCours.Text = "Détails"
        Me.btnDetailsCours.UseVisualStyleBackColor = True
        '
        'btnSupprimerCours
        '
        Me.btnSupprimerCours.Location = New System.Drawing.Point(499, 48)
        Me.btnSupprimerCours.Name = "btnSupprimerCours"
        Me.btnSupprimerCours.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerCours.TabIndex = 2
        Me.btnSupprimerCours.Text = "Supprimer"
        Me.btnSupprimerCours.UseVisualStyleBackColor = True
        '
        'btnAjouterCours
        '
        Me.btnAjouterCours.Location = New System.Drawing.Point(499, 19)
        Me.btnAjouterCours.Name = "btnAjouterCours"
        Me.btnAjouterCours.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouterCours.TabIndex = 1
        Me.btnAjouterCours.Text = "Ajouter"
        Me.btnAjouterCours.UseVisualStyleBackColor = True
        '
        'dgvCours
        '
        Me.dgvCours.AllowUserToAddRows = False
        Me.dgvCours.AllowUserToDeleteRows = False
        Me.dgvCours.AllowUserToResizeColumns = False
        Me.dgvCours.AllowUserToResizeRows = False
        Me.dgvCours.AutoGenerateColumns = False
        Me.dgvCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCOURSDataGridViewTextBoxColumn, Me.CodeCOURSDataGridViewTextBoxColumn, Me.TitreCOURSDataGridViewTextBoxColumn})
        Me.dgvCours.DataSource = Me.PSELECTCoursDevisBindingSource
        Me.dgvCours.Location = New System.Drawing.Point(6, 19)
        Me.dgvCours.MultiSelect = False
        Me.dgvCours.Name = "dgvCours"
        Me.dgvCours.ReadOnly = True
        Me.dgvCours.RowHeadersVisible = False
        Me.dgvCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCours.Size = New System.Drawing.Size(487, 160)
        Me.dgvCours.TabIndex = 0
        '
        'IdCOURSDataGridViewTextBoxColumn
        '
        Me.IdCOURSDataGridViewTextBoxColumn.DataPropertyName = "idCOURS"
        Me.IdCOURSDataGridViewTextBoxColumn.HeaderText = "idCOURS"
        Me.IdCOURSDataGridViewTextBoxColumn.Name = "IdCOURSDataGridViewTextBoxColumn"
        Me.IdCOURSDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCOURSDataGridViewTextBoxColumn.Visible = False
        '
        'CodeCOURSDataGridViewTextBoxColumn
        '
        Me.CodeCOURSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodeCOURSDataGridViewTextBoxColumn.DataPropertyName = "codeCOURS"
        Me.CodeCOURSDataGridViewTextBoxColumn.FillWeight = 35.0!
        Me.CodeCOURSDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeCOURSDataGridViewTextBoxColumn.Name = "CodeCOURSDataGridViewTextBoxColumn"
        Me.CodeCOURSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitreCOURSDataGridViewTextBoxColumn
        '
        Me.TitreCOURSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitreCOURSDataGridViewTextBoxColumn.DataPropertyName = "titreCOURS"
        Me.TitreCOURSDataGridViewTextBoxColumn.HeaderText = "Cours"
        Me.TitreCOURSDataGridViewTextBoxColumn.Name = "TitreCOURSDataGridViewTextBoxColumn"
        Me.TitreCOURSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTCoursDevisBindingSource
        '
        Me.PSELECTCoursDevisBindingSource.DataMember = "P_SELECT_CoursDevis"
        Me.PSELECTCoursDevisBindingSource.DataSource = Me.SGPDataSet
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(871, 409)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 12
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'P_SELECT_Programme_ListeTableAdapter
        '
        Me.P_SELECT_Programme_ListeTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_CoursDevisTableAdapter
        '
        Me.P_SELECT_CoursDevisTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_IntentionDevisTableAdapter
        '
        Me.P_SELECT_IntentionDevisTableAdapter.ClearBeforeFill = True
        '
        'dlgDonneesDevis
        '
        Me.AcceptButton = Me.btnValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnuler
        Me.ClientSize = New System.Drawing.Size(1110, 447)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.gbCours)
        Me.Controls.Add(Me.gbIntentions)
        Me.Controls.Add(Me.gbInfoDevis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDonneesDevis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Données du devis"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PSELECTProgrammeListeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfoDevis.ResumeLayout(False)
        Me.gbInfoDevis.PerformLayout()
        Me.gbIntentions.ResumeLayout(False)
        CType(Me.dgvIntentions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTIntentionDevisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCours.ResumeLayout(False)
        CType(Me.dgvCours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTCoursDevisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents lbProgramme As System.Windows.Forms.Label
    Friend WithEvents lbCommentaire As System.Windows.Forms.Label
    Friend WithEvents btnProfilDiplome As System.Windows.Forms.Button
    Friend WithEvents btnEpreuveSynthese As System.Windows.Forms.Button
    Friend WithEvents btnSanteSecurite As System.Windows.Forms.Button
    Friend WithEvents chbOfficiel As System.Windows.Forms.CheckBox
    Friend WithEvents txtCommentaire As System.Windows.Forms.TextBox
    Friend WithEvents cbProgramme As System.Windows.Forms.ComboBox
    Friend WithEvents gbInfoDevis As System.Windows.Forms.GroupBox
    Friend WithEvents gbIntentions As System.Windows.Forms.GroupBox
    Friend WithEvents gbCours As System.Windows.Forms.GroupBox
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents btnSupprimerIntention As System.Windows.Forms.Button
    Friend WithEvents btnAjouterIntention As System.Windows.Forms.Button
    Friend WithEvents btnSupprimerCours As System.Windows.Forms.Button
    Friend WithEvents btnAjouterCours As System.Windows.Forms.Button
    Friend WithEvents PSELECTProgrammeListeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_Programme_ListeTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Programme_ListeTableAdapter
    Public WithEvents dgvCours As System.Windows.Forms.DataGridView
    Friend WithEvents btnAnnulerInfos As System.Windows.Forms.Button
    Friend WithEvents btnModifierInfos As System.Windows.Forms.Button
    Friend WithEvents btnValiderInfos As System.Windows.Forms.Button
    Friend WithEvents PSELECTCoursDevisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_CoursDevisTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_CoursDevisTableAdapter
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents IdCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvIntentions As System.Windows.Forms.DataGridView
    Friend WithEvents IdINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTIntentionDevisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_IntentionDevisTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_IntentionDevisTableAdapter
    Friend WithEvents btnDetailsCours As System.Windows.Forms.Button

End Class
