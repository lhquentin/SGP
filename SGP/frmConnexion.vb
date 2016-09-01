Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class frmConnexion


    Dim taUtilisateur As New SGPDataSetTableAdapters.P_SELECT_Utilisateur_CourrielTableAdapter
    Dim dtUtilisateur As DataTable

    Public continuer As Boolean

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim UtilMdp As New UtilitaireMDP

        'récupération des données de l'utilisateur
        dtUtilisateur = taUtilisateur.GetData(txtCourriel.Text)

        If dtUtilisateur.Rows.Count > 0 Then
            'récupération du mot de passe de l'utilisateur
            Dim taMdp As New SGPDataSetTableAdapters.P_SELECT_MotDePasseTableAdapter
            Dim dtMdp As DataTable
            dtMdp = taMdp.GetData(dtUtilisateur.Rows(0).Item(0))

            VariablesGlobales.idUtilisateur = dtUtilisateur.Rows(0)("idUTILISATEUR")
            VariablesGlobales.idRole = dtUtilisateur.Rows(0)("idROLE")
            VariablesGlobales.nomUtilisateur = dtUtilisateur.Rows(0)("Utilisateur")

            Dim mdpSel As String = dtMdp.Rows(0)("mdpSel")
            Dim mdpHash As String = dtMdp.Rows(0)("mdpHash")

            If UtilMdp.VerifierMDP(txtMotDePasse.Text, mdpSel, mdpHash) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                continuer = True
                Me.Close()
                MDISGP.Text = MDISGP.Text + " - " + VariablesGlobales.nomUtilisateur
            Else
                MsgBox("Le mot de passe est incorrect!", MsgBoxStyle.Critical, "Erreur de saisie")
            End If
        Else
            MsgBox("Le courriel est incorrect!", MsgBoxStyle.Critical, "Erreur de saisie")
        End If
    End Sub

    Private Sub frmConnexion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Me.DialogResult = Windows.Forms.DialogResult.Cancel Then
            MDISGP.Close()
        End If
    End Sub

    Private Sub llbReinitialiserMdp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbReinitialiserMdp.LinkClicked
        dtUtilisateur = taUtilisateur.GetData(txtCourriel.Text)

        If dtUtilisateur.Rows.Count > 0 Then

            VariablesGlobales.idUtilisateur = dtUtilisateur.Rows(0)("idUTILISATEUR")

            If MsgBox("Désirez-vous vraiment réinitialiser votre mot de passe ?", MsgBoxStyle.YesNo, "Réinitialisation de mot de passe") = MsgBoxResult.Yes Then
                Try
                    'envoi de nouveau mot de passe par courriel
                    Dim mail As String = txtCourriel.Text

                    envoyerCourriel(mail, nouveauMotDePasse(VariablesGlobales.idUtilisateur))
                    MsgBox("Votre nouveau mot de passe vous a été envoyer par mail.", MsgBoxStyle.Information)

                Catch ex As Exception
                    MsgBox("Une erreur est survenue lors de l'envoi du courriel: " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        Else
            MsgBox("Le courriel est incorrect!", MsgBoxStyle.Critical, "Erreur de saisie")
        End If
    End Sub

    Private Sub envoyerCourriel(courriel As String, mdp As String)
        Dim Mailmsg As New MailMessage()

        Mailmsg.To.Add(courriel)
        Mailmsg.Subject = "SGP - Réinitialisation mot de passe"
        Mailmsg.Body = "Voici votre nouveau mot de passe: " + mdp
        Mailmsg.IsBodyHtml = True
        Mailmsg.From = New MailAddress(SGP.My.Settings.SMTPAccount)


        Dim Smtp As New SmtpClient

        Smtp.Host = SGP.My.Settings.SMTPHost
        Smtp.Port = SGP.My.Settings.SMTPPort

        Smtp.Send(Mailmsg)
    End Sub

    Public Function nouveauMotDePasse(idUtilisateur As Integer) As String
        Dim maRequete As New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim utilMdp As New UtilitaireMDP
        Dim nouveauMdp As String
        Dim nouveauMdpSel As String
        Dim nouveauMdpHash As String

        nouveauMdp = utilMdp.GenererChaineDeCaracteres()
        nouveauMdpSel = utilMdp.GenererSel()
        nouveauMdpHash = utilMdp.GenererHash(nouveauMdp, nouveauMdpSel)

        maRequete.P_UPDATE_MotDePasse(idUtilisateur, nouveauMdpSel, nouveauMdpHash)

        Return nouveauMdp
    End Function
End Class
