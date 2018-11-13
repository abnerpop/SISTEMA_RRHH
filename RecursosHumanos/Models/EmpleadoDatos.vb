Public Class EmpleadoDatos

    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Dpi As String
    Public Property Nit As String
    Public Property Edad As String
    Public Property Nacionalidad As String
    Public Property Fecha_Naci As String
    Public Property Telefono As String
    Public Property Sexo As String
    Public Property Estado_Civil As String



    Dim BD As New UsersDataDataContext
    Dim em As New empleado
    Public Sub Ingresar_Empleado(NOMBRE As String, APELLIDO As String, DPI As String,
                                      NIT As String, EDAD As Integer, NACIONALIDAD As String,
                                      FECHA_NACI As String, TELEFONO As String, SEXO As String,
                                      CIVIL As String, JORNADA As Integer, SALARIO As Integer,
                                      DEPARTAMENTO As String, PUESTO As String)

        If SALARIO = 0 And JORNADA = 0 And DEPARTAMENTO = 0 And PUESTO = 0 Then
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
        Else
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
            em.id_jornada = JORNADA
            em.id_salario = SALARIO
            em.id_departamento = DEPARTAMENTO
            em.id_puesto = PUESTO
            em.id_empresa = 1

        End If


        BD.empleado.InsertOnSubmit(em)
        BD.SubmitChanges()
    End Sub



End Class
