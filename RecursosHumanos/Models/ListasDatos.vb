Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Web.Mvc


Public Class ListasDatos


    Public Property puestoList As List(Of SelectListItem)
    Public Property id As Integer

    Public Property departamentoList As List(Of SelectListItem)
    Public Property id_1 As Integer

    Public Property jornadaList As List(Of SelectListItem)
    Public Property id_2 As Integer

    Public Property salarioList As List(Of SelectListItem)
    Public Property id_3 As Integer

    'Lista de puesto
    Sub New()
        Dim ds As New UsersDataDataContext()
        puestoList = New List(Of SelectListItem)
        Dim Query = From u In ds.puesto Select u
        Dim listaData = Query.ToList()
        For Each Dato In listaData
            puestoList.Add(New SelectListItem() With {
                  .Value = Dato.id_puesto.ToString(),
                  .Text = Dato.nombre_puesto
            })
        Next

        'Lista de departamento

        Dim de As New UsersDataDataContext()
        departamentoList = New List(Of SelectListItem)
        Dim Query1 = From u In ds.departamento Select u
        Dim listaData1 = Query1.ToList()
        For Each Dato1 In listaData1
            departamentoList.Add(New SelectListItem() With {
                  .Value = Dato1.id_departamento.ToString(),
                  .Text = Dato1.nombre_dep
            })
        Next


        'Lista de jornada

        Dim jor As New UsersDataDataContext()
        jornadaList = New List(Of SelectListItem)
        Dim Query2 = From u In ds.jornada Select u
        Dim listaData2 = Query2.ToList()
        For Each Dato2 In listaData2
            jornadaList.Add(New SelectListItem() With {
                  .Value = Dato2.id_jornada.ToString(),
                  .Text = Dato2.tipo_jornadal
            })
        Next

        'Lista de salario

        Dim sal As New UsersDataDataContext()
        salarioList = New List(Of SelectListItem)
        Dim Query3 = From u In ds.salario Select u
        Dim listaData3 = Query3.ToList()
        For Each Dato3 In listaData3
            salarioList.Add(New SelectListItem() With {
                  .Value = Dato3.id_salario.ToString(),
                  .Text = Dato3.tipo_salario
            })
        Next


    End Sub




End Class
