Imports System.Windows.Forms

Public Class dlgListeCours

    Dim taPrealable As New SGPDataSetTableAdapters.P_SELECT_PrealableCours_PKTableAdapter
    Dim dtPrealable As DataTable

    Dim styleSelection As Integer = 0

    Dim nomPoliceRtf As String = ""
    Dim taillePoliceRtf As Integer

    Private Sub dlgListeCours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTypePrealable.DataSource = P_SELECT_TypePrealableTableAdapter().GetData()
        If VariablesGlobales.actionPrealable = Action.inserer Then
            RechercherCours()
            If dgvCours.SelectedRows.Count > 0 Then
                gbListeCours.Enabled = True
            End If
            gbDetailPrealable.Enabled = False
            rtxtJustification.Rtf = VariablesGlobales.justification
        ElseIf VariablesGlobales.actionPrealable = Action.modifier Then

            dtPrealable = taPrealable.GetData(VariablesGlobales.idCours,
                                              VariablesGlobales.idCoursRequis)

            If dtPrealable.Rows.Count > 0 Then
                cbTypePrealable.SelectedValue = dtPrealable.Rows(0)("idTypePrealable")
                rtxtJustification.Rtf = dtPrealable.Rows(0)("justificationPrealable")
            End If

            gbListeCours.Enabled = False
            gbDetailPrealable.Enabled = True
        End If
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        gbListeCours.Enabled = False
        gbDetailPrealable.Enabled = True
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter
        Dim justification As String
        justification = rtxtJustification.Rtf
        Dim nombreFonts As Integer
        'récupération du nombre de fonts du texte rtf
        nombreFonts = VariablesGlobales.TrouverMot(justification, "{\f")
        Dim indexDepart As Integer
        Dim indexFin As Integer
        Dim indexBaliseFont As Integer
        'parcour des fonts
        For i As Integer = 0 To nombreFonts - 1
            If i = 0 Then
                'pour le premier qui n'est pas un font
                indexDepart = justification.IndexOf("{\f")
            ElseIf i = 1 Then
                'pour le premier font
                indexDepart = justification.IndexOf("{\f", indexDepart + 1)
                indexFin = justification.IndexOf("}", indexDepart + 1)
                Dim indexDebutPolice As Integer = justification.IndexOf(" ", indexDepart) + 1
                Dim nombreCaracterePolice As Integer = indexFin - indexDebutPolice - 1
                'récupération de la police
                nomPoliceRtf = justification.Substring(indexDebutPolice, nombreCaracterePolice)
            Else
                If i = 2 Then
                    'pour le deuxième font
                    indexDepart = justification.IndexOf("{\f", indexDepart + 1)
                End If
                indexFin = justification.IndexOf("}", indexDepart + 1)
                Dim nombreCaracteres As Integer = indexFin - indexDepart + 1
                'suppression du font
                justification = justification.Remove(indexDepart, nombreCaracteres)
                'récupération du nombre de balise du font supprimé
                Dim nombreBalisesFont As Integer = VariablesGlobales.TrouverMot(justification, "\f" & i - 1)
                For j As Integer = 1 To nombreBalisesFont
                    indexBaliseFont = justification.IndexOf("\f" & i - 1)
                    'suppression des balises
                    justification = justification.Remove(indexBaliseFont, 3)
                Next
            End If
        Next
        rtxtJustification.Rtf = justification
        rtxtJustification.SelectAll()
        'récupération de la taille du texte
        taillePoliceRtf = rtxtJustification.SelectionFont.SizeInPoints.ToString("0.0") * 2
        If Not justification = "" And Not nomPoliceRtf = "" Then
            If Not rtxtJustification.Rtf.Contains("fs18\qj") Then
                'remplacement de la police, taille et justification du texte
                justification = rtxtJustification.Rtf.Replace(nomPoliceRtf, "Calibri").Replace("fs" + taillePoliceRtf.ToString(), "fs18\qj")
            Else
                justification = rtxtJustification.Rtf.Replace(nomPoliceRtf, "Calibri")
            End If
            nomPoliceRtf = Nothing
            taillePoliceRtf = Nothing
        End If

        If VariablesGlobales.actionPrealable = Action.inserer Then
            monTa.P_INSERT_PrealableCours(VariablesGlobales.idCours,
                                          dgvCours.SelectedRows(0).Cells(0).Value,
                                          cbTypePrealable.SelectedValue,
                                          justification)
            RechercherCours()
            gbListeCours.Enabled = True
            gbDetailPrealable.Enabled = False
        ElseIf VariablesGlobales.actionPrealable = Action.modifier Then
            monTa.P_UPDATE_PrealableCours(VariablesGlobales.idCours,
                                          VariablesGlobales.idCoursRequis,
                                          cbTypePrealable.SelectedValue,
                                          justification)
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RechercherCours()
        dgvCours.DataSource = P_SELECT_CoursDevis_EXTableAdapter().GetData(VariablesGlobales.idCours, VariablesGlobales.idDevis)

        gbListeCours.Text = "Liste des cours du devis (" + dgvCours.RowCount().ToString + ")"
    End Sub

    Private Sub cbTypePrealable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTypePrealable.SelectedIndexChanged

        dtPrealable = taPrealable.GetData(VariablesGlobales.idCours,
                                          VariablesGlobales.idCoursRequis)

        If dtPrealable.Rows.Count > 0 Then
            If cbTypePrealable.SelectedValue <> dtPrealable.Rows(0)("idTypePrealable") Then
                VariablesGlobales.modification = True
            Else
                VariablesGlobales.modification = False
            End If
        End If
    End Sub

    Private Sub rtxtJustification_TextChanged(sender As Object, e As EventArgs) Handles rtxtJustification.TextChanged
        dtPrealable = taPrealable.GetData(VariablesGlobales.idCours,
                                          VariablesGlobales.idCoursRequis)

        If dtPrealable.Rows.Count > 0 Then
            If IsDBNull(dtPrealable.Rows(0)("justificationPrealable")) Then
                VariablesGlobales.modification = True
            Else
                If rtxtJustification.Rtf <> dtPrealable.Rows(0)("justificationPrealable") Then
                    VariablesGlobales.modification = True
                Else
                    VariablesGlobales.modification = False
                End If
            End If
        End If
    End Sub

    Private Sub rtxtJustification_SelectionChanged(sender As Object, e As EventArgs) Handles rtxtJustification.SelectionChanged
        styleSelection = 0
        If Not IsNothing(rtxtJustification.SelectionFont) Then
            'récupération du style de la sélection
            If rtxtJustification.SelectionFont.Bold Then
                styleSelection += 1
            End If
            If rtxtJustification.SelectionFont.Italic Then
                styleSelection += 3
            End If
            If rtxtJustification.SelectionFont.Underline Then
                styleSelection += 5
            End If
        End If
    End Sub

    Private Sub tsbGras_Click(sender As Object, e As EventArgs) Handles tsbGras.Click
        If Not IsNothing(rtxtJustification.SelectionFont) Then
            If rtxtJustification.SelectionFont.Bold Then
                styleSelection -= 1
            Else
                styleSelection += 1
            End If
            changerStyle()
        End If
    End Sub

    Private Sub tsbItalique_Click(sender As Object, e As EventArgs) Handles tsbItalique.Click
        If Not IsNothing(rtxtJustification.SelectionFont) Then
            If rtxtJustification.SelectionFont.Italic Then
                styleSelection -= 3
            Else
                styleSelection += 3
            End If
            changerStyle()
        End If
    End Sub

    Private Sub tsbSouligne_Click(sender As Object, e As EventArgs) Handles tsbSouligne.Click
        If Not IsNothing(rtxtJustification.SelectionFont) Then
            If rtxtJustification.SelectionFont.Underline Then
                styleSelection -= 5
            Else
                styleSelection += 5
            End If
            changerStyle()
        End If
    End Sub

    Private Sub changerStyle()
        Select Case styleSelection
            Case 0
                If Not IsNothing(rtxtJustification.SelectionFont) Then
                    rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                           FontStyle.Regular)
                End If
            Case 1
                rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                       FontStyle.Bold)
            Case 3
                rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                       FontStyle.Italic)
            Case 5
                rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                       FontStyle.Underline)
            Case 4
                rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                       FontStyle.Bold Or FontStyle.Italic)
            Case 6
                rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                       FontStyle.Bold Or FontStyle.Underline)
            Case 8
                rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                       FontStyle.Italic Or FontStyle.Underline)
            Case 9
                rtxtJustification.SelectionFont = New Font(rtxtJustification.SelectionFont,
                                                       FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
            Case Else
                MsgBox("Oups, erreur lors de la récupération du style!")
        End Select
    End Sub

    Private Sub tsbPuce_Click(sender As Object, e As EventArgs) Handles tsbPuce.Click
        If rtxtJustification.SelectionBullet Then
            rtxtJustification.SelectionBullet = False
        Else
            rtxtJustification.SelectionBullet = True
        End If
    End Sub
End Class
