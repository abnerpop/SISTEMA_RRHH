Public Class LoginDatos

    Public Property User As String
    Public Property Password As String


    Dim use As New UsersDataDataContext


    Public Function Login(USER As String, PASS As String)
        Dim _Usuario As String
        _Usuario = ""
        Dim query = From u In use.usuario Where u.usser = USER And u.pass = PASS Select u

        If query.Count() > 0 Then

            Dim datos = query.ToList()

            For Each Dato In datos
                _Usuario = Dato.usser
            Next
            Return _Usuario

        End If

        Return _Usuario

    End Function

End Class
