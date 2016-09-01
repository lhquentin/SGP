Imports System.Windows.Forms

Public Class dlgListeIntention

    Private Sub dlgListeIntention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvListeIntention.DataSource = P_SELECT_IntentionCours_EXTableAdapter().GetData(VariablesGlobales.idCours, VariablesGlobales.idDevis)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouterIntention.Click
        Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter

        For Each row As DataGridViewRow In dgvListeIntention.SelectedRows
            monTa.P_INSERT_IntentionCours(VariablesGlobales.idCours,
                                          row.Cells(0).Value)
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
