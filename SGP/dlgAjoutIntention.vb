Imports System.Windows.Forms

Public Class dlgAjoutIntention
    Private Sub dlgAjoutIntention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rechercher()
        ActiverAjoutIntention(True)
        ActiverCreationIntention(False)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtIntention_TextChanged(sender As Object, e As EventArgs) Handles txtIntention.TextChanged
        Rechercher()
    End Sub

    Private Sub Rechercher()
        dgvIntentions.DataSource = P_SELECT_IntentionDevis_EXTableAdapter.GetData(txtIntention.Text, VariablesGlobales.idDevis)
    End Sub

    Private Sub ActiverCreationIntention(blnActiver As Boolean)
        txtTitreIntention.ReadOnly = Not blnActiver
        txtDescriptionIntention.ReadOnly = Not blnActiver
        btnValiderIntention.Enabled = blnActiver
        btnAnnulerIntention.Enabled = blnActiver
    End Sub

    Private Sub ActiverAjoutIntention(blnActiver As Boolean)
        txtIntention.ReadOnly = Not blnActiver
        btnAjouter.Enabled = blnActiver
        btnCreerIntention.Enabled = blnActiver
        dgvIntentions.Enabled = blnActiver
    End Sub

    Private Sub btnCréerIntention_Click(sender As Object, e As EventArgs) Handles btnCreerIntention.Click
        ActiverAjoutIntention(False)
        ActiverCreationIntention(True)
    End Sub

    Private Sub btnAnnulerIntention_Click(sender As Object, e As EventArgs) Handles btnAnnulerIntention.Click
        ActiverAjoutIntention(True)
        ActiverCreationIntention(False)
        txtTitreIntention.Clear()
        txtDescriptionIntention.Clear()
    End Sub

    Private Sub btnValiderIntention_Click(sender As Object, e As EventArgs) Handles btnValiderIntention.Click
        Dim taInsert As New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim numIntention As Integer

        If validerIntention() Then
            numIntention = taInsert.P_INSERT_Intention(txtTitreIntention.Text, txtDescriptionIntention.Text, VariablesGlobales.idDevis)
            
            ActiverAjoutIntention(True)
            ActiverCreationIntention(False)
            txtTitreIntention.Clear()
            txtDescriptionIntention.Clear()
            MsgBox("L'intention a été associée au devis avec succès!", MsgBoxStyle.Information, "Ajout de l'intention")
            Rechercher()
        End If

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim taIntentionDevis = New SGPDataSetTableAdapters.QueriesTableAdapter
        For Each row As DataGridViewRow In dgvIntentions.SelectedRows
            taIntentionDevis.P_INSERT_IntentionDevis(VariablesGlobales.idDevis, row.Cells(0).Value)
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function validerIntention() As Boolean
        If String.IsNullOrEmpty(txtTitreIntention.Text) Then
            MsgBox("Veuillez spécifier le titre de l'intention.")
            txtTitreIntention.Focus()
            Return (False)
        ElseIf String.IsNullOrEmpty(txtDescriptionIntention.Text) Then
            MsgBox("Veuillez spécifier une description de l'intention.")
            txtDescriptionIntention.Focus()
            Return (False)
        Else
            Return (True)
        End If
    End Function

    
End Class
