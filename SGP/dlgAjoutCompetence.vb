Imports System.Windows.Forms

Public Class dlgAjoutCompetence

    Private Sub dlgAjoutCompetence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chargement des données
        Me.P_SELECT_CodeProgrammeTableAdapter.Fill(Me.SGPDataSet.P_SELECT_CodeProgramme)
        RechercherCompetence()
    End Sub

    Private Sub cbCodeProgramme_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCodeProgramme.SelectedValueChanged
        RechercherCompetence()
    End Sub

    Private Sub btnAjouterCompetence_Click(sender As Object, e As EventArgs) Handles btnAjouterCompetence.Click
        'association des compétences sélectionnées au programme en cours de création/modification
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim taCompetenceProgramme = New SGPDataSetTableAdapters.QueriesTableAdapter
        For Each row As DataGridViewRow In dgvCompetences.SelectedRows
            taCompetenceProgramme.P_INSERT_ProgrammeCompetence(VariablesGlobales.idProgramme, row.Cells(0).Value)
        Next
        VariablesGlobales.modification = True
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnCreerCompetence_Click(sender As Object, e As EventArgs) Handles btnCreerCompetence.Click
        'création d'une nouvelle compétence
        Dim formulaireCompetence As New dlgFormulaireCompetence
        VariablesGlobales.actionSecondaire = Action.inserer
        formulaireCompetence.ShowDialog()

        'la compétence créée est directement ajoutée à la liste des compétences du programme
        If VariablesGlobales.actionSecondaire = Action.inserer And formulaireCompetence.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim taCompetenceProgramme = New SGPDataSetTableAdapters.QueriesTableAdapter
            taCompetenceProgramme.P_INSERT_ProgrammeCompetence(VariablesGlobales.idProgramme, VariablesGlobales.idCompetence)
            MsgBox("La compétence créée a bien été ajoutée à la liste des compétences du programme.", MsgBoxStyle.Information, "Compétence ajoutée")
            VariablesGlobales.modification = True
        End If
        RechercherCompetence()
        dgvCompetences.ClearSelection()
        SelectionneCompetence(VariablesGlobales.idCompetence)
    End Sub


    Private Sub RechercherCompetence()
        'recherche des compétences d'un programme 
        dgvCompetences.DataSource = P_SELECT_CompetencesTableAdapter.GetData(cbCodeProgramme.SelectedValue, VariablesGlobales.idProgramme)
    End Sub

    Private Sub SelectionneCompetence(intIdCompetence As Integer)

        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvCompetences.Rows.Count) And (Not blnTrouve)
            If dgvCompetences.Rows(intRangee).Cells(0).Value = intIdCompetence Then
                dgvCompetences.Rows(intRangee).Selected = True
                dgvCompetences.FirstDisplayedScrollingRowIndex = intRangee

                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub
End Class
