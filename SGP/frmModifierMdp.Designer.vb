<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifierMdp
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
        Me.lbNouveauMdp = New System.Windows.Forms.Label()
        Me.txtNouveauMdp = New System.Windows.Forms.TextBox()
        Me.lbConfirmerMdp = New System.Windows.Forms.Label()
        Me.txtConfirmerMdp = New System.Windows.Forms.TextBox()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNouveauMdp
        '
        Me.lbNouveauMdp.AutoSize = True
        Me.lbNouveauMdp.Location = New System.Drawing.Point(13, 13)
        Me.lbNouveauMdp.Name = "lbNouveauMdp"
        Me.lbNouveauMdp.Size = New System.Drawing.Size(120, 13)
        Me.lbNouveauMdp.TabIndex = 0
        Me.lbNouveauMdp.Text = "Nouveau mot de passe:"
        '
        'txtNouveauMdp
        '
        Me.txtNouveauMdp.Location = New System.Drawing.Point(139, 10)
        Me.txtNouveauMdp.Name = "txtNouveauMdp"
        Me.txtNouveauMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNouveauMdp.Size = New System.Drawing.Size(184, 20)
        Me.txtNouveauMdp.TabIndex = 1
        '
        'lbConfirmerMdp
        '
        Me.lbConfirmerMdp.AutoSize = True
        Me.lbConfirmerMdp.Location = New System.Drawing.Point(13, 41)
        Me.lbConfirmerMdp.Name = "lbConfirmerMdp"
        Me.lbConfirmerMdp.Size = New System.Drawing.Size(120, 13)
        Me.lbConfirmerMdp.TabIndex = 2
        Me.lbConfirmerMdp.Text = "Confirmer mot de passe:"
        '
        'txtConfirmerMdp
        '
        Me.txtConfirmerMdp.Location = New System.Drawing.Point(139, 38)
        Me.txtConfirmerMdp.Name = "txtConfirmerMdp"
        Me.txtConfirmerMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmerMdp.Size = New System.Drawing.Size(184, 20)
        Me.txtConfirmerMdp.TabIndex = 3
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Location = New System.Drawing.Point(182, 74)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrer.TabIndex = 4
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(263, 74)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 5
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'frmModifierMdp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 106)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.txtConfirmerMdp)
        Me.Controls.Add(Me.lbConfirmerMdp)
        Me.Controls.Add(Me.txtNouveauMdp)
        Me.Controls.Add(Me.lbNouveauMdp)
        Me.Name = "frmModifierMdp"
        Me.Text = "Modification du mot de passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNouveauMdp As System.Windows.Forms.Label
    Friend WithEvents txtNouveauMdp As System.Windows.Forms.TextBox
    Friend WithEvents lbConfirmerMdp As System.Windows.Forms.Label
    Friend WithEvents txtConfirmerMdp As System.Windows.Forms.TextBox
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
End Class
