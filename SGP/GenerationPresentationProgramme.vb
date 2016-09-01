Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.Threading

Module GenerationPresentationProgramme
    Public nomFichierExcel As String
    Public Sub GenererPresentationProgramme(idDevis As Integer)
        'Try

        '----------------------------------------------
        ' récupère les données à mettre dans le fichier
        '----------------------------------------------

        'variables devis
        Dim taDevis As SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter
        Dim dtDevis As DataTable = taDevis.GetData(idDevis)
        Dim taIntentionsDevis = New SGPDataSetTableAdapters.P_SELECT_IntentionDevisTableAdapter
        Dim dtIntentionsDevis = taIntentionsDevis.GetData(idDevis)

        'Dim dateOfficialisation As Date
        'If Not IsDBNull(dtDevis.Rows(0)("dateOfficialisation")) Then
        '    dateOfficialisation = dtDevis.Rows(0)("dateOfficialisation")
        'End If
        Dim profilDiplome As String = dtDevis.Rows(0)("profilDiplome")
        Dim epreuveSynthese As String = dtDevis.Rows(0)("epreuveSynthese")
        Dim rangeProfilDiplome As Word.Range
        Dim rangeEpreuveSynthese As Word.Range
        Dim tableIntentions As Word.Table
        Dim nombreIntentionsDevis = dtIntentionsDevis.Rows.Count

        'variables programme
        Dim taProgramme As SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter
        Dim dtProgramme As DataTable = taProgramme.GetData(idDevis)

        Dim codeProgramme As String = dtProgramme.Rows(0)("codePROGRAMME")
        Dim titreProgramme As String = dtProgramme.Rows(0)("titrePROGRAMME")
        Dim idSanction As String = dtProgramme.Rows(0)("idTYPE_SANCTION")
        Dim typeProgramme As String = dtProgramme.Rows(0)("libelleTYPE_PROGRAMME")
        Dim unites As Decimal = dtProgramme.Rows(0)("unites")
        Dim unitesSpecifique As Decimal = dtProgramme.Rows(0)("unitesFormationSpecifique")
        Dim duree As Integer = dtProgramme.Rows(0)("duree")
        Dim dureeSpecifique As Integer = dtProgramme.Rows(0)("dureeFormationSpecifique")
        Dim conditionAdmission As String = dtProgramme.Rows(0)("conditionAdmission")
        Dim butProgramme As String = dtProgramme.Rows(0)("butProgramme")
        Dim intentionsEducativesProgramme As String = dtProgramme.Rows(0)("intentionsEducatives")

        Dim rangeButProgramme As Word.Range
        Dim rangeIntentionsProgramme As Word.Range

        'variables compétences
        Dim taCompetence As SGPDataSetTableAdapters.P_SELECT_Competences_ProgrammeTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Competences_ProgrammeTableAdapter
        Dim dtCompetence As DataTable = taCompetence.GetData(dtProgramme.Rows(0)("idPROGRAMME"))

        'variables cours
        Dim taCours As SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter
        Dim dtCours As DataTable = taCours.GetData(idDevis)

        Dim idCours As Integer
        Dim taIntentionCours As New SGPDataSetTableAdapters.P_SELECT_IntentionCoursTableAdapter
        Dim dtIntentionCours As DataTable
        Dim taActivite As New SGPDataSetTableAdapters.P_SELECT_ActiviteTableAdapter
        Dim dtActivite As DataTable
        Dim taHabilete As New SGPDataSetTableAdapters.P_SELECT_HabileteCoursTableAdapter
        Dim dtHabilete As DataTable
        Dim taCompetenceCours As New SGPDataSetTableAdapters.P_SELECT_CompetenceCours_GTableAdapter
        Dim taContexte As New SGPDataSetTableAdapters.P_SELECT_ContexteCompetenceTableAdapter
        Dim taElement As New SGPDataSetTableAdapters.P_SELECT_ElementCompetenceTableAdapter
        Dim taCritere As New SGPDataSetTableAdapters.P_SELECT_CritereElementTableAdapter
        Dim dtCompetenceCours As DataTable
        Dim dtContexte As DataTable
        Dim dtElement As DataTable
        Dim dtCritere As DataTable

        Dim cours As String
        Dim discipline As String
        Dim ponderationTh As String
        Dim ponderationLab As String
        Dim ponderationPerso As String
        Dim unitesCours As String
        Dim heuresContact As String
        Dim session As String
        Dim description As String

        Dim i As Integer
        Dim j As Integer
        Dim k = 0
        Dim cpt = 1
        Dim nombreIntentionsCours As Integer
        Dim habilete As String
        Dim section As String
        Dim numeroElement As String
        Dim numeroCritere As Integer
        Dim critere As String
        Dim tableCompetence As Word.Table
        Dim tableHabilete As Word.Table
        Dim nombreActivites As Integer
        Dim tableDetails As Word.Table
        Dim nombreElements As Integer
        Dim nombreCompetencesCours As Integer

        'variables préalables
        Dim taPrealable As SGPDataSetTableAdapters.P_SELECT_PrealableCours_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_PrealableCours_GTableAdapter
        Dim justification As String

        'Variables tableaux Excel
        Dim taSessions = New SGPDataSetTableAdapters.P_SELECT_Sessions_DevisTableAdapter
        Dim dtSessions As DataTable = taSessions.GetData(idDevis)
        Dim taHabiletesDevis = New SGPDataSetTableAdapters.P_SELECT_HabileteDevis_GTableAdapter
        Dim dtHabiletesDevis As DataTable = taHabiletesDevis.GetData(idDevis)

        Dim indexLigneFin As Integer
        Dim indexColonneFin As Integer
        Dim nombreCours = dtCours.Rows.Count
        Dim nombreSessions = dtSessions.Rows.Count
        Dim nombreCompetences = dtCompetence.Rows.Count
        Dim nombreHabiletes = dtHabiletesDevis.Rows.Count
        Dim rangeCompetences As Word.Range


        '-----------------------
        ' génération du fichier
        '-----------------------

        'création du document Word
        Dim oWord As Word.Application
        Dim oDoc As Word.Document = Nothing
        Dim oDocCours As Word.Document
        oWord = CreateObject("Word.Application")
        'oWord.Visible = True
        'chargement du modèle
        oDoc = oWord.Documents.Add(Application.StartupPath + "\modele\modeleDevis.dotx")

        'chargement du fichier excel contenant les tableaux
        Dim oExcel As Excel.Application
        oExcel = CreateObject("Excel.Application")
        Dim oDocTableaux = oExcel.Workbooks.Add(nomFichierExcel)
        Dim feuilleCompetences As Excel.Worksheet
        Dim feuilleIntentions As New Excel.Worksheet
        Dim feuilleHabiletesTIC As New Excel.Worksheet


        Clipboard.Clear()

        'couverture
        oDoc.Bookmarks("TypeProgramme").Range.Text = typeProgramme
        oDoc.Bookmarks("CodeProgramme").Range.Text = codeProgramme
        oDoc.Bookmarks("TitreProgramme").Range.Text = titreProgramme
        oDoc.Bookmarks("DateOfficiel").Range.Text = dateOfficialisation.ToString("dd MMMM yyyy")

        'présentation du programme
        oDoc.Bookmarks("CodeTitreProgramme").Range.Text = codeProgramme + " " + titreProgramme

        'insertion du texte selon l'idSanction
        If idSanction = 1 Then
            oDoc.Bookmarks("TypeSanctionProgramme").Range.Text = "Diplôme d'études collégiales (DEC)"
        ElseIf idSanction = 2 Then
            oDoc.Bookmarks("TypeSanctionProgramme").Range.Text = "Attestation d'études collégiales (AEC)"
        Else
            oDoc.Bookmarks("TypeSanctionProgramme").Range.Text = "Aucun"
        End If

        'convertion des décimale en fraction
        If unites.ToString().Contains(",33") Then
            oDoc.Bookmarks("UnitesTotaleProgramme").Range.Text = unites.ToString().Replace(",33", " 1/3")
        ElseIf unites.ToString().Contains(",67") Then
            oDoc.Bookmarks("UnitesTotaleProgramme").Range.Text = unites.ToString().Replace(",67", " 2/3")
        Else
            oDoc.Bookmarks("UnitesTotaleProgramme").Range.Text = unites.ToString().Replace(",00", "")
        End If

        If unitesSpecifique.ToString().Contains(",33") Then
            oDoc.Bookmarks("UnitesSpecifiqueProgramme").Range.Text = unitesSpecifique.ToString().Replace(",33", " 1/3")
            oDoc.Bookmarks("UnitesFormationSpecifique").Range.Text = unitesSpecifique.ToString().Replace(",33", " 1/3")
        ElseIf unitesSpecifique.ToString().Contains(",67") Then
            oDoc.Bookmarks("UnitesSpecifiqueProgramme").Range.Text = unitesSpecifique.ToString().Replace(",67", " 2/3")
            oDoc.Bookmarks("UnitesFormationSpecifique").Range.Text = unitesSpecifique.ToString().Replace(",67", " 2/3")
        Else
            oDoc.Bookmarks("UnitesSpecifiqueProgramme").Range.Text = unitesSpecifique.ToString().Replace(",00", "")
            oDoc.Bookmarks("UnitesFormationSpecifique").Range.Text = unitesSpecifique.ToString().Replace(",00", "")
        End If

        oDoc.Bookmarks("HeuresTotaleProgramme").Range.Text = duree
        oDoc.Bookmarks("HeuresSpecifiqueProgramme").Range.Text = dureeSpecifique
        oDoc.Bookmarks("ConditionsProgramme").Range.Text = conditionAdmission

        'buts du programme
        'copie du butProgramme en format RTF afin de garder le style
        rangeButProgramme = oDoc.Bookmarks("ButsProgramme").Range
        If String.IsNullOrEmpty(butProgramme) Then
            butProgramme = " "
        End If
        Clipboard.SetText(butProgramme, TextDataFormat.Rtf)
        rangeButProgramme.Paste()
        rangeButProgramme.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify

        'intentions éducatives du programme
        If String.IsNullOrEmpty(intentionsEducativesProgramme) Then
            intentionsEducativesProgramme = " "
        End If
        rangeIntentionsProgramme = oDoc.Bookmarks("IntentionsProgramme").Range
        Clipboard.SetText(intentionsEducativesProgramme, TextDataFormat.Rtf)
        rangeIntentionsProgramme.Paste()
        rangeIntentionsProgramme.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify

        'liste des objectifs du programme
        'récupération du texte contenu dans le signet
        Dim formationSpecifique As String = oDoc.Bookmarks("FormationSpecifique").Range.Text
        'parcour des compétences du programmes
        For Each rowCompetence As DataRow In dtCompetence.Rows
            'récupération des données
            Dim codeCompetence As String = rowCompetence.Item("codeCOMPETENCE")
            Dim nomCompetence As String = rowCompetence.Item("nomCOMPETENCE")

            If formationSpecifique = "FormationSpecifique" Then
                'ajout de la première compétence
                formationSpecifique = codeCompetence + vbTab + nomCompetence
            Else
                'ajout des autres compétences
                formationSpecifique = formationSpecifique + vbNewLine + codeCompetence + vbTab + nomCompetence
            End If
        Next
        'insertion de la valeur dans le signet
        oDoc.Bookmarks("FormationSpecifique").Range.Text = formationSpecifique

        'intentions éducatives du devis
        If nombreIntentionsDevis > 0 Then
            tableIntentions = oDoc.Tables.Add(oDoc.Bookmarks.Item("IntentionsEducatives").Range, 2 * nombreIntentionsDevis, 1)
            i = 1
            For Each rowIntention As DataRow In dtIntentionsDevis.Rows
                With tableIntentions.Cell(i, 1).Range
                    .Text = rowIntention.Item("titreINTENTION")
                    .Font.Size = 12
                    .Font.Name = "Calibri"
                    .Font.Bold = True
                    .Paragraphs.SpaceAfter = 6
                    If i = 1 Then
                        .Paragraphs.SpaceBefore = 0
                    Else
                        .Paragraphs.SpaceBefore = 12
                    End If
                End With
                With tableIntentions.Cell(i + 1, 1).Range
                    .Text = rowIntention.Item("descriptionINTENTION")
                    .Font.Size = 11
                    .Font.Name = "Calibri"
                    .Paragraphs.SpaceAfter = 12
                End With
                i += 2
            Next
        End If



        'profil du diplômé
        If String.IsNullOrEmpty(profilDiplome) Then
            profilDiplome = " "
        End If
        rangeProfilDiplome = oDoc.Bookmarks("ProfilDiplome").Range
        Clipboard.SetText(profilDiplome, TextDataFormat.Rtf)
        oDoc.Bookmarks("ProfilDiplome").Range.Paste()
        rangeProfilDiplome.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify


        'epreuve de synthèse
        If String.IsNullOrEmpty(epreuveSynthese) Then
            epreuveSynthese = " "
        End If
        rangeEpreuveSynthese = oDoc.Bookmarks("EpreuveSynthese").Range
        Clipboard.SetText(epreuveSynthese, TextDataFormat.Rtf)
        oDoc.Bookmarks("EpreuveSynthese").Range.Paste()
        rangeEpreuveSynthese.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify

        'Dim relancer As Boolean
        'Do
        '    Try
        '        relancer = False
        Clipboard.Clear()
        'tableau relations compétences/cours
        feuilleCompetences = oDocTableaux.Sheets("Liens Compétences-Cours")
        indexLigneFin = 4 + nombreCours + nombreSessions
        indexColonneFin = 4 + nombreCompetences
        rangeCompetences = oDoc.Bookmarks("CompetencesCours").Range

        feuilleCompetences.Range(feuilleCompetences.Cells(1, 1), feuilleCompetences.Cells(indexLigneFin, indexColonneFin)).Copy()
        rangeCompetences.PasteSpecial(DataType:=Word.WdPasteDataType.wdPasteBitmap)
        'Thread.Sleep(1000)
        oDoc.Range.InlineShapes(1).Height = oWord.CentimetersToPoints(16)


        'tableau relations intentions/cours
        feuilleIntentions = oDocTableaux.Sheets("Intentions Éducatives-Cours")
        indexLigneFin = 3 + nombreCours + nombreSessions
        indexColonneFin = 4 + nombreIntentionsDevis

        feuilleIntentions.Range(feuilleIntentions.Cells(1, 1), feuilleIntentions.Cells(indexLigneFin, indexColonneFin)).Copy()
        oDoc.Bookmarks("IntentionsCours").Range.PasteSpecial(DataType:=Word.WdPasteDataType.wdPasteBitmap)


        'tableau habiletes TIC
        feuilleHabiletesTIC = oDocTableaux.Sheets("Habiletés TIC")
        indexLigneFin = 5 + nombreCours + nombreSessions
        indexColonneFin = 3 + nombreHabiletes

        feuilleHabiletesTIC.Range(feuilleHabiletesTIC.Cells(1, 1), feuilleHabiletesTIC.Cells(indexLigneFin, indexColonneFin)).Copy()
        oDoc.Bookmarks("HabiletesTic").Range.PasteSpecial(DataType:=Word.WdPasteDataType.wdPasteBitmap)
        oDoc.Range.InlineShapes(3).Height = oWord.CentimetersToPoints(15.3)

        Clipboard.Clear()
        oDocTableaux.Close()

        '    Catch ex As COMException
        '        'If ex.HResult = H0x80010001 Then
        '        Thread.Sleep(1000) ' attendre 1 seconde avant de recommencer
        '        relancer = True
        '        'Else
        '        'Throw
        '        'End If
        '    End Try
        'Loop While relancer







        'tableau de la liste des cours
        For Each rowCours As DataRow In dtCours.Rows
            Dim numero As String = rowCours.Item("codeCOURS")
            Dim titre As String = rowCours.Item("titreCOURS")
            discipline = rowCours.Item("discipline")
            Dim ponderation As String = rowCours.Item("ponderationTheorique").ToString() + " " + rowCours.Item("ponderationLaboratoire").ToString() + " " + rowCours.Item("ponderationPersonnel").ToString()
            unitesCours = rowCours.Item("unites")
            heuresContact = rowCours.Item("heureContact")
            Dim heuresTotal As String = rowCours.Item("heureTotal")
            session = rowCours.Item("session")

            'récupération du tableau de cours du modèle
            Dim tableauCours = oDoc.Bookmarks("TableauCours").Range.Tables(1).Range
            'booléen de vérification de première cellule d'une ligne
            Dim premier As Boolean = True
            'parcour des cellules du tableau
            For i = 1 To tableauCours.Cells.Count
                'verifie que la ligne actif est la dernière et que la cellule est la première de la ligne
                If tableauCours.Cells(i).RowIndex = tableauCours.Rows.Count And premier Then
                    'insertion des données du cours
                    tableauCours.Cells(i).Range.Text = numero
                    tableauCours.Cells(i + 1).Range.Text = titre
                    tableauCours.Cells(i + 2).Range.Text = discipline
                    tableauCours.Cells(i + 3).Range.Text = ponderation
                    tableauCours.Cells(i + 4).Range.Text = unitesCours
                    tableauCours.Cells(i + 5).Range.Text = heuresContact
                    tableauCours.Cells(i + 6).Range.Text = heuresTotal
                    tableauCours.Cells(i + 7).Range.Text = session
                    premier = False
                End If
            Next

            'vérifie si ce n'est pas le dernier cours
            If Not rowCours Is dtCours.Rows.Item(dtCours.Rows.Count - 1) Then
                'ajout d'une ligne
                tableauCours.Rows.Add()
                premier = True
            End If

            'détails des cours
            oDocCours = oWord.Documents.Add(Application.StartupPath + "\modele\ModeleCours.dotx")

            tableHabilete = oDocCours.Bookmarks("HabileteTIC").Range.Tables(1)
            tableDetails = oDocCours.Bookmarks("PresentationCours").Range.Tables(1)
            idCours = rowCours("idCOURS")

            dtIntentionCours = taIntentionCours.GetData(idCours)
            dtActivite = taActivite.GetData(idCours)
            dtHabilete = taHabilete.GetData(idCours)
            dtCompetenceCours = taCompetenceCours.GetData(idCours)

            cours = rowCours("codeCOURS") + " " + rowCours("titreCOURS")
            ponderationTh = rowCours("ponderationTheorique")
            ponderationLab = rowCours("ponderationLaboratoire")
            ponderationPerso = rowCours("ponderationPersonnel")
            description = rowCours("description")

            'tableau de début de page
            tableDetails.Cell(1, 1).Range.Text = cours
            tableDetails.Cell(2, 1).Range.Text = "Discipline : " & discipline
            tableDetails.Cell(2, 2).Range.Text = "Pondération : " & ponderationTh & " " & ponderationLab & " " & ponderationPerso
            tableDetails.Cell(2, 3).Range.Text = "Unités : " & unitesCours
            tableDetails.Cell(2, 4).Range.Text = "Heures Contact : " & heuresContact
            tableDetails.Cell(2, 5).Range.Text = "Session : " & session

            'Description
            If String.IsNullOrEmpty(description) Then
                description = "À compléter"
            End If
            Clipboard.SetText(description, TextDataFormat.Rtf)
            oDocCours.Bookmarks("descriptionCours").Range.Paste()

            'Intentions Éducatives
            nombreIntentionsCours = dtIntentionCours.Rows.Count

            For i = nombreIntentionsCours To 1 Step -1
                If i = nombreIntentionsCours Then
                    oDocCours.Bookmarks("IntentionsCours").Range.Text = dtIntentionCours.Rows(i - 1)("titreIntention")
                Else
                    oDocCours.Bookmarks("IntentionsCours").Range.Text = dtIntentionCours.Rows(i - 1)("titreIntention") + vbNewLine
                End If
            Next

            'Habiletés TIC
            If dtHabilete.Rows.Count = 0 Then
                tableHabilete.Delete()
                oDocCours.Bookmarks("HabileteTIC").Range.Delete()
            Else
                i = 0
                For Each rowHabilete As DataRow In dtHabilete.Rows
                    habilete = rowHabilete.Item("Code") + vbTab + rowHabilete.Item("libelleHABILETE")
                    section = rowHabilete.Item("titreSECTION_HABILETE")
                    If i = 0 Then
                        tableHabilete.Cell(i + 1, 1).Range.Text = section
                        tableHabilete.Cell(i + 1, 2).Range.Text = habilete
                    Else
                        If dtHabilete.Rows(i)("numeroSECTION_HABILETE") = dtHabilete.Rows(i - 1)("numeroSECTION_HABILETE") Then

                            tableHabilete.Cell(i + 1, 2).Range.Text = String.Concat(tableHabilete.Cell(i + 1, 2).Range.Text, habilete)

                        Else
                            tableHabilete.Rows.Add()
                            tableHabilete.Cell(i + 1, 1).Range.Text = section
                            tableHabilete.Cell(i + 1, 2).Range.Text = habilete
                        End If
                    End If
                    i = i + 1
                Next
            End If

            'Activités
            nombreActivites = dtActivite.Rows.Count

            For i = nombreActivites To 1 Step -1
                If i = nombreActivites Then
                    oDocCours.Bookmarks("Activites").Range.Text = dtActivite.Rows(i - 1)("descriptionActivite")
                Else
                    oDocCours.Bookmarks("Activites").Range.Text = dtActivite.Rows(i - 1)("descriptionActivite") + vbNewLine
                End If
            Next

            'Compétences
            nombreCompetencesCours = dtCompetenceCours.Rows.Count
            If nombreCompetencesCours = 0 Then
                tableCompetence = oDocCours.Tables.Add(oDocCours.Bookmarks.Item("Competences").Range, 2, 2)
            Else
                i = 0
                For Each rowCompetence As DataRow In dtCompetenceCours.Rows
                    dtElement = taElement.GetData(rowCompetence.Item("idCOMPETENCE"))
                    dtContexte = taContexte.GetData(rowCompetence.Item("idCOMPETENCE"))
                    nombreElements = dtElement.Rows.Count

                    'Création du tableau
                    tableCompetence = oDocCours.Tables.Add(oDocCours.Bookmarks.Item("Competences").Range, nombreElements + 4, 2)
                    With tableCompetence
                        .Cell(1, 1).Range.Text() = "Objectif"
                        .Cell(1, 2).Range.Text() = "Standard"
                        .Cell(2, 1).Range.Text() = "Énoncé de la compétence"
                        .Cell(2, 2).Range.Text() = "Contexte de réalisation"
                        .Cell(4, 1).Range.Text() = "Éléments de compétence"
                        .Cell(4, 2).Range.Text() = "Critères de performance"
                        .Borders.Enable = True
                        .Columns(1).Width = 201
                        .Columns(2).Width = 266

                        For j = 1 To nombreElements + 4
                            If j = 1 Or j = 2 Or j = 4 Then
                                With .Rows(j)
                                    .Height = 0.42
                                    .Range.Font.SmallCaps = True
                                    .Range.Font.Bold = True
                                    .Range.Font.Size = 9
                                    .Range.Font.Name = "Gill Sans MT"
                                    .Range.ParagraphFormat.SpaceBefore = 2
                                    .Range.ParagraphFormat.SpaceAfter = 0
                                    '.Range.ParagraphFormat.
                                    If j = 1 Then
                                        .Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                                    End If
                                End With
                            Else
                                With .Rows(j)
                                    .Range.Font.Size = 9
                                    .Range.Font.Name = "Calibri"
                                    .Range.ParagraphFormat.SpaceBefore = 2
                                    .Range.ParagraphFormat.SpaceAfter = 0
                                    .Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify

                                End With


                            End If
                        Next
                    End With

                    'Remplissage du tableau créé avec les données de la base
                    tableCompetence.Cell(3, 1).Range.Text() = rowCompetence.Item("codeCOMPETENCE") + ":   " + rowCompetence.Item("nomCOMPETENCE")

                    'Contexte
                    j = 0
                    For Each rowContexte As DataRow In dtContexte.Rows
                        If j = 0 Then
                            tableCompetence.Cell(3, 2).Range.Text = rowContexte.Item("libelleCONTEXTE")
                        Else
                            tableCompetence.Cell(3, 2).Range.Text += rowContexte.Item("libelleCONTEXTE")
                        End If
                        j += 1
                    Next
                    tableCompetence.Cell(3, 2).Range.ListFormat.ApplyBulletDefault()
                    tableCompetence.Cell(3, 2).Range.Font.Name = "Calibri"

                    'Éléments/Critères
                    j = 0
                    For Each rowElement As DataRow In dtElement.Rows
                        dtCritere = taCritere.GetData(rowElement.Item("idELEMENT"))
                        numeroElement = rowElement.Item("numeroELEMENT").ToString
                        tableCompetence.Cell(5 + j, 1).Range.Text = numeroElement + vbTab + rowElement.Item("libelleELEMENT")
                        For Each rowCritere As DataRow In dtCritere.Rows
                            numeroCritere = rowCritere.Item("numeroCRITERE")
                            critere = numeroElement + "." + numeroCritere.ToString + vbTab + rowCritere.Item("libelleCRITERE")
                            If numeroCritere = 1 Then
                                tableCompetence.Cell(5 + j, 2).Range.Text = critere
                            Else
                                tableCompetence.Cell(5 + j, 2).Range.Text = String.Concat(tableCompetence.Cell(5 + j, 2).Range.Text + critere)
                            End If
                            tableCompetence.Cell(5 + j, 2).Range.Paragraphs.Format.BaseLineAlignment = Word.WdBaselineAlignment.wdBaselineAlignBaseline
                        Next
                        j = j + 1
                    Next
                    tableCompetence.Range.ParagraphFormat.KeepWithNext = True


                    i = i + 1
                    tableCompetence.Range.Next.InsertParagraphBefore()
                    tableCompetence.Range.Next.InsertParagraphBefore()
                    oDocCours.Bookmarks.Add("Competences", tableCompetence.Range.Next.Next)
                Next
            End If

            'Insertion du modèle de cours rempli dans le devis
            If cpt = 1 Then
                oDoc.Bookmarks("Cours").Range.Next.Next.InsertParagraphBefore()
                oDoc.Bookmarks("Cours").Range.Next.Text = vbFormFeed
            Else
                oDoc.Tables(oDoc.Tables.Count - 1).Range.Next.Next.InsertParagraphBefore()
                oDoc.Tables(oDoc.Tables.Count - 1).Range.Next.Next.InsertParagraphBefore()
                oDoc.Tables(oDoc.Tables.Count - 1).Range.Next.Text = vbFormFeed
            End If

            Clipboard.Clear()
            oDocCours.Range(0, oDocCours.Characters.Count - 4).Copy()

            If cpt = 1 Then
                oDoc.Bookmarks("Cours").Range.Paste()
            Else
                oDoc.Tables(oDoc.Tables.Count - 1).Range.Next.Next.Paste()
            End If

            oDocCours.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
            cpt = cpt + 1


            'liste des préalables
            'récupération du tableau de préalable
            Dim tableauPrealable = oDoc.Bookmarks("TableauPrealable").Range.Tables(1).Range
            Dim derniereLigneTableauPrealable = tableauPrealable.Rows.Last
            Dim dtPrealable As DataTable = taPrealable.GetData(rowCours.Item("idCOURS"))
            If dtPrealable.Rows.Count > 0 Then
                justification = dtPrealable.Rows(0)("justificationPrealable")
                'vérifie si la première cellule de la dernière ligne ne contient pas le terme "Aucun" contenu dans le modèle
                If Not derniereLigneTableauPrealable.Cells(1).Range.Text.Contains("Aucun") Then
                    tableauPrealable.Rows.Add()
                    'actualisation de la variable du tableau
                    tableauPrealable = oDoc.Bookmarks("TableauPrealable").Range.Tables(1).Range
                    'actualisation de la dernière ligne
                    derniereLigneTableauPrealable = tableauPrealable.Rows.Last
                End If
                'insertion des données dans la dernière ligne
                derniereLigneTableauPrealable.Cells(1).Range.Text = dtPrealable.Rows(0)("codeCOURS")
                derniereLigneTableauPrealable.Cells(2).Range.Text = dtPrealable.Rows(0)("titreCOURS")
                If String.IsNullOrEmpty(justification) Then
                    justification = " "
                End If
                Clipboard.SetText(justification, TextDataFormat.Rtf)
                derniereLigneTableauPrealable.Cells(4).Range.Paste()

                For Each rowPrealable As DataRow In dtPrealable.Rows
                    Dim prealable As String = rowPrealable.Item("idTypePrealable") + " : " + rowPrealable.Item("codeCOURS_REQUIS")
                    If rowPrealable Is dtPrealable.Rows.Item(0) Then
                        'insertion de la donnée si c'est le premier préalable
                        derniereLigneTableauPrealable.Cells(3).Range.Text = prealable
                    Else
                        'ajout de la donnée si ce n'est pas le premier préalable
                        derniereLigneTableauPrealable.Cells(3).Range.Text = derniereLigneTableauPrealable.Cells(3).Range.Text + prealable
                    End If
                Next
            End If
        Next

        'si il y'a pas de préalable
        If oDoc.Bookmarks("TableauPrealable").Range.Tables(1).Cell(2, 1).Range.Text.Contains("Aucun") Then
            'suppression du titre et tableau préalable
            oDoc.Bookmarks("TableauPrealable").Range.Previous().Delete()
            oDoc.Bookmarks("TableauPrealable").Range.Delete()
        End If

        oDoc.TablesOfContents(1).Update()
        oExcel.Quit()

        'Sauvegarde
        Dim fenetreSauvegarde As New SaveFileDialog
        Dim nomFichierDevis As String

        fenetreSauvegarde.Title = "Où voulez vous enregistrer le fichier?"
        fenetreSauvegarde.FileName = "Devis_" + Replace(Now.ToString, ":", "-")
        fenetreSauvegarde.Filter = "docx files(*.docx)|*.docx"
        fenetreSauvegarde.InitialDirectory = "C:\"
        fenetreSauvegarde.RestoreDirectory = True

        If fenetreSauvegarde.ShowDialog() = DialogResult.OK Then
            nomFichierDevis = fenetreSauvegarde.FileName
            oDoc.SaveAs(fenetreSauvegarde.FileName)
            oDoc.Close()
            oWord.Quit()
        Else
            oDoc.Close(False)
        End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub


    Public Sub GenererTableauDevis(idDevis As Integer)
        'Try
        Dim selection As Excel.Range
        Dim ligneHabilete As Excel.Range
        Dim ligneNumeroHabilete As Excel.Range
        Dim ligne1 As Excel.Range
        Dim ligne2 As Excel.Range
        Dim dtHabileteCours As DataTable
        'Dim section As Integer
        'Dim nombreCasesCochees As String
        Dim i As Integer

        '----------------------------------------------
        ' récupère les données à mettre dans le fichier
        '----------------------------------------------

        'programme
        Dim taProgramme As SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter
        Dim dtProgramme As DataTable = taProgramme.GetData(idDevis)

        'compétences
        Dim taCompetence As SGPDataSetTableAdapters.P_SELECT_Competences_ProgrammeTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Competences_ProgrammeTableAdapter
        Dim dtCompetence As DataTable = taCompetence.GetData(dtProgramme.Rows(0)("idPROGRAMME"))

        'cours
        Dim taCours As SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter
        Dim dtCours As DataTable = taCours.GetData(idDevis)

        'compétencesCours
        Dim taCompetenceCours As SGPDataSetTableAdapters.P_SELECT_CompetenceCours_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_CompetenceCours_GTableAdapter

        'intentions
        Dim taIntention = New SGPDataSetTableAdapters.P_SELECT_IntentionDevisTableAdapter
        Dim dtIntention = taIntention.GetData(idDevis)

        'intentionsCours
        Dim taIntentionCours = New SGPDataSetTableAdapters.P_SELECT_IntentionCoursTableAdapter

        'habiletés
        Dim taHabilete = New SGPDataSetTableAdapters.P_SELECT_HabileteDevis_GTableAdapter
        Dim dtHabilete = taHabilete.GetData(idDevis)

        'habiletésCours
        Dim taHabileteCours = New SGPDataSetTableAdapters.P_SELECT_HabileteCoursTableAdapter


        '-----------------------
        ' génération du fichier
        '-----------------------

        'création du document Excel
        Dim oExcel As Excel.Application
        Dim oDoc As Excel.Workbook = Nothing

        oExcel = CreateObject("Excel.Application")
        'oExcel.Visible = True
        'chargement du modèle
        oDoc = oExcel.Workbooks.Add(Application.StartupPath + "\modele\modeleTableau.xltx")

        'tableau relation compétences/cours

        'récupération de la page
        Dim feuilleCompetenceCours As Excel.Worksheet = oDoc.Sheets("Liens Compétences-Cours")
        i = 0
        'parcour des compétences du programme
        For Each rowCompetence As DataRow In dtCompetence.Rows
            'lors de la première compétence
            If i = 0 Then
                'récupération de la première colonne de compétence
                selection = feuilleCompetenceCours.Range("D1:D5")
                selection.Copy()
                'parcour du nombre de colonnes de compétence à insérer
                For j As Integer = 0 To dtCompetence.Rows.Count - 2
                    'insertion du style
                    selection.Next.PasteSpecial(Excel.XlPasteType.xlPasteAllUsingSourceTheme)
                    selection.Next.PasteSpecial(Excel.XlPasteType.xlPasteColumnWidths)
                    'récupération de la nouvelle colonne de compétence
                    selection = selection.Next
                    'si on est à la dernière colonne de compétence
                    If j = dtCompetence.Rows.Count - 2 Then
                        'sélection de la première ligne de la colonne
                        selection = selection.Rows(1)
                        'parcour du nombre de lignes de la colonne
                        For k As Integer = 1 To 5
                            'modification de la bordure droite de la cellule
                            Dim selection2 As Excel.Range = selection.Item(k)
                            selection2.Borders.Item(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
                        Next
                    End If
                Next
            End If
            'insertion des données dans les deux premières lignes de la colonne de compétence active
            ligne1 = feuilleCompetenceCours.Rows(1)
            ligne1 = ligne1.Cells(4 + i)
            ligne1.Value = rowCompetence.Item("nomCOMPETENCE")
            ligne2 = feuilleCompetenceCours.Rows(2)
            ligne2 = ligne2.Cells(4 + i)
            ligne2.Value = rowCompetence.Item("codeCOMPETENCE")

            i += 1
        Next

        Dim sessionTableau As Integer = 1
        i = 0
        For Each rowCours As DataRow In dtCours.Rows
            'lors du premier cours
            If i = 0 Then
                'sélection de la première ligne de cours
                selection = feuilleCompetenceCours.Rows(4)
                selection.Copy()
                'parcour du nombre de lignes de cours à insérer
                For j As Integer = 0 To dtCours.Rows.Count - 2
                    'insertion de ligne à la suite, avec le style de la précédente
                    selection.Insert(Excel.XlDirection.xlDown, selection.Rows(selection.Row + 1))
                    'sélection de la nouvelle ligne
                    selection = feuilleCompetenceCours.Rows(selection.Row)
                Next
                'sélection des lignes des cours
                selection = feuilleCompetenceCours.Range(feuilleCompetenceCours.Cells(4, 1), feuilleCompetenceCours.Cells(4 + dtCours.Rows.Count - 1, dtCompetence.Rows.Count + 3))
                'modification des bordures horizontales
                selection.Borders.Item(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlHairline
                'modification du format en texte
                selection.NumberFormat = "@"
            End If
            'vérification si la session du cours a changé
            If rowCours.Item("session") <> sessionTableau Then
                sessionTableau = rowCours.Item("session")
                'copie de la ligne de première session
                feuilleCompetenceCours.Rows(3).Copy()
                'insertion de la nouvelle ligne de session au dessus du nouveau cours
                feuilleCompetenceCours.Rows(4 + i).Insert(Excel.XlDirection.xlUp)
                feuilleCompetenceCours.Cells(4 + i, 1).Value = "SESSION " + sessionTableau.ToString()
                'modification des bordures de la nouvelle ligne de session
                selection = feuilleCompetenceCours.Range(feuilleCompetenceCours.Cells(4 + i, 1), feuilleCompetenceCours.Cells(4 + i, dtCompetence.Rows.Count + 3))
                selection.Borders.Item(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
                selection.Borders.Item(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin

                i += 1
                Clipboard.Clear()
            End If
            feuilleCompetenceCours.Cells(4 + i, 1).Value = rowCours.Item("codeCOURS")
            feuilleCompetenceCours.Cells(4 + i, 2).Value = rowCours.Item("titreCOURS")

            'récupération des compétences du cours
            Dim dtCompetenceCours As DataTable = taCompetenceCours.GetData(rowCours.Item("idCOURS"))

            feuilleCompetenceCours.Cells(4 + i, 3).Value = dtCompetenceCours.Rows.Count

            For Each rowCompetence As DataRow In dtCompetenceCours.Rows
                For j As Integer = 4 To dtCompetence.Rows.Count + 3
                    'vérifie si la compétence de la colonne est celle du cours
                    If feuilleCompetenceCours.Cells(2, j).Value = rowCompetence.Item("codeCOMPETENCE") Then
                        Dim element As String = rowCompetence.Item("element")
                        'vérifie si il n'y a qu'un élément de la compétence dans le cours
                        If element.Split("-").GetValue(0) = element.Split("-").GetValue(1) Then
                            'insertion de l'élément seul
                            feuilleCompetenceCours.Cells(4 + i, j).Value = element.Split("-").GetValue(0)
                        Else
                            feuilleCompetenceCours.Cells(4 + i, j).Value = element
                        End If
                    End If
                Next
            Next

            i += 1
        Next

        feuilleCompetenceCours.Rows(1).Insert(Excel.XlDirection.xlUp)
        feuilleCompetenceCours.Columns("A:A").Insert(Excel.XlDirection.xlToLeft, feuilleCompetenceCours.Columns.Next)
        feuilleCompetenceCours.Columns("A").ColumnWidth = 0.1
        feuilleCompetenceCours.Rows(1).RowHeight = 1.5



        'tableau relation intentions/cours
        'récupération de la page
        Dim feuilleIntentionCours As Excel.Worksheet = oDoc.Sheets("Intentions Éducatives-Cours")
        Dim nombreIntentions = dtIntention.Rows.Count
        i = 0
        'parcours des intentions du devis
        For Each rowIntention As DataRow In dtIntention.Rows
            'lors de la première intention
            If i = 0 Then
                'récupération de la première colonne d'intention
                selection = feuilleIntentionCours.Range("D1:D4")
                selection.Copy()
                'parcours du nombre de colonnes d'intentions à insérer
                For j As Integer = 0 To dtIntention.Rows.Count - 2
                    'insertion du style
                    selection.Next.PasteSpecial(Excel.XlPasteType.xlPasteAllUsingSourceTheme)
                    selection.Next.PasteSpecial(Excel.XlPasteType.xlPasteColumnWidths)
                    selection = selection.Next
                Next
            End If
            'insertion du titre des intentions 
            ligneHabilete = feuilleIntentionCours.Rows(1)
            ligneHabilete = ligneHabilete.Cells(4 + i)
            ligneHabilete.Value = rowIntention.Item("titreINTENTION")

            i += 1
        Next
        feuilleIntentionCours.Range(feuilleIntentionCours.Cells(2, 1), feuilleIntentionCours.Cells(2, nombreIntentions + 3)).Merge()


        sessionTableau = 1
        i = 0
        For Each rowCours As DataRow In dtCours.Rows

            'lors du premier cours
            If i = 0 Then
                'sélection de la première ligne de cours
                selection = feuilleIntentionCours.Rows(3)
                selection.Copy()
                'parcours du nombre de lignes de cours à insérer
                For j As Integer = 0 To dtCours.Rows.Count - 2
                    'insertion de ligne à la suite, avec le style de la précédente
                    selection.Insert(Excel.XlDirection.xlDown, selection.Rows(selection.Row + 1))
                    'sélection de la nouvelle ligne
                    selection = feuilleIntentionCours.Rows(selection.Row)
                Next
                feuilleIntentionCours.Range(feuilleIntentionCours.Cells(3, 2), feuilleIntentionCours.Cells(dtCours.Rows.Count + 2, nombreIntentions + 3)).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlDash
                feuilleIntentionCours.Range(feuilleIntentionCours.Cells(3, 2), feuilleIntentionCours.Cells(dtCours.Rows.Count + 2, nombreIntentions + 3)).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlDash
            End If

            'vérification si la session du cours a changé
            If rowCours.Item("session") <> sessionTableau Then
                sessionTableau = rowCours.Item("session")
                'copie de la ligne de première session
                feuilleIntentionCours.Rows(2).Copy()
                'insertion de la nouvelle ligne de session au dessus du nouveau cours
                feuilleIntentionCours.Rows(3 + i).Insert(Excel.XlDirection.xlUp)
                feuilleIntentionCours.Cells(3 + i, 1).Value = "SESSION " + sessionTableau.ToString()

                i += 1
                Clipboard.Clear()
            End If
            feuilleIntentionCours.Cells(3 + i, 1).Value = rowCours.Item("codeCOURS")
            feuilleIntentionCours.Cells(3 + i, 2).Value = rowCours.Item("titreCOURS")

            'récupération des intentions du cours
            Dim dtIntentionCours As DataTable = taIntentionCours.GetData(rowCours.Item("idCOURS"))

            feuilleIntentionCours.Cells(3 + i, 3).Value = dtIntentionCours.Rows.Count

            If dtIntentionCours.Rows.Count <> 0 Then
                For Each rowIntention As DataRow In dtIntentionCours.Rows
                    For j As Integer = 4 To dtIntention.Rows.Count + 3
                        'vérifie si la compétence de la colonne est celle du cours
                        If feuilleIntentionCours.Cells(1, j).Value = rowIntention.Item("titreINTENTION") Then
                            feuilleIntentionCours.Cells(3 + i, j).Value = "X"
                        End If
                    Next
                Next
            Else
                For j As Integer = 4 To dtIntention.Rows.Count + 3
                    feuilleIntentionCours.Cells(3 + i, j).Value = ""
                Next
            End If
            i += 1
        Next

        feuilleIntentionCours.Rows(1).Insert(Excel.XlDirection.xlUp)
        feuilleIntentionCours.Columns("A:A").Insert(Excel.XlDirection.xlToLeft, feuilleIntentionCours.Columns.Next)
        feuilleIntentionCours.Columns("A").ColumnWidth = 0.1
        feuilleIntentionCours.Rows(1).RowHeight = 1.5

        'profil TIC
        'récupération de la page
        Dim feuilleTIC As Excel.Worksheet = oDoc.Sheets("Habiletés TIC")
        Dim nombreHabiletes = dtHabilete.Rows.Count

        i = 0
        Dim numeroSectionHabilete = 0
        feuilleTIC.Cells(3, 3).NumberFormat = "@"
        For Each rowHabilete As DataRow In dtHabilete.Rows
            'lors de la première habileté
            If i = 0 Then
                'récupération de la première colonne d'habileté
                selection = feuilleTIC.Range("C:C")
                selection.Copy()
                'parcours du nombre de colonnes d'habiletés à insérer
                For j As Integer = 0 To dtHabilete.Rows.Count - 2
                    'insertion des colonnes en gardant le même style
                    selection.Next.PasteSpecial(Excel.XlPasteType.xlPasteAllUsingSourceTheme)
                    selection.Next.PasteSpecial(Excel.XlPasteType.xlPasteColumnWidths)
                    selection = selection.Next
                Next

            End If
            'ajout des titres de section
            If rowHabilete.Item("numeroSECTION_HABILETE") = numeroSectionHabilete Then
                feuilleTIC.Range(feuilleTIC.Cells(1, 2 + i), feuilleTIC.Cells(1, 3 + i)).Merge()
                feuilleTIC.Range(feuilleTIC.Cells(2, 3 + i), feuilleTIC.Cells(6, 3 + i)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlDash
            Else
                numeroSectionHabilete = rowHabilete.Item("numeroSECTION_HABILETE")
                feuilleTIC.Cells(1, 3 + i) = rowHabilete.Item("numeroSECTION_HABILETE") & ". " & rowHabilete.Item("titreSECTION_HABILETE")

            End If

            'insertion du titre des habiletés 
            ligneHabilete = feuilleTIC.Rows(2)
            ligneHabilete = ligneHabilete.Cells(3 + i)
            ligneHabilete.Value = rowHabilete.Item("libelleHABILETE")
            ligneNumeroHabilete = feuilleTIC.Rows(3)
            ligneNumeroHabilete = ligneNumeroHabilete.Cells(3 + i)
            ligneNumeroHabilete.Value = rowHabilete.Item("Code")

            i += 1
        Next

        sessionTableau = 1
        i = 0
        For Each rowCours As DataRow In dtCours.Rows
            'lors du premier cours
            If i = 0 Then
                'sélection de la première ligne de cours
                selection = feuilleTIC.Rows(5)
                selection.Copy()
                'parcours du nombre de lignes de cours à insérer
                For j As Integer = 0 To dtCours.Rows.Count - 2
                    'insertion de ligne à la suite, avec le style de la précédente
                    selection.Insert(Excel.XlDirection.xlDown, selection.Rows(selection.Row + 1))
                    'sélection de la nouvelle ligne
                    selection = feuilleTIC.Rows(selection.Row)
                Next
                'feuilleTIC.Range(feuilleTIC.Cells(5, 3), feuilleTIC.Cells(dtCours.Rows.Count + 4, nombreHabiletes + 2)).Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlDash
                feuilleTIC.Range(feuilleTIC.Cells(5, 3), feuilleTIC.Cells(dtCours.Rows.Count + 4, nombreHabiletes + 2)).Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlDash
                feuilleTIC.Range(feuilleTIC.Cells(4, 1), feuilleTIC.Cells(4, nombreHabiletes + 2)).BorderAround2()
            End If
            'vérification si la session du cours a changé
            If rowCours.Item("session") <> sessionTableau Then
                sessionTableau = rowCours.Item("session")
                'copie de la ligne de première session
                feuilleTIC.Range(feuilleTIC.Cells(4, 2), feuilleTIC.Cells(4, dtHabilete.Rows.Count + 2)).Merge()

                feuilleTIC.Rows(4).Copy()
                'insertion de la nouvelle ligne de session au dessus du nouveau cours
                feuilleTIC.Rows(5 + i).Insert(Excel.XlDirection.xlUp)
                feuilleTIC.Cells(5 + i, 1).Value = "SESSION " + sessionTableau.ToString()

                i += 1
                Clipboard.Clear()
            End If

            'Remplissage des habiletés (partie gauche du tableau)
            feuilleTIC.Cells(5 + i, 1).Value = rowCours.Item("codeCOURS")
            feuilleTIC.Cells(5 + i, 2).Value = rowCours.Item("titreCOURS")

            'remplissage du reste du tableau
            dtHabileteCours = taHabileteCours.GetData(rowCours.Item("idCOURS"))

            For Each rowHabiletes As DataRow In dtHabileteCours.Rows
                For j As Integer = 3 To dtHabilete.Rows.Count + 2
                    'vérifie si la compétence de la colonne est celle du cours
                    If feuilleTIC.Cells(2, j).Value = rowHabiletes.Item("libelleHABILETE") Then
                        feuilleTIC.Cells(5 + i, j).Value = "X"
                    End If

                Next
            Next
            i += 1
        Next

        'On insère une ligne et une colonne avant le tableau pour que toutes les bordures s'affichent lors du copier coller vers word
        feuilleTIC.Rows(1).Insert(Excel.XlDirection.xlUp)
        feuilleTIC.Columns("A:A").Insert(Excel.XlDirection.xlToLeft, feuilleTIC.Columns.Next)
        feuilleTIC.Columns("A").ColumnWidth = 0.1
        feuilleTIC.Rows(1).RowHeight = 1.5

        'Sauvegarde
        Dim fenetreSauvegarde As New SaveFileDialog

        fenetreSauvegarde.Title = "Où voulez vous enregistrer le fichier?"
        fenetreSauvegarde.FileName = "Tabeaux_Devis_" + Replace(Now.ToString, ":", "-")
        fenetreSauvegarde.Filter = "xlsx files(*.xlsx)|*.xlsx"
        fenetreSauvegarde.InitialDirectory = "C:\"
        fenetreSauvegarde.RestoreDirectory = True

        If fenetreSauvegarde.ShowDialog() = DialogResult.OK Then
            nomFichierExcel = fenetreSauvegarde.FileName
            oDoc.SaveAs(fenetreSauvegarde.FileName)
            oDoc.Close()
            oExcel.Quit()
        Else
            oDoc.Close(False)
        End If


    End Sub


    Public Sub genererPlanCours(idDevis As Integer)
        'document
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        'devis
        Dim taDevis As SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter
        Dim dtDevis As DataTable = taDevis.GetData(idDevis)

        Dim dateOfficialisation As Date
        If Not IsDBNull(dtDevis.Rows(0)("dateOfficialisation")) Then
            dateOfficialisation = dtDevis.Rows(0)("dateOfficialisation")
        End If
        Dim profilDiplome As String = dtDevis.Rows(0)("profilDiplome")
        Dim epreuveSynthese As String = dtDevis.Rows(0)("epreuveSynthese")

        'programme
        Dim taProgramme As SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter
        Dim dtProgramme As DataTable = taProgramme.GetData(idDevis)

        Dim titreProgramme As String = dtProgramme.Rows(0)("titrePROGRAMME")

        'cours
        Dim taCours As SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter
        Dim dtCours As DataTable = taCours.GetData(idDevis)

        Dim idCours As Integer
        Dim taIntention As New SGPDataSetTableAdapters.P_SELECT_IntentionCoursTableAdapter
        Dim dtIntention As DataTable
        Dim taActivite As New SGPDataSetTableAdapters.P_SELECT_ActiviteTableAdapter
        Dim dtActivite As DataTable
        Dim taCompetence As New SGPDataSetTableAdapters.P_SELECT_CompetenceCours_GTableAdapter
        Dim taContexte As New SGPDataSetTableAdapters.P_SELECT_ContexteCompetenceTableAdapter
        Dim taElement As New SGPDataSetTableAdapters.P_SELECT_ElementCompetenceTableAdapter
        Dim taCritere As New SGPDataSetTableAdapters.P_SELECT_CritereElementTableAdapter
        Dim dtCompetence As DataTable
        Dim dtContexte As DataTable
        Dim dtElement As DataTable
        Dim dtCritere As DataTable

        Dim description As String
        Dim critere As String

        'Préalables
        Dim taPrealables As New SGPDataSetTableAdapters.P_SELECT_PrealableCoursTableAdapter
        Dim dtPrealables As DataTable

        Dim nombreCompetences As Integer
        Dim nombreElements As Integer
        Dim tableCompetence As Word.Table
        Dim numeroCritere As Integer
        Dim numeroElement As Integer
        Dim paragrapheContexte As Word.Paragraph
        Dim rangePrealables As Word.Range
        Dim rangeDescription As Word.Range
        Dim rangeActivites As Word.Range
        Dim rangeIntentions As Word.Range
        Dim i As Integer
        Dim j As Integer



        For Each rowCours As DataRow In dtCours.Rows
            'Ouverture de l'application
            oWord = CreateObject("Word.Application")
            'oWord.Visible = True
            'chargement du modèle
            oDoc = oWord.Documents.Add(Application.StartupPath + "\modele\ModelePlanEtudesV4.dotx")
            idCours = rowCours.Item("idCOURS")

            'Informations 1ère page
            oDoc.Bookmarks("programme").Range.Text = titreProgramme
            oDoc.Bookmarks("ponderation").Range.Text = rowCours.Item("ponderationTheorique").ToString() + " " + rowCours.Item("ponderationLaboratoire").ToString() + " " + rowCours.Item("ponderationPersonnel").ToString()
            oDoc.Bookmarks("unites").Range.Text = rowCours.Item("unites")
            oDoc.Bookmarks("heuresContact").Range.Text = rowCours.Item("heureContact")
            oDoc.Bookmarks("codeCours").Range.Text = rowCours.Item("codeCOURS")
            oDoc.Bookmarks("titreCours").Range.Text = rowCours.Item("titreCOURS")

            'Préalables
            dtPrealables = taPrealables.GetData(idCours)
            i = 0
            If dtPrealables.Rows.Count = 0 Then
                oDoc.Bookmarks("prealables").Range.Text = " Aucun"
            Else
                rangePrealables = oDoc.Bookmarks("prealables").Range
                For Each rowPrealable As DataRow In dtPrealables.Rows
                    If i = 0 Then
                        rangePrealables.Text = rowPrealable.Item("codeCOURS")
                    ElseIf (i Mod 3) = 0 Then
                        rangePrealables.Text += "," & vbNewLine & rowPrealable.Item("codeCOURS")
                        oDoc.Tables(1).Cell(10, 2).Height -= oWord.CentimetersToPoints(0.27)
                    Else
                        rangePrealables.Text += ", " & rowPrealable.Item("codeCOURS")
                    End If
                    i += 1
                Next
            End If

            'description
            description = rowCours.Item("description")
            rangeDescription = oDoc.Bookmarks("description").Range
            If String.IsNullOrEmpty(description) Then
                description = " "
            End If
            Clipboard.SetText(description, TextDataFormat.Rtf)
            oDoc.Bookmarks("description").Range.Paste()
            rangeDescription.Font.Name = "Calibri"
            rangeDescription.Font.Size = 11
            rangeDescription.Font.Bold = False
            rangeDescription.Font.Italic = False
            rangeDescription.Font.Underline = False

            'Intentions
            dtIntention = taIntention.GetData(idCours)
            rangeIntentions = oDoc.Bookmarks("Intentions").Range
            i = 0
            For Each rowIntention As DataRow In dtIntention.Rows
                If i = 0 Then
                    rangeIntentions.Text = rowIntention.Item("titreIntention")
                Else
                    rangeIntentions.Text += vbNewLine & rowIntention.Item("titreIntention")
                End If
                i += 1
            Next
            rangeIntentions.ListFormat.ApplyBulletDefault()
            rangeIntentions.ParagraphFormat.Style = "bulletpoint"

            'Activités
            dtActivite = taActivite.GetData(idCours)
            rangeActivites = oDoc.Bookmarks("activites").Range
            i = 0
            For Each rowActivite As DataRow In dtActivite.Rows
                If i = 0 Then
                    rangeActivites.Text = rowActivite.Item("descriptionACTIVITE")
                Else
                    rangeActivites.Text += vbNewLine & rowActivite.Item("descriptionACTIVITE")
                End If
                i += 1
            Next
            rangeActivites.ListFormat.ApplyBulletDefault()
            rangeActivites.ParagraphFormat.Style = "bulletpoint"

            'Compétences
            dtCompetence = taCompetence.GetData(idCours)
            nombreCompetences = dtCompetence.Rows.Count
            If nombreCompetences = 0 Then
                tableCompetence = oDoc.Tables.Add(oDoc.Bookmarks("competences").Range, 2, 2)
            Else
                i = 0
                For Each rowCompetence As DataRow In dtCompetence.Rows
                    dtElement = taElement.GetData(rowCompetence.Item("idCOMPETENCE"))
                    dtContexte = taContexte.GetData(rowCompetence.Item("idCOMPETENCE"))
                    nombreElements = dtElement.Rows.Count

                    'Création du tableau
                    tableCompetence = oDoc.Tables.Add(oDoc.Bookmarks.Item("competences").Range, nombreElements + 4, 2)
                    With tableCompetence
                        .Cell(1, 1).Range.Text() = "Objectif"
                        .Cell(1, 2).Range.Text() = "Standard"
                        .Cell(2, 1).Range.Text() = "Énoncé de la compétence"
                        .Cell(2, 2).Range.Text() = "Contexte de réalisation"
                        .Cell(4, 1).Range.Text() = "Éléments de compétence"
                        .Cell(4, 2).Range.Text() = "Critères de performance"
                        .Borders.Enable = True
                        .Borders.InsideColor = RGB(31, 73, 125)
                        .Borders.OutsideColor = RGB(31, 73, 125)
                        .Columns(1).Width = 201
                        .Columns(2).Width = 266

                        For j = 1 To nombreElements + 4
                            If j = 1 Or j = 2 Or j = 4 Then
                                With .Rows(j)
                                    .Height = 0.42
                                    .Range.Font.SmallCaps = True
                                    .Range.Font.Bold = True
                                    .Range.Font.Size = 11
                                    .Range.Font.Name = "Calibri"
                                    .Range.ParagraphFormat.SpaceBefore = 6
                                    .Range.ParagraphFormat.SpaceAfter = 6
                                    If j = 1 Then
                                        .Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                                        .Cells.Shading.BackgroundPatternColor = RGB(238, 236, 225)
                                    End If
                                End With
                            Else
                                With .Rows(j)
                                    .Range.Font.Size = 9
                                    .Range.Font.Name = "Calibri"
                                    .Range.ParagraphFormat.SpaceBefore = 0
                                    .Range.ParagraphFormat.SpaceAfter = 10
                                    .Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify

                                End With


                            End If
                        Next
                    End With

                    'Remplissage du tableau créé avec les données de la base
                    tableCompetence.Cell(3, 1).Range.Text() = rowCompetence.Item("codeCOMPETENCE") + " :   " + rowCompetence.Item("nomCOMPETENCE")

                    'Contexte
                    j = 0
                    paragrapheContexte = tableCompetence.Cell(3, 2).Range.Paragraphs(1)
                    For Each rowContexte As DataRow In dtContexte.Rows
                        If j = 0 Then
                            'paragrapheContexte = tableCompetence.Cell(3, 2).Range.Paragraphs(1)

                            j = j + 1
                        Else
                            paragrapheContexte = tableCompetence.Cell(3, 2).Range.Paragraphs.Add
                        End If
                        paragrapheContexte.Range.Text = rowContexte.Item("libelleCONTEXTE")

                    Next
                    paragrapheContexte.Range.ListFormat.ApplyBulletDefault()

                    'Éléments/Critères
                    j = 0
                    For Each rowElement As DataRow In dtElement.Rows
                        dtCritere = taCritere.GetData(rowElement.Item("idELEMENT"))
                        numeroElement = rowElement.Item("numeroELEMENT").ToString
                        tableCompetence.Cell(5 + j, 1).Range.Text = numeroElement & vbTab & rowElement.Item("libelleELEMENT")
                        For Each rowCritere As DataRow In dtCritere.Rows
                            numeroCritere = rowCritere.Item("numeroCRITERE")
                            critere = numeroElement & "." & numeroCritere.ToString & vbTab & rowCritere.Item("libelleCRITERE")
                            If numeroCritere = 1 Then
                                tableCompetence.Cell(5 + j, 2).Range.Text = critere
                            Else
                                tableCompetence.Cell(5 + j, 2).Range.Text = String.Concat(tableCompetence.Cell(5 + j, 2).Range.Text + critere)
                            End If
                            tableCompetence.Cell(5 + j, 2).Range.Paragraphs.Format.BaseLineAlignment = Word.WdBaselineAlignment.wdBaselineAlignBaseline
                        Next
                        j = j + 1
                    Next
                    tableCompetence.Range.ParagraphFormat.KeepWithNext = True

                    If i < dtCompetence.Rows.Count - 1 Then
                        tableCompetence.Range.Next.InsertParagraphBefore()
                        tableCompetence.Range.Next.InsertParagraphBefore()
                        oDoc.Bookmarks.Add("competences", tableCompetence.Range.Next.Next)
                    End If

                    i = i + 1
                Next
            End If

            'Sauvegarde
            Dim fenetreSauvegarde As New SaveFileDialog
            Dim nomFichierDevis As String

            fenetreSauvegarde.Title = "Où voulez vous enregistrer les fichiers?"
            fenetreSauvegarde.FileName = "Plan_de_cours_" + rowCours.Item("codeCOURS") + "_" + Replace(Now.ToString, ":", "-")
            fenetreSauvegarde.Filter = "docx files(*.docx)|*.docx"
            fenetreSauvegarde.InitialDirectory = "C:\"
            fenetreSauvegarde.RestoreDirectory = True

            If fenetreSauvegarde.ShowDialog() = DialogResult.OK Then
                nomFichierDevis = fenetreSauvegarde.FileName
                oDoc.SaveAs(fenetreSauvegarde.FileName)
                oDoc.Close()
                oWord.Quit()
            Else
                oDoc.Close(False)
            End If
        Next

        Clipboard.Clear()

    End Sub


    Public Sub genererProfilFormation(idDevis As Integer)
        '----------------------------------------------
        ' récupère les données à mettre dans le fichier
        '----------------------------------------------

        Dim taDevis As SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Devis_PKTableAdapter
        Dim dtDevis As DataTable = taDevis.GetData(idDevis)
        Dim taIntentionsDevis = New SGPDataSetTableAdapters.P_SELECT_IntentionDevisTableAdapter
        Dim dtIntentionsDevis = taIntentionsDevis.GetData(idDevis)

        Dim profilDiplome As String = dtDevis.Rows(0)("profilDiplome")
        Dim epreuveSynthese As String = dtDevis.Rows(0)("epreuveSynthese")
        Dim tableIntentions As Word.Table
        Dim nombreIntentionsDevis = dtIntentionsDevis.Rows.Count

        'variables programme
        Dim taProgramme As SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Programmes_GTableAdapter
        Dim dtProgramme As DataTable = taProgramme.GetData(idDevis)

        Dim codeProgramme As String = dtProgramme.Rows(0)("codePROGRAMME")
        Dim titreProgramme As String = dtProgramme.Rows(0)("titrePROGRAMME")
        Dim typeProgramme As String = dtProgramme.Rows(0)("libelleTYPE_PROGRAMME")

        'variables cours
        Dim taCours As SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter = New SGPDataSetTableAdapters.P_SELECT_Cours_GTableAdapter
        Dim dtCours As DataTable = taCours.GetData(idDevis)
        Dim idCours As Integer

        Dim codeCours As String
        Dim titreCours As String
        Dim session As String
        Dim description As String

        'autres variables
        Dim tableCours As Word.Table
        Dim nombreCours As Integer
        Dim i As Integer


        '-----------------------
        ' génération du fichier
        '-----------------------

        'création du document Word
        Dim oWord As Word.Application
        Dim oDoc As Word.Document = Nothing

        oWord = CreateObject("Word.Application")
        'oWord.Visible = True

        'chargement du modèle
        oDoc = oWord.Documents.Add(Application.StartupPath + "\modele\modeleProfilFormation.dotm")

        'page de garde
        oDoc.Bookmarks("typeProgramme").Range.Text = typeProgramme
        oDoc.Bookmarks("codeProgramme").Range.Text = codeProgramme
        oDoc.Bookmarks("programme").Range.Text = titreProgramme

        'intentions éducatives
        If nombreIntentionsDevis > 0 Then
            tableIntentions = oDoc.Tables.Add(oDoc.Bookmarks.Item("intentionsEducatives").Range, 2 * nombreIntentionsDevis, 1)
            i = 1
            For Each rowIntention As DataRow In dtIntentionsDevis.Rows
                'cellule contenant le titre
                With tableIntentions.Cell(i, 1).Range
                    .Text = rowIntention.Item("titreINTENTION")
                    'style de la cellule
                    .Font.Size = 12
                    .Font.Name = "Calibri"
                    .Font.Bold = True
                    .Paragraphs.SpaceAfter = 6
                    If i = 1 Then
                        .Paragraphs.SpaceBefore = 0
                    Else
                        .Paragraphs.SpaceBefore = 12
                    End If
                End With

                'cellule contenant la description
                With tableIntentions.Cell(i + 1, 1).Range
                    .Text = rowIntention.Item("descriptionINTENTION")
                    'style de la cellule
                    .Font.Size = 11
                    .Font.Name = "Calibri"
                    .Paragraphs.SpaceAfter = 12
                End With
                i += 2
            Next
        End If


        'profil du diplômé
        If String.IsNullOrEmpty(profilDiplome) Then
            profilDiplome = " "
        End If
        Clipboard.SetText(profilDiplome, TextDataFormat.Rtf)
        oDoc.Bookmarks("profilDiplome").Range.Paste()

        'Cours
        nombreCours = dtCours.Rows.Count
        tableCours = oDoc.Tables.Add(oDoc.Bookmarks.Item("Cours").Range, 2 * nombreCours, 2)
        i = 1
        With tableCours.Range
            .Font.Size = 12
            .Font.Name = "Calibri"
            .Font.Bold = True
            .ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        End With

        For Each rowCours As DataRow In dtCours.Rows
            idCours = rowCours.Item("idCOURS")
            codeCours = rowCours.Item("codeCOURS")
            titreCours = rowCours.Item("titreCOURS")
            description = rowCours.Item("description")
            session = rowCours.Item("session")

            tableCours.Rows(i).Range.Paragraphs.SpaceAfter = 4
            tableCours.Rows(i + 1).Range.Paragraphs.SpaceAfter = 10

            'récupération de la description
            If String.IsNullOrEmpty(description) Then
                description = " "
            End If
            Clipboard.SetText(description, TextDataFormat.Rtf)
            'cellule contenant la description
            With tableCours.Cell(i + 1, 2).Range
                .Paste()
                .Font.Size = 11
                .Font.Bold = False
            End With
            'remplissage du tableau
            tableCours.Cell(i, 1).Range.Text = codeCours
            tableCours.Cell(i, 2).Range.Text = "Session : " & session
            tableCours.Cell(i + 1, 1).Range.Text = titreCours


            i += 2
        Next

        'épreuve synthèse
        If String.IsNullOrEmpty(epreuveSynthese) Then
            epreuveSynthese = " "
        End If
        Clipboard.SetText(epreuveSynthese, TextDataFormat.Rtf)
        oDoc.Bookmarks("epreuveSythese").Range.Paste()

        'Màj de la table des matières
        oDoc.TablesOfContents(1).Update()

        'Sauvegarde
        Dim fenetreSauvegarde As New SaveFileDialog
        Dim nomFichierDevis As String

        fenetreSauvegarde.Title = "Où voulez vous enregistrer le fichier?"
        fenetreSauvegarde.FileName = "Profil_de_formation_" + Replace(Now.ToString, ":", "-")
        fenetreSauvegarde.Filter = "docx files(*.docx)|*.docx"
        fenetreSauvegarde.InitialDirectory = "C:\"
        fenetreSauvegarde.RestoreDirectory = True

        If fenetreSauvegarde.ShowDialog() = DialogResult.OK Then
            nomFichierDevis = fenetreSauvegarde.FileName
            oDoc.SaveAs(fenetreSauvegarde.FileName)
            oDoc.Close()
            oWord.Quit()
        Else
            oDoc.Close(False)
        End If
    End Sub





End Module
