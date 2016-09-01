<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAjoutIntention
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
        Me.gbRechercheIntentions = New System.Windows.Forms.GroupBox()
        Me.txtIntention = New System.Windows.Forms.TextBox()
        Me.lbIntention = New System.Windows.Forms.Label()
        Me.gbListeIntentions = New System.Windows.Forms.GroupBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnCreerIntention = New System.Windows.Forms.Button()
        Me.dgvIntentions = New System.Windows.Forms.DataGridView()
        Me.IdINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTIntentionDevisEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.gbAjoutIntention = New System.Windows.Forms.GroupBox()
        Me.txtDescriptionIntention = New System.Windows.Forms.TextBox()
        Me.txtTitreIntention = New System.Windows.Forms.TextBox()
        Me.lbDescriptionIntention = New System.Windows.Forms.Label()
        Me.lbTitreIntention = New System.Windows.Forms.Label()
        Me.btnAnnulerIntention = New System.Windows.Forms.Button()
        Me.btnValiderIntention = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_IntentionDevis_EXTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_IntentionDevis_EXTableAdapter()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbRechercheIntentions.SuspendLayout()
        Me.gbListeIntentions.SuspendLayout()
        CType(Me.dgvIntentions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTIntentionDevisEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAjoutIntention.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRechercheIntentions
        '
        Me.gbRechercheIntentions.Controls.Add(Me.txtIntention)
        Me.gbRechercheIntentions.Controls.Add(Me.lbIntention)
        Me.gbRechercheIntentions.Location = New System.Drawing.Point(12, 11)
        Me.gbRechercheIntentions.Name = "gbRechercheIntentions"
        Me.gbRechercheIntentions.Size = New System.Drawing.Size(633, 49)
        Me.gbRechercheIntentions.TabIndex = 1
        Me.gbRechercheIntentions.TabStop = False
        Me.gbRechercheIntentions.Text = "Recherche"
        '
        'txtIntention
        '
        Me.txtIntention.Location = New System.Drawing.Point(116, 19)
        Me.txtIntention.Name = "txtIntention"
        Me.txtIntention.Size = New System.Drawing.Size(167, 20)
        Me.txtIntention.TabIndex = 1
        '
        'lbIntention
        '
        Me.lbIntention.AutoSize = True
        Me.lbIntention.Location = New System.Drawing.Point(6, 22)
        Me.lbIntention.Name = "lbIntention"
        Me.lbIntention.Size = New System.Drawing.Size(104, 13)
        Me.lbIntention.TabIndex = 0
        Me.lbIntention.Text = "Intention éducative :"
        '
        'gbListeIntentions
        '
        Me.gbListeIntentions.Controls.Add(Me.btnAjouter)
        Me.gbListeIntentions.Controls.Add(Me.btnCreerIntention)
        Me.gbListeIntentions.Controls.Add(Me.dgvIntentions)
        Me.gbListeIntentions.Location = New System.Drawing.Point(12, 66)
        Me.gbListeIntentions.Name = "gbListeIntentions"
        Me.gbListeIntentions.Size = New System.Drawing.Size(633, 221)
        Me.gbListeIntentions.TabIndex = 2
        Me.gbListeIntentions.TabStop = False
        Me.gbListeIntentions.Text = "Liste des intentions éducatives"
        '
        'btnAjouter
        '
        Me.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAjouter.Location = New System.Drawing.Point(551, 48)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 2
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnCreerIntention
        '
        Me.btnCreerIntention.Location = New System.Drawing.Point(551, 19)
        Me.btnCreerIntention.Name = "btnCreerIntention"
        Me.btnCreerIntention.Size = New System.Drawing.Size(75, 23)
        Me.btnCreerIntention.TabIndex = 1
        Me.btnCreerIntention.Text = "Créer"
        Me.btnCreerIntention.UseVisualStyleBackColor = True
        '
        'dgvIntentions
        '
        Me.dgvIntentions.AllowUserToAddRows = False
        Me.dgvIntentions.AllowUserToDeleteRows = False
        Me.dgvIntentions.AllowUserToResizeColumns = False
        Me.dgvIntentions.AllowUserToResizeRows = False
        Me.dgvIntentions.AutoGenerateColumns = False
        Me.dgvIntentions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIntentions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdINTENTIONDataGridViewTextBoxColumn, Me.TitreINTENTIONDataGridViewTextBoxColumn, Me.DescriptionINTENTIONDataGridViewTextBoxColumn})
        Me.dgvIntentions.DataSource = Me.PSELECTIntentionDevisEXBindingSource
        Me.dgvIntentions.Location = New System.Drawing.Point(6, 19)
        Me.dgvIntentions.Name = "dgvIntentions"
        Me.dgvIntentions.ReadOnly = True
        Me.dgvIntentions.RowHeadersVisible = False
        Me.dgvIntentions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIntentions.Size = New System.Drawing.Size(539, 196)
        Me.dgvIntentions.TabIndex = 0
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
        Me.TitreINTENTIONDataGridViewTextBoxColumn.HeaderText = "Titre"
        Me.TitreINTENTIONDataGridViewTextBoxColumn.Name = "TitreINTENTIONDataGridViewTextBoxColumn"
        Me.TitreINTENTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionINTENTIONDataGridViewTextBoxColumn
        '
        Me.DescriptionINTENTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionINTENTIONDataGridViewTextBoxColumn.DataPropertyName = "descriptionINTENTION"
        Me.DescriptionINTENTIONDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionINTENTIONDataGridViewTextBoxColumn.Name = "DescriptionINTENTIONDataGridViewTextBoxColumn"
        Me.DescriptionINTENTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PSELECTIntentionDevisEXBindingSource
        '
        Me.PSELECTIntentionDevisEXBindingSource.DataMember = "P_SELECT_IntentionDevis_EX"
        Me.PSELECTIntentionDevisEXBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbAjoutIntention
        '
        Me.gbAjoutIntention.Controls.Add(Me.txtDescriptionIntention)
        Me.gbAjoutIntention.Controls.Add(Me.txtTitreIntention)
        Me.gbAjoutIntention.Controls.Add(Me.lbDescriptionIntention)
        Me.gbAjoutIntention.Controls.Add(Me.lbTitreIntention)
        Me.gbAjoutIntention.Controls.Add(Me.btnAnnulerIntention)
        Me.gbAjoutIntention.Controls.Add(Me.btnValiderIntention)
        Me.gbAjoutIntention.Location = New System.Drawing.Point(12, 293)
        Me.gbAjoutIntention.Name = "gbAjoutIntention"
        Me.gbAjoutIntention.Size = New System.Drawing.Size(633, 163)
        Me.gbAjoutIntention.TabIndex = 3
        Me.gbAjoutIntention.TabStop = False
        Me.gbAjoutIntention.Text = "Détails"
        '
        'txtDescriptionIntention
        '
        Me.txtDescriptionIntention.Location = New System.Drawing.Point(92, 60)
        Me.txtDescriptionIntention.Multiline = True
        Me.txtDescriptionIntention.Name = "txtDescriptionIntention"
        Me.txtDescriptionIntention.Size = New System.Drawing.Size(407, 62)
        Me.txtDescriptionIntention.TabIndex = 5
        '
        'txtTitreIntention
        '
        Me.txtTitreIntention.Location = New System.Drawing.Point(92, 23)
        Me.txtTitreIntention.Name = "txtTitreIntention"
        Me.txtTitreIntention.Size = New System.Drawing.Size(407, 20)
        Me.txtTitreIntention.TabIndex = 4
        '
        'lbDescriptionIntention
        '
        Me.lbDescriptionIntention.AutoSize = True
        Me.lbDescriptionIntention.Location = New System.Drawing.Point(20, 82)
        Me.lbDescriptionIntention.Name = "lbDescriptionIntention"
        Me.lbDescriptionIntention.Size = New System.Drawing.Size(66, 13)
        Me.lbDescriptionIntention.TabIndex = 3
        Me.lbDescriptionIntention.Text = "Description :"
        '
        'lbTitreIntention
        '
        Me.lbTitreIntention.AutoSize = True
        Me.lbTitreIntention.Location = New System.Drawing.Point(20, 26)
        Me.lbTitreIntention.Name = "lbTitreIntention"
        Me.lbTitreIntention.Size = New System.Drawing.Size(34, 13)
        Me.lbTitreIntention.TabIndex = 2
        Me.lbTitreIntention.Text = "Titre :"
        '
        'btnAnnulerIntention
        '
        Me.btnAnnulerIntention.Location = New System.Drawing.Point(551, 87)
        Me.btnAnnulerIntention.Name = "btnAnnulerIntention"
        Me.btnAnnulerIntention.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulerIntention.TabIndex = 1
        Me.btnAnnulerIntention.Text = "Annuler"
        Me.btnAnnulerIntention.UseVisualStyleBackColor = True
        '
        'btnValiderIntention
        '
        Me.btnValiderIntention.Location = New System.Drawing.Point(551, 58)
        Me.btnValiderIntention.Name = "btnValiderIntention"
        Me.btnValiderIntention.Size = New System.Drawing.Size(75, 23)
        Me.btnValiderIntention.TabIndex = 0
        Me.btnValiderIntention.Text = "Enregistrer"
        Me.btnValiderIntention.UseVisualStyleBackColor = True
        '
        'P_SELECT_IntentionDevis_EXTableAdapter
        '
        Me.P_SELECT_IntentionDevis_EXTableAdapter.ClearBeforeFill = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(10, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Fermer"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.164383!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.83562!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(563, 462)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(82, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dlgAjoutIntention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(657, 503)
        Me.Controls.Add(Me.gbAjoutIntention)
        Me.Controls.Add(Me.gbListeIntentions)
        Me.Controls.Add(Me.gbRechercheIntentions)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAjoutIntention"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Intentions Éducatives"
        Me.gbRechercheIntentions.ResumeLayout(False)
        Me.gbRechercheIntentions.PerformLayout()
        Me.gbListeIntentions.ResumeLayout(False)
        CType(Me.dgvIntentions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTIntentionDevisEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAjoutIntention.ResumeLayout(False)
        Me.gbAjoutIntention.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRechercheIntentions As System.Windows.Forms.GroupBox
    Friend WithEvents txtIntention As System.Windows.Forms.TextBox
    Friend WithEvents lbIntention As System.Windows.Forms.Label
    Friend WithEvents gbListeIntentions As System.Windows.Forms.GroupBox
    Friend WithEvents dgvIntentions As System.Windows.Forms.DataGridView
    Friend WithEvents gbAjoutIntention As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnCreerIntention As System.Windows.Forms.Button
    Friend WithEvents txtDescriptionIntention As System.Windows.Forms.TextBox
    Friend WithEvents txtTitreIntention As System.Windows.Forms.TextBox
    Friend WithEvents lbDescriptionIntention As System.Windows.Forms.Label
    Friend WithEvents lbTitreIntention As System.Windows.Forms.Label
    Friend WithEvents btnAnnulerIntention As System.Windows.Forms.Button
    Friend WithEvents btnValiderIntention As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdDEVISDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdINTENTION1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTIntentionDevisEXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents P_SELECT_IntentionDevis_EXTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_IntentionDevis_EXTableAdapter
    Friend WithEvents IdINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
