Public Class DepartamentoMostrar


    Dim userDC As New UsersDataDataContext
    Function DepartamentoDatos(buscar As String) As List(Of DepartamentoDatosModel)

        Dim list As List(Of DepartamentoDatosModel) = New List(Of DepartamentoDatosModel)

        Dim query = From u In userDC.departamento

        If buscar = "" Then
            query = From u In userDC.departamento

        Else
            query = From u In userDC.departamento Where u.nombre_dep = buscar

        End If


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New DepartamentoDatosModel() With {
                .NOMBRE_DEP = datos.nombre_dep,
                .FUNCION_DEP = datos.funcion_dep
            })
        Next
        Return list
    End Function

End Class

Public Class DepartamentoDatosModel

    Public Property NOMBRE_DEP As String
    Public Property FUNCION_DEP As String



End Class