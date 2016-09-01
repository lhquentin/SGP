

Partial Public Class SGPDataSet
    Partial Class P_SELECT_HabileteCoursDataTable

    End Class

End Class


Namespace SGPDataSetTableAdapters

    Partial Public Class P_SELECT_CompetenceProgrammeTableAdapter

        Private _getData As DataTable

        Property GetData(p1 As Object) As DataTable
            Get
                Return _getData
            End Get
            Set(value As DataTable)
                _getData = value
            End Set
        End Property

    End Class
End Namespace
