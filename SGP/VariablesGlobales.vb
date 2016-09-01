Module VariablesGlobales
    Public idUtilisateur As Integer
    Public idRole As Integer
    Public nomUtilisateur As String
    Public fermer As Boolean = False

    Public idProgramme As Integer
    Public butProgramme As String
    Public intentionEducativesProgramme As String

    Public idCompetence As Integer
    Public competencesSelectionnees As List(Of Integer)

    Public idCours As Integer
    Public idDevisCours As Integer
    Public descriptionCours As String = ""
    Public idCoursRequis As Integer
    Public actionPrealable As Action
    Public justification As String

    Public idDevis As Integer = -1
    Public idIntention As Integer

    Enum Action
        consulter
        modifier
        inserer
        modifierAutre
        valider
        ajoutCoursDevis
        gestionHabilete
    End Enum


    Public monAction As Action
    Public actionSecondaire As Action = -1


    Public profilDiplome As String
    Public epreuveSynthese As String
    Public santeSecurite As String
    Public dateOfficialisation As Date

    Public modification As Boolean = False
    Public devisOfficiel As Boolean = False

    Public actionDonnees As Action = Action.modifier

    Public Function TrouverMot(ByVal TexteRecherche As String, ByVal Paragraphe As String) As Integer

        Dim location As Integer = 0

        Dim occurances As Integer = 0

        Do

            location = TexteRecherche.IndexOf(Paragraphe, location)

            If location <> -1 Then

                occurances += 1

                location += Paragraphe.Length



            End If

        Loop Until location = -1

        Return occurances

    End Function
End Module
