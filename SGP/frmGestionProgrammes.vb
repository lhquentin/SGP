Public Class frmGestionProgrammes

    Private Sub frmGestionProgrammes_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbTypeSanction.DataSource = P_SELECT_Type_SanctionTableAdapter.GetData(True)
        cbTypeProgramme.DataSource = P_SELECT_Type_ProgrammeTableAdapter.GetData(True, cbTypeSanction.SelectedValue)
        RechercherProgramme()
    End Sub

    Private Sub txtProgramme_TextChanged(sender As Object, e As EventArgs) Handles txtProgramme.TextChanged
        RechercherProgramme()
    End Sub

    Private Sub cbTypeProgramme_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTypeProgramme.SelectedValueChanged
        RechercherProgramme()
    End Sub

    Public Sub RechercherProgramme()
        'si l'utilisateur est un enseignant
        If VariablesGlobales.idRole = 2 Then
            dgvProgrammes.DataSource = P_SELECT_ProgrammeEnseignantTableAdapter.GetData(VariablesGlobales.idUtilisateur, txtProgramme.Text, cbTypeSanction.SelectedValue, cbTypeProgramme.SelectedValue)

            'si c'est un administrateur
        Else
            dgvProgrammes.DataSource = P_SELECT_ProgrammesTableAdapter().GetData(txtProgramme.Text, cbTypeSanction.SelectedValue, cbTypeProgramme.SelectedValue)
        End If

    End Sub

    Private Sub cbTypeSanction_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTypeSanction.SelectedValueChanged
        'sélection du contenu de la combobox du type de programme selon le type de sanction choisi
        cbTypeProgramme.DataSource = P_SELECT_Type_ProgrammeTableAdapter.GetData(True, cbTypeSanction.SelectedValue)
        RechercherProgramme()
    End Sub

    Private Sub btnCreerPrograme_Click(sender As Object, e As EventArgs) Handles btnCreerProgramme.Click
        'création d'un nouveau programme
        VariablesGlobales.monAction = Action.inserer

        Dim formulaireProgramme As New dlgDonneesProgramme
        AddHandler formulaireProgramme.FormClosed, AddressOf formulaireProgramme_FormClosed
        formulaireProgramme.ShowDialog()

    End Sub

    Private Sub btnDetailsProgramme_Click(sender As Object, e As EventArgs) Handles btnDetailsProgramme.Click
        'consultation des données du programme sélectionné
        Dim formulaireProgramme As New dlgDonneesProgramme

        If dgvProgrammes.SelectedRows.Count = 1 Then
            VariablesGlobales.monAction = Action.consulter
            VariablesGlobales.idProgramme = dgvProgrammes.SelectedRows(0).Cells(0).Value
            AddHandler formulaireProgramme.FormClosed, AddressOf formulaireProgramme_FormClosed
            formulaireProgramme.Text = dgvProgrammes.SelectedRows(0).Cells(1).Value + " " + dgvProgrammes.SelectedRows(0).Cells(2).Value
            formulaireProgramme.ShowDialog()
        End If
    End Sub

    Private Sub formulaireProgramme_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        'lors de la fermeture d'une fenêtre de création/modification de programme
        Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter
        'actualisation du dgv et sélection du programme
        RechercherProgramme()
        SelectionnerProgramme(VariablesGlobales.idProgramme)
        VariablesGlobales.monAction = -1
        VariablesGlobales.idProgramme = -1
        VariablesGlobales.butProgramme = ""
        VariablesGlobales.intentionEducativesProgramme = ""
        VariablesGlobales.actionDonnees = Action.modifier
        'suppression des compétences liées à aucun programme
        monTa.P_DELETE_CompetenceSansProgramme()

    End Sub

    Private Sub SelectionnerProgramme(idProgramme As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvProgrammes.Rows.Count) And (Not blnTrouve)
            If dgvProgrammes.Rows(intRangee).Cells(0).Value = idProgramme Then
                dgvProgrammes.Rows(intRangee).Selected = True
                dgvProgrammes.FirstDisplayedScrollingRowIndex = intRangee
                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub
End Class
