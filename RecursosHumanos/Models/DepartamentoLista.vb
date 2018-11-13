Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc

Public Class DepartamentoLista


    Public Property departamentoList As List(Of SelectListItem)
    Public Property id_1 As Integer


    Sub New()
        Dim ds As New UsersDataDataContext()
        departamentoList = New List(Of SelectListItem)
        Dim Query = From u In ds.departamento Select u
        Dim listaData = Query.ToList()
        For Each Dato In listaData
            departamentoList.Add(New SelectListItem() With {
                  .Value = Dato.id_departamento.ToString(),
                  .Text = Dato.nombre_dep
            })
        Next
    End Sub


End Class
