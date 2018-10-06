Public Class Datos

    Dim BD As New UsersDataDataContext
    Dim em As New empleado
    Public Sub Ingresar_Empleado(NOMBRE As String, APELLIDO As String, DPI As String,
                                      NIT As String, EDAD As Integer, NACIONALIDAD As String,
                                      FECHA_NACI As String, TELEFONO As String, SEXO As String,
                                      CIVIL As String)


        em.nombre = NOMBRE
        em.apellido = APELLIDO
        em.dpi = DPI
        em.nit = NIT
        em.edad = EDAD
        em.nacionalidad = NACIONALIDAD
        em.fecha_nacimiento = FECHA_NACI
        em.telefono = TELEFONO
        em.sexo = SEXO
        em.estado_civil = CIVIL

        BD.empleado.InsertOnSubmit(em)
        BD.SubmitChanges()
    End Sub




End Class
