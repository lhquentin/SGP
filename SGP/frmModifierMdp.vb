Public Class frmModifierMdp

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        If txtNouveauMdp.Text = txtConfirmerMdp.Text Then
            Dim maRequete As New SGPDataSetTableAdapters.QueriesTableAdapter
            Dim utilMdp As New UtilitaireMDP
            Dim nouveauMdpSel As String
            Dim nouveauMdpHash As String

            nouveauMdpSel = utilMdp.GenererSel()
            nouveauMdpHash = utilMdp.GenererHash(txtNouveauMdp.Text, nouveauMdpSel)

            maRequete.P_UPDATE_MotDePasse(VariablesGlobales.idUtilisateur, nouveauMdpSel, nouveauMdpHash)

            MsgBox("Votre mot de passe a été modifié.", MsgBoxStyle.Information)

            Me.Close()
        Else
            MsgBox("Les mots de passe ne correspondent pas!", MsgBoxStyle.Critical, "Erreur de saisie")
        End If
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub
End Class