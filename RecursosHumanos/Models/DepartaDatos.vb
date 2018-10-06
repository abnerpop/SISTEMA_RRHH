Public Class DepartaDatos
    Dim userDC As New UsersDataDataContext
    Function DepartaDatos() As List(Of DepartaDatosModel)

        Dim list As List(Of DepartaDatosModel) = New List(Of DepartaDatosModel)
        Dim query = From u In userDC.departamento


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New DepartaDatosModel() With {
                .NOMBRE_DEP = datos.nombre_dep,
                .FUNCION_DEP = datos.funcion_dep,
                .FECHA_INGRESO = datos.fecha_ingreso
            })
        Next
        Return list
    End Function

End Class

Public Class DepartaDatosModel

    Public Property NOMBRE_DEP As String
    Public Property FUNCION_DEP As String
    Public Property FECHA_INGRESO As String


End Class