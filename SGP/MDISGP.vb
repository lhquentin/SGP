Imports System.Windows.Forms

Public Class MDISGP
    Public nomUtilisateur As String
    Public idUtilisateur As Integer
    Public administrateur As Boolean
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDISGP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        administrateur = False
        'ouverture de la fenêtre de connexion
        Dim connexion As New frmConnexion
        connexion.ShowDialog()


        'après validation de la connexion
        If (connexion.continuer) Then
            nomUtilisateur = VariablesGlobales.nomUtilisateur
            idUtilisateur = VariablesGlobales.idUtilisateur
            'si l'utilisateur n'est pas admin, il ne peut pas gérer les utilisateurs ni les habiletés
            If VariablesGlobales.idRole <> 1 Then
                HabileteToolStripMenuItem.Visible = False
                GererUtilisateursToolStripMenuItem.Visible = False
                tsSeparateur1.Visible = False
                tsSeparateur3.Visible = False
            End If

        Else
            Me.Close()
        End If
    End Sub


    'ouverture des fenetres
    Private Sub ProgrammeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammeToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmGestionProgrammes Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New frmGestionProgrammes
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub CoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoursToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmGestionCours Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New frmGestionCours
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub DevisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevisToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmGestionDevis Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New frmGestionDevis
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub FrmConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmConnexion Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New frmConnexion
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub ModifierMotDePasseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierMotDePasseToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmModifierMdp Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New frmModifierMdp
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub GérerUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GererUtilisateursToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmGestionUtilisateur Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New frmGestionUtilisateur
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub HabiletéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabileteToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is frmGestionHabilete Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New frmGestionHabilete
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim ChildForm As New dlgApropos
        ChildForm.ShowDialog()
    End Sub
End Class
