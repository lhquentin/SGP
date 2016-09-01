<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAjoutCompetence
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
        Me.gbListe = New System.Windows.Forms.GroupBox()
        Me.btnAjouterCompetence = New System.Windows.Forms.Button()
        Me.btnCreerCompetence = New System.Windows.Forms.Button()
        Me.dgvCompetences = New System.Windows.Forms.DataGridView()
        Me.IdCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTCompetencesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.gbRecherche = New System.Windows.Forms.GroupBox()
        Me.cbCodeProgramme = New System.Windows.Forms.ComboBox()
        Me.PSELECTCodeProgrammeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbCodeProgramme = New System.Windows.Forms.Label()
        Me.P_SELECT_CompetencesTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_CompetencesTableAdapter()
        Me.P_SELECT_CodeProgrammeTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_CodeProgrammeTableAdapter()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbListe.SuspendLayout()
        CType(Me.dgvCompetences, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTCompetencesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRecherche.SuspendLayout()
        CType(Me.PSELECTCodeProgrammeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbListe
        '
        Me.gbListe.Controls.Add(Me.btnAjouterCompetence)
        Me.gbListe.Controls.Add(Me.btnCreerCompetence)
        Me.gbListe.Controls.Add(Me.dgvCompetences)
        Me.gbListe.Location = New System.Drawing.Point(12, 69)
        Me.gbListe.Name = "gbListe"
        Me.gbListe.Size = New System.Drawing.Size(637, 264)
        Me.gbListe.TabIndex = 1
        Me.gbListe.TabStop = False
        Me.gbListe.Text = "Liste"
        '
        'btnAjouterCompetence
        '
        Me.btnAjouterCompetence.Location = New System.Drawing.Point(436, 48)
        Me.btnAjouterCompetence.Name = "btnAjouterCompetence"
        Me.btnAjouterCompetence.Size = New System.Drawing.Size(195, 23)
        Me.btnAjouterCompetence.TabIndex = 2
        Me.btnAjouterCompetence.Text = "Ajouter compétence(s) sélectionnée(s)"
        Me.btnAjouterCompetence.UseVisualStyleBackColor = True
        '
        'btnCreerCompetence
        '
        Me.btnCreerCompetence.Location = New System.Drawing.Point(436, 19)
        Me.btnCreerCompetence.Name = "btnCreerCompetence"
        Me.btnCreerCompetence.Size = New System.Drawing.Size(195, 23)
        Me.btnCreerCompetence.TabIndex = 1
        Me.btnCreerCompetence.Text = "Créer nouvelle compétence"
        Me.btnCreerCompetence.UseVisualStyleBackColor = True
        '
        'dgvCompetences
        '
        Me.dgvCompetences.AllowUserToAddRows = False
        Me.dgvCompetences.AllowUserToDeleteRows = False
        Me.dgvCompetences.AllowUserToOrderColumns = True
        Me.dgvCompetences.AllowUserToResizeColumns = False
        Me.dgvCompetences.AllowUserToResizeRows = False
        Me.dgvCompetences.AutoGenerateColumns = False
        Me.dgvCompetences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompetences.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCOMPETENCEDataGridViewTextBoxColumn, Me.CodeCOMPETENCEDataGridViewTextBoxColumn, Me.NomCOMPETENCEDataGridViewTextBoxColumn})
        Me.dgvCompetences.DataSource = Me.PSELECTCompetencesBindingSource
        Me.dgvCompetences.Location = New System.Drawing.Point(7, 20)
        Me.dgvCompetences.Name = "dgvCompetences"
        Me.dgvCompetences.ReadOnly = True
        Me.dgvCompetences.RowHeadersVisible = False
        Me.dgvCompetences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompetences.Size = New System.Drawing.Size(423, 238)
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
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.DataPropertyName = "codeCOMPETENCE"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.Name = "CodeCOMPETENCEDataGridViewTextBoxColumn"
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn.Width = 57
        '
        'NomCOMPETENCEDataGridViewTextBoxColumn
        '
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.DataPropertyName = "nomCOMPETENCE"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.HeaderText = "Compétence"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.Name = "NomCOMPETENCEDataGridViewTextBoxColumn"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTCompetencesBindingSource
        '
        Me.PSELECTCompetencesBindingSource.DataMember = "P_SELECT_Competences"
        Me.PSELECTCompetencesBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbRecherche
        '
        Me.gbRecherche.Controls.Add(Me.cbCodeProgramme)
        Me.gbRecherche.Controls.Add(Me.lbCodeProgramme)
        Me.gbRecherche.Location = New System.Drawing.Point(12, 12)
        Me.gbRecherche.Name = "gbRecherche"
        Me.gbRecherche.Size = New System.Drawing.Size(637, 50)
        Me.gbRecherche.TabIndex = 0
        Me.gbRecherche.TabStop = False
        Me.gbRecherche.Text = "Recherche"
        '
        'cbCodeProgramme
        '
        Me.cbCodeProgramme.DataSource = Me.PSELECTCodeProgrammeBindingSource
        Me.cbCodeProgramme.DisplayMember = "Programme"
        Me.cbCodeProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCodeProgramme.FormattingEnabled = True
        Me.cbCodeProgramme.Location = New System.Drawing.Point(118, 17)
        Me.cbCodeProgramme.Name = "cbCodeProgramme"
        Me.cbCodeProgramme.Size = New System.Drawing.Size(305, 21)
        Me.cbCodeProgramme.TabIndex = 1
        Me.cbCodeProgramme.ValueMember = "codePROGRAMME"
        '
        'PSELECTCodeProgrammeBindingSource
        '
        Me.PSELECTCodeProgrammeBindingSource.DataMember = "P_SELECT_CodeProgramme"
        Me.PSELECTCodeProgrammeBindingSource.DataSource = Me.SGPDataSet
        '
        'lbCodeProgramme
        '
        Me.lbCodeProgramme.AutoSize = True
        Me.lbCodeProgramme.Location = New System.Drawing.Point(7, 20)
        Me.lbCodeProgramme.Name = "lbCodeProgramme"
        Me.lbCodeProgramme.Size = New System.Drawing.Size(105, 13)
        Me.lbCodeProgramme.TabIndex = 0
        Me.lbCodeProgramme.Text = "Code du programme:"
        '
        'P_SELECT_CompetencesTableAdapter
        '
        Me.P_SELECT_CompetencesTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_CodeProgrammeTableAdapter
        '
        Me.P_SELECT_CodeProgrammeTableAdapter.ClearBeforeFill = True
        '
        'btnFermer
        '
        Me.btnFermer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFermer.Location = New System.Drawing.Point(5, 3)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(87, 23)
        Me.btnFermer.TabIndex = 0
        Me.btnFermer.Text = "Fermer"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnFermer, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(551, 339)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(98, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dlgAjoutCompetence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnFermer
        Me.ClientSize = New System.Drawing.Size(661, 380)
        Me.Controls.Add(Me.gbListe)
        Me.Controls.Add(Me.gbRecherche)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAjoutCompetence"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajout de compétence"
        Me.gbListe.ResumeLayout(False)
        CType(Me.dgvCompetences, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTCompetencesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRecherche.ResumeLayout(False)
        Me.gbRecherche.PerformLayout()
        CType(Me.PSELECTCodeProgrammeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbListe As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjouterCompetence As System.Windows.Forms.Button
    Friend WithEvents btnCreerCompetence As System.Windows.Forms.Button
    Friend WithEvents dgvCompetences As System.Windows.Forms.DataGridView
    Friend WithEvents gbRecherche As System.Windows.Forms.GroupBox
    Friend WithEvents cbCodeProgramme As System.Windows.Forms.ComboBox
    Friend WithEvents lbCodeProgramme As System.Windows.Forms.Label
    Friend WithEvents IdCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTCompetencesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents P_SELECT_CompetencesTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_CompetencesTableAdapter
    Friend WithEvents PSELECTCodeProgrammeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_CodeProgrammeTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_CodeProgrammeTableAdapter
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
