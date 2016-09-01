<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCours
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
        Me.gbRecherche = New System.Windows.Forms.GroupBox()
        Me.txtCours = New System.Windows.Forms.TextBox()
        Me.lbCours = New System.Windows.Forms.Label()
        Me.gbResultat = New System.Windows.Forms.GroupBox()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.dgvCours = New System.Windows.Forms.DataGridView()
        Me.IdCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTCoursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.P_SELECT_CoursTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_CoursTableAdapter()
        Me.P_SELECT_Cours_EnseignantTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_Cours_EnseignantTableAdapter()
        Me.TableAdapterManager = New SGP.SGPDataSetTableAdapters.TableAdapterManager()
        Me.gbRecherche.SuspendLayout()
        Me.gbResultat.SuspendLayout()
        CType(Me.dgvCours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTCoursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRecherche
        '
        Me.gbRecherche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRecherche.Controls.Add(Me.txtCours)
        Me.gbRecherche.Controls.Add(Me.lbCours)
        Me.gbRecherche.Location = New System.Drawing.Point(3, 1)
        Me.gbRecherche.Name = "gbRecherche"
        Me.gbRecherche.Size = New System.Drawing.Size(755, 47)
        Me.gbRecherche.TabIndex = 0
        Me.gbRecherche.TabStop = False
        Me.gbRecherche.Text = "Recherche"
        '
        'txtCours
        '
        Me.txtCours.Location = New System.Drawing.Point(52, 17)
        Me.txtCours.Name = "txtCours"
        Me.txtCours.Size = New System.Drawing.Size(305, 20)
        Me.txtCours.TabIndex = 2
        '
        'lbCours
        '
        Me.lbCours.AutoSize = True
        Me.lbCours.Location = New System.Drawing.Point(9, 20)
        Me.lbCours.Name = "lbCours"
        Me.lbCours.Size = New System.Drawing.Size(37, 13)
        Me.lbCours.TabIndex = 1
        Me.lbCours.Text = "Cours:"
        '
        'gbResultat
        '
        Me.gbResultat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbResultat.Controls.Add(Me.btnAnnuler)
        Me.gbResultat.Controls.Add(Me.btnAjouter)
        Me.gbResultat.Controls.Add(Me.btnDetail)
        Me.gbResultat.Controls.Add(Me.btnNouveau)
        Me.gbResultat.Controls.Add(Me.dgvCours)
        Me.gbResultat.Location = New System.Drawing.Point(3, 54)
        Me.gbResultat.Name = "gbResultat"
        Me.gbResultat.Size = New System.Drawing.Size(755, 340)
        Me.gbResultat.TabIndex = 1
        Me.gbResultat.TabStop = False
        Me.gbResultat.Text = "Résultat"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnuler.Location = New System.Drawing.Point(670, 106)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 4
        Me.btnAnnuler.Text = "Fermer"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        Me.btnAnnuler.Visible = False
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAjouter.Location = New System.Drawing.Point(670, 77)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        Me.btnAjouter.Visible = False
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.Location = New System.Drawing.Point(670, 48)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(75, 23)
        Me.btnDetail.TabIndex = 2
        Me.btnDetail.Text = "Détails"
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'btnNouveau
        '
        Me.btnNouveau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNouveau.Location = New System.Drawing.Point(670, 19)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(75, 23)
        Me.btnNouveau.TabIndex = 1
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'dgvCours
        '
        Me.dgvCours.AllowUserToAddRows = False
        Me.dgvCours.AllowUserToDeleteRows = False
        Me.dgvCours.AllowUserToResizeColumns = False
        Me.dgvCours.AllowUserToResizeRows = False
        Me.dgvCours.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCours.AutoGenerateColumns = False
        Me.dgvCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCOURSDataGridViewTextBoxColumn, Me.CodeCOURSDataGridViewTextBoxColumn, Me.TitreCOURSDataGridViewTextBoxColumn})
        Me.dgvCours.DataSource = Me.PSELECTCoursBindingSource
        Me.dgvCours.Location = New System.Drawing.Point(6, 19)
        Me.dgvCours.MultiSelect = False
        Me.dgvCours.Name = "dgvCours"
        Me.dgvCours.ReadOnly = True
        Me.dgvCours.RowHeadersVisible = False
        Me.dgvCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCours.Size = New System.Drawing.Size(658, 313)
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
        Me.CodeCOURSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodeCOURSDataGridViewTextBoxColumn.DataPropertyName = "codeCOURS"
        Me.CodeCOURSDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeCOURSDataGridViewTextBoxColumn.Name = "CodeCOURSDataGridViewTextBoxColumn"
        Me.CodeCOURSDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeCOURSDataGridViewTextBoxColumn.Width = 57
        '
        'TitreCOURSDataGridViewTextBoxColumn
        '
        Me.TitreCOURSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitreCOURSDataGridViewTextBoxColumn.DataPropertyName = "titreCOURS"
        Me.TitreCOURSDataGridViewTextBoxColumn.HeaderText = "Titre"
        Me.TitreCOURSDataGridViewTextBoxColumn.Name = "TitreCOURSDataGridViewTextBoxColumn"
        Me.TitreCOURSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTCoursBindingSource
        '
        Me.PSELECTCoursBindingSource.DataMember = "P_SELECT_Cours"
        Me.PSELECTCoursBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_SELECT_CoursTableAdapter
        '
        Me.P_SELECT_CoursTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_Cours_EnseignantTableAdapter
        '
        Me.P_SELECT_Cours_EnseignantTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SGP.SGPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmGestionCours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 398)
        Me.Controls.Add(Me.gbResultat)
        Me.Controls.Add(Me.gbRecherche)
        Me.Name = "frmGestionCours"
        Me.Text = "Gestion des cours"
        Me.gbRecherche.ResumeLayout(False)
        Me.gbRecherche.PerformLayout()
        Me.gbResultat.ResumeLayout(False)
        CType(Me.dgvCours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTCoursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRecherche As System.Windows.Forms.GroupBox
    Friend WithEvents txtCours As System.Windows.Forms.TextBox
    Friend WithEvents lbCours As System.Windows.Forms.Label
    Friend WithEvents gbResultat As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCours As System.Windows.Forms.DataGridView
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnNouveau As System.Windows.Forms.Button
    Friend WithEvents IdCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTCoursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents P_SELECT_CoursTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_CoursTableAdapter
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents P_SELECT_Cours_EnseignantTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_Cours_EnseignantTableAdapter
    Friend WithEvents TableAdapterManager As SGP.SGPDataSetTableAdapters.TableAdapterManager
End Class
