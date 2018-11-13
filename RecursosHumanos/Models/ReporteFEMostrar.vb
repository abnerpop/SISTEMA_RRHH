Public Class ReporteFEMostrar


    Dim userDC As New UsersDataDataContext
    Function ReporteFEDatos(buscar As String) As List(Of ReporteFEDatosModel)

        Dim list As List(Of ReporteFEDatosModel) = New List(Of ReporteFEDatosModel)
        Dim query = From u In userDC.empleado
                    Join emp In userDC.empresa On u.id_empresa Equals emp.id_empresa
                    Join dep In userDC.departamento On u.id_departamento Equals dep.id_departamento
                    Join jor In userDC.jornada On u.id_jornada Equals jor.id_jornada
                    Join pue In userDC.puesto On u.id_puesto Equals pue.id_puesto
                    Join sal In userDC.salario On u.id_salario Equals sal.id_salario



        If buscar = "" Then
            query = From u In userDC.empleado
                    Join emp In userDC.empresa On u.id_empresa Equals emp.id_empresa
                    Join dep In userDC.departamento On u.id_departamento Equals dep.id_departamento
                    Join jor In userDC.jornada On u.id_jornada Equals jor.id_jornada
                    Join pue In userDC.puesto On u.id_puesto Equals pue.id_puesto
                    Join sal In userDC.salario On u.id_salario Equals sal.id_salario

        Else


            query = From u In userDC.empleado
                    Join emp In userDC.empresa On u.id_empresa Equals emp.id_empresa
                    Join dep In userDC.departamento On u.id_departamento Equals dep.id_departamento
                    Join jor In userDC.jornada On u.id_jornada Equals jor.id_jornada
                    Join pue In userDC.puesto On u.id_puesto Equals pue.id_puesto
                    Join sal In userDC.salario On u.id_salario Equals sal.id_salario Where u.nombre = buscar


        End If

        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New ReporteFEDatosModel() With {
            .NOMBRE = datos.u.nombre,
            .APELLIDO = datos.u.apellido,
            .EMPRESA = datos.emp.nombre_empresa,
            .DEPARTAMENTO = datos.dep.nombre_dep,
            .JORNADA = datos.jor.tipo_jornadal,
            .HORA_JORNADA = datos.jor.hora_jornada.ToString(),
            .PUESTO = datos.pue.nombre_puesto,
            .SALARIO = datos.sal.tipo_salario,
            .CANTIDAD_SALARIO = datos.sal.cantidad_salario
            })
        Next
        Return list
    End Function


End Class



Public Class ReporteFEDatosModel

    Public Property NOMBRE As String
    Public Property APELLIDO As String
    Public Property EMPRESA As String
    Public Property DEPARTAMENTO As String
    Public Property JORNADA As String
    Public Property HORA_JORNADA As String
    Public Property PUESTO As String
    Public Property SALARIO As String
    Public Property CANTIDAD_SALARIO As String

End Class