<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionProgrammes
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
        Me.PSELECTTypeProgrammeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.PSELECTTypeSanctionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_Type_SanctionTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Type_SanctionTableAdapter()
        Me.PSELECTProgrammesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_ProgrammesTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_ProgrammesTableAdapter()
        Me.P_SELECT_Type_ProgrammeTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Type_ProgrammeTableAdapter()
        Me.lbRechercheProgramme = New System.Windows.Forms.Label()
        Me.txtProgramme = New System.Windows.Forms.TextBox()
        Me.lbTypeSanction = New System.Windows.Forms.Label()
        Me.cbTypeSanction = New System.Windows.Forms.ComboBox()
        Me.lbTypeProgramme = New System.Windows.Forms.Label()
        Me.cbTypeProgramme = New System.Windows.Forms.ComboBox()
        Me.gbProgrammeRecherche = New System.Windows.Forms.GroupBox()
        Me.dgvProgrammes = New System.Windows.Forms.DataGridView()
        Me.IdPROGRAMMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodePROGRAMMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitrePROGRAMMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleTYPESANCTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCreerProgramme = New System.Windows.Forms.Button()
        Me.btnDetailsProgramme = New System.Windows.Forms.Button()
        Me.gbProgrammesResultats = New System.Windows.Forms.GroupBox()
        Me.P_SELECT_ProgrammeEnseignantTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Programme_EnseignantTableAdapter()
        Me.TableAdapterManager = New SGP.SGPDataSetTableAdapters.TableAdapterManager()
        CType(Me.PSELECTTypeProgrammeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTTypeSanctionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTProgrammesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProgrammeRecherche.SuspendLayout()
        CType(Me.dgvProgrammes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProgrammesResultats.SuspendLayout()
        Me.SuspendLayout()
        '
        'PSELECTTypeProgrammeBindingSource
        '
        Me.PSELECTTypeProgrammeBindingSource.DataMember = "P_SELECT_Type_Programme"
        Me.PSELECTTypeProgrammeBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PSELECTTypeSanctionBindingSource
        '
        Me.PSELECTTypeSanctionBindingSource.DataMember = "P_SELECT_Type_Sanction"
        Me.PSELECTTypeSanctionBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_Type_SanctionTableAdapter
        '
        Me.P_SELECT_Type_SanctionTableAdapter.ClearBeforeFill = True
        '
        'PSELECTProgrammesBindingSource
        '
        Me.PSELECTProgrammesBindingSource.DataMember = "P_SELECT_Programmes"
        Me.PSELECTProgrammesBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_ProgrammesTableAdapter
        '
        Me.P_SELECT_ProgrammesTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_Type_ProgrammeTableAdapter
        '
        Me.P_SELECT_Type_ProgrammeTableAdapter.ClearBeforeFill = True
        '
        'lbRechercheProgramme
        '
        Me.lbRechercheProgramme.AutoSize = True
        Me.lbRechercheProgramme.Location = New System.Drawing.Point(6, 22)
        Me.lbRechercheProgramme.Name = "lbRechercheProgramme"
        Me.lbRechercheProgramme.Size = New System.Drawing.Size(66, 13)
        Me.lbRechercheProgramme.TabIndex = 0
        Me.lbRechercheProgramme.Text = "Programme :"
        '
        'txtProgramme
        '
        Me.txtProgramme.Location = New System.Drawing.Point(78, 19)
        Me.txtProgramme.Name = "txtProgramme"
        Me.txtProgramme.Size = New System.Drawing.Size(223, 20)
        Me.txtProgramme.TabIndex = 1
        '
        'lbTypeSanction
        '
        Me.lbTypeSanction.AutoSize = True
        Me.lbTypeSanction.Location = New System.Drawing.Point(6, 50)
        Me.lbTypeSanction.Name = "lbTypeSanction"
        Me.lbTypeSanction.Size = New System.Drawing.Size(95, 13)
        Me.lbTypeSanction.TabIndex = 4
        Me.lbTypeSanction.Text = "Type de sanction :"
        '
        'cbTypeSanction
        '
        Me.cbTypeSanction.DataSource = Me.PSELECTTypeSanctionBindingSource
        Me.cbTypeSanction.DisplayMember = "libelleTYPE_SANCTION"
        Me.cbTypeSanction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeSanction.FormattingEnabled = True
        Me.cbTypeSanction.Location = New System.Drawing.Point(119, 47)
        Me.cbTypeSanction.Name = "cbTypeSanction"
        Me.cbTypeSanction.Size = New System.Drawing.Size(182, 21)
        Me.cbTypeSanction.TabIndex = 5
        Me.cbTypeSanction.ValueMember = "idTYPE_SANCTION"
        '
        'lbTypeProgramme
        '
        Me.lbTypeProgramme.AutoSize = True
        Me.lbTypeProgramme.Location = New System.Drawing.Point(6, 77)
        Me.lbTypeProgramme.Name = "lbTypeProgramme"
        Me.lbTypeProgramme.Size = New System.Drawing.Size(107, 13)
        Me.lbTypeProgramme.TabIndex = 6
        Me.lbTypeProgramme.Text = "Type de programme :"
        '
        'cbTypeProgramme
        '
        Me.cbTypeProgramme.DataSource = Me.PSELECTTypeProgrammeBindingSource
        Me.cbTypeProgramme.DisplayMember = "libelleTYPE_PROGRAMME"
        Me.cbTypeProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypeProgramme.FormattingEnabled = True
        Me.cbTypeProgramme.Location = New System.Drawing.Point(119, 74)
        Me.cbTypeProgramme.Name = "cbTypeProgramme"
        Me.cbTypeProgramme.Size = New System.Drawing.Size(182, 21)
        Me.cbTypeProgramme.TabIndex = 7
        Me.cbTypeProgramme.ValueMember = "idTYPE_PROGRAMME"
        '
        'gbProgrammeRecherche
        '
        Me.gbProgrammeRecherche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProgrammeRecherche.Controls.Add(Me.cbTypeProgramme)
        Me.gbProgrammeRecherche.Controls.Add(Me.lbTypeProgramme)
        Me.gbProgrammeRecherche.Controls.Add(Me.cbTypeSanction)
        Me.gbProgrammeRecherche.Controls.Add(Me.lbTypeSanction)
        Me.gbProgrammeRecherche.Controls.Add(Me.txtProgramme)
        Me.gbProgrammeRecherche.Controls.Add(Me.lbRechercheProgramme)
        Me.gbProgrammeRecherche.Location = New System.Drawing.Point(12, 12)
        Me.gbProgrammeRecherche.Name = "gbProgrammeRecherche"
        Me.gbProgrammeRecherche.Size = New System.Drawing.Size(721, 106)
        Me.gbProgrammeRecherche.TabIndex = 0
        Me.gbProgrammeRecherche.TabStop = False
        Me.gbProgrammeRecherche.Text = "Recherche"
        '
        'dgvProgrammes
        '
        Me.dgvProgrammes.AllowUserToAddRows = False
        Me.dgvProgrammes.AllowUserToDeleteRows = False
        Me.dgvProgrammes.AllowUserToOrderColumns = True
        Me.dgvProgrammes.AllowUserToResizeColumns = False
        Me.dgvProgrammes.AllowUserToResizeRows = False
        Me.dgvProgrammes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProgrammes.AutoGenerateColumns = False
        Me.dgvProgrammes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProgrammes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPROGRAMMEDataGridViewTextBoxColumn, Me.CodePROGRAMMEDataGridViewTextBoxColumn, Me.TitrePROGRAMMEDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn, Me.LibelleTYPESANCTIONDataGridViewTextBoxColumn, Me.LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn})
        Me.dgvProgrammes.DataSource = Me.PSELECTProgrammesBindingSource
        Me.dgvProgrammes.Location = New System.Drawing.Point(9, 19)
        Me.dgvProgrammes.MultiSelect = False
        Me.dgvProgrammes.Name = "dgvProgrammes"
        Me.dgvProgrammes.ReadOnly = True
        Me.dgvProgrammes.RowHeadersVisible = False
        Me.dgvProgrammes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProgrammes.Size = New System.Drawing.Size(625, 220)
        Me.dgvProgrammes.TabIndex = 0
        '
        'IdPROGRAMMEDataGridViewTextBoxColumn
        '
        Me.IdPROGRAMMEDataGridViewTextBoxColumn.DataPropertyName = "idPROGRAMME"
        Me.IdPROGRAMMEDataGridViewTextBoxColumn.HeaderText = "idPROGRAMME"
        Me.IdPROGRAMMEDataGridViewTextBoxColumn.Name = "IdPROGRAMMEDataGridViewTextBoxColumn"
        Me.IdPROGRAMMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPROGRAMMEDataGridViewTextBoxColumn.Visible = False
        '
        'CodePROGRAMMEDataGridViewTextBoxColumn
        '
        Me.CodePROGRAMMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CodePROGRAMMEDataGridViewTextBoxColumn.DataPropertyName = "codePROGRAMME"
        Me.CodePROGRAMMEDataGridViewTextBoxColumn.FillWeight = 35.0!
        Me.CodePROGRAMMEDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodePROGRAMMEDataGridViewTextBoxColumn.Name = "CodePROGRAMMEDataGridViewTextBoxColumn"
        Me.CodePROGRAMMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitrePROGRAMMEDataGridViewTextBoxColumn
        '
        Me.TitrePROGRAMMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitrePROGRAMMEDataGridViewTextBoxColumn.DataPropertyName = "titrePROGRAMME"
        Me.TitrePROGRAMMEDataGridViewTextBoxColumn.HeaderText = "Programme"
        Me.TitrePROGRAMMEDataGridViewTextBoxColumn.Name = "TitrePROGRAMMEDataGridViewTextBoxColumn"
        Me.TitrePROGRAMMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VersionDataGridViewTextBoxColumn
        '
        Me.VersionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "version"
        Me.VersionDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.VersionDataGridViewTextBoxColumn.HeaderText = "Version"
        Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
        Me.VersionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibelleTYPESANCTIONDataGridViewTextBoxColumn
        '
        Me.LibelleTYPESANCTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleTYPESANCTIONDataGridViewTextBoxColumn.DataPropertyName = "libelleTYPE_SANCTION"
        Me.LibelleTYPESANCTIONDataGridViewTextBoxColumn.HeaderText = "Type de sanction"
        Me.LibelleTYPESANCTIONDataGridViewTextBoxColumn.Name = "LibelleTYPESANCTIONDataGridViewTextBoxColumn"
        Me.LibelleTYPESANCTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn
        '
        Me.LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn.DataPropertyName = "libelleTYPE_PROGRAMME"
        Me.LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn.HeaderText = "Type de programme"
        Me.LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn.Name = "LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn"
        Me.LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnCreerProgramme
        '
        Me.btnCreerProgramme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreerProgramme.Location = New System.Drawing.Point(640, 19)
        Me.btnCreerProgramme.Name = "btnCreerProgramme"
        Me.btnCreerProgramme.Size = New System.Drawing.Size(75, 23)
        Me.btnCreerProgramme.TabIndex = 1
        Me.btnCreerProgramme.Text = "Nouveau"
        Me.btnCreerProgramme.UseVisualStyleBackColor = True
        '
        'btnDetailsProgramme
        '
        Me.btnDetailsProgramme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetailsProgramme.Location = New System.Drawing.Point(640, 48)
        Me.btnDetailsProgramme.Name = "btnDetailsProgramme"
        Me.btnDetailsProgramme.Size = New System.Drawing.Size(75, 23)
        Me.btnDetailsProgramme.TabIndex = 2
        Me.btnDetailsProgramme.Text = "Détails"
        Me.btnDetailsProgramme.UseVisualStyleBackColor = True
        '
        'gbProgrammesResultats
        '
        Me.gbProgrammesResultats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProgrammesResultats.Controls.Add(Me.btnDetailsProgramme)
        Me.gbProgrammesResultats.Controls.Add(Me.btnCreerProgramme)
        Me.gbProgrammesResultats.Controls.Add(Me.dgvProgrammes)
        Me.gbProgrammesResultats.Location = New System.Drawing.Point(12, 124)
        Me.gbProgrammesResultats.Name = "gbProgrammesResultats"
        Me.gbProgrammesResultats.Size = New System.Drawing.Size(735, 259)
        Me.gbProgrammesResultats.TabIndex = 1
        Me.gbProgrammesResultats.TabStop = False
        Me.gbProgrammesResultats.Text = "Résultats"
        '
        'P_SELECT_ProgrammeEnseignantTableAdapter
        '
        Me.P_SELECT_ProgrammeEnseignantTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SGP.SGPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmGestionProgrammes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 391)
        Me.Controls.Add(Me.gbProgrammesResultats)
        Me.Controls.Add(Me.gbProgrammeRecherche)
        Me.Name = "frmGestionProgrammes"
        Me.Text = "Gestion des programmes"
        CType(Me.PSELECTTypeProgrammeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTTypeSanctionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTProgrammesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProgrammeRecherche.ResumeLayout(False)
        Me.gbProgrammeRecherche.PerformLayout()
        CType(Me.dgvProgrammes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProgrammesResultats.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents PSELECTTypeSanctionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_Type_SanctionTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Type_SanctionTableAdapter
    Friend WithEvents PSELECTProgrammesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_ProgrammesTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_ProgrammesTableAdapter
    Friend WithEvents PSELECTTypeProgrammeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_Type_ProgrammeTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Type_ProgrammeTableAdapter
    Friend WithEvents lbRechercheProgramme As System.Windows.Forms.Label
    Friend WithEvents txtProgramme As System.Windows.Forms.TextBox
    Friend WithEvents lbTypeSanction As System.Windows.Forms.Label
    Friend WithEvents cbTypeSanction As System.Windows.Forms.ComboBox
    Friend WithEvents lbTypeProgramme As System.Windows.Forms.Label
    Friend WithEvents cbTypeProgramme As System.Windows.Forms.ComboBox
    Friend WithEvents gbProgrammeRecherche As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProgrammes As System.Windows.Forms.DataGridView
    Friend WithEvents IdPROGRAMMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodePROGRAMMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitrePROGRAMMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleTYPESANCTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleTYPEPROGRAMMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCreerProgramme As System.Windows.Forms.Button
    Friend WithEvents btnDetailsProgramme As System.Windows.Forms.Button
    Friend WithEvents gbProgrammesResultats As System.Windows.Forms.GroupBox
    Friend WithEvents P_SELECT_ProgrammeEnseignantTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Programme_EnseignantTableAdapter
    Friend WithEvents TableAdapterManager As SGP.SGPDataSetTableAdapters.TableAdapterManager

End Class
