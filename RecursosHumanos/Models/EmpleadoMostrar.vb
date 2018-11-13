Public Class EmpleadoMostrar


    Dim userDC As New UsersDataDataContext
    Function EmpleadoDatos(buscar As String) As List(Of EmpleadoDatosModel)

        Dim list As List(Of EmpleadoDatosModel) = New List(Of EmpleadoDatosModel)
        Dim query = From u In userDC.empleado



        If buscar = "" Then
            query = From u In userDC.empleado

        Else
            query = From u In userDC.empleado Where u.nombre = buscar Or u.apellido = buscar

        End If

        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New EmpleadoDatosModel() With {
            .NOMBRE = datos.nombre,
            .APELLIDO = datos.apellido,
            .DPI = datos.dpi,
            .NIT = datos.nit,
            .EDAD = datos.edad,
            .NACIONALIDAD = datos.nacionalidad,
            .FECHA_NACI = datos.fecha_nacimiento,
            .TELEFONO = datos.telefono,
            .SEXO = datos.sexo,
            .CIVIL = datos.estado_civil
            })
        Next
        Return list
    End Function


End Class


Public Class EmpleadoDatosModel

    Public Property NOMBRE As String
    Public Property APELLIDO As String
    Public Property DPI As String
    Public Property NIT As String
    Public Property EDAD As Integer
    Public Property NACIONALIDAD As String
    Public Property FECHA_NACI As String
    Public Property TELEFONO As String
    Public Property SEXO As String
    Public Property CIVIL As String

End Class