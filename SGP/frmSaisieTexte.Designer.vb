<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieTexte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaisieTexte))
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.rtxtSaisieTexte = New System.Windows.Forms.RichTextBox()
        Me.tsBarreOutilTexte = New System.Windows.Forms.ToolStrip()
        Me.tsbGras = New System.Windows.Forms.ToolStripButton()
        Me.tsbItalique = New System.Windows.Forms.ToolStripButton()
        Me.tsbSouligne = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPuce = New System.Windows.Forms.ToolStripButton()
        Me.tsBarreOutilTexte.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEnregistrer.Location = New System.Drawing.Point(565, 499)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrer.TabIndex = 1
        Me.btnEnregistrer.Text = "Ok"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.Location = New System.Drawing.Point(646, 499)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 2
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'rtxtSaisieTexte
        '
        Me.rtxtSaisieTexte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSaisieTexte.Location = New System.Drawing.Point(0, 28)
        Me.rtxtSaisieTexte.Name = "rtxtSaisieTexte"
        Me.rtxtSaisieTexte.Size = New System.Drawing.Size(733, 465)
        Me.rtxtSaisieTexte.TabIndex = 3
        Me.rtxtSaisieTexte.Text = ""
        '
        'tsBarreOutilTexte
        '
        Me.tsBarreOutilTexte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGras, Me.tsbItalique, Me.tsbSouligne, Me.ToolStripSeparator1, Me.tsbPuce})
        Me.tsBarreOutilTexte.Location = New System.Drawing.Point(0, 0)
        Me.tsBarreOutilTexte.Name = "tsBarreOutilTexte"
        Me.tsBarreOutilTexte.Size = New System.Drawing.Size(733, 25)
        Me.tsBarreOutilTexte.TabIndex = 4
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
        'frmSaisieTexte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 534)
        Me.Controls.Add(Me.tsBarreOutilTexte)
        Me.Controls.Add(Me.rtxtSaisieTexte)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Name = "frmSaisieTexte"
        Me.Text = "Form1"
        Me.tsBarreOutilTexte.ResumeLayout(False)
        Me.tsBarreOutilTexte.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents rtxtSaisieTexte As System.Windows.Forms.RichTextBox
    Friend WithEvents tsBarreOutilTexte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGras As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbItalique As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSouligne As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPuce As System.Windows.Forms.ToolStripButton
End Class
