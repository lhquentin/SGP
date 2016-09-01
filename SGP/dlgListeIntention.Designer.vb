<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgListeIntention
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
        Me.btnAjouterIntention = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gbListeIntention = New System.Windows.Forms.GroupBox()
        Me.dgvListeIntention = New System.Windows.Forms.DataGridView()
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.PSELECTIntentionCoursEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_SELECT_IntentionCours_EXTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_IntentionCours_EXTableAdapter()
        Me.IdINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreINTENTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbListeIntention.SuspendLayout()
        CType(Me.dgvListeIntention, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTIntentionCoursEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.88889!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAjouterIntention, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(499, 300)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(188, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnAjouterIntention
        '
        Me.btnAjouterIntention.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAjouterIntention.Location = New System.Drawing.Point(3, 3)
        Me.btnAjouterIntention.Name = "btnAjouterIntention"
        Me.btnAjouterIntention.Size = New System.Drawing.Size(105, 23)
        Me.btnAjouterIntention.TabIndex = 0
        Me.btnAjouterIntention.Text = "Ajouter intention(s)"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(116, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'gbListeIntention
        '
        Me.gbListeIntention.Controls.Add(Me.dgvListeIntention)
        Me.gbListeIntention.Location = New System.Drawing.Point(2, 2)
        Me.gbListeIntention.Name = "gbListeIntention"
        Me.gbListeIntention.Size = New System.Drawing.Size(695, 295)
        Me.gbListeIntention.TabIndex = 1
        Me.gbListeIntention.TabStop = False
        Me.gbListeIntention.Text = "Liste"
        '
        'dgvListeIntention
        '
        Me.dgvListeIntention.AllowUserToAddRows = False
        Me.dgvListeIntention.AllowUserToDeleteRows = False
        Me.dgvListeIntention.AllowUserToResizeColumns = False
        Me.dgvListeIntention.AllowUserToResizeRows = False
        Me.dgvListeIntention.AutoGenerateColumns = False
        Me.dgvListeIntention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListeIntention.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdINTENTIONDataGridViewTextBoxColumn, Me.TitreINTENTIONDataGridViewTextBoxColumn})
        Me.dgvListeIntention.DataSource = Me.PSELECTIntentionCoursEXBindingSource
        Me.dgvListeIntention.Location = New System.Drawing.Point(6, 19)
        Me.dgvListeIntention.Name = "dgvListeIntention"
        Me.dgvListeIntention.ReadOnly = True
        Me.dgvListeIntention.RowHeadersVisible = False
        Me.dgvListeIntention.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListeIntention.Size = New System.Drawing.Size(683, 270)
        Me.dgvListeIntention.TabIndex = 0
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PSELECTIntentionCoursEXBindingSource
        '
        Me.PSELECTIntentionCoursEXBindingSource.DataMember = "P_SELECT_IntentionCours_EX"
        Me.PSELECTIntentionCoursEXBindingSource.DataSource = Me.SGPDataSet
        '
        'P_SELECT_IntentionCours_EXTableAdapter
        '
        Me.P_SELECT_IntentionCours_EXTableAdapter.ClearBeforeFill = True
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
        'dlgListeIntention
        '
        Me.AcceptButton = Me.btnAjouterIntention
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(699, 341)
        Me.Controls.Add(Me.gbListeIntention)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgListeIntention"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Intentions du devis"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbListeIntention.ResumeLayout(False)
        CType(Me.dgvListeIntention, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTIntentionCoursEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAjouterIntention As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbListeIntention As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListeIntention As System.Windows.Forms.DataGridView
    Friend WithEvents IdINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreINTENTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSELECTIntentionCoursEXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents P_SELECT_IntentionCours_EXTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_IntentionCours_EXTableAdapter

End Class
