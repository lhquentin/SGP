Imports System.Windows.Forms

Public Class dlgListeElement

    Private Sub dlgListeElement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCompetence.DataSource = P_SELECT_CompetenceDevisTableAdapter().GetData(VariablesGlobales.idCours, VariablesGlobales.idDevis)
        gbListeCompetence.Text = "Liste des compétences (" + dgvCompetence.RowCount().ToString + ")"
        If dgvCompetence.SelectedRows.Count > 0 Then
            RechercheElement()
            btnAjouter.Enabled = True
        Else
            btnAjouter.Enabled = False
        End If
    End Sub

    Private Sub dgvCompetence_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCompetence.SelectionChanged
        If dgvCompetence.SelectedRows.Count > 0 Then
            RechercheElement()
            btnAjouter.Enabled = True
        Else
            btnAjouter.Enabled = False
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter

        For Each row As DataGridViewRow In dgvElement.SelectedRows
            monTa.P_INSERT_ElementCours(VariablesGlobales.idCours,
                                         row.Cells(0).Value)
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub RechercheElement()
        dgvElement.DataSource = P_SELECT_ElementCompetence_EXTableAdapter().GetData(dgvCompetence.SelectedRows(0).Cells(0).Value,
                                                                             VariablesGlobales.idCours)

        gbListeElement.Text = "Liste des éléments (" + dgvElement.RowCount().ToString + ")"
    End Sub
End Class
