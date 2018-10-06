Public Class PuestosDatos
    Dim userDC As New UsersDataDataContext
    Function PuestosDatos() As List(Of PuestosDatosModel)

        Dim list As List(Of PuestosDatosModel) = New List(Of PuestosDatosModel)
        Dim query = From u In userDC.puesto


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New PuestosDatosModel() With {
                .ID_PUESTO = datos.id_puesto,
                .NOMBRE_PUESTO = datos.nombre_puesto
            })
        Next
        Return list
    End Function

End Class


Public Class PuestosDatosModel

    Public Property ID_PUESTO As String
    Public Property NOMBRE_PUESTO As String



End Class