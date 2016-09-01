<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDISGP
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparateur3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HabileteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparateur1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GererUtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.GestionToolStripMenuItem, Me.UtilisateurToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(738, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(54, 20)
        Me.FileMenu.Text = "&Fichier"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExitToolStripMenuItem.Text = "&Quitter"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammeToolStripMenuItem, Me.CoursToolStripMenuItem, Me.DevisToolStripMenuItem, Me.tsSeparateur3, Me.HabileteToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestionToolStripMenuItem.Text = "&Gestion"
        '
        'ProgrammeToolStripMenuItem
        '
        Me.ProgrammeToolStripMenuItem.Name = "ProgrammeToolStripMenuItem"
        Me.ProgrammeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgrammeToolStripMenuItem.Text = "&Programme"
        '
        'CoursToolStripMenuItem
        '
        Me.CoursToolStripMenuItem.Name = "CoursToolStripMenuItem"
        Me.CoursToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CoursToolStripMenuItem.Text = "&Cours"
        '
        'DevisToolStripMenuItem
        '
        Me.DevisToolStripMenuItem.Name = "DevisToolStripMenuItem"
        Me.DevisToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DevisToolStripMenuItem.Text = "&Devis"
        '
        'tsSeparateur3
        '
        Me.tsSeparateur3.Name = "tsSeparateur3"
        Me.tsSeparateur3.Size = New System.Drawing.Size(149, 6)
        '
        'HabileteToolStripMenuItem
        '
        Me.HabileteToolStripMenuItem.Name = "HabileteToolStripMenuItem"
        Me.HabileteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HabileteToolStripMenuItem.Text = "Profil &TIC"
        '
        'UtilisateurToolStripMenuItem
        '
        Me.UtilisateurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierMotDePasseToolStripMenuItem, Me.tsSeparateur1, Me.GererUtilisateursToolStripMenuItem})
        Me.UtilisateurToolStripMenuItem.Name = "UtilisateurToolStripMenuItem"
        Me.UtilisateurToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.UtilisateurToolStripMenuItem.Text = "&Utilisateur"
        '
        'ModifierMotDePasseToolStripMenuItem
        '
        Me.ModifierMotDePasseToolStripMenuItem.Name = "ModifierMotDePasseToolStripMenuItem"
        Me.ModifierMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ModifierMotDePasseToolStripMenuItem.Text = "&Modifier mot de passe"
        '
        'tsSeparateur1
        '
        Me.tsSeparateur1.Name = "tsSeparateur1"
        Me.tsSeparateur1.Size = New System.Drawing.Size(189, 6)
        '
        'GererUtilisateursToolStripMenuItem
        '
        Me.GererUtilisateursToolStripMenuItem.Name = "GererUtilisateursToolStripMenuItem"
        Me.GererUtilisateursToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GererUtilisateursToolStripMenuItem.Text = "&Gérer les utilisateurs"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(24, 20)
        Me.HelpMenu.Text = "&?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AboutToolStripMenuItem.Text = "À pr&opos de..."
        '
        'MDISGP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(738, 505)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDISGP"
        Me.Text = "Système de Gestion des Programmes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents GestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgrammeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilisateurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierMotDePasseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparateur1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GererUtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparateur3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HabileteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
