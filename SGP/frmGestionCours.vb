Public Class frmGestionCours
    Private exclusion As Integer
    Private Sub frmGestionCours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'vérifie avec quel formulaire il a été ouvert
        If VariablesGlobales.actionSecondaire = Action.ajoutCoursDevis Then
            'à partir du devis
            exclusion = 1
        Else
            'directement depuis le MDI
            exclusion = 0
        End If

        RechercheCours()
    End Sub

    Private Sub txtCours_TextChanged(sender As Object, e As EventArgs) Handles txtCours.TextChanged
        RechercheCours()
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        VariablesGlobales.monAction = Action.inserer

        Dim formulaireCours As New dlgFormulaireCours

        If exclusion = 1 Then
            formulaireCours.ShowDialog()
        Else

            Dim selectionDevis As New dlgSelectionDevis
            selectionDevis.ShowDialog()

            If selectionDevis.DialogResult <> Windows.Forms.DialogResult.Cancel Then
                formulaireCours.ShowDialog()
            End If

            VariablesGlobales.monAction = -1
        End If

        RechercheCours()
        SelectionnerCours(VariablesGlobales.idCours)

        VariablesGlobales.idCours = -1
        VariablesGlobales.idDevisCours = -1
        VariablesGlobales.descriptionCours = ""
        If exclusion = 1 And formulaireCours.DialogResult = Windows.Forms.DialogResult.OK Then
            VariablesGlobales.modification = True
        End If
        VariablesGlobales.justification = Nothing
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        VariablesGlobales.monAction = Action.consulter
        VariablesGlobales.idCours = dgvCours.SelectedRows(0).Cells(0).Value
        Dim formulaireCours As New dlgFormulaireCours
        formulaireCours.Text = dgvCours.SelectedRows(0).Cells(1).Value + " " + dgvCours.SelectedRows(0).Cells(2).Value
        formulaireCours.ShowDialog()

        RechercheCours()
        SelectionnerCours(VariablesGlobales.idCours)

        VariablesGlobales.idCours = -1
        VariablesGlobales.descriptionCours = ""
        VariablesGlobales.monAction = -1
        VariablesGlobales.actionPrealable = -1
        VariablesGlobales.idDevisCours = -1
        VariablesGlobales.justification = Nothing
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim taCoursDevis = New SGPDataSetTableAdapters.QueriesTableAdapter
        For Each row As DataGridViewRow In dgvCours.SelectedRows
            taCoursDevis.P_INSERT_CoursDevis(VariablesGlobales.idDevis, row.Cells(0).Value)
        Next
        VariablesGlobales.modification = True
        Me.Close()
    End Sub

    Public Sub RechercheCours()
        If VariablesGlobales.idRole = 1 Then
            dgvCours.DataSource = P_SELECT_CoursTableAdapter().GetData(txtCours.Text, exclusion, VariablesGlobales.idDevis)
        ElseIf VariablesGlobales.idRole = 2 Then
            dgvCours.DataSource = P_SELECT_Cours_EnseignantTableAdapter.GetData(txtCours.Text, exclusion, VariablesGlobales.idDevis, VariablesGlobales.idUtilisateur)
        End If

        If dgvCours.SelectedRows.Count = 0 Then
            btnDetail.Enabled = False
        Else
            btnDetail.Enabled = True
        End If
    End Sub

    Private Sub SelectionnerCours(idCours As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False
        dgvCours.Rows(0).Selected = False
        While (intRangee < dgvCours.Rows.Count) And (Not blnTrouve)
            If dgvCours.Rows(intRangee).Cells(0).Value = idCours Then
                dgvCours.Rows(intRangee).Selected = True
                dgvCours.FirstDisplayedScrollingRowIndex = intRangee
                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub dgvCours_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCours.SelectionChanged
        If dgvCours.SelectedRows.Count <> 1 Then
            btnDetail.Enabled = False
        ElseIf btnDetail.Enabled = False Then
            btnDetail.Enabled = True
        End If
    End Sub
End Class