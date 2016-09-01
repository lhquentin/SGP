<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmConnexion
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lbCourriel As System.Windows.Forms.Label
    Friend WithEvents lbMotDePasse As System.Windows.Forms.Label
    Friend WithEvents txtCourriel As System.Windows.Forms.TextBox
    Friend WithEvents txtMotDePasse As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnexion))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lbCourriel = New System.Windows.Forms.Label()
        Me.lbMotDePasse = New System.Windows.Forms.Label()
        Me.txtCourriel = New System.Windows.Forms.TextBox()
        Me.txtMotDePasse = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.llbReinitialiserMdp = New System.Windows.Forms.LinkLabel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(4, 67)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(170, 47)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'lbCourriel
        '
        Me.lbCourriel.Location = New System.Drawing.Point(196, 24)
        Me.lbCourriel.Name = "lbCourriel"
        Me.lbCourriel.Size = New System.Drawing.Size(269, 23)
        Me.lbCourriel.TabIndex = 0
        Me.lbCourriel.Text = "&Courriel"
        Me.lbCourriel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMotDePasse
        '
        Me.lbMotDePasse.Location = New System.Drawing.Point(196, 81)
        Me.lbMotDePasse.Name = "lbMotDePasse"
        Me.lbMotDePasse.Size = New System.Drawing.Size(269, 23)
        Me.lbMotDePasse.TabIndex = 2
        Me.lbMotDePasse.Text = "&Mot de passe"
        Me.lbMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCourriel
        '
        Me.txtCourriel.Location = New System.Drawing.Point(196, 44)
        Me.txtCourriel.Name = "txtCourriel"
        Me.txtCourriel.Size = New System.Drawing.Size(271, 20)
        Me.txtCourriel.TabIndex = 1
        '
        'txtMotDePasse
        '
        Me.txtMotDePasse.Location = New System.Drawing.Point(196, 101)
        Me.txtMotDePasse.Name = "txtMotDePasse"
        Me.txtMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMotDePasse.Size = New System.Drawing.Size(271, 20)
        Me.txtMotDePasse.TabIndex = 3
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(270, 161)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(94, 23)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&OK"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.Location = New System.Drawing.Point(373, 161)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(94, 23)
        Me.btnAnnuler.TabIndex = 6
        Me.btnAnnuler.Text = "&Annuler"
        '
        'llbReinitialiserMdp
        '
        Me.llbReinitialiserMdp.AutoSize = True
        Me.llbReinitialiserMdp.Location = New System.Drawing.Point(193, 124)
        Me.llbReinitialiserMdp.Name = "llbReinitialiserMdp"
        Me.llbReinitialiserMdp.Size = New System.Drawing.Size(149, 13)
        Me.llbReinitialiserMdp.TabIndex = 4
        Me.llbReinitialiserMdp.TabStop = True
        Me.llbReinitialiserMdp.Text = "Réinitialiser mon mot de passe"
        '
        'frmConnexion
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnuler
        Me.ClientSize = New System.Drawing.Size(474, 192)
        Me.Controls.Add(Me.llbReinitialiserMdp)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtMotDePasse)
        Me.Controls.Add(Me.txtCourriel)
        Me.Controls.Add(Me.lbMotDePasse)
        Me.Controls.Add(Me.lbCourriel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnexion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connexion"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents llbReinitialiserMdp As System.Windows.Forms.LinkLabel

End Class
