Imports System.Windows.Forms

Public Class dlgListeHabilete

    Private Sub dlgListeHabilete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'vérifie avec quel formulaire il a été ouvert
        If VariablesGlobales.monAction = Action.gestionHabilete Then
            'depuis la gestion des habiletés
            dgvHabilete.DataSource = P_SELECT_SectionHabileteTableAdapter().GetData(2)
            dgvHabilete.MultiSelect = True
            dgvSousHabilete.MultiSelect = False
        Else
            'depuis le formulaire de cours
            dgvHabilete.DataSource = P_SELECT_SectionHabileteTableAdapter().GetData(1)
            dgvHabilete.MultiSelect = False
            dgvSousHabilete.MultiSelect = True
        End If
        gbListeHabilete.Text = "Liste des habiletés (" + dgvHabilete.RowCount().ToString + ")"
        If dgvHabilete.SelectedRows.Count > 0 Then
            RechercheHabilete()
            btnAjouter.Enabled = True
        Else
            btnAjouter.Enabled = False
        End If
    End Sub

    Private Sub dgvHabilete_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHabilete.SelectionChanged
        If dgvHabilete.SelectedRows.Count > 0 Then
            RechercheHabilete()
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim monTa As New SGPDataSetTableAdapters.QueriesTableAdapter

        If VariablesGlobales.monAction = Action.gestionHabilete Then
            'insertion des habiletés pour l'année courante
            Dim connexion As New System.Data.SqlClient.SqlConnection
            Dim commandeAjouterSectionHabilete As New System.Data.SqlClient.SqlCommand
            Dim commandeSelectionnerHabilete As New System.Data.SqlClient.SqlCommand
            Dim commandeAjouterHabilete As New System.Data.SqlClient.SqlCommand
            Dim transaction As System.Data.SqlClient.SqlTransaction
            Dim idSectionHabileteAjoute As Integer
            Dim taHabilete As New SGPDataSetTableAdapters.P_SELECT_HabileteTableAdapter

            Try

                'ouverture de la connexion
                connexion.ConnectionString = SGP.My.Settings.H2016_Stage_Yoann_QuentinConnectionString
                connexion.Open()

                'création de la commandeAjouterSectionHabilete
                commandeAjouterSectionHabilete.Connection = connexion
                commandeAjouterSectionHabilete.CommandType = CommandType.StoredProcedure
                commandeAjouterSectionHabilete.CommandText = "P_INSERT_SectionHabilete"

                commandeAjouterSectionHabilete.Parameters.Add("titreSECTION_HABILETE", SqlDbType.VarChar)
                commandeAjouterSectionHabilete.Parameters.Add("numeroSECTION_HABILETE", SqlDbType.Int)

                'création de la commandeSelectionnerHabilete
                commandeSelectionnerHabilete.Connection = connexion
                commandeSelectionnerHabilete.CommandType = CommandType.StoredProcedure
                commandeSelectionnerHabilete.CommandText = "P_SELECT_Habilete"

                commandeSelectionnerHabilete.Parameters.Add("idSECTION_HABILETE", SqlDbType.Int)
                commandeSelectionnerHabilete.Parameters.Add("idCOURS", SqlDbType.Int)

                'création de la commandeAjouterHabilete
                commandeAjouterHabilete.Connection = connexion
                commandeAjouterHabilete.CommandType = CommandType.StoredProcedure
                commandeAjouterHabilete.CommandText = "P_INSERT_Habilete"

                commandeAjouterHabilete.Parameters.Add("libelleHABILETE", SqlDbType.VarChar)
                commandeAjouterHabilete.Parameters.Add("numeroHABILETE", SqlDbType.Int)
                commandeAjouterHabilete.Parameters.Add("idSECTION_HABILETE", SqlDbType.Int)

                'BEGIN TRANSACTION
                transaction = connexion.BeginTransaction

                For Each row1 As DataGridViewRow In dgvHabilete.SelectedRows
                    commandeAjouterSectionHabilete.Parameters(0).Value = row1.Cells(3).Value
                    commandeAjouterSectionHabilete.Parameters(1).Value = row1.Cells(2).Value

                    commandeAjouterSectionHabilete.Transaction = transaction

                    'exécution de la commandeAjouterSectionHabilete
                    idSectionHabileteAjoute = commandeAjouterSectionHabilete.ExecuteScalar()

                    commandeSelectionnerHabilete.Parameters(0).Value = row1.Cells(0).Value
                    commandeSelectionnerHabilete.Parameters(1).Value = 0

                    commandeSelectionnerHabilete.Transaction = transaction

                    'exécution de la commandeSelectionnerHabilete
                    Dim listeHabilete = commandeSelectionnerHabilete.ExecuteReader()
                    Dim listeLibelleHabilete As List(Of String)
                    Dim listeNumeroHabilete As List(Of Integer)
                    listeLibelleHabilete = New List(Of String)
                    listeNumeroHabilete = New List(Of Integer)

                    If listeHabilete.HasRows Then
                        Do While listeHabilete.Read()
                            listeLibelleHabilete.Add(listeHabilete.Item(3))
                            listeNumeroHabilete.Add(listeHabilete.Item(2))
                        Loop
                    End If
                    listeHabilete.Close()

                    For i As Integer = 0 To listeLibelleHabilete.Count - 1
                        commandeAjouterHabilete.Parameters(0).Value = listeLibelleHabilete.Item(i)
                        commandeAjouterHabilete.Parameters(1).Value = listeNumeroHabilete.Item(i)
                        commandeAjouterHabilete.Parameters(2).Value = idSectionHabileteAjoute

                        commandeAjouterHabilete.Transaction = transaction

                        'exécution de la commandeAjouterHabilete
                        commandeAjouterHabilete.ExecuteNonQuery()
                    Next
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
            For Each row As DataGridViewRow In dgvSousHabilete.SelectedRows
                monTa.P_INSERT_HabileteCours(VariablesGlobales.idCours,
                                             row.Cells(0).Value)
            Next
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub RechercheHabilete()
        dgvSousHabilete.DataSource = P_SELECT_HabileteTableAdapter().GetData(dgvHabilete.SelectedRows(0).Cells(0).Value,
                                                                             VariablesGlobales.idCours)

        gbListeSousHabilete.Text = "Liste des sous-habiletés (" + dgvSousHabilete.RowCount().ToString + ")"
        If dgvSousHabilete.SelectedRows.Count > 0 Then
            btnAjouter.Enabled = True
        Else
            btnAjouter.Enabled = False
        End If
    End Sub
End Class
