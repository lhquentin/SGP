Imports System.Windows.Forms

Public Class dlgSelectionDevis

    Private Sub dlgSelectionDevis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        dgvDevis.DataSource = P_SELECT_DevisTableAdapter().GetData(0, 0)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectionne.Click
        VariablesGlobales.idDevisCours = dgvDevis.SelectedRows(0).Cells(0).Value

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
