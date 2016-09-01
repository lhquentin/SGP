Public Class frmSaisieTexte

    Dim styleSelection As Integer = 0

    Private Sub frmSaisieTexte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If VariablesGlobales.monAction = Action.consulter Or VariablesGlobales.actionDonnees = Action.consulter Then
            rtxtSaisieTexte.ReadOnly = True
            tsBarreOutilTexte.Enabled = False
        ElseIf VariablesGlobales.monAction = Action.modifier Then
            rtxtSaisieTexte.ReadOnly = False
            tsBarreOutilTexte.Enabled = True
        End If
        rtxtSaisieTexte.BulletIndent = 20
    End Sub

    Private Sub frmSaisieTexte_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        rtxtSaisieTexte.DeselectAll()
    End Sub

    Private Sub rtxtSaisieTexte_SelectionChanged(sender As Object, e As EventArgs) Handles rtxtSaisieTexte.SelectionChanged
        styleSelection = 0
        If Not IsNothing(rtxtSaisieTexte.SelectionFont) Then
            'récupération du style de la sélection
            If rtxtSaisieTexte.SelectionFont.Bold Then
                styleSelection += 1
            End If
            If rtxtSaisieTexte.SelectionFont.Italic Then
                styleSelection += 3
            End If
            If rtxtSaisieTexte.SelectionFont.Underline Then
                styleSelection += 5
            End If
        End If
    End Sub

    Private Sub tsbGras_Click(sender As Object, e As EventArgs) Handles tsbGras.Click
        If Not IsNothing(rtxtSaisieTexte.SelectionFont) Then
            If rtxtSaisieTexte.SelectionFont.Bold Then
                styleSelection -= 1
            Else
                styleSelection += 1
            End If
            changerStyle()
        End If
    End Sub

    Private Sub tsbItalique_Click(sender As Object, e As EventArgs) Handles tsbItalique.Click
        If Not IsNothing(rtxtSaisieTexte.SelectionFont) Then
            If rtxtSaisieTexte.SelectionFont.Italic Then
                styleSelection -= 3
            Else
                styleSelection += 3
            End If
            changerStyle()
        End If
    End Sub

    Private Sub tsbSouligne_Click(sender As Object, e As EventArgs) Handles tsbSouligne.Click
        If Not IsNothing(rtxtSaisieTexte.SelectionFont) Then
            If rtxtSaisieTexte.SelectionFont.Underline Then
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
                If Not IsNothing(rtxtSaisieTexte.SelectionFont) Then
                    rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                           FontStyle.Regular)
                End If
            Case 1
                rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                       FontStyle.Bold)
            Case 3
                rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                       FontStyle.Italic)
            Case 5
                rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                       FontStyle.Underline)
            Case 4
                rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                       FontStyle.Bold Or FontStyle.Italic)
            Case 6
                rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                       FontStyle.Bold Or FontStyle.Underline)
            Case 8
                rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                       FontStyle.Italic Or FontStyle.Underline)
            Case 9
                rtxtSaisieTexte.SelectionFont = New Font(rtxtSaisieTexte.SelectionFont,
                                                       FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
            Case Else
                MsgBox("Oups, erreur lors de la récupération du style!")
        End Select
    End Sub

    Private Sub tsbPuce_Click(sender As Object, e As EventArgs) Handles tsbPuce.Click
        If rtxtSaisieTexte.SelectionBullet Then
            rtxtSaisieTexte.SelectionBullet = False
        Else
            rtxtSaisieTexte.SelectionBullet = True
        End If
    End Sub
End Class