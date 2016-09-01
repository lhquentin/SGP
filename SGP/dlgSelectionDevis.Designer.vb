<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSelectionDevis
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
        Me.btnSelectionne = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.lbSelectionDevis = New System.Windows.Forms.Label()
        Me.dgvDevis = New System.Windows.Forms.DataGridView()
        Me.PSELECTDevisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGPDataSet = New SGP.SGPDataSet()
        Me.P_SELECT_DevisTableAdapter = New SGP.SGPDataSetTableAdapters.P_SELECT_DevisTableAdapter()
        Me.IdDEVISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfficialisationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvDevis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSELECTDevisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6129!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3871!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelectionne, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAnnuler, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(444, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(155, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnSelectionne
        '
        Me.btnSelectionne.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelectionne.Location = New System.Drawing.Point(3, 3)
        Me.btnSelectionne.Name = "btnSelectionne"
        Me.btnSelectionne.Size = New System.Drawing.Size(73, 23)
        Me.btnSelectionne.TabIndex = 0
        Me.btnSelectionne.Text = "Sélectionner"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.Location = New System.Drawing.Point(83, 3)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(67, 23)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Annuler"
        '
        'lbSelectionDevis
        '
        Me.lbSelectionDevis.AutoSize = True
        Me.lbSelectionDevis.Location = New System.Drawing.Point(6, 7)
        Me.lbSelectionDevis.Name = "lbSelectionDevis"
        Me.lbSelectionDevis.Size = New System.Drawing.Size(322, 13)
        Me.lbSelectionDevis.TabIndex = 1
        Me.lbSelectionDevis.Text = "Veuillez sélectionner le devis auquel vous voulez associer le cours:"
        '
        'dgvDevis
        '
        Me.dgvDevis.AllowUserToAddRows = False
        Me.dgvDevis.AllowUserToDeleteRows = False
        Me.dgvDevis.AllowUserToResizeColumns = False
        Me.dgvDevis.AllowUserToResizeRows = False
        Me.dgvDevis.AutoGenerateColumns = False
        Me.dgvDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDEVISDataGridViewTextBoxColumn, Me.ProgrammeDataGridViewTextBoxColumn, Me.DateOfficialisationDataGridViewTextBoxColumn, Me.CommentaireDataGridViewTextBoxColumn})
        Me.dgvDevis.DataSource = Me.PSELECTDevisBindingSource
        Me.dgvDevis.Location = New System.Drawing.Point(3, 28)
        Me.dgvDevis.MultiSelect = False
        Me.dgvDevis.Name = "dgvDevis"
        Me.dgvDevis.ReadOnly = True
        Me.dgvDevis.RowHeadersVisible = False
        Me.dgvDevis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDevis.Size = New System.Drawing.Size(604, 240)
        Me.dgvDevis.TabIndex = 2
        '
        'PSELECTDevisBindingSource
        '
        Me.PSELECTDevisBindingSource.DataMember = "P_SELECT_Devis"
        Me.PSELECTDevisBindingSource.DataSource = Me.SGPDataSet
        '
        'SGPDataSet
        '
        Me.SGPDataSet.DataSetName = "SGPDataSet"
        Me.SGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_SELECT_DevisTableAdapter
        '
        Me.P_SELECT_DevisTableAdapter.ClearBeforeFill = True
        '
        'IdDEVISDataGridViewTextBoxColumn
        '
        Me.IdDEVISDataGridViewTextBoxColumn.DataPropertyName = "idDEVIS"
        Me.IdDEVISDataGridViewTextBoxColumn.HeaderText = "idDEVIS"
        Me.IdDEVISDataGridViewTextBoxColumn.Name = "IdDEVISDataGridViewTextBoxColumn"
        Me.IdDEVISDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDEVISDataGridViewTextBoxColumn.Visible = False
        '
        'ProgrammeDataGridViewTextBoxColumn
        '
        Me.ProgrammeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProgrammeDataGridViewTextBoxColumn.DataPropertyName = "Programme"
        Me.ProgrammeDataGridViewTextBoxColumn.HeaderText = "Programme"
        Me.ProgrammeDataGridViewTextBoxColumn.Name = "ProgrammeDataGridViewTextBoxColumn"
        Me.ProgrammeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProgrammeDataGridViewTextBoxColumn.Width = 85
        '
        'DateOfficialisationDataGridViewTextBoxColumn
        '
        Me.DateOfficialisationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateOfficialisationDataGridViewTextBoxColumn.DataPropertyName = "dateOfficialisation"
        Me.DateOfficialisationDataGridViewTextBoxColumn.HeaderText = "Officialisation"
        Me.DateOfficialisationDataGridViewTextBoxColumn.Name = "DateOfficialisationDataGridViewTextBoxColumn"
        Me.DateOfficialisationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateOfficialisationDataGridViewTextBoxColumn.Visible = False
        Me.DateOfficialisationDataGridViewTextBoxColumn.Width = 94
        '
        'CommentaireDataGridViewTextBoxColumn
        '
        Me.CommentaireDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CommentaireDataGridViewTextBoxColumn.DataPropertyName = "commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.HeaderText = "Commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.Name = "CommentaireDataGridViewTextBoxColumn"
        Me.CommentaireDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dlgSelectionDevis
        '
        Me.AcceptButton = Me.btnSelectionne
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnuler
        Me.ClientSize = New System.Drawing.Size(611, 315)
        Me.Controls.Add(Me.dgvDevis)
        Me.Controls.Add(Me.lbSelectionDevis)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSelectionDevis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Selection de devis"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvDevis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSELECTDevisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSelectionne As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents lbSelectionDevis As System.Windows.Forms.Label
    Friend WithEvents dgvDevis As System.Windows.Forms.DataGridView
    Friend WithEvents SGPDataSet As SGP.SGPDataSet
    Friend WithEvents PSELECTDevisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents P_SELECT_DevisTableAdapter As SGP.SGPDataSetTableAdapters.P_SELECT_DevisTableAdapter
    Friend WithEvents IdDEVISDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgrammeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfficialisationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
