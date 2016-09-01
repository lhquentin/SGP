<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgListeElement
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
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gbListeCompetence = New System.Windows.Forms.GroupBox()
        Me.dgvCompetence = New System.Windows.Forms.DataGridView()
        Me.gbListeElement = New System.Windows.Forms.GroupBox()
        Me.dgvElement = New System.Windows.Forms.DataGridView()
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.PSELECTCompetenceDevisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_CompetenceDevisTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_CompetenceDevisTableAdapter()
        Me.IdCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCOMPETENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTElementCompetenceEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_ElementCompetence_EXTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_ElementCompetence_EXTableAdapter()
        Me.IdELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelleELEMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbListeCompetence.SuspendLayout()
        CType(Me.dgvCompetence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListeElement.SuspendLayout()
        CType(Me.dgvElement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTCompetenceDevisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTElementCompetenceEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.6087!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.3913!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAjouter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(497, 496)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(184, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAjouter.Location = New System.Drawing.Point(3, 3)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(100, 23)
        Me.btnAjouter.TabIndex = 0
        Me.btnAjouter.Text = "Ajouter élément(s)"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(111, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'gbListeCompetence
        '
        Me.gbListeCompetence.Controls.Add(Me.dgvCompetence)
        Me.gbListeCompetence.Location = New System.Drawing.Point(3, 2)
        Me.gbListeCompetence.Name = "gbListeCompetence"
        Me.gbListeCompetence.Size = New System.Drawing.Size(678, 241)
        Me.gbListeCompetence.TabIndex = 1
        Me.gbListeCompetence.TabStop = False
        Me.gbListeCompetence.Text = "Liste des compétences"
        '
        'dgvCompetence
        '
        Me.dgvCompetence.AllowUserToAddRows = False
        Me.dgvCompetence.AllowUserToDeleteRows = False
        Me.dgvCompetence.AllowUserToResizeColumns = False
        Me.dgvCompetence.AllowUserToResizeRows = False
        Me.dgvCompetence.AutoGenerateColumns = False
        Me.dgvCompetence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompetence.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCOMPETENCEDataGridViewTextBoxColumn, Me.CodeCOMPETENCEDataGridViewTextBoxColumn, Me.NomCOMPETENCEDataGridViewTextBoxColumn})
        Me.dgvCompetence.DataSource = Me.PSELECTCompetenceDevisBindingSource
        Me.dgvCompetence.Location = New System.Drawing.Point(6, 19)
        Me.dgvCompetence.MultiSelect = False
        Me.dgvCompetence.Name = "dgvCompetence"
        Me.dgvCompetence.ReadOnly = True
        Me.dgvCompetence.RowHeadersVisible = False
        Me.dgvCompetence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompetence.Size = New System.Drawing.Size(666, 216)
        Me.dgvCompetence.TabIndex = 0
        '
        'gbListeElement
        '
        Me.gbListeElement.Controls.Add(Me.dgvElement)
        Me.gbListeElement.Location = New System.Drawing.Point(3, 249)
        Me.gbListeElement.Name = "gbListeElement"
        Me.gbListeElement.Size = New System.Drawing.Size(678, 241)
        Me.gbListeElement.TabIndex = 0
        Me.gbListeElement.TabStop = False
        Me.gbListeElement.Text = "Liste des éléments"
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
        Me.dgvElement.DataSource = Me.PSELECTElementCompetenceEXBindingSource
        Me.dgvElement.Location = New System.Drawing.Point(6, 19)
        Me.dgvElement.Name = "dgvElement"
        Me.dgvElement.ReadOnly = True
        Me.dgvElement.RowHeadersVisible = False
        Me.dgvElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElement.Size = New System.Drawing.Size(666, 216)
        Me.dgvElement.TabIndex = 0
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PSELECTCompetenceDevisBindingSource
        '
        Me.PSELECTCompetenceDevisBindingSource.DataMember = "P_SELECT_CompetenceDevis"
        Me.PSELECTCompetenceDevisBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_CompetenceDevisTableAdapter
        '
        Me.P_SELECT_CompetenceDevisTableAdapter.ClearBeforeFill = True
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
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.Name = "NomCOMPETENCEDataGridViewTextBoxColumn"
        Me.NomCOMPETENCEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTElementCompetenceEXBindingSource
        '
        Me.PSELECTElementCompetenceEXBindingSource.DataMember = "P_SELECT_ElementCompetence_EX"
        Me.PSELECTElementCompetenceEXBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_ElementCompetence_EXTableAdapter
        '
        Me.P_SELECT_ElementCompetence_EXTableAdapter.ClearBeforeFill = True
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
        Me.LibelleELEMENTDataGridViewTextBoxColumn.HeaderText = "Libellé"
        Me.LibelleELEMENTDataGridViewTextBoxColumn.Name = "LibelleELEMENTDataGridViewTextBoxColumn"
        Me.LibelleELEMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dlgListeElement
        '
        Me.AcceptButton = Me.btnAjouter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(685, 528)
        Me.Controls.Add(Me.gbListeElement)
        Me.Controls.Add(Me.gbListeCompetence)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgListeElement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sélection d'élement"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbListeCompetence.ResumeLayout(False)
        CType(Me.dgvCompetence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListeElement.ResumeLayout(False)
        CType(Me.dgvElement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTCompetenceDevisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTElementCompetenceEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbListeCompetence As System.Windows.Forms.GroupBox
    Friend WithEvents gbListeElement As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCompetence As System.Windows.Forms.DataGridView
    Friend WithEvents dgvElement As System.Windows.Forms.DataGridView
    Friend WithEvents IdCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCOMPETENCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTCompetenceDevisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents IdELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleELEMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTElementCompetenceEXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_CompetenceDevisTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_CompetenceDevisTableAdapter
    Friend WithEvents P_SELECT_ElementCompetence_EXTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_ElementCompetence_EXTableAdapter

End Class
