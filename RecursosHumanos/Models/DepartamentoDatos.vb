Public Class DepartamentoDatos
    Public Property Nombre_dep As String
    Public Property Funcion_dep As String


    Dim BD As New UsersDataDataContext
    Dim de As New departamento

    Public Sub Ingresar_Departamento(NOMBRE As String, FUNCION As String)

        de.nombre_dep = NOMBRE
        de.funcion_dep = FUNCION

        BD.departamento.InsertOnSubmit(de)
        BD.SubmitChanges()
    End Sub


End Class
