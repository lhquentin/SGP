Imports System.Windows.Forms

Public Class dlgFormulaireCompetence

    Private monAction As New Action

    Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter
    Dim idCompetence As Integer
    Dim codeCompetence As String
    Dim nomCompetence As String
    Dim competenceCree As Boolean = False
    Dim modificationContexte As Boolean = False
    Dim modificationElement As Boolean = False
    Dim modificationCritere As Boolean = False
    Dim modificationCode As Boolean = False
    Dim modificationLibelle As Boolean = False

    Dim dtContexte As DataTable
    Dim dtElement As DataTable
    Dim dtCritere As DataTable
    Dim dtCoursElement As DataTable

    Dim idElementModifie As Integer

    Dim taCompetence As New SGPDataSetTableAdapters.P_SELECT_Competence_PKTableAdapter
    Dim dtCompetence As DataTable

    Private Sub dlgFormulaireCompetence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        monAction = Action.inserer

        If VariablesGlobales.actionSecondaire = Action.consulter Then
            dtCompetence = taCompetence.GetData(VariablesGlobales.idCompetence)

            If dtCompetence.Rows.Count > 0 Then
                txtCodeCompetence.Text = dtCompetence.Rows(0)("codeCOMPETENCE")
                txtLibelleCompetence.Text = dtCompetence.Rows(0)("nomCOMPETENCE")
                idCompetence = dtCompetence.Rows(0)("idCOMPETENCE")

                RechercherContexte()
                RechercherElement()
                RechercherCritere()

                dgvContexte.ClearSelection()
                dgvElement.ClearSelection()
                dgvCritere.ClearSelection()

                ActiverCompetence(False)
                ActiverContexte(False)
                ActiverElement(False)
                ActiverCritere(False)
                btnValider.Visible = False
                btnAnnuler.Visible = False
                btnModifier.Visible = False
                btnAnnulerCompetence.Enabled = True
                btnEnregistrerCompetence.Text = "Modifier compétence"
                btnEnregistrerCompetence.Enabled = True
            End If
        Else
            ActiverCompetence(True)
            ActiverContexte(False)
            ActiverElement(False)
            ActiverCritere(False)
            btnValider.Visible = True
            btnAnnuler.Visible = True
            btnModifier.Visible = True
            btnAnnuler.Enabled = False
            btnAnnulerCompetence.Enabled = True
            btnEnregistrerCompetence.Text = "Enregistrer compétence"
        End If
    End Sub

    'Gestion des boutons de la partie information
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If ValiderCompetence() Then
            Select Case monAction
                Case Action.inserer
                    idCompetence = monTa.P_INSERT_Competence(txtCodeCompetence.Text,
                                                             txtLibelleCompetence.Text)

                    competenceCree = True
                Case Action.modifier
                    monTa.P_UPDATE_Competence(idCompetence,
                                              txtCodeCompetence.Text,
                                              txtLibelleCompetence.Text)
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            ActiverCompetence(False)
            ActiverContexte(True)
            ActiverElement(True)
            ActiverCritere(True)

            codeCompetence = txtCodeCompetence.Text
            nomCompetence = txtLibelleCompetence.Text
        End If
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        ActiverCompetence(True)
        ActiverContexte(False)
        ActiverElement(False)
        ActiverCritere(False)

        monAction = Action.modifier
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        txtCodeCompetence.Text = codeCompetence
        txtLibelleCompetence.Text = nomCompetence

        monAction = Action.inserer
        ActiverCompetence(False)
        ActiverContexte(True)
        ActiverElement(True)
        ActiverCritere(True)
    End Sub

    'Gestion des boutons de la partie contexte

    'Private Sub dgvContexte_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContexte.RowValidated
    '    If dgvContexte.Rows(e.RowIndex).Cells(0).Value = 0 Then
    '        If Not String.IsNullOrEmpty(dgvContexte.Rows(e.RowIndex).Cells(1).Value) Then
    '            monTa.P_INSERT_Contexte(dgvContexte.Rows(e.RowIndex).Cells(1).Value,
    '                                    1)
    '            dgvContexte.Rows(e.RowIndex).Cells(0).Value = 
    '        End If
    '    Else
    '        monTa.P_UPDATE_Contexte(dgvContexte.Rows(e.RowIndex).Cells(0).Value,
    '                                dgvContexte.Rows(e.RowIndex).Cells(1).Value)
    '    End If
    '    RechercherContexte()
    'End Sub

    Private Sub btnEnregistrerContexte_Click(sender As Object, e As EventArgs) Handles btnEnregistrerContexte.Click
        If ValiderContexte() Then
            Dim idContexte As Integer

            Select Case monAction
                Case Action.inserer
                    idContexte = monTa.P_INSERT_Contexte(txtLibelleContexte.Text,
                                            idCompetence)

                    modificationContexte = True
                Case Action.modifier
                    idContexte = dgvContexte.SelectedRows(0).Cells(0).Value

                    monTa.P_UPDATE_Contexte(idContexte,
                                            txtLibelleContexte.Text)

                    modificationContexte = True
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            RechercherContexte()
            SelectionneContexte(idContexte)
            txtLibelleContexte.Clear()
        End If
    End Sub

    Private Sub btnModifierContexte_Click(sender As Object, e As EventArgs) Handles btnModifierContexte.Click
        txtLibelleContexte.Text = dgvContexte.SelectedRows(0).Cells(1).Value
        monAction = Action.modifierAutre
        ActiverElement(False)
        ActiverCritere(False)
        monAction = Action.modifier
        ActiverContexte(False)
    End Sub

    Private Sub btnSupprimerContexte_Click(sender As Object, e As EventArgs) Handles btnSupprimerContexte.Click
        monTa.P_DELETE_Contexte(dgvContexte.SelectedRows(0).Cells(0).Value)
        RechercherContexte()

        modificationContexte = True
    End Sub

    Private Sub btnAnnulerContexte_Click(sender As Object, e As EventArgs) Handles btnAnnulerContexte.Click
        txtLibelleContexte.Clear()
        monAction = Action.inserer
        ActiverContexte(True)
        ActiverElement(True)
        ActiverCritere(True)
    End Sub

    'Gestion des boutons de la partie element

    Private Sub btnEnregistrerElement_Click(sender As Object, e As EventArgs) Handles btnEnregistrerElement.Click
        If ValiderElement() Then
            Dim idElement As Integer

            Select Case monAction
                Case Action.inserer
                    idElement = monTa.P_INSERT_Element(txtLibelleElement.Text,
                                                       dgvElement.Rows.Count + 1,
                                                       idCompetence)

                    modificationElement = True
                Case Action.modifier
                    idElement = dgvElement.SelectedRows(0).Cells(0).Value

                    monTa.P_UPDATE_LibelleElement(idElement,
                                           txtLibelleElement.Text)

                    modificationElement = True
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            RechercherElement()
            SelectionneElement(idElement)
            txtLibelleElement.Clear()
        End If
    End Sub

    Private Sub btnModifierElement_Click(sender As Object, e As EventArgs) Handles btnModifierElement.Click
        txtLibelleElement.Text = dgvElement.SelectedRows(0).Cells(2).Value
        monAction = Action.modifierAutre
        ActiverContexte(False)
        ActiverCritere(False)
        monAction = Action.modifier
        ActiverElement(False)
    End Sub

    Private Sub btnSupprimerElement_Click(sender As Object, e As EventArgs) Handles btnSupprimerElement.Click
        If dgvCritere.Rows.Count > 0 Then
            If MsgBox("Si vous supprimez cet élément, les critères associés le seront aussi, êtes-vous sûr ?", MsgBoxStyle.YesNo, "Suppression d'un élément") = MsgBoxResult.Yes Then
                monTa.P_DELETE_Element_Critere_TR(dgvElement.SelectedRows(0).Cells(0).Value)
                RechercherElement()

                modificationElement = True
            End If
        Else
            monTa.P_DELETE_Element_Critere_TR(dgvElement.SelectedRows(0).Cells(0).Value)
            RechercherElement()

            modificationElement = True
        End If
    End Sub

    Private Sub btnAnnulerElement_Click(sender As Object, e As EventArgs) Handles btnAnnulerElement.Click
        txtLibelleElement.Clear()
        monAction = Action.inserer
        ActiverContexte(True)
        ActiverElement(True)
        ActiverCritere(True)
    End Sub

    Private Sub btnMonterElement_Click(sender As Object, e As EventArgs) Handles btnMonterElement.Click
        Dim idElement As Integer
        idElement = dgvElement.SelectedRows(0).Cells(0).Value

        monTa.P_UPDATE_NumeroElement(idCompetence,
                                     idElement,
                                     dgvElement.SelectedRows(0).Cells(1).Value,
                                     1)

        monAction = Action.inserer

        RechercherElement()
        SelectionneElement(idElement)
        If VariablesGlobales.actionSecondaire = Action.modifier Then
            For Each row As DataRow In dtElement.Rows
                If row.Item(0) = idElement And dgvElement.SelectedRows(0).Cells(1).Value <> row.Item(1) Then
                    modificationElement = True
                End If
            Next
        End If
    End Sub

    Private Sub btnDescendreElement_Click(sender As Object, e As EventArgs) Handles btnDescendreElement.Click
        Dim idElement As Integer
        idElement = dgvElement.SelectedRows(0).Cells(0).Value

        monTa.P_UPDATE_NumeroElement(idCompetence,
                                     idElement,
                                     dgvElement.SelectedRows(0).Cells(1).Value,
                                     2)

        monAction = Action.inserer

        RechercherElement()
        SelectionneElement(idElement)
        If VariablesGlobales.actionSecondaire = Action.modifier Then
            For Each row As DataRow In dtElement.Rows
                If row.Item(0) = idElement And dgvElement.SelectedRows(0).Cells(1).Value <> row.Item(1) Then
                    modificationElement = True
                End If
            Next
        End If
    End Sub

    Private Sub dgvElement_SelectionChanged(sender As Object, e As EventArgs) Handles dgvElement.SelectionChanged
        ActiverElement(True)
        RechercherCritere()
    End Sub

    'Gestion des boutons de la partie critere

    Private Sub btnEnregistrerCritere_Click(sender As Object, e As EventArgs) Handles btnEnregistrerCritere.Click
        If ValiderCritere() Then
            Dim idCritere As Integer

            Select Case monAction
                Case Action.inserer
                    idCritere = monTa.P_INSERT_Critere(txtLibelleCritere.Text,
                                                       dgvCritere.Rows.Count + 1,
                                                       dgvElement.SelectedRows(0).Cells(0).Value)

                    modificationCritere = True
                Case Action.modifier
                    monTa.P_UPDATE_LibelleCritere(dgvCritere.SelectedRows(0).Cells(0).Value,
                                           txtLibelleCritere.Text)

                    modificationCritere = True
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            RechercherCritere()
            SelectionneCritere(idCritere)
            txtLibelleCritere.Clear()
        End If
    End Sub

    Private Sub btnModifierCritere_Click(sender As Object, e As EventArgs) Handles btnModifierCritere.Click
        txtLibelleCritere.Text = dgvCritere.SelectedRows(0).Cells(2).Value
        monAction = Action.modifierAutre
        ActiverContexte(False)
        ActiverElement(False)
        monAction = Action.modifier
        ActiverCritere(False)
    End Sub

    Private Sub btnSupprimerCritere_Click(sender As Object, e As EventArgs) Handles btnSupprimerCritere.Click
        monTa.P_DELETE_Critere(dgvCritere.SelectedRows(0).Cells(0).Value)
        RechercherCritere()

        modificationCritere = True
    End Sub

    Private Sub btnAnnulerCritere_Click(sender As Object, e As EventArgs) Handles btnAnnulerCritere.Click
        txtLibelleCritere.Clear()
        monAction = Action.inserer
        ActiverContexte(True)
        ActiverElement(True)
        ActiverCritere(True)
    End Sub

    Private Sub btnMonterCritere_Click(sender As Object, e As EventArgs) Handles btnMonterCritere.Click
        Dim idCritere As Integer
        idCritere = dgvCritere.SelectedRows(0).Cells(0).Value

        monTa.P_UPDATE_NumeroCritere(dgvElement.SelectedRows(0).Cells(0).Value,
                                     idCritere,
                                     dgvCritere.SelectedRows(0).Cells(1).Value,
                                     1)

        monAction = Action.inserer

        RechercherCritere()
        SelectionneCritere(idCritere)
        If VariablesGlobales.actionSecondaire = Action.modifier Then
            For Each row As DataRow In dtCritere.Rows
                If row.Item(0) = idCritere And dgvCritere.SelectedRows(0).Cells(1).Value <> row.Item(1) Then
                    modificationCritere = True
                End If
            Next
        End If
    End Sub

    Private Sub btnDescendreCritere_Click(sender As Object, e As EventArgs) Handles btnDescendreCritere.Click
        Dim idCritere As Integer
        idCritere = dgvCritere.SelectedRows(0).Cells(0).Value
        monTa.P_UPDATE_NumeroCritere(dgvElement.SelectedRows(0).Cells(0).Value,
                                     idCritere,
                                     dgvCritere.SelectedRows(0).Cells(1).Value,
                                     2)

        monAction = Action.inserer

        RechercherCritere()
        SelectionneCritere(idCritere)
        If VariablesGlobales.actionSecondaire = Action.modifier Then
            For Each row As DataRow In dtCritere.Rows
                If row.Item(0) = idCritere And dgvCritere.SelectedRows(0).Cells(1).Value <> row.Item(1) Then
                    modificationCritere = True
                End If
            Next
        End If
    End Sub

    Private Sub dgvCritere_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCritere.SelectionChanged
        ActiverCritere(True)
    End Sub

    'Gestion de la validation de la compétence

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrerCompetence.Click
        Select Case VariablesGlobales.actionSecondaire
            Case Action.consulter
                VariablesGlobales.actionSecondaire = Action.modifier

                'récupération des éléments avant modification au cas où il y'a annulation
                dtContexte = P_SELECT_ContexteCompetenceTableAdapter.GetData(idCompetence)
                dtElement = P_SELECT_ElementCompetenceTableAdapter.GetData(idCompetence)
                Dim taCritere As New SGPDataSetTableAdapters.P_SELECT_CritereCompetenceTableAdapter
                dtCritere = taCritere.GetData(idCompetence)
                Dim taCoursElement As New SGPDataSetTableAdapters.P_SELECT_CoursElementTableAdapter
                For Each row1 As DataGridViewRow In dgvElement.Rows
                    If dtCoursElement Is Nothing Then
                        dtCoursElement = taCoursElement.GetData(row1.Cells(0).Value)
                    ElseIf Not IsDBNull(taCoursElement.GetData(row1.Cells(0).Value)) Then
                        For Each row2 In taCoursElement.GetData(row1.Cells(0).Value)
                            dtCoursElement.Rows.Add(row2.Item(0), row2.Item(1))
                        Next
                    End If
                Next

                ActiverCompetence(True)
                ActiverContexte(True)

                If dgvContexte.Rows.Count > 0 Then
                    dgvContexte.Rows(0).Selected = True
                End If
                ActiverElement(True)
                If dgvElement.Rows.Count > 0 Then
                    dgvElement.Rows(0).Selected = True
                End If
                ActiverCritere(True)
                btnEnregistrerCompetence.Text = "Enregistrer compétence"
            Case Action.modifier
                monTa.P_UPDATE_Competence(idCompetence,
                                              txtCodeCompetence.Text,
                                              txtLibelleCompetence.Text)

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Case Else
                VariablesGlobales.idCompetence = idCompetence
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulerCompetence.Click
        Select Case VariablesGlobales.actionSecondaire
            Case Action.consulter
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            Case Action.modifier
                If modificationContexte Or modificationElement Or modificationCritere Or modificationCode Or modificationLibelle Then
                    If MsgBox("Si vous annulez, toutes les modifications seront perdues, êtes-vous sûr ?", MsgBoxStyle.YesNo, "Annuler la modification de compétence") = MsgBoxResult.Yes Then
                        'résinsertion des données avant modification
                        Dim connexion As New System.Data.SqlClient.SqlConnection
                        Dim commandeViderContexte As New System.Data.SqlClient.SqlCommand
                        Dim commandeViderElement As New System.Data.SqlClient.SqlCommand
                        Dim commandeViderCritere As New System.Data.SqlClient.SqlCommand
                        Dim commandeViderCoursElement As New System.Data.SqlClient.SqlCommand
                        Dim commandeReinsererContexte As New System.Data.SqlClient.SqlCommand
                        Dim commandeReinsererElement As New System.Data.SqlClient.SqlCommand
                        Dim commandeReinsererCritere As New System.Data.SqlClient.SqlCommand
                        Dim commandeReinsererCoursElement As New System.Data.SqlClient.SqlCommand
                        Dim transaction As System.Data.SqlClient.SqlTransaction

                        Try
                            'ouverture de la connexion
                            connexion.ConnectionString = SGP.My.Settings.H2016_Stage_Yoann_QuentinConnectionString
                            connexion.Open()

                            'création de la commandeViderContexte
                            commandeViderContexte.Connection = connexion
                            commandeViderContexte.CommandType = CommandType.StoredProcedure
                            commandeViderContexte.CommandText = "P_DELETE_Contexte"

                            commandeViderContexte.Parameters.Add("idCONTEXTE", SqlDbType.Int)

                            'création de la commandeViderElement
                            commandeViderElement.Connection = connexion
                            commandeViderElement.CommandType = CommandType.StoredProcedure
                            commandeViderElement.CommandText = "P_DELETE_Element"

                            commandeViderElement.Parameters.Add("idELEMENT", SqlDbType.Int)

                            'création de la commandeViderCritere
                            commandeViderCritere.Connection = connexion
                            commandeViderCritere.CommandType = CommandType.StoredProcedure
                            commandeViderCritere.CommandText = "P_DELETE_CritereElement_FK"

                            commandeViderCritere.Parameters.Add("idELEMENT", SqlDbType.Int)

                            'création de la commandeViderCoursElement
                            commandeViderCoursElement.Connection = connexion
                            commandeViderCoursElement.CommandType = CommandType.StoredProcedure
                            commandeViderCoursElement.CommandText = "P_DELETE_ElementCours"

                            commandeViderCoursElement.Parameters.Add("idCOURS", SqlDbType.Int)
                            commandeViderCoursElement.Parameters.Add("idELEMENT", SqlDbType.Int)

                            'création de la commandeReinsererContexte
                            commandeReinsererContexte.Connection = connexion
                            commandeReinsererContexte.CommandType = CommandType.StoredProcedure
                            commandeReinsererContexte.CommandText = "P_INSERT_Contexte"

                            commandeReinsererContexte.Parameters.Add("libelleCONTEXTE", SqlDbType.VarChar)
                            commandeReinsererContexte.Parameters.Add("idCOMPETENCE", SqlDbType.Int)

                            'création de la commandeReinsererElement
                            commandeReinsererElement.Connection = connexion
                            commandeReinsererElement.CommandType = CommandType.StoredProcedure
                            commandeReinsererElement.CommandText = "P_INSERT_Element"

                            commandeReinsererElement.Parameters.Add("libelleELEMENT", SqlDbType.VarChar)
                            commandeReinsererElement.Parameters.Add("numeroELEMENT", SqlDbType.Int)
                            commandeReinsererElement.Parameters.Add("idCOMPETENCE", SqlDbType.Int)

                            'création de la commandeReinsererCritere
                            commandeReinsererCritere.Connection = connexion
                            commandeReinsererCritere.CommandType = CommandType.StoredProcedure
                            commandeReinsererCritere.CommandText = "P_INSERT_Critere"

                            commandeReinsererCritere.Parameters.Add("libelleCRITERE", SqlDbType.VarChar)
                            commandeReinsererCritere.Parameters.Add("numeroCRITERE", SqlDbType.Int)
                            commandeReinsererCritere.Parameters.Add("idELEMENT", SqlDbType.Int)

                            'création de la commandeReinsererCoursElement
                            commandeReinsererCoursElement.Connection = connexion
                            commandeReinsererCoursElement.CommandType = CommandType.StoredProcedure
                            commandeReinsererCoursElement.CommandText = "P_INSERT_ElementCours"

                            commandeReinsererCoursElement.Parameters.Add("idCOURS", SqlDbType.Int)
                            commandeReinsererCoursElement.Parameters.Add("idELEMENT", SqlDbType.Int)

                            'BEGIN TRANSACTION
                            transaction = connexion.BeginTransaction

                            For Each row As DataGridViewRow In dgvContexte.Rows
                                commandeViderContexte.Parameters(0).Value = row.Cells(0).Value

                                commandeViderContexte.Transaction = transaction

                                'exécution de la commandeViderContexte
                                commandeViderContexte.ExecuteNonQuery()
                            Next

                            If Not IsNothing(dtCoursElement) Then
                                For Each row As DataRow In dtCoursElement.Rows
                                    commandeViderCoursElement.Parameters(0).Value = row.Item(0)
                                    commandeViderCoursElement.Parameters(1).Value = row.Item(1)

                                    commandeViderCoursElement.Transaction = transaction

                                    'exécution de la commandeViderCoursElement
                                    commandeViderCoursElement.ExecuteNonQuery()
                                Next
                            End If

                            For Each row As DataGridViewRow In dgvElement.Rows
                                commandeViderCritere.Parameters(0).Value = row.Cells(0).Value

                                commandeViderCritere.Transaction = transaction

                                'exécution de la commandeViderCritere
                                commandeViderCritere.ExecuteNonQuery()

                                commandeViderElement.Parameters(0).Value = row.Cells(0).Value

                                commandeViderElement.Transaction = transaction

                                'exécution de la commandeViderElement
                                commandeViderElement.ExecuteNonQuery()
                            Next

                            For Each row As DataRow In dtContexte.Rows
                                commandeReinsererContexte.Parameters(0).Value = row.Item(1)
                                commandeReinsererContexte.Parameters(1).Value = VariablesGlobales.idCompetence

                                commandeReinsererContexte.Transaction = transaction

                                'exécution de la commandeReinsererContexte
                                commandeReinsererContexte.ExecuteNonQuery()
                            Next

                            For Each row1 As DataRow In dtElement.Rows
                                commandeReinsererElement.Parameters(0).Value = row1.Item(2)
                                commandeReinsererElement.Parameters(1).Value = row1.Item(1)
                                commandeReinsererElement.Parameters(2).Value = VariablesGlobales.idCompetence

                                commandeReinsererElement.Transaction = transaction

                                'exécution de la commandeReinsererElement
                                idElementModifie = commandeReinsererElement.ExecuteScalar()

                                For Each row2 As DataRow In dtCritere.Rows
                                    If row2.Item(3) = row1.Item(0) Then
                                        commandeReinsererCritere.Parameters(0).Value = row2.Item(2)
                                        commandeReinsererCritere.Parameters(1).Value = row2.Item(1)
                                        commandeReinsererCritere.Parameters(2).Value = idElementModifie

                                        commandeReinsererCritere.Transaction = transaction

                                        'exécution de la commandeReinsererCritere
                                        commandeReinsererCritere.ExecuteNonQuery()
                                    End If
                                Next

                                If Not IsNothing(dtCoursElement) Then
                                    For Each row3 As DataRow In dtCoursElement.Rows
                                        If row3.Item(1) = row1.Item(0) Then
                                            commandeReinsererCoursElement.Parameters(0).Value = row3.Item(0)
                                            commandeReinsererCoursElement.Parameters(1).Value = idElementModifie

                                            commandeReinsererCoursElement.Transaction = transaction

                                            'exécution de la commandeReinsererCoursElement
                                            commandeReinsererCoursElement.ExecuteNonQuery()
                                        End If
                                    Next
                                End If
                            Next

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
            Case Else
                VariablesGlobales.idCompetence = idCompetence
                If competenceCree Then
                    If MsgBox("Si vous annulez, toutes les valeurs saisies seront perdues, êtes-vous sûr ?", MsgBoxStyle.YesNo, "Annuler la compétence") = MsgBoxResult.Yes Then
                        monTa.P_DELETE_Competence(idCompetence)
                        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                        Me.Close()
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.None
                    End If
                Else
                    monTa.P_DELETE_Competence(idCompetence)
                    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                    Me.Close()
                End If
        End Select

    End Sub

    'Fonctions

    Private Sub txtCodeCompetence_TextChanged(sender As Object, e As EventArgs) Handles txtCodeCompetence.TextChanged
        If VariablesGlobales.actionSecondaire = Action.modifier Then
            If txtCodeCompetence.Text <> dtCompetence.Rows(0)("codeCOMPETENCE") Then
                modificationCode = True
            Else
                modificationCode = False
            End If
        End If
    End Sub

    Private Sub txtLibelleCompetence_TextChanged(sender As Object, e As EventArgs) Handles txtLibelleCompetence.TextChanged
        If VariablesGlobales.actionSecondaire = Action.modifier Then
            If txtLibelleCompetence.Text <> dtCompetence.Rows(0)("nomCOMPETENCE") Then
                modificationLibelle = True
            Else
                modificationLibelle = False
            End If
        End If
    End Sub

    Private Sub RechercherContexte()
        dgvContexte.DataSource = P_SELECT_ContexteCompetenceTableAdapter.GetData(idCompetence)

        gbContexte.Text = "Contexte de réalisation (" + dgvContexte.RowCount().ToString + ")"

        ActiverContexte(True)
        ActiverElement(True)
        ActiverCritere(True)
    End Sub

    Private Sub RechercherElement()
        dgvElement.DataSource = P_SELECT_ElementCompetenceTableAdapter.GetData(idCompetence)

        gbElement.Text = "Élément de compétence (" + dgvElement.RowCount().ToString + ")"

        ActiverContexte(True)
        ActiverElement(True)
        ActiverCritere(True)
    End Sub

    Private Sub RechercherCritere()
        If dgvElement.SelectedRows.Count > 0 Then
            dgvCritere.DataSource = P_SELECT_CritereElementTableAdapter.GetData(dgvElement.SelectedRows(0).Cells(0).Value)
        Else
            dgvCritere.DataSource = Nothing
        End If

        gbCritere.Text = "Critère (" + dgvCritere.RowCount().ToString + ")"

        ActiverContexte(True)
        ActiverElement(True)
        ActiverCritere(True)
    End Sub

    Private Sub SelectionneContexte(intIdContexte As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvContexte.Rows.Count) And (Not blnTrouve)
            If dgvContexte.Rows(intRangee).Cells(0).Value = intIdContexte Then
                dgvContexte.Rows(intRangee).Selected = True
                dgvContexte.FirstDisplayedScrollingRowIndex = intRangee

                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Sub SelectionneElement(intIdElement As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvElement.Rows.Count) And (Not blnTrouve)
            If dgvElement.Rows(intRangee).Cells(0).Value = intIdElement Then
                dgvElement.Rows(intRangee).Selected = True
                dgvElement.FirstDisplayedScrollingRowIndex = intRangee

                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Sub SelectionneCritere(intIdCritere As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvCritere.Rows.Count) And (Not blnTrouve)
            If dgvCritere.Rows(intRangee).Cells(0).Value = intIdCritere Then
                dgvCritere.Rows(intRangee).Selected = True
                dgvCritere.FirstDisplayedScrollingRowIndex = intRangee

                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Function ValiderCompetence() As Boolean
        If txtCodeCompetence.Text = "" Then
            MsgBox("Veuillez spécifier un code de compétence.")
            txtCodeCompetence.Focus()
            Return False
        End If
        If txtCodeCompetence.Text.Length > 4 Then
            MsgBox("Le code doit contenir un maximum de 4 caractères.")
            txtCodeCompetence.Focus()
            Return False
        End If
        If txtLibelleCompetence.Text = "" Then
            MsgBox("Veuillez spécifier un libelle pour la compétence.")
            txtLibelleCompetence.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValiderContexte() As Boolean
        If txtLibelleContexte.Text = "" Then
            MsgBox("Veuillez spécifier un contexte.")
            txtLibelleContexte.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValiderElement() As Boolean
        If txtLibelleElement.Text = "" Then
            MsgBox("Veuillez spécifier un élément.")
            txtLibelleElement.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValiderCritere() As Boolean
        If txtLibelleCritere.Text = "" Then
            MsgBox("Veuillez spécifier un critère.")
            txtLibelleCritere.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub ActiverCompetence(blnActiver As Boolean)
        If VariablesGlobales.actionSecondaire = Action.consulter Or VariablesGlobales.actionSecondaire = Action.modifier Then
            gbInformations.Enabled = blnActiver
        Else
            lbCodeCompetence.Enabled = blnActiver
            txtCodeCompetence.Enabled = blnActiver

            lbLibelleCompetence.Enabled = blnActiver
            txtLibelleCompetence.Enabled = blnActiver

            btnValider.Enabled = blnActiver
            btnAnnuler.Enabled = blnActiver
        End If
    End Sub

    Private Sub ActiverContexte(blnActiver As Boolean)
        Select Case monAction
            Case Action.inserer
                gbContexte.Enabled = blnActiver
                dgvContexte.Enabled = blnActiver

                If dgvContexte.SelectedRows.Count > 0 Then
                    btnModifierContexte.Enabled = blnActiver
                    btnSupprimerContexte.Enabled = blnActiver
                Else
                    btnModifierContexte.Enabled = False
                    btnSupprimerContexte.Enabled = False
                End If

                btnModifier.Enabled = blnActiver
                btnEnregistrerCompetence.Enabled = blnActiver
                btnAnnulerCompetence.Enabled = blnActiver
            Case Action.modifier
                dgvContexte.Enabled = blnActiver
                btnModifierContexte.Enabled = blnActiver
                btnSupprimerContexte.Enabled = blnActiver
                btnModifier.Enabled = blnActiver
                btnEnregistrerCompetence.Enabled = blnActiver
                btnAnnulerCompetence.Enabled = blnActiver
            Case Action.modifierAutre
                gbContexte.Enabled = blnActiver
                btnModifier.Enabled = blnActiver
                btnEnregistrerCompetence.Enabled = blnActiver
                btnAnnulerCompetence.Enabled = blnActiver
            Case Else
                MsgBox("Oups")
        End Select
    End Sub

    Private Sub ActiverElement(blnActiver As Boolean)
        Select Case monAction
            Case Action.inserer
                gbElement.Enabled = blnActiver
                dgvElement.Enabled = blnActiver

                If dgvElement.SelectedRows.Count > 0 Then
                    btnModifierElement.Enabled = blnActiver
                    btnSupprimerElement.Enabled = blnActiver
                    If dgvElement.SelectedRows(0).Index = 0 Then
                        btnMonterElement.Enabled = False
                    Else
                        btnMonterElement.Enabled = blnActiver
                    End If
                    If dgvElement.SelectedRows(0).Index = dgvElement.Rows.Count - 1 Then
                        btnDescendreElement.Enabled = False
                    Else
                        btnDescendreElement.Enabled = blnActiver
                    End If
                Else
                    btnModifierElement.Enabled = False
                    btnSupprimerElement.Enabled = False
                    btnMonterElement.Enabled = False
                    btnDescendreElement.Enabled = False
                End If
            Case Action.modifier
                dgvElement.Enabled = blnActiver
                btnModifierElement.Enabled = blnActiver
                btnSupprimerElement.Enabled = blnActiver
                btnMonterElement.Enabled = blnActiver
                btnDescendreElement.Enabled = blnActiver
            Case Action.modifierAutre
                gbElement.Enabled = blnActiver
            Case Else
                MsgBox("Oups")
        End Select
    End Sub

    Private Sub ActiverCritere(blnActiver As Boolean)
        Select Case monAction
            Case Action.inserer
                If dgvElement.SelectedRows.Count > 0 Then
                    gbCritere.Enabled = blnActiver
                    dgvCritere.Enabled = blnActiver

                    If dgvCritere.SelectedRows.Count > 0 Then
                        btnModifierCritere.Enabled = blnActiver
                        btnSupprimerCritere.Enabled = blnActiver
                        If dgvCritere.SelectedRows(0).Index = 0 Then
                            btnMonterCritere.Enabled = False
                        Else
                            btnMonterCritere.Enabled = blnActiver
                        End If
                        If dgvCritere.SelectedRows(0).Index = dgvCritere.Rows.Count - 1 Then
                            btnDescendreCritere.Enabled = False
                        Else
                            btnDescendreCritere.Enabled = blnActiver
                        End If
                    Else
                        btnModifierCritere.Enabled = False
                        btnSupprimerCritere.Enabled = False
                        btnMonterCritere.Enabled = False
                        btnDescendreCritere.Enabled = False
                    End If
                Else
                    gbCritere.Enabled = False
                End If
            Case Action.modifier
                dgvCritere.Enabled = blnActiver
                btnModifierCritere.Enabled = blnActiver
                btnSupprimerCritere.Enabled = blnActiver
                btnMonterCritere.Enabled = blnActiver
                btnDescendreCritere.Enabled = blnActiver
            Case Action.modifierAutre
                gbCritere.Enabled = blnActiver
            Case Else
                MsgBox("Oups")
        End Select
    End Sub
End Class
