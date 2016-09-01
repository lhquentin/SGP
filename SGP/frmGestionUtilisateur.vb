Public Class frmGestionUtilisateur
    Private idUtilisateur As Integer
    Private Sub frmGestionUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRoleRecherche.DataSource = P_SELECT_RoleTableAdapter.GetData(True)
        cbRole.DataSource = P_SELECT_RoleTableAdapter.GetData(False)
        Rechercher()
        ActiverDetails(False)
        ActiverRecherche(True)

    End Sub

    Private Sub txtUtilisateurRecherche_TextChanged(sender As Object, e As EventArgs) Handles txtUtilisateurRecherche.TextChanged
        Rechercher()
    End Sub

    Private Sub cbRoleRecherche_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbRoleRecherche.SelectedValueChanged
        Rechercher()
    End Sub

    Private Sub Rechercher()
        dgvUtilisateur.DataSource = P_SELECT_UtilisateurTableAdapter.GetData(txtUtilisateurRecherche.Text, cbRoleRecherche.SelectedValue)
        ActiverResultats(True)
    End Sub

    Private Sub ActiverRecherche(blnActiver As Boolean)
        'gestion de l'activation de la recherche
        txtUtilisateurRecherche.ReadOnly = Not blnActiver
        cbRoleRecherche.Enabled = blnActiver
    End Sub

    Private Sub ActiverResultats(blnActiver As Boolean)
        'gestion de l'activation des résultats de la recherche
        dgvUtilisateur.Enabled = blnActiver
        btnModifier.Enabled = blnActiver
        btnSupprimer.Enabled = blnActiver
        btnCréer.Enabled = blnActiver
    End Sub

    Private Sub ActiverDetails(blnActiver As Boolean)
        'gestion de l'activation des détails
        If VariablesGlobales.monAction = Action.modifier Then
            cbRole.Enabled = False
            cbProgramme.Enabled = False
        Else
            cbRole.Enabled = blnActiver
            cbProgramme.Enabled = blnActiver
        End If
        txtNom.ReadOnly = Not blnActiver
        txtPrenom.ReadOnly = Not blnActiver
        txtCourriel.ReadOnly = Not blnActiver
        btnEnregistrer.Enabled = blnActiver
        btnAnnuler.Enabled = blnActiver
    End Sub


    Private Sub dgvUtilisateur_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUtilisateur.SelectionChanged
        'lors du changement de la sélection dans le dgv
        If dgvUtilisateur.SelectedRows.Count > 0 Then
            Dim taUtilisateur = New SGPDataSetTableAdapters.P_SELECT_Utilisateur_PKTableAdapter
            Dim dtUtilisateur As DataTable
            'affichage des données du nouvel utilisateur sélectionné
            dtUtilisateur = taUtilisateur.GetData(dgvUtilisateur.SelectedRows(0).Cells(0).Value)
            If dtUtilisateur.Rows.Count > 0 Then
                txtNom.Text = dtUtilisateur.Rows(0)("nomUTILISATEUR")
                txtPrenom.Text = dtUtilisateur.Rows(0)("prenomUTILISATEUR")
                txtCourriel.Text = dtUtilisateur.Rows(0)("courriel")
                cbRole.SelectedValue = dtUtilisateur.Rows(0)("idRole")
                If cbRole.SelectedValue = 2 Then
                    cbProgramme.Visible = True
                    lbProgramme.Visible = True
                    cbProgramme.SelectedValue = dtUtilisateur.Rows(0)("Programme")
                Else
                    cbProgramme.Visible = False
                    lbProgramme.Visible = False
                End If
            Else
                ViderDetails()
            End If
        End If
    End Sub

    Private Sub ViderDetails()
        txtNom.Clear()
        txtPrenom.Clear()
        txtCourriel.Clear()
        cbRole.SelectedValue = -1
        cbProgramme.SelectedValue = -1
    End Sub



    Private Sub btnCréer_Click(sender As Object, e As EventArgs) Handles btnCréer.Click
        ActiverDetails(True)
        ActiverRecherche(False)
        ActiverResultats(False)
        ViderDetails()
        VariablesGlobales.monAction = Action.inserer
    End Sub
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        VariablesGlobales.monAction = Action.modifier
        ActiverDetails(True)
        ActiverRecherche(False)
        ActiverResultats(False)
        idUtilisateur = dgvUtilisateur.SelectedRows(0).Cells(0).Value
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        'validation de la création/modification d'un utilisateur
        Dim utilitaireMdp As New UtilitaireMDP
        Dim taUtilisateur = New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim motDePasse As String = utilitaireMdp.GenererChaineDeCaracteres
        Dim sel As String = utilitaireMdp.GenererSel
        Dim mdpHashe As String = utilitaireMdp.GenererHash(motDePasse, sel)
        'si les champs requis sont remplis
        If ValiderUtilisateur() Then
            Select Case VariablesGlobales.monAction
                'si on crée un nouvel utilisateur
                Case Action.inserer
                    'si c'est un enseignant
                    If cbRole.SelectedValue = 2 Then
                        taUtilisateur.P_INSERT_Enseignant(txtNom.Text,
                                                          txtPrenom.Text,
                                                          sel,
                                                          mdpHashe,
                                                          txtCourriel.Text,
                                                          cbRole.SelectedValue,
                                                          cbProgramme.SelectedValue)

                        'si c'est un administrateur
                    Else
                        taUtilisateur.P_INSERT_Administrateur(txtNom.Text,
                                                          txtPrenom.Text,
                                                          sel,
                                                          mdpHashe,
                                                          txtCourriel.Text,
                                                          cbRole.SelectedValue)
                    End If

                    'si on modifie les données d'un utilisateur
                Case Action.modifier
                    idUtilisateur = dgvUtilisateur.SelectedRows(0).Cells(0).Value
                    taUtilisateur.P_UPDATE_Utilisateur(idUtilisateur,
                                                        txtNom.Text,
                                                        txtPrenom.Text,
                                                        txtCourriel.Text)
                Case Else

            End Select

            VariablesGlobales.monAction = -1
            ActiverDetails(False)
            ActiverRecherche(True)
            ActiverResultats(True)
            ViderDetails()
            Rechercher()
            SelectionnerUtilisateur(idUtilisateur)
            idUtilisateur = -1
        End If
    End Sub


    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        ActiverDetails(False)
        ActiverRecherche(True)
        ActiverResultats(True)
        ViderDetails()
        idUtilisateur = -1
        Rechercher()
    End Sub

    Private Sub cbRole_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedValueChanged
        'si le rôle sélectionné est enseignant, on doit l'associer à un programme
        If cbRole.SelectedValue = 2 Then
            cbProgramme.Visible = True
            lbProgramme.Visible = True
            cbProgramme.DataSource = P_SELECT_TitreProgrammeListeTableAdapter.GetData()
        Else
            cbProgramme.Visible = False
            lbProgramme.Visible = False
        End If

    End Sub

    Private Sub SelectionnerUtilisateur(idUtilisateurSelectionne As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvUtilisateur.Rows.Count) And (Not blnTrouve)
            If dgvUtilisateur.Rows(intRangee).Cells(0).Value = idUtilisateurSelectionne Then
                dgvUtilisateur.Rows(intRangee).Selected = True
                dgvUtilisateur.FirstDisplayedScrollingRowIndex = intRangee
                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If dgvUtilisateur.SelectedRows.Count = 1 Then
            If MsgBox("Désirez vous vraiment supprimer cet utilisateur?", MsgBoxStyle.YesNo, "Suppression d'un utilisateur") = MsgBoxResult.Yes Then
                'suppr enreg
                Dim taUtilisateur As New SGPDataSetTableAdapters.QueriesTableAdapter

                taUtilisateur.P_DELETE_Utilisateur(dgvUtilisateur.SelectedRows(0).Cells(0).Value)
                Rechercher()
            End If
        End If
    End Sub

    Private Function ValiderUtilisateur() As Boolean
        'vérifie si les champs obligatoires sont remplis et bien saisis
        'courriel
        If String.IsNullOrEmpty(txtCourriel.Text) Or Not txtCourriel.Text.Contains("@") Then
            MsgBox("Veuillez spécifier une adresse mail correcte.")
            Return False

            'rôle
        ElseIf cbRole.SelectedValue < 1 Then
            MsgBox("Veuillez spécifier le rôle de l'utilisateur.")
            Return False
        Else
            Return True
        End If
    End Function
End Class