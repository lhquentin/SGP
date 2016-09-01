Imports System.Windows.Forms

Public Class dlgDonneesProgramme
    Private blnModifie As Boolean = False
    Private blnDonneesSaisies As Boolean = False
    Private listeCompetences As List(Of Integer)
    Private svgAction = New Action
    Private taProgramme = New SGPDataSetTableAdapters.QueriesTableAdapter
    Private codeProgramme As String
    Private titreProgramme As String
    Private typeSanction As Integer
    Private typeProgramme As Integer
    Private dureeProgramme As Integer
    Private unitesProgramme As Integer
    Private versionProgramme As Integer
    Private conditionAdmission As String
    Private butsProgramme As String
    Private intentionsProgramme As String
    Private buts As String
    Private intentions As String
    Dim nomPoliceRtfButs As String = ""
    Dim taillePoliceRtfButs As Integer
    Dim nomPoliceRtfIntentions As String = ""
    Dim taillePoliceRtfIntentions As Integer
    Private Sub dlgDonneesProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        cbTypeSanction.DataSource = P_SELECT_Type_SanctionTableAdapter.GetData(False)
        cbTypeProgramme.DataSource = P_SELECT_Type_ProgrammeTableAdapter.GetData(False, cbTypeSanction.SelectedValue)
        ActiverInfos(False)
        ActiverCompetences(False)
        'si on crée un nouveau programme
        If VariablesGlobales.monAction = Action.inserer Then
            cbTypeSanction.SelectedIndex = -1
            cbTypeProgramme.SelectedIndex = -1
            ActiverInfos(True)
            btnAnnulerInfos.Enabled = False
            btnModifier.Visible = False

            'si on modifie un programme
        ElseIf VariablesGlobales.monAction = Action.consulter Then
            Dim taProgramme As New SGPDataSetTableAdapters.P_SELECT_Programmes_PKTableAdapter
            Dim dtProgramme = taProgramme.GetData(VariablesGlobales.idProgramme)
            'chargement des données du programme
            If dtProgramme.Rows.Count > 0 Then
                txtCode.Text = dtProgramme.Rows(0)("codeProgramme")
                txtTitre.Text = dtProgramme.Rows(0)("titreProgramme")
                cbTypeSanction.SelectedValue = dtProgramme.Rows(0)("idTYPE_SANCTION")
                cbTypeProgramme.SelectedValue = dtProgramme.Rows(0)("idTYPE_PROGRAMME")
                nudVersion.Value = dtProgramme.Rows(0)("version")
                nudUnites.Value = dtProgramme.Rows(0)("unites")
                nudDureeFormationSpecifique.Value = dtProgramme.Rows(0)("duree")
                txtConditionAdmission.Text = dtProgramme.Rows(0)("conditionAdmission")
                VariablesGlobales.butProgramme = dtProgramme.Rows(0)("butPROGRAMME")
                VariablesGlobales.intentionEducativesProgramme = dtProgramme.Rows(0)("intentionsEducatives")
            End If
            RechercherCompetence()

            'activation/désactivation d'éléments du contenu
            btnValiderInfos.Visible = False
            btnAnnulerInfos.Visible = False
            btnModifierInfos.Visible = False
            ActiverCompetences(False)

            'sauvegarde des compétences liées
            listeCompetences = New List(Of Integer)
            For Each row As DataGridViewRow In dgvCompetences.Rows
                listeCompetences.Add(row.Cells(0).Value)
            Next
        End If

    End Sub

    Private Sub btnBut_Click(sender As Object, e As EventArgs) Handles btnBut.Click
        'ouverture de la fenêtre de saisie de texte
        Dim saisieBut As New frmSaisieTexte
        saisieBut.Text = "Buts du programme"
        saisieBut.rtxtSaisieTexte.Rtf = VariablesGlobales.butProgramme
        saisieBut.ShowDialog()

        'en cas de validation du texte saisi
        If saisieBut.DialogResult = Windows.Forms.DialogResult.OK Then
            If VariablesGlobales.monAction = Action.modifier And VariablesGlobales.butProgramme <> saisieBut.rtxtSaisieTexte.Rtf Then
                VariablesGlobales.butProgramme = saisieBut.rtxtSaisieTexte.Rtf
                Dim nombreFonts As Integer
                'récupération du nombre de fonts du texte rtf
                nombreFonts = VariablesGlobales.TrouverMot(VariablesGlobales.butProgramme, "{\f")
                Dim indexDepart As Integer
                Dim indexFin As Integer
                Dim indexBaliseFont As Integer
                'parcour des fonts
                For i As Integer = 0 To nombreFonts - 1
                    If i = 0 Then
                        'pour le premier qui n'est pas un font
                        indexDepart = VariablesGlobales.butProgramme.IndexOf("{\f")
                    ElseIf i = 1 Then
                        'pour le premier font
                        indexDepart = VariablesGlobales.butProgramme.IndexOf("{\f", indexDepart + 1)
                        indexFin = VariablesGlobales.butProgramme.IndexOf("}", indexDepart + 1)
                        Dim indexDebutPolice As Integer = VariablesGlobales.butProgramme.IndexOf(" ", indexDepart) + 1
                        Dim nombreCaracterePolice As Integer = indexFin - indexDebutPolice - 1
                        'récupération de la police
                        nomPoliceRtfButs = VariablesGlobales.butProgramme.Substring(indexDebutPolice, nombreCaracterePolice)
                    Else
                        If i = 2 Then
                            'pour le deuxième font
                            indexDepart = VariablesGlobales.butProgramme.IndexOf("{\f", indexDepart + 1)
                        End If
                        indexFin = VariablesGlobales.butProgramme.IndexOf("}", indexDepart + 1)
                        Dim nombreCaracteres As Integer = indexFin - indexDepart + 1
                        'suppression du font
                        VariablesGlobales.butProgramme = VariablesGlobales.butProgramme.Remove(indexDepart, nombreCaracteres)
                        'récupération du nombre de balise du font supprimé
                        Dim nombreBalisesFont As Integer = VariablesGlobales.TrouverMot(VariablesGlobales.butProgramme, "\f" & i - 1)
                        For j As Integer = 1 To nombreBalisesFont
                            indexBaliseFont = VariablesGlobales.butProgramme.IndexOf("\f" & i - 1)
                            'suppression des balises
                            VariablesGlobales.butProgramme = VariablesGlobales.butProgramme.Remove(indexBaliseFont, 3)
                        Next
                    End If
                Next
                saisieBut.rtxtSaisieTexte.Rtf = VariablesGlobales.butProgramme
                saisieBut.rtxtSaisieTexte.SelectAll()
                'récupération de la taille du texte
                taillePoliceRtfButs = saisieBut.rtxtSaisieTexte.SelectionFont.SizeInPoints.ToString("0.0") * 2

                blnModifie = True
            End If
        End If
    End Sub

    Private Sub btnIntentions_Click(sender As Object, e As EventArgs) Handles btnIntentions.Click
        'ouverture de la fenêtre de saisie de texte 
        Dim saisieIntentions As New frmSaisieTexte
        saisieIntentions.Text = "Intentions éducatives du programme"
        saisieIntentions.rtxtSaisieTexte.Rtf = VariablesGlobales.intentionEducativesProgramme
        saisieIntentions.ShowDialog()
        'en cas de validation du texte saisi
        If saisieIntentions.DialogResult = Windows.Forms.DialogResult.OK Then
            If VariablesGlobales.monAction = Action.modifier And VariablesGlobales.intentionEducativesProgramme <> saisieIntentions.rtxtSaisieTexte.Rtf Then
                VariablesGlobales.intentionEducativesProgramme = saisieIntentions.rtxtSaisieTexte.Rtf
                Dim nombreFonts As Integer
                nombreFonts = VariablesGlobales.TrouverMot(VariablesGlobales.intentionEducativesProgramme, "{\f")
                Dim indexDepart As Integer
                Dim indexFin As Integer
                Dim indexBaliseFont As Integer
                For i As Integer = 0 To nombreFonts - 1
                    If i = 0 Then
                        indexDepart = VariablesGlobales.intentionEducativesProgramme.IndexOf("{\f")
                    ElseIf i = 1 Then
                        indexDepart = VariablesGlobales.intentionEducativesProgramme.IndexOf("{\f", indexDepart + 1)
                        indexFin = VariablesGlobales.intentionEducativesProgramme.IndexOf("}", indexDepart + 1)
                        Dim indexDebutPolice As Integer = VariablesGlobales.intentionEducativesProgramme.IndexOf(" ", indexDepart) + 1
                        Dim nombreCaracterePolice As Integer = indexFin - indexDebutPolice - 1
                        nomPoliceRtfIntentions = VariablesGlobales.intentionEducativesProgramme.Substring(indexDebutPolice, nombreCaracterePolice)
                    Else
                        If i = 2 Then
                            indexDepart = VariablesGlobales.intentionEducativesProgramme.IndexOf("{\f", indexDepart + 1)
                        End If
                        indexFin = VariablesGlobales.intentionEducativesProgramme.IndexOf("}", indexDepart + 1)
                        Dim nombreCaracteres As Integer = indexFin - indexDepart + 1
                        VariablesGlobales.intentionEducativesProgramme = VariablesGlobales.intentionEducativesProgramme.Remove(indexDepart, nombreCaracteres)
                        Dim nombreBalisesFont As Integer = VariablesGlobales.TrouverMot(VariablesGlobales.intentionEducativesProgramme, "\f" & i - 1)
                        For j As Integer = 1 To nombreBalisesFont
                            indexBaliseFont = VariablesGlobales.intentionEducativesProgramme.IndexOf("\f" & i - 1)
                            VariablesGlobales.intentionEducativesProgramme = VariablesGlobales.intentionEducativesProgramme.Remove(indexBaliseFont, 3)
                        Next
                    End If
                Next
                saisieIntentions.rtxtSaisieTexte.Rtf = VariablesGlobales.intentionEducativesProgramme
                saisieIntentions.rtxtSaisieTexte.SelectAll()
                taillePoliceRtfIntentions = saisieIntentions.rtxtSaisieTexte.SelectionFont.SizeInPoints.ToString("0.0") * 2

                blnModifie = True
            End If
        End If
    End Sub

    Private Sub btnModifierInfos_Click(sender As Object, e As EventArgs) Handles btnModifierInfos.Click
        'activation de la saisie des informations générales/désactivation de l'association de compétences
        ActiverInfos(True)
        ActiverCompetences(False)
        VariablesGlobales.monAction = Action.modifier
        VariablesGlobales.actionDonnees = Action.modifier
    End Sub

    Private Sub btnAnnulerInfos_Click(sender As Object, e As EventArgs) Handles btnAnnulerInfos.Click

        'désactivation de la saisie des informations générales/activation de l'association de compétencesActiverInfos(False)
        ActiverCompetences(True)
        VariablesGlobales.monAction = Action.inserer
        VariablesGlobales.actionDonnees = Action.consulter

        'restauration des anciennes données
        txtCode.Text = codeProgramme
        txtTitre.Text = titreProgramme
        cbTypeSanction.SelectedValue = typeSanction
        cbTypeProgramme.SelectedValue = typeProgramme
        nudDureeFormationSpecifique.Value = dureeProgramme
        nudUnites.Value = unitesProgramme
        nudVersion.Value = versionProgramme
        txtConditionAdmission.Text = conditionAdmission
        VariablesGlobales.butProgramme = butsProgramme
        VariablesGlobales.intentionEducativesProgramme = intentionsProgramme
    End Sub

    Private Sub btnValiderInfos_Click(sender As Object, e As EventArgs) Handles btnValiderInfos.Click
        Dim taProgramme = New SGPDataSetTableAdapters.QueriesTableAdapter
        'si les champs requis sont remplis, enregistrement des informations saisies (création uniquement)
        If ValiderProgramme() Then
            'buts du programme
            If Not VariablesGlobales.butProgramme = "" And Not nomPoliceRtfButs = "" Then
                'remplacement de la police et taille du texte
                buts = VariablesGlobales.butProgramme.Replace(nomPoliceRtfButs, "Calibri").Replace("fs" + taillePoliceRtfButs.ToString(), "fs22")
                nomPoliceRtfButs = Nothing
                taillePoliceRtfButs = Nothing
            Else
                buts = VariablesGlobales.butProgramme
            End If
            'intentions éducatives du programme
            If Not VariablesGlobales.intentionEducativesProgramme = "" And Not nomPoliceRtfIntentions = "" Then
                intentions = VariablesGlobales.intentionEducativesProgramme.Replace(nomPoliceRtfIntentions, "Calibri").Replace("fs" + taillePoliceRtfIntentions.ToString(), "fs22")
                nomPoliceRtfIntentions = Nothing
                taillePoliceRtfIntentions = Nothing
            Else
                intentions = VariablesGlobales.intentionEducativesProgramme
            End If
            '1ere saisie des informations générales
            If VariablesGlobales.monAction = Action.inserer Then
                VariablesGlobales.idProgramme = taProgramme.P_INSERT_Programme(txtCode.Text,
                                                                 txtTitre.Text,
                                                                 nudUnites.Value,
                                                                 nudVersion.Value,
                                                                 nudDureeFormationSpecifique.Value,
                                                                 txtConditionAdmission.Text,
                                                                 buts,
                                                                 intentions,
                                                                 cbTypeProgramme.SelectedValue)
                blnDonneesSaisies = True

                'modification des informations générales saisie (toujours lors de la création)
            ElseIf VariablesGlobales.monAction = Action.modifier Then
                taProgramme.P_UPDATE_Programme(VariablesGlobales.idProgramme,
                                                   txtCode.Text,
                                                   txtTitre.Text,
                                                   nudUnites.Value,
                                                   nudVersion.Value,
                                                   nudDureeFormationSpecifique.Value,
                                                   txtConditionAdmission.Text,
                                                   buts,
                                                   intentions,
                                                   cbTypeProgramme.SelectedValue)
                VariablesGlobales.monAction = Action.inserer
            End If
            btnOk.Enabled = True
            ActiverInfos(False)
            ActiverCompetences(True)
            VariablesGlobales.actionDonnees = Action.consulter

            codeProgramme = txtCode.Text
            titreProgramme = txtTitre.Text
            typeSanction = cbTypeSanction.SelectedValue
            typeProgramme = cbTypeProgramme.SelectedValue
            dureeProgramme = nudDureeFormationSpecifique.Value
            unitesProgramme = nudUnites.Value
            versionProgramme = nudVersion.Value
            conditionAdmission = txtConditionAdmission.Text
            butsProgramme = VariablesGlobales.butProgramme
            intentionsProgramme = VariablesGlobales.intentionEducativesProgramme
        End If

    End Sub

    Private Sub btnAjouterCompetence_Click(sender As Object, e As EventArgs) Handles btnAjouterCompetence.Click
        'ouverture de la fenêtre dee gestion des compétences
        Dim ajoutCompetence As New dlgAjoutCompetence
        ajoutCompetence.ShowDialog()

        If VariablesGlobales.monAction = Action.modifier And VariablesGlobales.modification Then
            blnModifie = True
            VariablesGlobales.modification = False
        End If
        RechercherCompetence()
    End Sub


    Private Sub btnSupprimerCompetences_Click(sender As Object, e As EventArgs) Handles btnSupprimerCompetences.Click
        'suppression du lien avec la compétence sélectionnée
        Dim taCompetence = New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim idCompetence As Integer
        If dgvCompetences.SelectedRows.Count = 1 Then
            idCompetence = dgvCompetences.SelectedRows(0).Cells(0).Value
            taCompetence.P_DELETE_ProgrammeCompetence(VariablesGlobales.idProgramme, idCompetence)
            blnModifie = True
            RechercherCompetence()
        End If

    End Sub

    Private Sub btnDetailCompetence_Click(sender As Object, e As EventArgs) Handles btnDetailsCompetence.Click
        'ouverture de la fenêtre de détails de la compétence sélectionnée
        If dgvCompetences.SelectedRows.Count = 1 Then
            VariablesGlobales.actionSecondaire = Action.consulter
            VariablesGlobales.idCompetence = dgvCompetences.SelectedRows(0).Cells(0).Value
            svgAction = VariablesGlobales.monAction
            Dim formulaireCompetence As New dlgFormulaireCompetence
            AddHandler formulaireCompetence.FormClosed, AddressOf formulaireCompetence_FormClosed
            formulaireCompetence.ShowDialog()
        End If


    End Sub

    Private Sub formulaireCompetence_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        'lors de la fermeture d'une fenêtre de détails d'une compétence
        'si on vient de créer un compétence, on la lie au programme
        If VariablesGlobales.actionSecondaire = Action.inserer And VariablesGlobales.modification Then
            Dim taCompetenceProgramme = New SGPDataSetTableAdapters.QueriesTableAdapter
            taCompetenceProgramme.P_INSERT_ProgrammeCompetence(VariablesGlobales.idProgramme, VariablesGlobales.idCompetence)
            blnModifie = True
            VariablesGlobales.modification = False

            'si on a modifié une compétence
        ElseIf VariablesGlobales.actionSecondaire = Action.modifier Then
            ActiverCompetences(True)
            ActiverInfos(True)
            btnModifier.Enabled = False
            btnOk.Enabled = True
        End If
        RechercherCompetence()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        'activation du contenu de la fenêtre
        VariablesGlobales.monAction = Action.modifier
        ActiverCompetences(True)
        ActiverInfos(True)
        btnOk.Enabled = True
        btnModifier.Enabled = False
    End Sub


    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'sauvegarde du programme
        'si on a modifié un programme, sauvegarde des informations générales
        If VariablesGlobales.monAction = Action.modifier Then
            'buts du programme
            If Not VariablesGlobales.butProgramme = "" And Not nomPoliceRtfButs = "" Then
                buts = VariablesGlobales.butProgramme.Replace(nomPoliceRtfButs, "Calibri").Replace("fs" + taillePoliceRtfButs.ToString(), "fs22")
                nomPoliceRtfButs = Nothing
                taillePoliceRtfButs = Nothing
            Else
                buts = VariablesGlobales.butProgramme
            End If
            'intentions éducatives du programme
            If Not VariablesGlobales.intentionEducativesProgramme = "" And Not nomPoliceRtfIntentions = "" Then
                intentions = VariablesGlobales.intentionEducativesProgramme.Replace(nomPoliceRtfIntentions, "Calibri").Replace("fs" + taillePoliceRtfIntentions.ToString(), "fs22")
                nomPoliceRtfIntentions = Nothing
                taillePoliceRtfIntentions = Nothing
            Else
                intentions = VariablesGlobales.intentionEducativesProgramme
            End If
            'autres informations
            taProgramme.P_UPDATE_Programme(VariablesGlobales.idProgramme,
                                           txtCode.Text,
                                           txtTitre.Text,
                                           nudUnites.Value,
                                           nudVersion.Value,
                                           nudDureeFormationSpecifique.Value,
                                           buts,
                                           txtConditionAdmission.Text,
                                           intentions,
                                           cbTypeProgramme.SelectedValue)
        End If

        Me.Close()
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        'annulation des données saisies/modifiées
        Dim taProgramme = New SGPDataSetTableAdapters.QueriesTableAdapter
        'si modification d'un programme
        If VariablesGlobales.monAction = Action.modifier And blnModifie Then
            If MsgBox("Les modifications ne seront pas sauvegardées. Voulez-vous continuer?", MsgBoxStyle.YesNo, "Annulation") = MsgBoxResult.Yes Then
                Dim connexion As New System.Data.SqlClient.SqlConnection
                Dim commandeDelete As New System.Data.SqlClient.SqlCommand
                Dim commandeInsert As New System.Data.SqlClient.SqlCommand
                Dim transaction As System.Data.SqlClient.SqlTransaction
                'transaction d'annulation
                Try
                    connexion.ConnectionString = SGP.My.Settings.H2016_Stage_Yoann_QuentinConnectionString
                    connexion.Open()

                    'Déclaration des commandes
                    commandeDelete.Connection = connexion
                    commandeDelete.CommandType = CommandType.StoredProcedure
                    commandeDelete.CommandText = "P_DELETE_ProgrammeCompetence"

                    commandeInsert.Connection = connexion
                    commandeInsert.CommandType = CommandType.StoredProcedure
                    commandeInsert.CommandText = "P_INSERT_ProgrammeCompetence"

                    'Ajout de paramètres aux commandes
                    commandeDelete.Parameters.Add("idProgramme", SqlDbType.Int)
                    commandeDelete.Parameters.Add("idCompetence", SqlDbType.Int)
                    commandeDelete.Parameters(0).Value = VariablesGlobales.idProgramme


                    commandeInsert.Parameters.Add("idProgramme", SqlDbType.Int)
                    commandeInsert.Parameters.Add("idCompetence", SqlDbType.Int)
                    commandeInsert.Parameters(0).Value = VariablesGlobales.idProgramme

                    'Début de la transaction
                    transaction = connexion.BeginTransaction
                    commandeDelete.Transaction = transaction
                    commandeInsert.Transaction = transaction

                    'suppression des nouveaux liens avec les compétences
                    For Each row As DataGridViewRow In dgvCompetences.Rows
                        commandeDelete.Parameters(1).Value = row.Cells(0).Value
                        commandeDelete.ExecuteNonQuery()
                    Next
                    'remise en place des anciens liens avec les compétences
                    For Each id As Integer In listeCompetences
                        commandeInsert.Parameters(1).Value = id
                        commandeInsert.ExecuteNonQuery()
                    Next


                    transaction.Commit()
                Catch ex As Exception
                    MsgBox("Erreur lors de l'enregistrement des compétences. Les autres données ont bien été enregistrées. " + ex.Message)
                    transaction.Rollback()
                Finally
                    connexion.Close()
                End Try

                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If

            'si on annule la création, suppression du programme et des liens avec des compétences
        ElseIf VariablesGlobales.monAction = Action.inserer And blnDonneesSaisies Then
            If MsgBox("Les données saisies ne seront pas sauvegardées. Voulez-vous continuer?", MsgBoxStyle.YesNo, "Annulation") = MsgBoxResult.Yes Then
                taProgramme = New SGPDataSetTableAdapters.QueriesTableAdapter
                taProgramme.P_DELETE_Programme(VariablesGlobales.idProgramme)
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            End If
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub RechercherCompetence()
        dgvCompetences.DataSource = P_SELECT_Competences_ProgrammeTableAdapter.GetData(VariablesGlobales.idProgramme)
    End Sub

    Private Sub nudUnites_ValueChanged(sender As Object, e As EventArgs) Handles nudUnites.ValueChanged
        'ajustement des valeurs des unités
        If nudUnites.Value - Int(nudUnites.Value) = 0.66 Then
            nudUnites.Value = nudUnites.Value + 0.01
        ElseIf nudUnites.Value - Int(nudUnites.Value) = 0.34 Then
            nudUnites.Value = nudUnites.Value - 0.01
        End If
    End Sub

    Private Function ValiderProgramme() As Boolean
        'vérification de la saisie des champs obligatoires
        'code du programme
        If txtCode.Text = "" Then
            MsgBox("Veuillez spécifier le code du programme")
            txtCode.Focus()
            Return False
        End If
        'titre
        If txtTitre.Text = "" Then
            MsgBox("Veuillez spécifier le titre du programme")
            txtTitre.Focus()
            Return False
        End If
        'type de programme
        If cbTypeProgramme.SelectedIndex = -1 Then
            MsgBox("Veuillez spécifier un type de programme")
            cbTypeProgramme.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ActiverCompetences(blnActiver As Boolean)
        'gestion de l'activation de l'association de compétences
        btnAjouterCompetence.Enabled = blnActiver
        If dgvCompetences.SelectedRows.Count > 0 Then
            btnDetailsCompetence.Enabled = blnActiver
            btnSupprimerCompetences.Enabled = blnActiver
        Else
            btnDetailsCompetence.Enabled = False
            btnSupprimerCompetences.Enabled = False
        End If
    End Sub

    Private Sub ActiverInfos(blnActiver)
        'gestion de l'activation de la saisie des informations générales
        txtCode.ReadOnly = Not blnActiver
        txtTitre.ReadOnly = Not blnActiver
        cbTypeSanction.Enabled = blnActiver
        cbTypeProgramme.Enabled = blnActiver
        nudDureeFormationSpecifique.ReadOnly = Not blnActiver
        nudDureeFormationSpecifique.Controls(0).Enabled = blnActiver
        nudUnites.ReadOnly = Not blnActiver
        nudUnites.Controls(0).Visible = blnActiver
        nudVersion.ReadOnly = Not blnActiver
        nudVersion.Controls(0).Visible = blnActiver
        txtConditionAdmission.ReadOnly = Not blnActiver
        btnValiderInfos.Enabled = blnActiver
        btnAnnulerInfos.Enabled = blnActiver
        btnModifierInfos.Enabled = Not blnActiver
        btnOk.Enabled = Not blnActiver
        If dgvCompetences.SelectedRows.Count > 0 Then
            btnDetailsCompetence.Enabled = blnActiver
        Else
            btnDetailsCompetence.Enabled = False
        End If
    End Sub

    Private Sub cbTypeSanction_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTypeSanction.SelectedValueChanged
        'sélection du contenu de la combobox du type de programme selon le type de sanction choisi
        cbTypeProgramme.DataSource = P_SELECT_Type_ProgrammeTableAdapter.GetData(False, cbTypeSanction.SelectedValue)
        cbTypeProgramme.SelectedIndex = -1
    End Sub

    Private Sub dgvCompetences_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCompetences.SelectionChanged
        ActiverCompetences(True)
    End Sub
End Class