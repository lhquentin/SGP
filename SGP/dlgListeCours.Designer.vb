<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgListeCours
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgListeCours))
        Me.gbListeCours = New System.Windows.Forms.GroupBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.dgvCours = New System.Windows.Forms.DataGridView()
        Me.IdCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreCOURSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSELECTCoursDevisEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gbDetailPrealable = New System.Windows.Forms.GroupBox()
        Me.tsBarreOutilTexte = New System.Windows.Forms.ToolStrip()
        Me.tsbGras = New System.Windows.Forms.ToolStripButton()
        Me.tsbItalique = New System.Windows.Forms.ToolStripButton()
        Me.tsbSouligne = New System.Windows.Forms.ToolStripButton()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.rtxtJustification = New System.Windows.Forms.RichTextBox()
        Me.lbJustification = New System.Windows.Forms.Label()
        Me.cbTypePrealable = New System.Windows.Forms.ComboBox()
        Me.PSELECTTypePrealableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbTypePrealable = New System.Windows.Forms.Label()
        Me.P_SELECT_TypePrealableTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_TypePrealableTableAdapter()
        Me.P_SELECT_CoursDevis_EXTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_CoursDevis_EXTableAdapter()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPuce = New System.Windows.Forms.ToolStripButton()
        Me.gbListeCours.SuspendLayout()
        CType(Me.dgvCours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTCoursDevisEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetailPrealable.SuspendLayout()
        Me.tsBarreOutilTexte.SuspendLayout()
        CType(Me.PSELECTTypePrealableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbListeCours
        '
        Me.gbListeCours.Controls.Add(Me.btnAjouter)
        Me.gbListeCours.Controls.Add(Me.dgvCours)
        Me.gbListeCours.Location = New System.Drawing.Point(3, 2)
        Me.gbListeCours.Name = "gbListeCours"
        Me.gbListeCours.Size = New System.Drawing.Size(680, 216)
        Me.gbListeCours.TabIndex = 1
        Me.gbListeCours.TabStop = False
        Me.gbListeCours.Text = "Liste des cours du devis"
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(599, 19)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 1
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
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
        Me.dgvCours.DataSource = Me.PSELECTCoursDevisEXBindingSource
        Me.dgvCours.Location = New System.Drawing.Point(6, 19)
        Me.dgvCours.MultiSelect = False
        Me.dgvCours.Name = "dgvCours"
        Me.dgvCours.ReadOnly = True
        Me.dgvCours.RowHeadersVisible = False
        Me.dgvCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCours.Size = New System.Drawing.Size(587, 191)
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
        'PSELECTCoursDevisEXBindingSource
        '
        Me.PSELECTCoursDevisEXBindingSource.DataMember = "P_SELECT_CoursDevis_EX"
        Me.PSELECTCoursDevisEXBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(610, 470)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Fermer"
        '
        'gbDetailPrealable
        '
        Me.gbDetailPrealable.Controls.Add(Me.tsBarreOutilTexte)
        Me.gbDetailPrealable.Controls.Add(Me.btnEnregistrer)
        Me.gbDetailPrealable.Controls.Add(Me.rtxtJustification)
        Me.gbDetailPrealable.Controls.Add(Me.lbJustification)
        Me.gbDetailPrealable.Controls.Add(Me.cbTypePrealable)
        Me.gbDetailPrealable.Controls.Add(Me.lbTypePrealable)
        Me.gbDetailPrealable.Location = New System.Drawing.Point(3, 224)
        Me.gbDetailPrealable.Name = "gbDetailPrealable"
        Me.gbDetailPrealable.Size = New System.Drawing.Size(680, 240)
        Me.gbDetailPrealable.TabIndex = 2
        Me.gbDetailPrealable.TabStop = False
        Me.gbDetailPrealable.Text = "Détail du préalable"
        '
        'tsBarreOutilTexte
        '
        Me.tsBarreOutilTexte.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBarreOutilTexte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGras, Me.tsbItalique, Me.tsbSouligne, Me.ToolStripSeparator1, Me.tsbPuce})
        Me.tsBarreOutilTexte.Location = New System.Drawing.Point(80, 47)
        Me.tsBarreOutilTexte.Name = "tsBarreOutilTexte"
        Me.tsBarreOutilTexte.Size = New System.Drawing.Size(141, 25)
        Me.tsBarreOutilTexte.TabIndex = 5
        Me.tsBarreOutilTexte.Text = "Barre d'outil de texte"
        '
        'tsbGras
        '
        Me.tsbGras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGras.Image = CType(resources.GetObject("tsbGras.Image"), System.Drawing.Image)
        Me.tsbGras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGras.Name = "tsbGras"
        Me.tsbGras.Size = New System.Drawing.Size(23, 22)
        Me.tsbGras.Text = "Gras"
        '
        'tsbItalique
        '
        Me.tsbItalique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbItalique.Image = CType(resources.GetObject("tsbItalique.Image"), System.Drawing.Image)
        Me.tsbItalique.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbItalique.Name = "tsbItalique"
        Me.tsbItalique.Size = New System.Drawing.Size(23, 22)
        Me.tsbItalique.Text = "Italique"
        '
        'tsbSouligne
        '
        Me.tsbSouligne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSouligne.Image = CType(resources.GetObject("tsbSouligne.Image"), System.Drawing.Image)
        Me.tsbSouligne.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSouligne.Name = "tsbSouligne"
        Me.tsbSouligne.Size = New System.Drawing.Size(23, 22)
        Me.tsbSouligne.Text = "Souligné"
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEnregistrer.Location = New System.Drawing.Point(599, 16)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrer.TabIndex = 4
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'rtxtJustification
        '
        Me.rtxtJustification.Location = New System.Drawing.Point(80, 75)
        Me.rtxtJustification.Name = "rtxtJustification"
        Me.rtxtJustification.Size = New System.Drawing.Size(513, 159)
        Me.rtxtJustification.TabIndex = 3
        Me.rtxtJustification.Text = ""
        '
        'lbJustification
        '
        Me.lbJustification.AutoSize = True
        Me.lbJustification.Location = New System.Drawing.Point(9, 54)
        Me.lbJustification.Name = "lbJustification"
        Me.lbJustification.Size = New System.Drawing.Size(65, 13)
        Me.lbJustification.TabIndex = 2
        Me.lbJustification.Text = "Justification:"
        '
        'cbTypePrealable
        '
        Me.cbTypePrealable.DataSource = Me.PSELECTTypePrealableBindingSource
        Me.cbTypePrealable.DisplayMember = "libelleTypePrealable"
        Me.cbTypePrealable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTypePrealable.FormattingEnabled = True
        Me.cbTypePrealable.Location = New System.Drawing.Point(69, 23)
        Me.cbTypePrealable.Name = "cbTypePrealable"
        Me.cbTypePrealable.Size = New System.Drawing.Size(121, 21)
        Me.cbTypePrealable.TabIndex = 1
        Me.cbTypePrealable.ValueMember = "idTypePrealable"
        '
        'PSELECTTypePrealableBindingSource
        '
        Me.PSELECTTypePrealableBindingSource.DataMember = "P_SELECT_TypePrealable"
        Me.PSELECTTypePrealableBindingSource.DataSource = Me.SGPDataSet
        '
        'lbTypePrealable
        '
        Me.lbTypePrealable.AutoSize = True
        Me.lbTypePrealable.Location = New System.Drawing.Point(9, 26)
        Me.lbTypePrealable.Name = "lbTypePrealable"
        Me.lbTypePrealable.Size = New System.Drawing.Size(54, 13)
        Me.lbTypePrealable.TabIndex = 0
        Me.lbTypePrealable.Text = "Préalable:"
        '
        'P_SELECT_TypePrealableTableAdapter
        '
        Me.P_SELECT_TypePrealableTableAdapter.ClearBeforeFill = True
        '
        'P_SELECT_CoursDevis_EXTableAdapter
        '
        Me.P_SELECT_CoursDevis_EXTableAdapter.ClearBeforeFill = True
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbPuce
        '
        Me.tsbPuce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPuce.Image = CType(resources.GetObject("tsbPuce.Image"), System.Drawing.Image)
        Me.tsbPuce.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPuce.Name = "tsbPuce"
        Me.tsbPuce.Size = New System.Drawing.Size(23, 22)
        Me.tsbPuce.Text = "Puce"
        '
        'dlgListeCours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(686, 505)
        Me.Controls.Add(Me.gbDetailPrealable)
        Me.Controls.Add(Me.gbListeCours)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgListeCours"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des préalables"
        Me.gbListeCours.ResumeLayout(False)
        CType(Me.dgvCours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTCoursDevisEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetailPrealable.ResumeLayout(False)
        Me.gbDetailPrealable.PerformLayout()
        Me.tsBarreOutilTexte.ResumeLayout(False)
        Me.tsBarreOutilTexte.PerformLayout()
        CType(Me.PSELECTTypePrealableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbListeCours As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents dgvCours As System.Windows.Forms.DataGridView
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbDetailPrealable As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents rtxtJustification As System.Windows.Forms.RichTextBox
    Friend WithEvents lbJustification As System.Windows.Forms.Label
    Friend WithEvents cbTypePrealable As System.Windows.Forms.ComboBox
    Friend WithEvents lbTypePrealable As System.Windows.Forms.Label
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents PSELECTTypePrealableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_TypePrealableTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_TypePrealableTableAdapter
    Friend WithEvents IdCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreCOURSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTCoursDevisEXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_CoursDevis_EXTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_CoursDevis_EXTableAdapter
    Friend WithEvents tsBarreOutilTexte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGras As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbItalique As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSouligne As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPuce As System.Windows.Forms.ToolStripButton

End Class
