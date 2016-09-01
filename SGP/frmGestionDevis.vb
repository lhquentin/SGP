Public Class frmGestionDevis
    Private estOfficiel As Boolean
    Private formulaireDevis As dlgDonneesDevis
    Private Sub frmGestionDevis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VariablesGlobales.idRole = 1 Then
            cbRechercheProgramme.DataSource = P_SELECT_Programme_ListeTableAdapter.GetData(True)
        ElseIf VariablesGlobales.idRole = 2 Then
            cbRechercheProgramme.DataSource = P_SELECT_Programme_Liste_EnseignantTableAdapter.GetData(VariablesGlobales.idUtilisateur, 1)
        End If

        cbRechercheProgramme.SelectedIndex = 0
        rbDevisTous.Checked = 1
        RechercherDevis()
        dgvDevis.Focus()
    End Sub

    Private Sub cbRechercheProgramme_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbRechercheProgramme.SelectedValueChanged
        RechercherDevis()
    End Sub

    Private Sub rbDevisTous_CheckedChanged(sender As Object, e As EventArgs) Handles rbDevisTous.CheckedChanged
        RechercherDevis()
    End Sub

    Private Sub rbDevisOfficiels_CheckedChanged(sender As Object, e As EventArgs) Handles rbDevisOfficiels.CheckedChanged
        RechercherDevis()
    End Sub

    Private Sub rbDevisNonOfficiels_CheckedChanged(sender As Object, e As EventArgs) Handles rbDevisNonOfficiels.CheckedChanged
        RechercherDevis()
    End Sub

    Public Sub RechercherDevis()
        Dim intOfficiel As Integer
        If rbDevisNonOfficiels.Checked Then
            intOfficiel = 0
        ElseIf rbDevisOfficiels.Checked Then
            intOfficiel = 1
        Else
            intOfficiel = 2
        End If
        'si l'utilisateur est un admisitrateur
        If VariablesGlobales.idRole = 1 Then
            dgvDevis.DataSource = P_SELECT_DevisTableAdapter.GetData(cbRechercheProgramme.SelectedValue, intOfficiel)

            'si c'est un enseignant
        Else
            dgvDevis.DataSource = P_SELECT_Devis_EnseignantTableAdapter.GetData(VariablesGlobales.idUtilisateur, cbRechercheProgramme.SelectedValue, intOfficiel)
        End If
    End Sub

    Private Sub btnAjouterDevis_Click(sender As Object, e As EventArgs) Handles btnAjouterDevis.Click
        formulaireDevis = New dlgDonneesDevis
        VariablesGlobales.monAction = Action.inserer
        AddHandler formulaireDevis.FormClosed, AddressOf formulaireDevis_FormClosed
        formulaireDevis.ShowDialog()
    End Sub

    Private Sub btnDetailsDevis_Click(sender As Object, e As EventArgs) Handles btnDetailsDevis.Click
        If dgvDevis.SelectedRows.Count > 0 Then
            formulaireDevis = New dlgDonneesDevis
            VariablesGlobales.monAction = Action.consulter
            VariablesGlobales.idDevis = dgvDevis.SelectedRows(0).Cells(0).Value
            AddHandler formulaireDevis.FormClosed, AddressOf formulaireDevis_FormClosed
            formulaireDevis.Text = "Devis de " + dgvDevis.SelectedRows(0).Cells(1).Value
            formulaireDevis.ShowDialog()
        End If
    End Sub

    Private Sub formulaireDevis_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        'lors de la fermeture de la fenêtre de création/modification des devis
        Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter
        'si on a validé
        If formulaireDevis.DialogResult = Windows.Forms.DialogResult.OK Then
            'on actualise le dgv et on sélectionne le devis créé/modifié
            RechercherDevis()
            SelectionnerDevis(VariablesGlobales.idDevis)
        Else
            'si on a annulé une création, on supprime le devis
            If VariablesGlobales.monAction = Action.inserer Then
                monTa.P_DELETE_Devis(VariablesGlobales.idDevis)
            End If
        End If

        VariablesGlobales.monAction = -1
        VariablesGlobales.idDevis = -1
        VariablesGlobales.epreuveSynthese = ""
        VariablesGlobales.profilDiplome = ""
        VariablesGlobales.santeSecurite = ""
        VariablesGlobales.devisOfficiel = False
        VariablesGlobales.actionDonnees = Action.modifier
        'supression des intentions et cours qui ne sont liés à aucun devis 
        monTa.P_DELETE_IntentionSansDevis()
        monTa.P_DELETE_CoursSansDevis()
    End Sub

    Private Sub SelectionnerDevis(idDevis As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvDevis.Rows.Count) And (Not blnTrouve)
            If dgvDevis.Rows(intRangee).Cells(0).Value = idDevis Then
                dgvDevis.Rows(intRangee).Selected = True
                dgvDevis.FirstDisplayedScrollingRowIndex = intRangee
                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Sub btnGenerer_Click(sender As Object, e As EventArgs) Handles btnGenerer.Click
        Dim taDevis As New SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter
        Dim choixGeneration = New dlgChoixGeneration
        'ouverture de la fenêtre de choix du document à générer
        If dgvDevis.SelectedRows.Count = 1 Then
            VariablesGlobales.idDevis = dgvDevis.SelectedRows(0).Cells(0).Value
            choixGeneration.ShowDialog()
        End If
    End Sub


End Class