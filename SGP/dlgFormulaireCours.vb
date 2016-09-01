Imports System.Windows.Forms

Public Class dlgFormulaireCours

    Private monAction As New Action


    Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter
    Dim codeCours As String
    Dim titreCours As String
    Dim sessionCours As Decimal
    Dim theoriqueCours As Decimal
    Dim laboratoireCours As Decimal
    Dim personnelCours As Decimal
    Dim descriptionCours As String
    Dim description As String
    Dim nomPoliceRtf As String = ""
    Dim taillePoliceRtf As Integer
    Dim dtActivite As DataTable
    Dim listeIntention As List(Of Integer)
    Dim dtHabilete As DataTable
    Dim listeElement As List(Of Integer)
    Dim dtPrealable As DataTable
    Dim justificationPrealable As String
    Dim coursCree As Boolean = False
    Dim modificationCode As Boolean = False
    Dim modificationTitre As Boolean = False
    Dim modificationDescription As Boolean = False
    Dim modificationSession As Boolean = False
    Dim modificationTheorique As Boolean = False
    Dim modificationLaboratoire As Boolean = False
    Dim modificationPersonnel As Boolean = False
    Dim modificationActivite As Boolean = False
    Dim modificationIntention As Boolean = False
    Dim modificationHabilete As Boolean = False
    Dim modificationElement As Boolean = False
    Dim modificationPrealable As Boolean = False
    Dim verificationModification As Boolean = False
    Dim idCoursModifie As Integer
    Dim idDevis As Integer

    Dim connexion As New System.Data.SqlClient.SqlConnection
    Dim commandeViderActivite As New System.Data.SqlClient.SqlCommand
    Dim commandeViderIntention As New System.Data.SqlClient.SqlCommand
    Dim commandeViderHabilete As New System.Data.SqlClient.SqlCommand
    Dim commandeViderElement As New System.Data.SqlClient.SqlCommand
    Dim commandeViderPrealable As New System.Data.SqlClient.SqlCommand
    Dim commandeReinsererActivite As New System.Data.SqlClient.SqlCommand
    Dim commandeReinsererIntention As New System.Data.SqlClient.SqlCommand
    Dim commandeReinsererHabilete As New System.Data.SqlClient.SqlCommand
    Dim commandeReinsererElement As New System.Data.SqlClient.SqlCommand
    Dim commandeReinsererPrealable As New System.Data.SqlClient.SqlCommand
    Dim transaction As System.Data.SqlClient.SqlTransaction

    Dim lancerCoursModifie As Boolean = False
    Dim quitterCoursModifie As Boolean = False
    Dim officiel As Boolean = False

    Dim taCours As New SGPDataSetTableAdapters.P_SELECT_Cours_PKTableAdapter
    Dim dtCours As DataTable

    Private Sub dlgFormulaireCours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        If VariablesGlobales.monAction = Action.inserer Then
            monAction = Action.inserer

            ActiverCours(True)
            ActiverActivite(False)
            ActiverAutres(False)
            btnValider.Visible = True
            btnAnnuler.Visible = True
            btnModifier.Visible = True
            btnAnnuler.Enabled = False
            btnAnnulerCours.Enabled = True
            btnEnregistrerCours.Text = "Enregistrer cours"
        ElseIf VariablesGlobales.monAction = Action.consulter Then
            monAction = Action.inserer

            dtCours = taCours.GetData(VariablesGlobales.idCours)

            If dtCours.Rows.Count > 0 Then
                txtCodeCours.Text = dtCours.Rows(0)("codeCOURS")
                txtTitreCours.Text = dtCours.Rows(0)("titreCOURS")
                nudSession.Value = dtCours.Rows(0)("session")
                VariablesGlobales.descriptionCours = dtCours.Rows(0)("description")
                nudTheorique.Value = dtCours.Rows(0)("ponderationTheorique")
                nudLaboratoire.Value = dtCours.Rows(0)("ponderationLaboratoire")
                nudPersonnel.Value = dtCours.Rows(0)("ponderationPersonnel")
                VariablesGlobales.idDevisCours = dtCours.Rows(0)("idDEVIS")
                If Not IsDBNull(dtCours.Rows(0)("justificationPrealable")) Then
                    VariablesGlobales.justification = dtCours.Rows(0)("justificationPrealable")
                End If

                RechercherActivite()
                RechercherIntention()
                RechercherHabilete()
                RechercherElement()
                RechercherPrealable()

                dgvActivite.ClearSelection()
                dgvIntention.ClearSelection()
                dgvHabilete.ClearSelection()
                dgvElement.ClearSelection()
                dgvPrealable.ClearSelection()
            End If

            ActiverCours(False)
            ActiverActivite(False)
            ActiverAutres(False)
            btnValider.Visible = False
            btnAnnuler.Visible = False
            btnModifier.Visible = False
            btnAnnulerCours.Enabled = True
            btnEnregistrerCours.Text = "Modifier cours"
            If VariablesGlobales.devisOfficiel Then
                btnEnregistrerCours.Enabled = False
            Else
                btnEnregistrerCours.Enabled = True
            End If
        End If

        If VariablesGlobales.actionSecondaire = Action.ajoutCoursDevis Then
            idDevis = VariablesGlobales.idDevis
        Else
            idDevis = VariablesGlobales.idDevisCours
        End If
    End Sub

    'Gestion des boutons de la partie cours
    Private Sub btnDescription_Click(sender As Object, e As EventArgs) Handles btnDescription.Click
        Dim saisieDescription As New frmSaisieTexte
        saisieDescription.Text = "Description du cours"
        saisieDescription.rtxtSaisieTexte.Rtf = VariablesGlobales.descriptionCours
        saisieDescription.ShowDialog()
        If (saisieDescription.DialogResult = Windows.Forms.DialogResult.OK) Then
            If VariablesGlobales.monAction = Action.modifier Then
                If (dtCours.Rows(0)("description") <> saisieDescription.rtxtSaisieTexte.Rtf) Then
                    modificationDescription = True
                Else
                    modificationDescription = False
                End If
                VariablesGlobales.descriptionCours = saisieDescription.rtxtSaisieTexte.Rtf
                Dim nombreFonts As Integer
                'récupération du nombre de fonts du texte rtf
                nombreFonts = VariablesGlobales.TrouverMot(VariablesGlobales.descriptionCours, "{\f")
                Dim indexDepart As Integer
                Dim indexFin As Integer
                Dim indexBaliseFont As Integer
                'parcour des fonts
                For i As Integer = 0 To nombreFonts - 1
                    If i = 0 Then
                        'pour le premier qui n'est pas un font
                        indexDepart = VariablesGlobales.descriptionCours.IndexOf("{\f")
                    ElseIf i = 1 Then
                        'pour le premier font
                        indexDepart = VariablesGlobales.descriptionCours.IndexOf("{\f", indexDepart + 1)
                        indexFin = VariablesGlobales.descriptionCours.IndexOf("}", indexDepart + 1)
                        Dim indexDebutPolice As Integer = VariablesGlobales.descriptionCours.IndexOf(" ", indexDepart) + 1
                        Dim nombreCaracterePolice As Integer = indexFin - indexDebutPolice - 1
                        'récupération de la police
                        nomPoliceRtf = VariablesGlobales.descriptionCours.Substring(indexDebutPolice, nombreCaracterePolice)
                    Else
                        If i = 2 Then
                            'pour le deuxième font
                            indexDepart = VariablesGlobales.descriptionCours.IndexOf("{\f", indexDepart + 1)
                        End If
                        indexFin = VariablesGlobales.descriptionCours.IndexOf("}", indexDepart + 1)
                        Dim nombreCaracteres As Integer = indexFin - indexDepart + 1
                        'suppression du font
                        VariablesGlobales.descriptionCours = VariablesGlobales.descriptionCours.Remove(indexDepart, nombreCaracteres)
                        'récupération du nombre de balise du font supprimé
                        Dim nombreBalisesFont As Integer = VariablesGlobales.TrouverMot(VariablesGlobales.descriptionCours, "\f" & i - 1)
                        For j As Integer = 1 To nombreBalisesFont
                            indexBaliseFont = VariablesGlobales.descriptionCours.IndexOf("\f" & i - 1)
                            'suppression des balises
                            VariablesGlobales.descriptionCours = VariablesGlobales.descriptionCours.Remove(indexBaliseFont, 3)
                        Next
                    End If
                Next
                saisieDescription.rtxtSaisieTexte.Rtf = VariablesGlobales.descriptionCours
                saisieDescription.rtxtSaisieTexte.SelectAll()
                'récupération de la taille du texte
                taillePoliceRtf = saisieDescription.rtxtSaisieTexte.SelectionFont.SizeInPoints.ToString("0.0") * 2
            End If
        End If
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If Not VariablesGlobales.descriptionCours = "" And Not nomPoliceRtf = "" Then
            'remplacement de la police et taille du texte
            description = VariablesGlobales.descriptionCours.Replace(nomPoliceRtf, "Calibri").Replace("fs" + taillePoliceRtf.ToString(), "fs22")
            nomPoliceRtf = Nothing
            taillePoliceRtf = Nothing
        Else
            description = VariablesGlobales.epreuveSynthese
        End If
        If ValiderCours() Then
            Select Case monAction
                Case Action.inserer
                    VariablesGlobales.idCours = monTa.P_INSERT_Cours(txtCodeCours.Text,
                                                        txtTitreCours.Text,
                                                        nudTheorique.Value,
                                                        nudLaboratoire.Value,
                                                        nudPersonnel.Value,
                                                        lbUnitesValeur.Text,
                                                        lbHeuresValeur.Text,
                                                        nudSession.Value,
                                                        description)

                    monTa.P_INSERT_CoursDevis(idDevis,
                                              VariablesGlobales.idCours)

                    coursCree = True
                Case Action.modifier
                    monTa.P_UPDATE_Cours(VariablesGlobales.idCours,
                                         txtCodeCours.Text,
                                         txtTitreCours.Text,
                                         nudTheorique.Value,
                                         nudLaboratoire.Value,
                                         nudPersonnel.Value,
                                         lbUnitesValeur.Text,
                                         lbHeuresValeur.Text,
                                         nudSession.Value,
                                         description)
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            ActiverCours(False)
            ActiverActivite(True)
            ActiverAutres(True)

            codeCours = txtCodeCours.Text
            titreCours = txtTitreCours.Text
            sessionCours = nudSession.Value
            theoriqueCours = nudTheorique.Value
            laboratoireCours = nudLaboratoire.Value
            personnelCours = nudPersonnel.Value
            descriptionCours = VariablesGlobales.descriptionCours
        End If
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        ActiverCours(True)
        ActiverActivite(False)
        ActiverAutres(False)

        monAction = Action.modifier
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        txtCodeCours.Text = codeCours
        txtTitreCours.Text = titreCours
        nudSession.Value = sessionCours
        nudTheorique.Value = theoriqueCours
        nudLaboratoire.Value = laboratoireCours
        nudPersonnel.Value = personnelCours
        VariablesGlobales.descriptionCours = descriptionCours

        monAction = Action.inserer
        ActiverCours(False)
        ActiverActivite(True)
        ActiverAutres(True)
    End Sub

    'Gestion des boutons de la partie activité
    Private Sub btnEnregistrerActivite_Click(sender As Object, e As EventArgs) Handles btnEnregistrerActivite.Click
        If ValiderActivite() Then
            Dim idActivite As Integer

            Select Case monAction
                Case Action.inserer
                    idActivite = monTa.P_INSERT_Activite(txtActivite.Text,
                                            VariablesGlobales.idCours)

                    modificationActivite = True

                Case Action.modifier
                    idActivite = dgvActivite.SelectedRows(0).Cells(0).Value

                    monTa.P_UPDATE_Activite(idActivite,
                                            txtActivite.Text)

                    modificationActivite = True
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            RechercherActivite()
            SelectionneActivite(idActivite)
            txtActivite.Clear()
        End If
    End Sub

    Private Sub btnModifierActivite_Click(sender As Object, e As EventArgs) Handles btnModifierActivite.Click
        txtActivite.Text = dgvActivite.SelectedRows(0).Cells(1).Value
        monAction = Action.modifierAutre
        ActiverAutres(False)
        monAction = Action.modifier
        ActiverActivite(False)
    End Sub

    Private Sub btnSupprimerActivite_Click(sender As Object, e As EventArgs) Handles btnSupprimerActivite.Click
        monTa.P_DELETE_Activite(dgvActivite.SelectedRows(0).Cells(0).Value)
        RechercherActivite()

        modificationActivite = True
    End Sub

    Private Sub btnAnnulerActivite_Click(sender As Object, e As EventArgs) Handles btnAnnulerActivite.Click
        txtActivite.Clear()
        monAction = Action.inserer
        ActiverActivite(True)
        ActiverAutres(True)
    End Sub

    'Gestion des boutons de la partie intention

    Private Sub btnAjouterIntention_Click(sender As Object, e As EventArgs) Handles btnAjouterIntention.Click
        Dim selectionIntention As New dlgListeIntention
        selectionIntention.ShowDialog()

        RechercherIntention()
    End Sub

    Private Sub btnEnleverIntention_Click(sender As Object, e As EventArgs) Handles btnEnleverIntention.Click
        monTa.P_DELETE_IntentionCours(VariablesGlobales.idCours,
                                      dgvIntention.SelectedRows(0).Cells(0).Value)

        RechercherIntention()
    End Sub

    'Gestion des boutons de la partie habileté

    Private Sub btnAjouterHabilete_Click(sender As Object, e As EventArgs) Handles btnAjouterHabilete.Click
        Dim selectionHabilete As New dlgListeHabilete
        selectionHabilete.ShowDialog()

        RechercherHabilete()
    End Sub

    Private Sub btnEnleverHabilete_Click(sender As Object, e As EventArgs) Handles btnEnleverHabilete.Click
        monTa.P_DELETE_HabileteCours(VariablesGlobales.idCours,
                                     dgvHabilete.SelectedRows(0).Cells(0).Value)

        RechercherHabilete()
    End Sub

    'Gestion des boutons de la partie élément

    Private Sub btnAjouterElement_Click(sender As Object, e As EventArgs) Handles btnAjouterElement.Click
        Dim selectionElement As New dlgListeElement
        selectionElement.ShowDialog()

        RechercherElement()
    End Sub

    Private Sub btnEnleverElement_Click(sender As Object, e As EventArgs) Handles btnEnleverElement.Click
        monTa.P_DELETE_ElementCours(VariablesGlobales.idCours,
                                     dgvElement.SelectedRows(0).Cells(0).Value)

        RechercherElement()
    End Sub

    'Gestion des boutons de la partie préalable

    Private Sub btnAjouterPrealable_Click(sender As Object, e As EventArgs) Handles btnAjouterPrealable.Click
        VariablesGlobales.actionPrealable = Action.inserer

        Dim selectionPrealable As New dlgListeCours
        selectionPrealable.ShowDialog()

        If selectionPrealable.DialogResult = Windows.Forms.DialogResult.OK Then
            VariablesGlobales.justification = selectionPrealable.rtxtJustification.Rtf
            modificationPrealable = True
        End If

        RechercherPrealable()
    End Sub

    Private Sub btnEnleverPrealable_Click(sender As Object, e As EventArgs) Handles btnEnleverPrealable.Click
        monTa.P_DELETE_PrealableCours(VariablesGlobales.idCours,
                                      dgvPrealable.SelectedRows(0).Cells(0).Value)

        modificationPrealable = True

        RechercherPrealable()

        dtCours = taCours.GetData(VariablesGlobales.idCours)
        If IsDBNull(dtCours.Rows(0)("justificationPrealable")) Then
            VariablesGlobales.justification = Nothing
        End If
    End Sub

    Private Sub btnModifierPrealable_Click(sender As Object, e As EventArgs) Handles btnModifierPrealable.Click
        VariablesGlobales.actionPrealable = Action.modifier
        VariablesGlobales.idCoursRequis = dgvPrealable.SelectedRows(0).Cells(0).Value

        Dim selectionPrealable As New dlgListeCours
        selectionPrealable.ShowDialog()

        If selectionPrealable.DialogResult = Windows.Forms.DialogResult.OK And VariablesGlobales.modification Then
            VariablesGlobales.justification = selectionPrealable.rtxtJustification.Rtf
            modificationPrealable = True
            VariablesGlobales.modification = False
        End If

        RechercherPrealable()
    End Sub

    'Gestion de la validation du cours

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrerCours.Click
        Select Case VariablesGlobales.monAction
            Case Action.inserer
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
                If VariablesGlobales.actionSecondaire = Action.ajoutCoursDevis Then
                    MsgBox("Le cours a été associé au devis avec succès!", MsgBoxStyle.Information, "Ajout du cours")
                End If
            Case Action.consulter
                VariablesGlobales.monAction = Action.modifier

                'récupération des données avant modification
                dtActivite = P_SELECT_ActiviteTableAdapter.GetData(VariablesGlobales.idCours)
                listeIntention = New List(Of Integer)
                For Each row As DataGridViewRow In dgvIntention.Rows
                    listeIntention.Add(row.Cells(0).Value)
                Next
                dtHabilete = P_SELECT_HabileteCoursTableAdapter().GetData(VariablesGlobales.idCours)
                listeElement = New List(Of Integer)
                For Each row As DataGridViewRow In dgvElement.Rows
                    listeElement.Add(row.Cells(0).Value)
                Next
                dtPrealable = P_SELECT_PrealableCoursTableAdapter().GetData(VariablesGlobales.idCours)
                justificationPrealable = VariablesGlobales.justification

                ActiverCours(True)
                ActiverActivite(True)
                ActiverAutres(True)
                btnEnregistrerCours.Text = "Enregistrer cours"
            Case Action.modifier
                Dim taCours As New SGPDataSetTableAdapters.P_SELECT_Cours_PKTableAdapter
                Dim dtCours = taCours.GetData(VariablesGlobales.idCours)

                For Each row As DataRow In dtCours
                    If Not IsDBNull(row.Item("dateOfficialisation")) Then
                        officiel = True
                    End If
                Next
                If Not VariablesGlobales.descriptionCours = "" And Not nomPoliceRtf = "" Then
                    description = VariablesGlobales.descriptionCours.Replace(nomPoliceRtf, "Calibri").Replace("fs" + taillePoliceRtf.ToString(), "fs22")
                    nomPoliceRtf = Nothing
                    taillePoliceRtf = Nothing
                Else
                    description = VariablesGlobales.descriptionCours
                End If
                If Not officiel Then
                    monTa.P_UPDATE_Cours(VariablesGlobales.idCours,
                                         txtCodeCours.Text,
                                         txtTitreCours.Text,
                                         nudTheorique.Value,
                                         nudLaboratoire.Value,
                                         nudPersonnel.Value,
                                         lbUnitesValeur.Text,
                                         lbHeuresValeur.Text,
                                         nudSession.Value,
                                         description)
                Else
                    If VariablesGlobales.actionSecondaire = Action.ajoutCoursDevis Then
                        lancerCoursModifie = True
                    Else
                        Dim selectionDevis As New dlgSelectionDevis
                        selectionDevis.ShowDialog()

                        If selectionDevis.DialogResult <> Windows.Forms.DialogResult.Cancel Then
                            lancerCoursModifie = True
                            idDevis = VariablesGlobales.idDevisCours
                        Else
                            While (Not quitterCoursModifie) And (Not lancerCoursModifie)
                                If MsgBox("Si vous annulez, toutes les valeurs saisies seront perdues, êtes-vous sûr ?", MsgBoxStyle.YesNo, "Annuler la création de cours") = MsgBoxResult.Yes Then
                                    quitterCoursModifie = True
                                Else
                                    selectionDevis.ShowDialog()
                                    If selectionDevis.DialogResult <> Windows.Forms.DialogResult.Cancel Then
                                        lancerCoursModifie = True
                                        idDevis = VariablesGlobales.idDevisCours
                                    End If
                                End If
                            End While
                        End If
                    End If

                    'création du cours
                    Dim commandeCreerCours As New System.Data.SqlClient.SqlCommand
                    Dim commandeAjouterDevis As New System.Data.SqlClient.SqlCommand
                    Dim commandeAjouterActivite As New System.Data.SqlClient.SqlCommand
                    Dim commandeAjouterIntention As New System.Data.SqlClient.SqlCommand
                    Dim commandeAjouterHabilete As New System.Data.SqlClient.SqlCommand
                    Dim commandeAjouterElement As New System.Data.SqlClient.SqlCommand
                    Dim commandeAjouterPrealable As New System.Data.SqlClient.SqlCommand

                    Try

                        'ouverture de la connexion
                        connexion.ConnectionString = SGP.My.Settings.H2016_Stage_Yoann_QuentinConnectionString
                        connexion.Open()

                        'création de la commandeCreerCour
                        commandeCreerCours.Connection = connexion
                        commandeCreerCours.CommandType = CommandType.StoredProcedure
                        commandeCreerCours.CommandText = "P_INSERT_Cours"

                        commandeCreerCours.Parameters.Add("codeCOURS", SqlDbType.VarChar)
                        commandeCreerCours.Parameters.Add("titreCOURS", SqlDbType.VarChar)
                        commandeCreerCours.Parameters.Add("ponderationTheorique", SqlDbType.Int)
                        commandeCreerCours.Parameters.Add("ponderationLaboratoire", SqlDbType.Int)
                        commandeCreerCours.Parameters.Add("ponderationPersonnel", SqlDbType.Int)
                        commandeCreerCours.Parameters.Add("unites", SqlDbType.Decimal)
                        commandeCreerCours.Parameters.Add("heureContact", SqlDbType.Int)
                        commandeCreerCours.Parameters.Add("session", SqlDbType.Int)
                        commandeCreerCours.Parameters.Add("description", SqlDbType.VarChar)

                        'création de la commandeAjouterDevis
                        commandeAjouterDevis.Connection = connexion
                        commandeAjouterDevis.CommandType = CommandType.StoredProcedure
                        commandeAjouterDevis.CommandText = "P_INSERT_CoursDevis"

                        commandeAjouterDevis.Parameters.Add("idDEVIS", SqlDbType.Int)
                        commandeAjouterDevis.Parameters.Add("idCOURS", SqlDbType.Int)

                        'création de la commandeAjouterActivite
                        commandeAjouterActivite.Connection = connexion
                        commandeAjouterActivite.CommandType = CommandType.StoredProcedure
                        commandeAjouterActivite.CommandText = "P_INSERT_Activite"

                        commandeAjouterActivite.Parameters.Add("descriptionACTIVITE", SqlDbType.VarChar)
                        commandeAjouterActivite.Parameters.Add("idCOURS", SqlDbType.Int)

                        'création de la commandeAjouterIntention
                        commandeAjouterIntention.Connection = connexion
                        commandeAjouterIntention.CommandType = CommandType.StoredProcedure
                        commandeAjouterIntention.CommandText = "P_INSERT_IntentionCours"

                        commandeAjouterIntention.Parameters.Add("idCOURS", SqlDbType.Int)
                        commandeAjouterIntention.Parameters.Add("idINTENTION", SqlDbType.Int)

                        'création de la commandeAjouterHabilete
                        commandeAjouterHabilete.Connection = connexion
                        commandeAjouterHabilete.CommandType = CommandType.StoredProcedure
                        commandeAjouterHabilete.CommandText = "P_INSERT_HabileteCours"

                        commandeAjouterHabilete.Parameters.Add("idCOURS", SqlDbType.Int)
                        commandeAjouterHabilete.Parameters.Add("idHABILETE", SqlDbType.Int)
                        commandeAjouterHabilete.Parameters.Add("idSECTION_HABILETE", SqlDbType.Int)
                        commandeAjouterHabilete.Parameters.Add("version", SqlDbType.Int)

                        'création de la commandeAjouterElement
                        commandeAjouterElement.Connection = connexion
                        commandeAjouterElement.CommandType = CommandType.StoredProcedure
                        commandeAjouterElement.CommandText = "P_INSERT_ElementCours"

                        commandeAjouterElement.Parameters.Add("idCOURS", SqlDbType.Int)
                        commandeAjouterElement.Parameters.Add("idELEMENT", SqlDbType.Int)

                        'création de la commandeAjouterPrealable
                        commandeAjouterPrealable.Connection = connexion
                        commandeAjouterPrealable.CommandType = CommandType.StoredProcedure
                        commandeAjouterPrealable.CommandText = "P_INSERT_PrealableCours"

                        commandeAjouterPrealable.Parameters.Add("idCOURS", SqlDbType.Int)
                        commandeAjouterPrealable.Parameters.Add("idCOURS_REQUIS", SqlDbType.Int)
                        commandeAjouterPrealable.Parameters.Add("idTypePrealable", SqlDbType.Char)
                        commandeAjouterPrealable.Parameters.Add("justification", SqlDbType.VarChar)

                        ReinitialiserDonneesCreationCommande()

                        'BEGIN TRANSACTION
                        transaction = connexion.BeginTransaction

                        If lancerCoursModifie Then
                            commandeCreerCours.Parameters(0).Value = txtCodeCours.Text
                            commandeCreerCours.Parameters(1).Value = txtTitreCours.Text
                            commandeCreerCours.Parameters(2).Value = nudTheorique.Value
                            commandeCreerCours.Parameters(3).Value = nudLaboratoire.Value
                            commandeCreerCours.Parameters(4).Value = nudPersonnel.Value
                            commandeCreerCours.Parameters(5).Value = lbUnitesValeur.Text
                            commandeCreerCours.Parameters(6).Value = lbHeuresValeur.Text
                            commandeCreerCours.Parameters(7).Value = nudSession.Value
                            commandeCreerCours.Parameters(8).Value = VariablesGlobales.descriptionCours

                            commandeCreerCours.Transaction = transaction

                            'exécution de la commandeCreerCours
                            idCoursModifie = commandeCreerCours.ExecuteScalar()

                            commandeAjouterDevis.Parameters(0).Value = idDevis
                            commandeAjouterDevis.Parameters(1).Value = idCoursModifie

                            commandeAjouterDevis.Transaction = transaction

                            'exécution de la commandeAjouterDevis
                            commandeAjouterDevis.ExecuteNonQuery()

                            For Each row As DataGridViewRow In dgvActivite.Rows
                                commandeAjouterActivite.Parameters(0).Value = row.Cells(1).Value
                                commandeAjouterActivite.Parameters(1).Value = idCoursModifie

                                commandeAjouterActivite.Transaction = transaction

                                'exécution de la commandeAjouterActivite
                                commandeAjouterActivite.ExecuteNonQuery()
                            Next

                            For Each row As DataGridViewRow In dgvIntention.Rows
                                commandeAjouterIntention.Parameters(0).Value = idCoursModifie
                                commandeAjouterIntention.Parameters(1).Value = row.Cells(0).Value

                                commandeAjouterIntention.Transaction = transaction

                                'exécution de la commandeAjouterIntention
                                commandeAjouterIntention.ExecuteNonQuery()
                            Next

                            For Each row As DataGridViewRow In dgvHabilete.Rows
                                commandeAjouterHabilete.Parameters(0).Value = idCoursModifie
                                commandeAjouterHabilete.Parameters(1).Value = row.Cells(0).Value
                                commandeAjouterHabilete.Parameters(2).Value = row.Cells(1).Value
                                commandeAjouterHabilete.Parameters(3).Value = row.Cells(2).Value

                                commandeAjouterHabilete.Transaction = transaction

                                'exécution de la commandeAjouterHabilete
                                commandeAjouterHabilete.ExecuteNonQuery()
                            Next

                            For Each row As DataGridViewRow In dgvElement.Rows
                                commandeAjouterElement.Parameters(0).Value = idCoursModifie
                                commandeAjouterElement.Parameters(1).Value = row.Cells(0).Value

                                commandeAjouterElement.Transaction = transaction

                                'exécution de la commandeAjouterElement
                                commandeAjouterElement.ExecuteNonQuery()
                            Next

                            For Each row As DataGridViewRow In dgvPrealable.Rows
                                commandeAjouterPrealable.Parameters(0).Value = idCoursModifie
                                commandeAjouterPrealable.Parameters(1).Value = row.Cells(0).Value
                                commandeAjouterPrealable.Parameters(2).Value = row.Cells(2).Value
                                commandeAjouterPrealable.Parameters(3).Value = row.Cells(3).Value

                                commandeAjouterPrealable.Transaction = transaction

                                'exécution de la commandeAjouterPrealable
                                commandeAjouterPrealable.ExecuteNonQuery()
                            Next
                        End If

                        If coursCree Then
                            'réinsertion des données avant modification
                            ReinitialiserDonneesExecutionCommande()
                        End If

                        'COMMIT TRANSACTION
                        transaction.Commit()

                    Catch ex As Exception

                        MsgBox("Oups! " + ex.Message)

                        'ROLLBACK TRANSACTION
                        transaction.Rollback()

                    Finally

                        'fermeture de la connexion
                        connexion.Close()

                    End Try
                    If VariablesGlobales.actionSecondaire = Action.ajoutCoursDevis Then
                        MsgBox("Le cours à été associé au devis avec succès!", MsgBoxStyle.Information, "Ajout du cours")
                    End If
                End If

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Case Else
                MsgBox("Oups")
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulerCours.Click
        Select Case VariablesGlobales.monAction
            Case Action.inserer
                If coursCree Then
                    If MsgBox("Si vous annulez, toutes les valeurs saisies seront perdues, êtes-vous sûr ?", MsgBoxStyle.YesNo, "Annuler la création de cours") = MsgBoxResult.Yes Then
                        monTa.P_DELETE_Cours(VariablesGlobales.idCours)
                        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                        Me.Close()
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.None
                    End If
                Else
                    monTa.P_DELETE_Cours(VariablesGlobales.idCours)
                    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                    Me.Close()
                End If
            Case Action.consulter
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            Case Action.modifier
                verifierModificationIntention()
                verifierModificationHabilete()
                verifierModificationElement()

                If modificationCode Or modificationTitre Or modificationDescription Or modificationSession Or modificationTheorique Or modificationLaboratoire Or modificationPersonnel Or modificationActivite Or modificationIntention Or modificationHabilete Or modificationElement Or modificationPrealable Then
                    If MsgBox("Si vous annulez, toutes les modifications seront perdues, êtes-vous sûr ?", MsgBoxStyle.YesNo, "Annuler la modification du cours") = MsgBoxResult.Yes Then
                        Try
                            'réinsertion des données avant modification

                            'ouverture de la connexion
                            connexion.ConnectionString = SGP.My.Settings.H2016_Stage_Yoann_QuentinConnectionString
                            connexion.Open()

                            ReinitialiserDonneesCreationCommande()

                            'BEGIN TRANSACTION
                            transaction = connexion.BeginTransaction

                            ReinitialiserDonneesExecutionCommande()

                            'COMMIT TRANSACTION
                            transaction.Commit()

                        Catch ex As Exception

                            MsgBox("Oups! " + ex.Message)

                            'ROLLBACK TRANSACTION
                            transaction.Rollback()

                        Finally

                            'fermeture de la connexion
                            connexion.Close()

                        End Try
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.None
                    End If
                End If
        End Select
    End Sub

    'Fonctions

    Private Sub dgvActivite_SelectionChanged(sender As Object, e As EventArgs) Handles dgvActivite.SelectionChanged
        If VariablesGlobales.monAction <> Action.consulter Then
            ActiverActivite(True)
        End If
    End Sub

    Private Sub dgvIntention_SelectionChanged(sender As Object, e As EventArgs) Handles dgvIntention.SelectionChanged
        If VariablesGlobales.monAction <> Action.consulter Then
            ActiverAutres(True)
        End If
    End Sub

    Private Sub dgvHabilete_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHabilete.SelectionChanged
        If VariablesGlobales.monAction <> Action.consulter Then
            ActiverAutres(True)
        End If
    End Sub

    Private Sub dgvElement_SelectionChanged(sender As Object, e As EventArgs) Handles dgvElement.SelectionChanged
        If VariablesGlobales.monAction <> Action.consulter Then
            ActiverAutres(True)
        End If
    End Sub

    Private Sub dgvPrealable_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPrealable.SelectionChanged
        If VariablesGlobales.monAction <> Action.consulter Then
            ActiverAutres(True)
        End If
    End Sub

    Private Sub txtCodeCours_TextChanged(sender As Object, e As EventArgs) Handles txtCodeCours.TextChanged
        If VariablesGlobales.monAction = Action.modifier Then
            If txtCodeCours.Text <> dtCours.Rows(0)("codeCOURS") Then
                modificationCode = True
            Else
                modificationCode = False
            End If
        End If
    End Sub

    Private Sub txtTitreCours_TextChanged(sender As Object, e As EventArgs) Handles txtTitreCours.TextChanged
        If VariablesGlobales.monAction = Action.modifier Then
            If txtTitreCours.Text <> dtCours.Rows(0)("titreCOURS") Then
                modificationTitre = True
            Else
                modificationTitre = False
            End If
        End If
    End Sub

    Private Sub nudSession_ValueChanged(sender As Object, e As EventArgs) Handles nudSession.ValueChanged
        If VariablesGlobales.monAction = Action.modifier Then
            If nudSession.Value <> dtCours.Rows(0)("session") Then
                modificationSession = True
            Else
                modificationSession = False
            End If
        End If
    End Sub

    Private Sub nudTheorique_ValueChanged(sender As Object, e As EventArgs) Handles nudTheorique.ValueChanged
        'calcule des unités et heures
        lbUnitesValeur.Text = ((nudTheorique.Value + nudLaboratoire.Value + nudPersonnel.Value) / 3).ToString("0.00")
        lbHeuresValeur.Text = (nudTheorique.Value + nudLaboratoire.Value) * 15
        If VariablesGlobales.monAction = Action.modifier Then
            If nudTheorique.Value <> dtCours.Rows(0)("ponderationTheorique") Then
                modificationTheorique = True
            Else
                modificationTheorique = False
            End If
        End If
    End Sub

    Private Sub nudLaboratoire_ValueChanged(sender As Object, e As EventArgs) Handles nudLaboratoire.ValueChanged
        lbUnitesValeur.Text = ((nudTheorique.Value + nudLaboratoire.Value + nudPersonnel.Value) / 3).ToString("0.00")
        lbHeuresValeur.Text = (nudTheorique.Value + nudLaboratoire.Value) * 15
        If VariablesGlobales.monAction = Action.modifier Then
            If nudLaboratoire.Value <> dtCours.Rows(0)("ponderationLaboratoire") Then
                modificationLaboratoire = True
            Else
                modificationLaboratoire = False
            End If
        End If
    End Sub

    Private Sub nudPersonnel_ValueChanged(sender As Object, e As EventArgs) Handles nudPersonnel.ValueChanged
        lbUnitesValeur.Text = ((nudTheorique.Value + nudLaboratoire.Value + nudPersonnel.Value) / 3).ToString("0.00")
        lbHeuresValeur.Text = (nudTheorique.Value + nudLaboratoire.Value) * 15
        If VariablesGlobales.monAction = Action.modifier Then
            If nudPersonnel.Value <> dtCours.Rows(0)("ponderationPersonnel") Then
                modificationPersonnel = True
            Else
                modificationPersonnel = False
            End If
        End If
    End Sub

    Private Sub verifierModificationIntention()
        If dgvIntention.Rows.Count = listeIntention.Count Then
            For Each row1 As DataGridViewRow In dgvIntention.Rows
                Dim correspondance As Boolean = False
                For Each idIntention In listeIntention
                    If row1.Cells(0).Value = idIntention Then
                        correspondance = True
                    End If
                Next
                If Not correspondance Then
                    verificationModification = True
                End If
            Next
        Else
            verificationModification = True
        End If
        If verificationModification Then
            modificationIntention = True
            verificationModification = False
        Else
            modificationIntention = False
        End If
    End Sub

    Private Sub verifierModificationHabilete()
        If dgvHabilete.Rows.Count = dtHabilete.Rows.Count Then
            For Each row1 As DataGridViewRow In dgvHabilete.Rows
                Dim correspondance As Boolean = False
                For Each row2 As DataRow In dtHabilete.Rows
                    If (row1.Cells(0).Value = row2.Item(0)) And (row1.Cells(1).Value = row2.Item(1)) And (row1.Cells(2).Value = row2.Item(2)) Then
                        correspondance = True
                    End If
                Next
                If Not correspondance Then
                    verificationModification = True
                End If
            Next
        Else
            verificationModification = True
        End If
        If verificationModification Then
            modificationHabilete = True
            verificationModification = False
        Else
            modificationHabilete = False
        End If
    End Sub

    Private Sub verifierModificationElement()
        If dgvElement.Rows.Count = listeElement.Count Then
            For Each row1 As DataGridViewRow In dgvElement.Rows
                Dim correspondance As Boolean = False
                For Each idElement In listeElement
                    If row1.Cells(0).Value = idElement Then
                        correspondance = True
                    End If
                Next
                If Not correspondance Then
                    verificationModification = True
                End If
            Next
        Else
            verificationModification = True
        End If
        If verificationModification Then
            modificationElement = True
            verificationModification = False
        Else
            modificationElement = False
        End If
    End Sub

    Private Sub RechercherActivite()
        dgvActivite.DataSource = P_SELECT_ActiviteTableAdapter.GetData(VariablesGlobales.idCours)

        gbActivite.Text = "Activités d'apprentissage (" + dgvActivite.RowCount().ToString + ")"

        ActiverActivite(True)
        ActiverAutres(True)
    End Sub

    Private Sub RechercherIntention()
        dgvIntention.DataSource = P_SELECT_IntentionCoursTableAdapter().GetData(VariablesGlobales.idCours)

        gbIntention.Text = "Intentions éducatives (" + dgvIntention.RowCount().ToString + ")"

        ActiverActivite(True)
        ActiverAutres(True)
    End Sub

    Private Sub RechercherHabilete()
        dgvHabilete.DataSource = P_SELECT_HabileteCoursTableAdapter().GetData(VariablesGlobales.idCours)

        gbHabilete.Text = "Habiletés du profil TIC (" + dgvHabilete.RowCount().ToString + ")"

        ActiverActivite(True)
        ActiverAutres(True)
    End Sub

    Private Sub RechercherElement()
        dgvElement.DataSource = P_SELECT_ElementCoursTableAdapter().GetData(VariablesGlobales.idCours)

        gbElement.Text = "Éléments de compétence (" + dgvElement.RowCount().ToString + ")"

        ActiverActivite(True)
        ActiverAutres(True)
    End Sub

    Private Sub RechercherPrealable()
        dgvPrealable.DataSource = P_SELECT_PrealableCoursTableAdapter().GetData(VariablesGlobales.idCours)

        gbPrealable.Text = "Préalable (" + dgvPrealable.RowCount().ToString + ")"

        ActiverActivite(True)
        ActiverAutres(True)
    End Sub

    Private Sub SelectionneActivite(intIdActivite As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvActivite.Rows.Count) And (Not blnTrouve)
            If dgvActivite.Rows(intRangee).Cells(0).Value = intIdActivite Then
                dgvActivite.Rows(intRangee).Selected = True
                dgvActivite.FirstDisplayedScrollingRowIndex = intRangee

                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Function ValiderCours() As Boolean
        If txtCodeCours.Text <> "" Then
            If Not IsNumeric(txtCodeCours.Text.Substring(0, 3)) Then
                MsgBox("Le code du cour doit commencer par 3 chiffres.")
                txtTitreCours.Focus()
                Return False
            End If
        End If
        If txtTitreCours.Text = "" Then
            MsgBox("Veuillez spécifier un titre pour le cours.")
            txtTitreCours.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValiderActivite() As Boolean
        If txtActivite.Text = "" Then
            MsgBox("Veuillez spécifier une activité.")
            txtActivite.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub ActiverCours(blnActiver As Boolean)
        gbFormation.Enabled = blnActiver
        gbPondUniHor.Enabled = blnActiver

        btnValider.Enabled = blnActiver
        btnAnnuler.Enabled = blnActiver
    End Sub

    Private Sub ActiverActivite(blnActiver As Boolean)
        Select Case monAction
            Case Action.inserer
                If VariablesGlobales.monAction <> Action.consulter Then
                    gbActivite.Enabled = blnActiver
                    dgvActivite.Enabled = blnActiver
                End If
                lbActivite.Enabled = blnActiver
                txtActivite.Enabled = blnActiver
                btnEnregistrerActivite.Enabled = blnActiver
                btnAnnulerActivite.Enabled = blnActiver

                If dgvActivite.SelectedRows.Count > 0 Then
                    btnModifierActivite.Enabled = blnActiver
                    btnSupprimerActivite.Enabled = blnActiver
                Else
                    btnModifierActivite.Enabled = False
                    btnSupprimerActivite.Enabled = False
                End If

                btnModifier.Enabled = blnActiver
                btnEnregistrerCours.Enabled = blnActiver
                btnAnnulerCours.Enabled = blnActiver
            Case Action.modifier
                dgvActivite.Enabled = blnActiver
                btnModifierActivite.Enabled = blnActiver
                btnSupprimerActivite.Enabled = blnActiver
                btnModifier.Enabled = blnActiver
                btnEnregistrerCours.Enabled = blnActiver
                btnAnnulerCours.Enabled = blnActiver
            Case Else
                MsgBox("Oups")
        End Select
    End Sub

    Private Sub ActiverAutres(blnActiver As Boolean)
        If VariablesGlobales.monAction <> Action.consulter Then
            gbIntention.Enabled = blnActiver
            gbHabilete.Enabled = blnActiver
            gbElement.Enabled = blnActiver
            gbPrealable.Enabled = blnActiver
        End If
        btnAjouterIntention.Enabled = blnActiver
        btnAjouterHabilete.Enabled = blnActiver
        btnAjouterElement.Enabled = blnActiver
        btnAjouterPrealable.Enabled = blnActiver

        If dgvIntention.SelectedRows.Count = 0 Then
            btnEnleverIntention.Enabled = False
        Else
            btnEnleverIntention.Enabled = blnActiver
        End If

        If dgvHabilete.SelectedRows.Count = 0 Then
            btnEnleverHabilete.Enabled = False
        Else
            btnEnleverHabilete.Enabled = blnActiver
        End If

        If dgvElement.SelectedRows.Count = 0 Then
            btnEnleverElement.Enabled = False
        Else
            btnEnleverElement.Enabled = blnActiver
        End If

        If dgvPrealable.SelectedRows.Count = 0 Then
            btnEnleverPrealable.Enabled = False
            btnModifierPrealable.Enabled = False
        Else
            btnEnleverPrealable.Enabled = blnActiver
            btnModifierPrealable.Enabled = blnActiver
        End If
    End Sub

    Private Sub ReinitialiserDonneesCreationCommande()
        'création de la commandeViderActivite
        commandeViderActivite.Connection = connexion
        commandeViderActivite.CommandType = CommandType.StoredProcedure
        commandeViderActivite.CommandText = "P_DELETE_Activite"

        commandeViderActivite.Parameters.Add("idACTIVITE", SqlDbType.Int)

        'création de la commandeViderIntention
        commandeViderIntention.Connection = connexion
        commandeViderIntention.CommandType = CommandType.StoredProcedure
        commandeViderIntention.CommandText = "P_DELETE_IntentionCours"

        commandeViderIntention.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeViderIntention.Parameters.Add("idINTENTION", SqlDbType.Int)

        'création de la commandeViderHabilete
        commandeViderHabilete.Connection = connexion
        commandeViderHabilete.CommandType = CommandType.StoredProcedure
        commandeViderHabilete.CommandText = "P_DELETE_HabileteCours"

        commandeViderHabilete.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeViderHabilete.Parameters.Add("idHABILETE", SqlDbType.Int)

        'création de la commandeViderElement
        commandeViderElement.Connection = connexion
        commandeViderElement.CommandType = CommandType.StoredProcedure
        commandeViderElement.CommandText = "P_DELETE_ElementCours"

        commandeViderElement.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeViderElement.Parameters.Add("idELEMENT", SqlDbType.Int)

        'création de la commandeViderPrealable
        commandeViderPrealable.Connection = connexion
        commandeViderPrealable.CommandType = CommandType.StoredProcedure
        commandeViderPrealable.CommandText = "P_DELETE_PrealableCours"

        commandeViderPrealable.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeViderPrealable.Parameters.Add("idCOURS_REQUIS", SqlDbType.Int)

        'création de la commandeReinsererActivite
        commandeReinsererActivite.Connection = connexion
        commandeReinsererActivite.CommandType = CommandType.StoredProcedure
        commandeReinsererActivite.CommandText = "P_INSERT_Activite"

        commandeReinsererActivite.Parameters.Add("descriptionACTIVITE", SqlDbType.VarChar)
        commandeReinsererActivite.Parameters.Add("idCOURS", SqlDbType.Int)

        'création de la commandeReinsererIntention
        commandeReinsererIntention.Connection = connexion
        commandeReinsererIntention.CommandType = CommandType.StoredProcedure
        commandeReinsererIntention.CommandText = "P_INSERT_IntentionCours"

        commandeReinsererIntention.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeReinsererIntention.Parameters.Add("idINTENTION", SqlDbType.Int)

        'création de la commandeReinsererHabilete
        commandeReinsererHabilete.Connection = connexion
        commandeReinsererHabilete.CommandType = CommandType.StoredProcedure
        commandeReinsererHabilete.CommandText = "P_INSERT_HabileteCours"

        commandeReinsererHabilete.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeReinsererHabilete.Parameters.Add("idHABILETE", SqlDbType.Int)

        'création de la commandeReinsererElement
        commandeReinsererElement.Connection = connexion
        commandeReinsererElement.CommandType = CommandType.StoredProcedure
        commandeReinsererElement.CommandText = "P_INSERT_ElementCours"

        commandeReinsererElement.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeReinsererElement.Parameters.Add("idELEMENT", SqlDbType.Int)

        'création de la commandeReinsererPrealable
        commandeReinsererPrealable.Connection = connexion
        commandeReinsererPrealable.CommandType = CommandType.StoredProcedure
        commandeReinsererPrealable.CommandText = "P_INSERT_PrealableCours"

        commandeReinsererPrealable.Parameters.Add("idCOURS", SqlDbType.Int)
        commandeReinsererPrealable.Parameters.Add("idCOURS_REQUIS", SqlDbType.Int)
        commandeReinsererPrealable.Parameters.Add("idTypePrealable", SqlDbType.Char)
        commandeReinsererPrealable.Parameters.Add("justification", SqlDbType.VarChar)
    End Sub

    Private Sub ReinitialiserDonneesExecutionCommande()
        For Each row As DataGridViewRow In dgvActivite.Rows
            commandeViderActivite.Parameters(0).Value = row.Cells(0).Value

            commandeViderActivite.Transaction = transaction

            'exécution de la commandeViderActivite
            commandeViderActivite.ExecuteNonQuery()
        Next

        For Each row As DataGridViewRow In dgvIntention.Rows
            commandeViderIntention.Parameters(0).Value = VariablesGlobales.idCours
            commandeViderIntention.Parameters(1).Value = row.Cells(0).Value

            commandeViderIntention.Transaction = transaction

            'exécution de la commandeViderIntention
            commandeViderIntention.ExecuteNonQuery()
        Next

        For Each row As DataGridViewRow In dgvHabilete.Rows
            commandeViderHabilete.Parameters(0).Value = VariablesGlobales.idCours
            commandeViderHabilete.Parameters(1).Value = row.Cells(0).Value

            commandeViderHabilete.Transaction = transaction

            'exécution de la commandeViderHabilete
            commandeViderHabilete.ExecuteNonQuery()
        Next

        For Each row As DataGridViewRow In dgvElement.Rows
            commandeViderElement.Parameters(0).Value = VariablesGlobales.idCours
            commandeViderElement.Parameters(1).Value = row.Cells(0).Value

            commandeViderElement.Transaction = transaction

            'exécution de la commandeViderElement
            commandeViderElement.ExecuteNonQuery()
        Next

        For Each row As DataGridViewRow In dgvPrealable.Rows
            commandeViderPrealable.Parameters(0).Value = VariablesGlobales.idCours
            commandeViderPrealable.Parameters(1).Value = row.Cells(0).Value

            commandeViderPrealable.Transaction = transaction

            'exécution de la commandeViderPrealable
            commandeViderPrealable.ExecuteNonQuery()
        Next

        For Each row As DataRow In dtActivite.Rows
            commandeReinsererActivite.Parameters(0).Value = row.Item(1)
            commandeReinsererActivite.Parameters(1).Value = VariablesGlobales.idCours

            commandeReinsererActivite.Transaction = transaction

            'exécution de la commandeReinsererActivite
            commandeReinsererActivite.ExecuteNonQuery()
        Next

        For Each idIntention In listeIntention
            commandeReinsererIntention.Parameters(0).Value = VariablesGlobales.idCours
            commandeReinsererIntention.Parameters(1).Value = idIntention

            commandeReinsererIntention.Transaction = transaction

            'exécution de la commandeReinsererIntention
            commandeReinsererIntention.ExecuteNonQuery()
        Next

        For Each row As DataRow In dtHabilete.Rows
            commandeReinsererHabilete.Parameters(0).Value = VariablesGlobales.idCours
            commandeReinsererHabilete.Parameters(1).Value = row.Item(0)

            commandeReinsererHabilete.Transaction = transaction

            'exécution de la commandeReinsererHabilete
            commandeReinsererHabilete.ExecuteNonQuery()
        Next

        For Each idElement In listeElement
            commandeReinsererElement.Parameters(0).Value = VariablesGlobales.idCours
            commandeReinsererElement.Parameters(1).Value = idElement

            commandeReinsererElement.Transaction = transaction

            'exécution de la commandeReinsererElement
            commandeReinsererElement.ExecuteNonQuery()
        Next

        For Each row As DataRow In dtPrealable.Rows
            commandeReinsererPrealable.Parameters(0).Value = VariablesGlobales.idCours
            commandeReinsererPrealable.Parameters(1).Value = row.Item(0)
            commandeReinsererPrealable.Parameters(2).Value = row.Item(2)
            commandeReinsererPrealable.Parameters(3).Value = justificationPrealable

            commandeReinsererPrealable.Transaction = transaction

            'exécution de la commandeReinsererPrealable
            commandeReinsererPrealable.ExecuteNonQuery()
        Next
    End Sub
End Class
