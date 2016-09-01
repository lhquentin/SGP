Imports System.Windows.Forms

Public Class dlgDonneesDevis
    Private chbCochee As Boolean
    Private listeIntentions As List(Of Integer)
    Private listeCours As List(Of Integer)
    Private svgMonAction = New Action
    Private svgIdDevis As Integer
    Private idProgramme As Integer
    Private blnModifie = False
    Private blnDonneesSaisies = False
    Private action As New Action

    Dim programmeDevis As Integer
    Dim profilDiplome As String
    Dim epreuveSynthese As String
    Dim santeSecurite As String
    Dim commentaire As String
    Dim officiel As Boolean
    Dim profil As String
    Dim epreuve As String
    Dim santeSecu As String
    Dim nomPoliceRtfProfilDiplome As String = ""
    Dim taillePoliceRtfProfilDiplome As Integer
    Dim nomPoliceRtfEpreuveSynthese As String = ""
    Dim taillePoliceRtfEpreuveSynthese As Integer
    Dim nomPoliceRtfSanteSecurite As String = ""
    Dim taillePoliceRtfSanteSecurite As Integer

    Private Sub dlgDonneesDevis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        cbProgramme.DataSource = P_SELECT_Programme_ListeTableAdapter.GetData(False)
        'activation/désactivation de l'affichage des éléments du contenu et chargement des données en fonction des
        'valeurs des variables globales
        ActiverCoursIntentions(False)
        ActiverInfosDevis(False)

        If VariablesGlobales.monAction = Action.inserer Then
            'si création d'un devis
            cbProgramme.SelectedIndex = -1
            ActiverInfosDevis(True)
            btnAnnulerInfos.Enabled = False
            btnModifier.Visible = False

        ElseIf VariablesGlobales.monAction = Action.consulter Then
            'si modification d'un devis
            Dim taDevis As New SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter
            Dim dtDevis = taDevis.GetData(VariablesGlobales.idDevis)

            'remplissage du formulaire avec les données de la base
            If dtDevis.Rows.Count > 0 Then
                idProgramme = dtDevis.Rows(0)("idPROGRAMME")
                cbProgramme.SelectedValue = idProgramme
                txtCommentaire.Text = dtDevis.Rows(0)("commentaire")
                VariablesGlobales.profilDiplome = dtDevis.Rows(0)("profilDiplome")
                VariablesGlobales.epreuveSynthese = dtDevis.Rows(0)("epreuveSynthese")
                VariablesGlobales.santeSecurite = dtDevis.Rows(0)("santeSecurite")
                chbOfficiel.Checked = dtDevis.Rows(0)("estOfficiel")
            End If
            If chbOfficiel.Checked Then
                btnModifier.Enabled = False
                VariablesGlobales.devisOfficiel = True
            End If
            chbCochee = False
            btnValiderInfos.Visible = False
            btnAnnulerInfos.Visible = False
            btnModifierInfos.Visible = False
            RechercherCours()
            RechercherIntention()

            'sauvegarde des liens avec les cours et les intentions en cas de modification de ceux-ci, puis d'annulation
            listeCours = New List(Of Integer)
            listeIntentions = New List(Of Integer)
            For Each row As DataGridViewRow In dgvCours.Rows
                listeCours.Add(row.Cells(0).Value)
            Next
            For Each row As DataGridViewRow In dgvIntentions.Rows
                listeIntentions.Add(row.Cells(0).Value)
            Next


        End If
    End Sub

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
        'validation de l'ensemble des données saisies sur le devis
        Dim formulaireDate As New dlgDateOfficialisation
        Dim taDevis = New SGPDataSetTableAdapters.QueriesTableAdapter

        'affichage de la fenêtre de choix de la date de validation si la checkbox d'officialisation est cochée
        If (chbOfficiel.Checked And VariablesGlobales.monAction = Action.inserer) Or (chbOfficiel.Checked And chbCochee) Then
            formulaireDate.ShowDialog()
            If formulaireDate.DialogResult = Windows.Forms.DialogResult.OK Then
                'enregistrement de la date dans la base de données
                taDevis.P_UPDATE_Devis_Date(VariablesGlobales.idDevis,
                                            VariablesGlobales.dateOfficialisation)
            Else
                Return
            End If
            'en cas de modification d'un devis, sauvegarde des nouvelles données saisies
        ElseIf VariablesGlobales.monAction = action.modifier Then
            'profil du diplômé
            If Not VariablesGlobales.profilDiplome = "" And Not nomPoliceRtfProfilDiplome = "" Then
                'remplacement de la police et taille du texte
                profil = VariablesGlobales.profilDiplome.Replace(nomPoliceRtfProfilDiplome, "Calibri").Replace("fs" + taillePoliceRtfProfilDiplome.ToString(), "fs22")
                nomPoliceRtfProfilDiplome = Nothing
                taillePoliceRtfProfilDiplome = Nothing
            Else
                profil = VariablesGlobales.profilDiplome
            End If
            'épreuve synthèse
            If Not VariablesGlobales.epreuveSynthese = "" And Not nomPoliceRtfEpreuveSynthese = "" Then
                epreuve = VariablesGlobales.epreuveSynthese.Replace(nomPoliceRtfEpreuveSynthese, "Calibri").Replace("fs" + taillePoliceRtfEpreuveSynthese.ToString(), "fs22")
                nomPoliceRtfEpreuveSynthese = Nothing
                taillePoliceRtfEpreuveSynthese = Nothing
            Else
                epreuve = VariablesGlobales.epreuveSynthese
            End If
            'santé et sécurité
            If Not VariablesGlobales.santeSecurite = "" And Not nomPoliceRtfSanteSecurite = "" Then
                santeSecu = VariablesGlobales.santeSecurite.Replace(nomPoliceRtfSanteSecurite, "Calibri").Replace("fs" + taillePoliceRtfSanteSecurite.ToString(), "fs22")
                nomPoliceRtfSanteSecurite = Nothing
                taillePoliceRtfSanteSecurite = Nothing
            Else
                santeSecu = VariablesGlobales.santeSecurite
            End If
            'autres données
            taDevis.P_UPDATE_Devis(VariablesGlobales.idDevis,
                                  cbProgramme.SelectedValue,
                                  profil,
                                 epreuve,
                                  santeSecu,
                                  txtCommentaire.Text)
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Dim taDevis = New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim connexion As New System.Data.SqlClient.SqlConnection
        Dim transaction As System.Data.SqlClient.SqlTransaction

        'en cas d'annulation, si des changements ont été faits, on les annule
        If VariablesGlobales.monAction = action.modifier And blnModifie Then
            'demande de confirmation
            If MsgBox("Les modifications ne seront pas sauvegardées. Voulez-vous continuer?", MsgBoxStyle.YesNo, "Annuler le devis") = MsgBoxResult.Yes Then
                'transaction de l'annulation
                Dim commandeInsertIntention As New System.Data.SqlClient.SqlCommand
                Dim commandeInsertCours As New System.Data.SqlClient.SqlCommand
                Try
                    connexion.ConnectionString = SGP.My.Settings.H2016_Stage_Yoann_QuentinConnectionString
                    connexion.Open()

                    'Déclaration des commandes
                    commandeInsertIntention.Connection = connexion
                    commandeInsertIntention.CommandType = CommandType.StoredProcedure
                    commandeInsertIntention.CommandText = "P_INSERT_IntentionDevis"

                    commandeInsertCours.Connection = connexion
                    commandeInsertCours.CommandType = CommandType.StoredProcedure
                    commandeInsertCours.CommandText = "P_INSERT_CoursDevis"

                    'Ajout de paramètres aux commandes
                    commandeInsertIntention.Parameters.Add("idDevis", SqlDbType.Int)
                    commandeInsertIntention.Parameters.Add("idIntention", SqlDbType.Int)
                    commandeInsertIntention.Parameters(0).Value = VariablesGlobales.idDevis

                    commandeInsertCours.Parameters.Add("idDevis", SqlDbType.Int)
                    commandeInsertCours.Parameters.Add("idCours", SqlDbType.Int)
                    commandeInsertCours.Parameters(0).Value = VariablesGlobales.idDevis

                    'Début de la transaction
                    transaction = connexion.BeginTransaction
                    commandeInsertIntention.Transaction = transaction
                    commandeInsertCours.Transaction = transaction
                  
                    'suppression des liens avec les cours et intentions
                    SupprimerCoursDevis(connexion, transaction, VariablesGlobales.idDevis)
                    SupprimerIntentionDevis(connexion, transaction, VariablesGlobales.idDevis)

                    'remise en place des liens avec les cours et intentions précédemment liées au devis
                    For Each id As Integer In listeIntentions
                        commandeInsertIntention.Parameters(1).Value = id
                        commandeInsertIntention.ExecuteNonQuery()
                    Next

                    For Each id As Integer In listeCours
                        commandeInsertCours.Parameters(1).Value = id
                        commandeInsertCours.ExecuteNonQuery()
                    Next
                    transaction.Commit()
                Catch ex As Exception
                    MsgBox("Erreur lors de l'enregistrement des intentions et des cours. Les autres données ont bien été enregistrées. " + ex.Message)
                    transaction.Rollback()
                Finally
                    connexion.Close()
                End Try
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
            'si création d'un devis
        ElseIf VariablesGlobales.monAction = action.inserer And blnDonneesSaisies Then
            If MsgBox("Les données saisies ne seront pas sauvegardées. Voulez-vous continuer?", MsgBoxStyle.YesNo, "Annuler le devis") = MsgBoxResult.Yes Then
                taDevis.P_DELETE_Devis(VariablesGlobales.idDevis)
                Dim commandeDeleteDevis As New System.Data.SqlClient.SqlCommand
                'transaction d'annulation
                Try
                    connexion.ConnectionString = SGP.My.Settings.H2016_Stage_Yoann_QuentinConnectionString
                    connexion.Open()

                    'Déclaration des commandes
                    commandeDeleteDevis.Connection = connexion
                    commandeDeleteDevis.CommandType = CommandType.StoredProcedure
                    commandeDeleteDevis.CommandText = "P_DELETE_Devis"

                    'Ajout de paramètres aux commandes
                    commandeDeleteDevis.Parameters.Add("idDevis", SqlDbType.Int)
                    commandeDeleteDevis.Parameters(0).Value = VariablesGlobales.idDevis

                    'Début de la transaction
                    transaction = connexion.BeginTransaction
                    commandeDeleteDevis.Transaction = transaction

                    'suppression des liens avec les cours et intentions
                    SupprimerCoursDevis(connexion, transaction, VariablesGlobales.idDevis)
                    SupprimerIntentionDevis(connexion, transaction, VariablesGlobales.idDevis)
                    'suppression du devis
                    commandeDeleteDevis.ExecuteNonQuery()
                    transaction.Commit()
                Catch ex As Exception
                    MsgBox("Erreur lors de l'enregistrement des intentions et des cours. Les autres données ont bien été enregistrées. " + ex.Message)
                    transaction.Rollback()
                Finally
                    connexion.Close()
                End Try

                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub


    Private Sub btnProfilDiplome_Click(sender As Object, e As EventArgs) Handles btnProfilDiplome.Click
        'ouverture d'une fenêtre de saisie de texte
        Dim saisieProfil As New frmSaisieTexte
        saisieProfil.Text = "Profil du diplômé"
        saisieProfil.rtxtSaisieTexte.Rtf = VariablesGlobales.profilDiplome
        saisieProfil.ShowDialog()

        'enregistrement en cas de validation de la fenêtre de saisie
        If saisieProfil.DialogResult = Windows.Forms.DialogResult.OK Then
            If VariablesGlobales.monAction = action.modifier And VariablesGlobales.profilDiplome <> saisieProfil.rtxtSaisieTexte.Rtf Then
                VariablesGlobales.profilDiplome = saisieProfil.rtxtSaisieTexte.Rtf
                Dim nombreFonts As Integer
                'récupération du nombre de fonts du texte rtf
                nombreFonts = VariablesGlobales.TrouverMot(VariablesGlobales.profilDiplome, "{\f")
                Dim indexDepart As Integer
                Dim indexFin As Integer
                Dim indexBaliseFont As Integer
                'parcour des fonts
                For i As Integer = 0 To nombreFonts - 1
                    If i = 0 Then
                        'pour le premier qui n'est pas un font
                        indexDepart = VariablesGlobales.profilDiplome.IndexOf("{\f")
                    ElseIf i = 1 Then
                        'pour le premier font
                        indexDepart = VariablesGlobales.profilDiplome.IndexOf("{\f", indexDepart + 1)
                        indexFin = VariablesGlobales.profilDiplome.IndexOf("}", indexDepart + 1)
                        Dim indexDebutPolice As Integer = VariablesGlobales.profilDiplome.IndexOf(" ", indexDepart) + 1
                        Dim nombreCaracterePolice As Integer = indexFin - indexDebutPolice - 1
                        'récupération de la police
                        nomPoliceRtfProfilDiplome = VariablesGlobales.profilDiplome.Substring(indexDebutPolice, nombreCaracterePolice)
                    Else
                        If i = 2 Then
                            'pour le deuxième font
                            indexDepart = VariablesGlobales.profilDiplome.IndexOf("{\f", indexDepart + 1)
                        End If
                        indexFin = VariablesGlobales.profilDiplome.IndexOf("}", indexDepart + 1)
                        Dim nombreCaracteres As Integer = indexFin - indexDepart + 1
                        'suppression du font
                        VariablesGlobales.profilDiplome = VariablesGlobales.profilDiplome.Remove(indexDepart, nombreCaracteres)
                        'récupération du nombre de balise du font supprimé
                        Dim nombreBalisesFont As Integer = VariablesGlobales.TrouverMot(VariablesGlobales.profilDiplome, "\f" & i - 1)
                        For j As Integer = 1 To nombreBalisesFont
                            indexBaliseFont = VariablesGlobales.profilDiplome.IndexOf("\f" & i - 1)
                            'suppression des balises
                            VariablesGlobales.profilDiplome = VariablesGlobales.profilDiplome.Remove(indexBaliseFont, 3)
                        Next
                    End If
                Next
                saisieProfil.rtxtSaisieTexte.Rtf = VariablesGlobales.profilDiplome
                saisieProfil.rtxtSaisieTexte.SelectAll()
                'récupération de la taille du texte
                taillePoliceRtfProfilDiplome = saisieProfil.rtxtSaisieTexte.SelectionFont.SizeInPoints.ToString("0.0") * 2

                blnModifie = True
            End If
        End If
    End Sub

    Private Sub btnEpreuveSynthese_Click(sender As Object, e As EventArgs) Handles btnEpreuveSynthese.Click
        'ouverture d'une fenêtre de saisie de texte  
        Dim saisieEpreuve As New frmSaisieTexte
        saisieEpreuve.Text = "Nature de l'épreuve synthèse"
        saisieEpreuve.rtxtSaisieTexte.Rtf = VariablesGlobales.epreuveSynthese
        saisieEpreuve.ShowDialog()
        'enregistrement en cas de validation de la fenêtre de saisie
        If saisieEpreuve.DialogResult = Windows.Forms.DialogResult.OK Then
            If VariablesGlobales.monAction = action.modifier And VariablesGlobales.epreuveSynthese <> saisieEpreuve.rtxtSaisieTexte.Rtf Then
                VariablesGlobales.epreuveSynthese = saisieEpreuve.rtxtSaisieTexte.Rtf
                Dim nombreFonts As Integer
                nombreFonts = VariablesGlobales.TrouverMot(VariablesGlobales.epreuveSynthese, "{\f")
                Dim indexDepart As Integer
                Dim indexFin As Integer
                Dim indexBaliseFont As Integer
                For i As Integer = 0 To nombreFonts - 1
                    If i = 0 Then
                        indexDepart = VariablesGlobales.epreuveSynthese.IndexOf("{\f")
                    ElseIf i = 1 Then
                        indexDepart = VariablesGlobales.epreuveSynthese.IndexOf("{\f", indexDepart + 1)
                        indexFin = VariablesGlobales.epreuveSynthese.IndexOf("}", indexDepart + 1)
                        Dim indexDebutPolice As Integer = VariablesGlobales.epreuveSynthese.IndexOf(" ", indexDepart) + 1
                        Dim nombreCaracterePolice As Integer = indexFin - indexDebutPolice - 1
                        nomPoliceRtfEpreuveSynthese = VariablesGlobales.epreuveSynthese.Substring(indexDebutPolice, nombreCaracterePolice)
                    Else
                        If i = 2 Then
                            indexDepart = VariablesGlobales.epreuveSynthese.IndexOf("{\f", indexDepart + 1)
                        End If
                        indexFin = VariablesGlobales.epreuveSynthese.IndexOf("}", indexDepart + 1)
                        Dim nombreCaracteres As Integer = indexFin - indexDepart + 1
                        VariablesGlobales.epreuveSynthese = VariablesGlobales.epreuveSynthese.Remove(indexDepart, nombreCaracteres)
                        Dim nombreBalisesFont As Integer = VariablesGlobales.TrouverMot(VariablesGlobales.epreuveSynthese, "\f" & i - 1)
                        For j As Integer = 1 To nombreBalisesFont
                            indexBaliseFont = VariablesGlobales.epreuveSynthese.IndexOf("\f" & i - 1)
                            VariablesGlobales.epreuveSynthese = VariablesGlobales.epreuveSynthese.Remove(indexBaliseFont, 3)
                        Next
                    End If
                Next
                saisieEpreuve.rtxtSaisieTexte.Rtf = VariablesGlobales.epreuveSynthese
                saisieEpreuve.rtxtSaisieTexte.SelectAll()
                taillePoliceRtfEpreuveSynthese = saisieEpreuve.rtxtSaisieTexte.SelectionFont.SizeInPoints.ToString("0.0") * 2

                blnModifie = True
            End If
        End If

    End Sub

    Private Sub btnSanteSecurite_Click(sender As Object, e As EventArgs) Handles btnSanteSecurite.Click
        'ouverture d'une fenêtre de saisie de texte 
        Dim saisieSanteSecu As New frmSaisieTexte
        saisieSanteSecu.Text = "Santé et sécurité au travail"
        saisieSanteSecu.rtxtSaisieTexte.Rtf = VariablesGlobales.santeSecurite
        saisieSanteSecu.ShowDialog()
        'enregistrement en cas de validation de la fenêtre de saisie
        If saisieSanteSecu.DialogResult = Windows.Forms.DialogResult.OK Then
            If VariablesGlobales.monAction = action.modifier And VariablesGlobales.santeSecurite <> saisieSanteSecu.rtxtSaisieTexte.Rtf Then
                VariablesGlobales.santeSecurite = saisieSanteSecu.rtxtSaisieTexte.Rtf
                Dim nombreFonts As Integer
                nombreFonts = VariablesGlobales.TrouverMot(VariablesGlobales.santeSecurite, "{\f")
                Dim indexDepart As Integer
                Dim indexFin As Integer
                Dim indexBaliseFont As Integer
                For i As Integer = 0 To nombreFonts - 1
                    If i = 0 Then
                        indexDepart = VariablesGlobales.santeSecurite.IndexOf("{\f")
                    ElseIf i = 1 Then
                        indexDepart = VariablesGlobales.santeSecurite.IndexOf("{\f", indexDepart + 1)
                        indexFin = VariablesGlobales.santeSecurite.IndexOf("}", indexDepart + 1)
                        Dim indexDebutPolice As Integer = VariablesGlobales.santeSecurite.IndexOf(" ", indexDepart) + 1
                        Dim nombreCaracterePolice As Integer = indexFin - indexDebutPolice - 1
                        nomPoliceRtfSanteSecurite = VariablesGlobales.santeSecurite.Substring(indexDebutPolice, nombreCaracterePolice)
                    Else
                        If i = 2 Then
                            indexDepart = VariablesGlobales.santeSecurite.IndexOf("{\f", indexDepart + 1)
                        End If
                        indexFin = VariablesGlobales.santeSecurite.IndexOf("}", indexDepart + 1)
                        Dim nombreCaracteres As Integer = indexFin - indexDepart + 1
                        VariablesGlobales.santeSecurite = VariablesGlobales.santeSecurite.Remove(indexDepart, nombreCaracteres)
                        Dim nombreBalisesFont As Integer = VariablesGlobales.TrouverMot(VariablesGlobales.santeSecurite, "\f" & i - 1)
                        For j As Integer = 1 To nombreBalisesFont
                            indexBaliseFont = VariablesGlobales.santeSecurite.IndexOf("\f" & i - 1)
                            VariablesGlobales.santeSecurite = VariablesGlobales.santeSecurite.Remove(indexBaliseFont, 3)
                        Next
                    End If
                Next
                saisieSanteSecu.rtxtSaisieTexte.Rtf = VariablesGlobales.santeSecurite
                saisieSanteSecu.rtxtSaisieTexte.SelectAll()
                taillePoliceRtfSanteSecurite = saisieSanteSecu.rtxtSaisieTexte.SelectionFont.SizeInPoints.ToString("0.0") * 2

                blnModifie = True
            End If
        End If
    End Sub

    Private Sub chbOfficiel_CheckedChanged(sender As Object, e As EventArgs) Handles chbOfficiel.CheckedChanged
        If VariablesGlobales.monAction = Action.modifier And chbOfficiel.Checked Then
            chbCochee = True
            blnModifie = True
        End If
    End Sub



    Private Sub btnAjouterCours_Click(sender As Object, e As EventArgs) Handles btnAjouterCours.Click
        'ouverture de la fenêtre de gestion des cours
        Dim ajoutCours As New frmGestionCours
        ajoutCours.btnAjouter.Visible = True
        ajoutCours.btnAnnuler.Visible = True
        ajoutCours.dgvCours.MultiSelect = True
        VariablesGlobales.actionSecondaire = Action.ajoutCoursDevis
        svgMonAction = VariablesGlobales.monAction
        svgIdDevis = VariablesGlobales.idDevis
        AddHandler ajoutCours.FormClosed, AddressOf ajoutCours_FormClosed
        ajoutCours.ShowDialog()
    End Sub

    Private Sub ajoutCours_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        'enregistrement des données lors de la fermeture de la fenêtre de gestion des cours
        VariablesGlobales.monAction = svgMonAction
        VariablesGlobales.idDevis = svgIdDevis
        VariablesGlobales.actionSecondaire = -1
        If VariablesGlobales.monAction = Action.modifier And VariablesGlobales.modification = True Then
            blnModifie = True
            VariablesGlobales.modification = False
        End If
        RechercherCours()
    End Sub

    Private Sub RechercherCours()
        dgvCours.DataSource = P_SELECT_CoursDevisTableAdapter.GetData(VariablesGlobales.idDevis)
    End Sub

    Private Sub btnValiderInfos_Click(sender As Object, e As EventArgs) Handles btnValiderInfos.Click
        'validation intermédiaire des données saisies lors de la création de devis
        Dim taDevis = New SGPDataSetTableAdapters.QueriesTableAdapter
        'profil du diplômé
        If Not VariablesGlobales.profilDiplome = "" And Not nomPoliceRtfProfilDiplome = "" Then
            profil = VariablesGlobales.profilDiplome.Replace(nomPoliceRtfProfilDiplome, "Calibri").Replace("fs" + taillePoliceRtfProfilDiplome.ToString(), "fs22")
            nomPoliceRtfProfilDiplome = Nothing
            taillePoliceRtfProfilDiplome = Nothing
        Else
            profil = VariablesGlobales.profilDiplome
        End If
        'épreuve synthèse
        If Not VariablesGlobales.epreuveSynthese = "" And Not nomPoliceRtfEpreuveSynthese = "" Then
            epreuve = VariablesGlobales.epreuveSynthese.Replace(nomPoliceRtfEpreuveSynthese, "Calibri").Replace("fs" + taillePoliceRtfEpreuveSynthese.ToString(), "fs22")
            nomPoliceRtfEpreuveSynthese = Nothing
            taillePoliceRtfEpreuveSynthese = Nothing
        Else
            epreuve = VariablesGlobales.epreuveSynthese
        End If
        'santé et sécurité
        If Not VariablesGlobales.santeSecurite = "" And Not nomPoliceRtfSanteSecurite = "" Then
            santeSecu = VariablesGlobales.santeSecurite.Replace(nomPoliceRtfSanteSecurite, "Calibri").Replace("fs" + taillePoliceRtfSanteSecurite.ToString(), "fs22")
            nomPoliceRtfSanteSecurite = Nothing
            taillePoliceRtfSanteSecurite = Nothing
        Else
            santeSecu = VariablesGlobales.santeSecurite
        End If
        'autres données
        If validerDevis() Then
            'si on modifie les données précédemment validées en étant toujours dans la création
            If action = action.modifier Then
                taDevis.P_UPDATE_Devis(VariablesGlobales.idDevis,
                                        cbProgramme.SelectedValue,
                                        profil,
                                        epreuve,
                                        santeSecu,
                                        txtCommentaire.Text)
                action = -1

                '1ere validation
            Else

                VariablesGlobales.idDevis = taDevis.P_INSERT_Devis(cbProgramme.SelectedValue,
                                                                                    profil,
                                                                                    epreuve,
                                                                                    santeSecu,
                                                                                    txtCommentaire.Text)
            End If
            'gestion de l'activation et de la visibilité de certains éléments
            btnValider.Enabled = True
            ActiverInfosDevis(False)
            ActiverCoursIntentions(True)
            blnDonneesSaisies = True
            VariablesGlobales.actionDonnees = action.consulter

            programmeDevis = cbProgramme.SelectedValue
            profilDiplome = VariablesGlobales.profilDiplome
            epreuveSynthese = VariablesGlobales.epreuveSynthese
            santeSecurite = VariablesGlobales.santeSecurite
            commentaire = txtCommentaire.Text
            officiel = chbOfficiel.Checked
        End If

    End Sub

    Private Sub ActiverInfosDevis(blnActiver As Boolean)
        'gestion de l'activation de la saisie des informations générales
        If VariablesGlobales.monAction = VariablesGlobales.Action.modifier Then
            cbProgramme.Enabled = False
        Else
            cbProgramme.Enabled = blnActiver
        End If
        txtCommentaire.ReadOnly = Not blnActiver
        chbOfficiel.Enabled = blnActiver
        btnValiderInfos.Enabled = blnActiver
        btnAnnulerInfos.Enabled = blnActiver
        btnModifierInfos.Enabled = Not blnActiver
        btnValider.Enabled = Not blnActiver

    End Sub

    Private Sub ActiverCoursIntentions(blnActiver As Boolean)
        'gestion de l'activation de l'association des cours et des intentions
        btnAjouterCours.Enabled = blnActiver
        btnSupprimerCours.Enabled = blnActiver
        btnAjouterIntention.Enabled = blnActiver
        btnSupprimerIntention.Enabled = blnActiver
    End Sub

    Private Sub btnAnnulerInfos_Click(sender As Object, e As EventArgs) Handles btnAnnulerInfos.Click
        'modification des éléments activés
        ActiverInfosDevis(False)
        ActiverCoursIntentions(True)
        action = -1
        VariablesGlobales.actionDonnees = action.consulter

        cbProgramme.SelectedValue = programmeDevis
        VariablesGlobales.profilDiplome = profilDiplome
        VariablesGlobales.epreuveSynthese = epreuveSynthese
        VariablesGlobales.santeSecurite = santeSecurite
        txtCommentaire.Text = commentaire
        chbOfficiel.Checked = officiel
    End Sub

    Private Sub btnModifierInfos_Click(sender As Object, e As EventArgs) Handles btnModifierInfos.Click
        'modification des éléments activés
        ActiverInfosDevis(True)
        ActiverCoursIntentions(False)
        action = action.modifier
        VariablesGlobales.actionDonnees = action.modifier
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        'modification des éléments activés
        VariablesGlobales.monAction = action.modifier
        ActiverInfosDevis(True)

        ActiverCoursIntentions(True)
        btnValider.Enabled = True
        btnModifier.Enabled = False
    End Sub

    Private Sub btnAjouterIntention_Click(sender As Object, e As EventArgs) Handles btnAjouterIntention.Click
        'ouverture de la fenêtre de gestion des intentions
        Dim ajoutIntention As New dlgAjoutIntention
        Dim nombreIntentions As Integer = dgvIntentions.Rows.Count
        ajoutIntention.ShowDialog()
        RechercherIntention()
        If dgvIntentions.Rows.Count <> nombreIntentions Then

            blnModifie = True
        End If

    End Sub


    Private Sub RechercherIntention()
        dgvIntentions.DataSource = P_SELECT_IntentionDevisTableAdapter.GetData(VariablesGlobales.idDevis)
    End Sub

    Private Sub btnSupprimerIntention_Click(sender As Object, e As EventArgs) Handles btnSupprimerIntention.Click
        'suppression du lien avec l'intention sélectionnée
        Dim taIntention = New SGPDataSetTableAdapters.QueriesTableAdapter
        If dgvIntentions.SelectedRows.Count > 0 Then
            taIntention.P_DELETE_Intention_Devis(dgvIntentions.SelectedRows(0).Cells(0).Value, VariablesGlobales.idDevis)
        End If
        blnModifie = True
        RechercherIntention()

    End Sub

    Private Sub btnSupprimerCours_Click(sender As Object, e As EventArgs) Handles btnSupprimerCours.Click
        'suppression du lien avec le cours sélectionné
        Dim taCours = New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim taCours2 = New SGPDataSetTableAdapters.P_SELECT_Cours_PKTableAdapter
        Dim idCours As Integer

        idCours = dgvCours.SelectedRows(0).Cells(0).Value
        Dim dtCours = taCours2.GetData(idCours)
        If dgvCours.SelectedRows.Count > 0 Then
            taCours.P_DELETE_Cours_Devis(idCours, VariablesGlobales.idDevis)
        End If

        blnModifie = True
        RechercherCours()
    End Sub

    Private Sub SupprimerCoursDevis(connexion As System.Data.SqlClient.SqlConnection, transaction As System.Data.SqlClient.SqlTransaction, idDevis As Integer)
        'partie de la transaction qui supprime toutes les associations de cours au devis
        Dim taCours = New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim taCoursDevis = New SGPDataSetTableAdapters.P_SELECT_CoursDevisTableAdapter
        Dim dtCoursDevis = taCoursDevis.GetData(idDevis)
        Dim idCours As Integer
        Dim commandeDeleteCours As New System.Data.SqlClient.SqlCommand
        Dim commandeDeleteCoursDevis As New System.Data.SqlClient.SqlCommand

        'Déclaration des commandes
        commandeDeleteCoursDevis.Connection = connexion
        commandeDeleteCoursDevis.CommandType = CommandType.StoredProcedure
        commandeDeleteCoursDevis.CommandText = "P_DELETE_Cours_Devis"

        'Ajout de paramètres aux commandes
        commandeDeleteCoursDevis.Parameters.Add("idCours", SqlDbType.Int)
        commandeDeleteCoursDevis.Parameters.Add("idDevis", SqlDbType.Int)
        commandeDeleteCoursDevis.Parameters(1).Value = VariablesGlobales.idDevis

        commandeDeleteCoursDevis.Transaction = transaction

        For Each row As DataRow In dtCoursDevis.Rows
            idCours = row.Item("idCOURS")
            commandeDeleteCoursDevis.Parameters(0).Value = idCours
            commandeDeleteCoursDevis.ExecuteNonQuery()
        Next


    End Sub

    Private Sub SupprimerIntentionDevis(connexion As System.Data.SqlClient.SqlConnection, transaction As System.Data.SqlClient.SqlTransaction, idDevis As Integer)
        'partie de la transaction qui supprime toutes les associations d'intentions au devis
        Dim taIntention = New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim taIntentionDevis = New SGPDataSetTableAdapters.P_SELECT_IntentionDevisTableAdapter
        Dim dtIntentionDevis = taIntentionDevis.GetData(idDevis)
        Dim idIntention As Integer

        Dim commandeDeleteIntentionDevis As New System.Data.SqlClient.SqlCommand

        'Déclaration des commandes
        commandeDeleteIntentionDevis.Connection = connexion
        commandeDeleteIntentionDevis.CommandType = CommandType.StoredProcedure
        commandeDeleteIntentionDevis.CommandText = "P_DELETE_Intention_Devis"

        'Ajout de paramètres aux commandes
        commandeDeleteIntentionDevis.Parameters.Add("idIntention", SqlDbType.Int)
        commandeDeleteIntentionDevis.Parameters.Add("idDevis", SqlDbType.Int)
        commandeDeleteIntentionDevis.Parameters(1).Value = VariablesGlobales.idDevis

        commandeDeleteIntentionDevis.Transaction = transaction

        For Each row As DataGridViewRow In dgvIntentions.Rows
            idIntention = row.Cells(0).Value

            commandeDeleteIntentionDevis.Parameters(0).Value = idIntention
            commandeDeleteIntentionDevis.ExecuteNonQuery()
        Next


    End Sub

    Private Function validerDevis() As Boolean
        If cbProgramme.SelectedIndex = -1 Then
            MsgBox("Veuillez spécifier un programme.")
            cbProgramme.Focus()
            Return False
        End If
        Return True

    End Function


    Private Sub cbProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgramme.SelectedIndexChanged
        If VariablesGlobales.monAction = Action.modifier Then
            If cbProgramme.SelectedValue <> idProgramme Then
                blnModifie = True
            End If
        End If

    End Sub

    Private Sub btnDetailsCours_Click(sender As Object, e As EventArgs) Handles btnDetailsCours.Click
        'accès au détails du cours sélectionné
        Dim detailsCours As New dlgFormulaireCours

        If dgvCours.SelectedRows.Count = 1 Then
            svgMonAction = VariablesGlobales.monAction
            VariablesGlobales.monAction = Action.consulter
            VariablesGlobales.idCours = dgvCours.SelectedRows(0).Cells(0).Value
            detailsCours.Text = dgvCours.SelectedRows(0).Cells(1).Value + " " + dgvCours.SelectedRows(0).Cells(2).Value
            AddHandler detailsCours.FormClosed, AddressOf detailsCours_FormClosed
            detailsCours.ShowDialog()

            RechercherCours()
            SelectionnerCours(VariablesGlobales.idCours)

            VariablesGlobales.idCours = -1
            VariablesGlobales.descriptionCours = ""
            VariablesGlobales.monAction = -1
            VariablesGlobales.actionPrealable = -1
            VariablesGlobales.idDevisCours = -1
            VariablesGlobales.justification = Nothing
        End If
    End Sub

    Private Sub detailsCours_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        'lors de la fermeture de la fenêtre de détails d'un cours
        If VariablesGlobales.actionSecondaire = Action.modifier Then
            ActiverCoursIntentions(True)
            ActiverInfosDevis(True)
            btnModifier.Enabled = False
            btnValider.Enabled = True
        End If
    End Sub

    Private Sub SelectionnerCours(idCours As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvCours.Rows.Count) And (Not blnTrouve)
            If dgvCours.Rows(intRangee).Cells(0).Value = idCours Then
                dgvCours.Rows(intRangee).Selected = True
                dgvCours.FirstDisplayedScrollingRowIndex = intRangee
                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

End Class
