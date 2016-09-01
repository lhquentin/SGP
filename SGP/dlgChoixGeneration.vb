Imports System.Windows.Forms

Public Class dlgChoixGeneration
    Private idDevis As Integer
    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbChoixDocument.SelectedIndex = -1
        idDevis = VariablesGlobales.idDevis
        VariablesGlobales.idDevis = -1
        lbGenerationEnCours.Visible = False

    End Sub
   

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        lbGenerationEnCours.Visible = True
        'génération des documents en fonction du choix de la combobox
        Select Case cbChoixDocument.SelectedIndex
            Case 0
                GenerationPresentationProgramme.genererPlanCours(idDevis)
                GenerationPresentationProgramme.GenererTableauDevis(idDevis)
                GenerationPresentationProgramme.GenererPresentationProgramme(idDevis)
                GenerationPresentationProgramme.genererProfilFormation(idDevis)
                lbGenerationEnCours.Text = "Génération terminée."

                'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                'Me.Close()


            Case 1
                GenerationPresentationProgramme.GenererTableauDevis(idDevis)
                GenerationPresentationProgramme.GenererPresentationProgramme(idDevis)
                lbGenerationEnCours.Text = "Génération terminée."
                'lbGenerationEnCours.Visible = False
                'MsgBox("Génération terminée.")
                'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                'Me.Close()
            Case 2
                GenerationPresentationProgramme.genererPlanCours(idDevis)
                lbGenerationEnCours.Text = "Génération terminée."

                'lbGenerationEnCours.Visible = False
                'MsgBox("Génération terminée.")
                'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                'Me.Close()

            Case 3
                GenerationPresentationProgramme.genererProfilFormation(idDevis)
                lbGenerationEnCours.Text = "Génération terminée."

                'lbGenerationEnCours.Visible = False
                'MsgBox("Génération terminée.")
                'Me.DialogResult = System.Windows.Forms.DialogResult.OK
                'Me.Close()
        End Select


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



End Class
