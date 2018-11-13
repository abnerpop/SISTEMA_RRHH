Public Class ReporteEDMostrar


    Dim userDC As New UsersDataDataContext
    Function ReporteEDDatos(buscar As String) As List(Of ReporteEDDatosModel)

        Dim list As List(Of ReporteEDDatosModel) = New List(Of ReporteEDDatosModel)
        Dim query = From u In userDC.empleado Join dep In userDC.departamento On u.id_departamento Equals dep.id_departamento



        If buscar = "" Then
            query = From u In userDC.empleado Join dep In userDC.departamento On u.id_departamento Equals dep.id_departamento

        Else


            query = From u In userDC.empleado Join dep In userDC.departamento On u.id_departamento Equals dep.id_departamento Where u.nombre = buscar


        End If

        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New ReporteEDDatosModel() With {
            .NOMBRE = datos.u.nombre,
            .APELLIDO = datos.u.apellido,
            .DPI = datos.u.dpi,
            .NIT = datos.u.nit,
            .NOMBRE_DEPARTAMENTO = datos.dep.nombre_dep,
            .FUNCION_DEPARTAMENTO = datos.dep.funcion_dep
            })
        Next
        Return list
    End Function


End Class



Public Class ReporteEDDatosModel

    Public Property NOMBRE As String
    Public Property APELLIDO As String
    Public Property DPI As String
    Public Property NIT As String
    Public Property NOMBRE_DEPARTAMENTO As String
    Public Property FUNCION_DEPARTAMENTO As String

End Class