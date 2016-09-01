Public Class frmGestionHabilete

    Private monAction As New Action
    Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter

    Private Sub frmGestionHabilete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RechercheSectionHabilete()
    End Sub

    'gestion de la section habileté

    Private Sub dgvSectionHabilete_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSectionHabilete.SelectionChanged
        ActiverSectionHabilete(True)
        RechercheHabilete()
    End Sub

    Private Sub btnModifierSectionHabilete_Click(sender As Object, e As EventArgs) Handles btnModifierSectionHabilete.Click
        txtTitreSectionHabilete.Text = dgvSectionHabilete.SelectedRows(0).Cells(3).Value
        monAction = Action.modifierAutre
        ActiverHabilete(False)
        monAction = Action.modifier
        ActiverSectionHabilete(False)
        btnFermer.Enabled = False
    End Sub

    Private Sub btnSupprimerSectionHabilete_Click(sender As Object, e As EventArgs) Handles btnSupprimerSectionHabilete.Click
        If MsgBox("Êtes-vous sûr de vouloir supprimer l'habileté ainsi que ses sous-habiletés ?", MsgBoxStyle.YesNo, "Supprimer habileté") = MsgBoxResult.Yes Then
            monTa.P_DELETE_SectionHabilete(dgvSectionHabilete.SelectedRows(0).Cells(0).Value)

            RechercheSectionHabilete()
        End If
    End Sub

    Private Sub btnEnregistrerSectionHabilete_Click(sender As Object, e As EventArgs) Handles btnEnregistrerSectionHabilete.Click
        If ValiderSectionHabilete() Then
            Dim idSectionHabilete As Integer

            Select Case monAction
                Case Action.inserer
                    idSectionHabilete = monTa.P_INSERT_SectionHabilete(txtTitreSectionHabilete.Text,
                                                   dgvSectionHabilete.Rows.Count + 1)
                Case Action.modifier
                    idSectionHabilete = dgvSectionHabilete.SelectedRows(0).Cells(0).Value

                    monTa.P_UPDATE_TitreSectionHabilete(idSectionHabilete,
                                                        txtTitreSectionHabilete.Text)
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            RechercheSectionHabilete()
            SelectionneSectionHabilete(idSectionHabilete)
            txtTitreSectionHabilete.Clear()
        End If
    End Sub

    Private Sub btnAnnulerSectionHabilete_Click(sender As Object, e As EventArgs) Handles btnAnnulerSectionHabilete.Click
        txtTitreSectionHabilete.Clear()
        monAction = Action.inserer
        ActiverSectionHabilete(True)
        ActiverHabilete(True)
        btnFermer.Enabled = True
    End Sub

    Private Sub btnAjouterSectionHabilete_Click(sender As Object, e As EventArgs) Handles btnAjouterSectionHabilete.Click
        VariablesGlobales.monAction = Action.gestionHabilete

        Dim selectionHabilete As New dlgListeHabilete
        selectionHabilete.ShowDialog()

        RechercheSectionHabilete()
        RechercheHabilete()

        VariablesGlobales.monAction = -1
    End Sub

    Private Sub btnMonterSectionHabilete_Click(sender As Object, e As EventArgs) Handles btnMonterSectionHabilete.Click
        Dim idSectionHabilete As Integer
        idSectionHabilete = dgvSectionHabilete.SelectedRows(0).Cells(0).Value

        monTa.P_UPDATE_NumeroSectionHabilete(idSectionHabilete,
                                             dgvSectionHabilete.SelectedRows(0).Cells(2).Value,
                                             1)

        monAction = Action.inserer

        RechercheSectionHabilete()
        SelectionneSectionHabilete(idSectionHabilete)
    End Sub

    Private Sub btnDescendreSectionHabilete_Click(sender As Object, e As EventArgs) Handles btnDescendreSectionHabilete.Click
        Dim idSectionHabilete As Integer
        idSectionHabilete = dgvSectionHabilete.SelectedRows(0).Cells(0).Value

        monTa.P_UPDATE_NumeroSectionHabilete(idSectionHabilete,
                                             dgvSectionHabilete.SelectedRows(0).Cells(2).Value,
                                             2)

        monAction = Action.inserer

        RechercheSectionHabilete()
        SelectionneSectionHabilete(idSectionHabilete)
    End Sub

    'gestion de la section sous-habileté

    Private Sub dgvHabilete_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHabilete.SelectionChanged
        ActiverHabilete(True)
    End Sub

    Private Sub btnModifierHabilete_Click(sender As Object, e As EventArgs) Handles btnModifierHabilete.Click
        txtLibelleHabilete.Text = dgvHabilete.SelectedRows(0).Cells(3).Value
        monAction = Action.modifierAutre
        ActiverSectionHabilete(False)
        monAction = Action.modifier
        ActiverHabilete(False)
        btnFermer.Enabled = False
    End Sub

    Private Sub btnSupprimerHabilete_Click(sender As Object, e As EventArgs) Handles btnSupprimerHabilete.Click
        If MsgBox("Êtes-vous sûr de vouloir supprimer la sous-habileté ?", MsgBoxStyle.YesNo, "Supprimer sous-habileté") = MsgBoxResult.Yes Then
            monTa.P_DELETE_Habilete(dgvHabilete.SelectedRows(0).Cells(0).Value)

            RechercheHabilete()
        End If
    End Sub

    Private Sub btnEnregistrerHabilete_Click(sender As Object, e As EventArgs) Handles btnEnregistrerHabilete.Click
        If ValiderHabilete() Then
            Dim idHabilete As Integer

            Select Case monAction
                Case Action.inserer
                    idHabilete = monTa.P_INSERT_Habilete(txtLibelleHabilete.Text,
                                                   dgvHabilete.Rows.Count + 1,
                                                   dgvSectionHabilete.SelectedRows(0).Cells(0).Value)
                Case Action.modifier
                    idHabilete = dgvHabilete.SelectedRows(0).Cells(0).Value

                    monTa.P_UPDATE_LibelleHabilete(idHabilete,
                                                   txtLibelleHabilete.Text)
                Case Else
                    MsgBox("Oups")
            End Select

            monAction = Action.inserer

            RechercheHabilete()
            SelectionneHabilete(idHabilete)
            txtLibelleHabilete.Clear()
        End If
    End Sub

    Private Sub btnAnnulerHabilete_Click(sender As Object, e As EventArgs) Handles btnAnnulerHabilete.Click
        txtLibelleHabilete.Clear()
        monAction = Action.inserer
        ActiverSectionHabilete(True)
        ActiverHabilete(True)
        btnFermer.Enabled = True
    End Sub

    Private Sub btnMonterHabilete_Click(sender As Object, e As EventArgs) Handles btnMonterHabilete.Click
        Dim idHabilete As Integer
        idHabilete = dgvHabilete.SelectedRows(0).Cells(0).Value

        monTa.P_UPDATE_NumeroHabilete(idHabilete,
                                      dgvHabilete.SelectedRows(0).Cells(1).Value,
                                      dgvHabilete.SelectedRows(0).Cells(2).Value,
                                      1)

        monAction = Action.inserer

        RechercheHabilete()
        SelectionneHabilete(idHabilete)
    End Sub

    Private Sub btnDescendreHabilete_Click(sender As Object, e As EventArgs) Handles btnDescendreHabilete.Click
        Dim idHabilete As Integer
        idHabilete = dgvHabilete.SelectedRows(0).Cells(0).Value

        monTa.P_UPDATE_NumeroHabilete(idHabilete,
                                      dgvHabilete.SelectedRows(0).Cells(1).Value,
                                      dgvHabilete.SelectedRows(0).Cells(2).Value,
                                      2)

        monAction = Action.inserer

        RechercheHabilete()
        SelectionneHabilete(idHabilete)
    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    'fonctions

    Public Sub RechercheSectionHabilete()
        dgvSectionHabilete.DataSource = P_SELECT_SectionHabileteTableAdapter.GetData(3)
        gbSectionHabilete.Text = "Habileté (" + dgvSectionHabilete.RowCount().ToString + ")"

        monAction = Action.inserer
        ActiverSectionHabilete(True)
        ActiverHabilete(True)
    End Sub

    Public Sub RechercheHabilete()
        If dgvSectionHabilete.SelectedRows.Count > 0 Then
            dgvHabilete.DataSource = P_SELECT_HabileteTableAdapter.GetData(dgvSectionHabilete.SelectedRows(0).Cells(0).Value,
                                                                           0)
        Else
            dgvHabilete.DataSource = Nothing
        End If

        gbHabilete.Text = "Sous-habileté (" + dgvHabilete.RowCount().ToString + ")"

        monAction = Action.inserer
        ActiverSectionHabilete(True)
        ActiverHabilete(True)
    End Sub

    Private Sub SelectionneSectionHabilete(intIdSectionHabilete As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvSectionHabilete.Rows.Count) And (Not blnTrouve)
            If dgvSectionHabilete.Rows(intRangee).Cells(0).Value = intIdSectionHabilete Then
                dgvSectionHabilete.Rows(intRangee).Selected = True
                dgvSectionHabilete.FirstDisplayedScrollingRowIndex = intRangee

                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Sub SelectionneHabilete(intIdHabilete As Integer)
        Dim intRangee As Integer = 0
        Dim blnTrouve As Boolean = False

        While (intRangee < dgvHabilete.Rows.Count) And (Not blnTrouve)
            If dgvHabilete.Rows(intRangee).Cells(0).Value = intIdHabilete Then
                dgvHabilete.Rows(intRangee).Selected = True
                dgvHabilete.FirstDisplayedScrollingRowIndex = intRangee

                blnTrouve = True
            End If

            intRangee += 1
        End While
    End Sub

    Private Function ValiderSectionHabilete() As Boolean
        If txtTitreSectionHabilete.Text = "" Then
            MsgBox("Veuillez spécifier un titre.")
            txtTitreSectionHabilete.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValiderHabilete() As Boolean
        If txtLibelleHabilete.Text = "" Then
            MsgBox("Veuillez spécifier un libellé.")
            txtLibelleHabilete.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub ActiverSectionHabilete(blnActiver As Boolean)
        Select Case monAction
            Case Action.inserer
                gbSectionHabilete.Enabled = blnActiver

                dgvSectionHabilete.Enabled = blnActiver
                btnAjouterSectionHabilete.Enabled = blnActiver

                If dgvSectionHabilete.SelectedRows.Count > 0 Then
                    btnModifierSectionHabilete.Enabled = blnActiver
                    btnSupprimerSectionHabilete.Enabled = blnActiver
                    If dgvSectionHabilete.SelectedRows(0).Index = 0 Then
                        btnMonterSectionHabilete.Enabled = False
                    Else
                        btnMonterSectionHabilete.Enabled = blnActiver
                    End If
                    If dgvSectionHabilete.SelectedRows(0).Index = dgvSectionHabilete.Rows.Count - 1 Then
                        btnDescendreSectionHabilete.Enabled = False
                    Else
                        btnDescendreSectionHabilete.Enabled = blnActiver
                    End If
                Else
                    btnModifierSectionHabilete.Enabled = False
                    btnSupprimerSectionHabilete.Enabled = False
                    btnMonterSectionHabilete.Enabled = False
                    btnDescendreSectionHabilete.Enabled = False
                End If
            Case Action.modifier
                dgvSectionHabilete.Enabled = blnActiver
                btnAjouterSectionHabilete.Enabled = blnActiver

                If dgvSectionHabilete.SelectedRows.Count > 0 Then
                    btnModifierSectionHabilete.Enabled = blnActiver
                    btnSupprimerSectionHabilete.Enabled = blnActiver
                    If dgvSectionHabilete.SelectedRows(0).Index = 0 Then
                        btnMonterSectionHabilete.Enabled = False
                    Else
                        btnMonterSectionHabilete.Enabled = blnActiver
                    End If
                    If dgvSectionHabilete.SelectedRows(0).Index = dgvSectionHabilete.Rows.Count - 1 Then
                        btnDescendreSectionHabilete.Enabled = False
                    Else
                        btnDescendreSectionHabilete.Enabled = blnActiver
                    End If
                Else
                    btnModifierSectionHabilete.Enabled = False
                    btnSupprimerSectionHabilete.Enabled = False
                    btnMonterSectionHabilete.Enabled = False
                    btnDescendreSectionHabilete.Enabled = False
                End If
            Case Action.modifierAutre
                gbSectionHabilete.Enabled = blnActiver

                If dgvSectionHabilete.SelectedRows.Count > 0 Then
                    btnModifierSectionHabilete.Enabled = blnActiver
                    btnSupprimerSectionHabilete.Enabled = blnActiver
                    If dgvSectionHabilete.SelectedRows(0).Index = 0 Then
                        btnMonterSectionHabilete.Enabled = False
                    Else
                        btnMonterSectionHabilete.Enabled = blnActiver
                    End If
                    If dgvSectionHabilete.SelectedRows(0).Index = dgvSectionHabilete.Rows.Count - 1 Then
                        btnDescendreSectionHabilete.Enabled = False
                    Else
                        btnDescendreSectionHabilete.Enabled = blnActiver
                    End If
                Else
                    btnModifierSectionHabilete.Enabled = False
                    btnSupprimerSectionHabilete.Enabled = False
                    btnMonterSectionHabilete.Enabled = False
                    btnDescendreSectionHabilete.Enabled = False
                End If
        End Select
    End Sub

    Private Sub ActiverHabilete(blnActiver As Boolean)
        Select Case monAction
            Case Action.inserer
                gbHabilete.Enabled = blnActiver

                dgvHabilete.Enabled = blnActiver

                If dgvHabilete.SelectedRows.Count > 0 Then
                    btnModifierHabilete.Enabled = blnActiver
                    btnSupprimerHabilete.Enabled = blnActiver
                    If dgvHabilete.SelectedRows(0).Index = 0 Then
                        btnMonterHabilete.Enabled = False
                    Else
                        btnMonterHabilete.Enabled = blnActiver
                    End If
                    If dgvHabilete.SelectedRows(0).Index = dgvHabilete.Rows.Count - 1 Then
                        btnDescendreHabilete.Enabled = False
                    Else
                        btnDescendreHabilete.Enabled = blnActiver
                    End If
                Else
                    btnModifierHabilete.Enabled = False
                    btnSupprimerHabilete.Enabled = False
                    btnMonterHabilete.Enabled = False
                    btnDescendreHabilete.Enabled = False
                End If
            Case Action.modifier
                dgvHabilete.Enabled = blnActiver

                If dgvHabilete.SelectedRows.Count > 0 Then
                    btnModifierHabilete.Enabled = blnActiver
                    btnSupprimerHabilete.Enabled = blnActiver
                    If dgvHabilete.SelectedRows(0).Index = 0 Then
                        btnMonterHabilete.Enabled = False
                    Else
                        btnMonterHabilete.Enabled = blnActiver
                    End If
                    If dgvHabilete.SelectedRows(0).Index = dgvHabilete.Rows.Count - 1 Then
                        btnDescendreHabilete.Enabled = False
                    Else
                        btnDescendreHabilete.Enabled = blnActiver
                    End If
                Else
                    btnModifierHabilete.Enabled = False
                    btnSupprimerHabilete.Enabled = False
                    btnMonterHabilete.Enabled = False
                    btnDescendreHabilete.Enabled = False
                End If
            Case Action.modifierAutre
                gbHabilete.Enabled = blnActiver

                If dgvHabilete.SelectedRows.Count > 0 Then
                    btnModifierHabilete.Enabled = blnActiver
                    btnSupprimerHabilete.Enabled = blnActiver
                    If dgvHabilete.SelectedRows(0).Index = 0 Then
                        btnMonterHabilete.Enabled = False
                    Else
                        btnMonterHabilete.Enabled = blnActiver
                    End If
                    If dgvHabilete.SelectedRows(0).Index = dgvHabilete.Rows.Count - 1 Then
                        btnDescendreHabilete.Enabled = False
                    Else
                        btnDescendreHabilete.Enabled = blnActiver
                    End If
                Else
                    btnModifierHabilete.Enabled = False
                    btnSupprimerHabilete.Enabled = False
                    btnMonterHabilete.Enabled = False
                    btnDescendreHabilete.Enabled = False
                End If
        End Select
    End Sub
End Class