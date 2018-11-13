Public Class PuestoDatos

    Public Property Nombre_pue As String



    Dim BD As New UsersDataDataContext
    Dim pu As New puesto

    Public Sub Ingresar_Puesto(NOMBRE As String)

        pu.nombre_puesto = NOMBRE


        BD.puesto.InsertOnSubmit(pu)
        BD.SubmitChanges()
    End Sub

End Class
