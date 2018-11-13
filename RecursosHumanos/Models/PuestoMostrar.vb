Public Class PuestoMostrar

    Dim userDC As New UsersDataDataContext
    Function PuestoDatos(buscar As String) As List(Of PuestoDatosModel)

        Dim list As List(Of PuestoDatosModel) = New List(Of PuestoDatosModel)
        Dim query = From u In userDC.puesto

        If buscar = "" Then
            query = From u In userDC.puesto

        Else
            query = From u In userDC.puesto Where u.nombre_puesto = buscar

        End If


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New PuestoDatosModel() With {
                .ID_PUESTO = datos.id_puesto,
                .NOMBRE_PUESTO = datos.nombre_puesto
            })
        Next
        Return list
    End Function

End Class


Public Class PuestoDatosModel

    Public Property ID_PUESTO As String
    Public Property NOMBRE_PUESTO As String



End Class