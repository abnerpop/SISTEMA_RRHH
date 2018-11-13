Imports System.Threading.Tasks
Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Login() As ActionResult
            Dim log As New LoginDatos

            If Request.Form("usuario") = "" And Request.Form("password") = "" Then
                Return View()

            End If

            log.User = Request.Form("usuario").ToString()
            log.Password = Request.Form("password").ToString()


            If log.Login(log.User, log.Password) = "" Then
                Return View()
            Else
                Return View("Menu")
            End If

        End Function


        Function Menu() As ActionResult
            Return View()
        End Function


        Function Empleado() As ActionResult
            Dim obj As New ListasDatos


            Return View(obj)
        End Function
        <HttpPost>
        <AllowAnonymous>
        Public Async Function AgregarEmpleado(pue1 As ListasDatos) As Task(Of ActionResult)
            Dim emplea As New EmpleadoDatos()

            emplea.Nombre = Request.Form("nombre").ToString

            emplea.Apellido = Request.Form("apellido").ToString

            emplea.Dpi = Request.Form("dpi").ToString

            emplea.Nit = Request.Form("nit").ToString

            emplea.Edad = Request.Form("edad").ToString

            emplea.Nacionalidad = Request.Form("nacionalidad").ToString

            emplea.Fecha_Naci = Request.Form("fecha_nac").ToString

            emplea.Telefono = Request.Form("telefono").ToString

            emplea.Sexo = Request.Form("sexo").ToString

            emplea.Estado_Civil = Request.Form("estado_civil").ToString

            Dim p As Integer = pue1.id
            Dim d As Integer = pue1.id_1
            Dim j As Integer = pue1.id_2
            Dim s As Integer = pue1.id_3
            If j > 0 And s > 0 And d > 0 And p > 0 Then

                emplea.Ingresar_Empleado(emplea.Nombre, emplea.Apellido, emplea.Dpi,
                                     emplea.Nit, emplea.Edad, emplea.Nacionalidad,
                                     emplea.Fecha_Naci, emplea.Telefono, emplea.Sexo,
                                         emplea.Estado_Civil, j, s, d, p)
                Return View()

            End If



            Return View("Empleado")


        End Function

        Function MostrarEmpleado() As ActionResult
            Dim mos As New EmpleadoMostrar
            Dim buscar As String


            If Request.Form("buscar") = "" Then
                Return View(mos.EmpleadoDatos(""))
            End If

            buscar = Request.Form("buscar").ToString()
            Return View(mos.EmpleadoDatos(buscar))


        End Function
        ' =============== DEPARTEMENTO 

        Function Departamento() As ActionResult
            Return View()
        End Function

        Function AgregarDepartamento() As ActionResult
            Dim depar As New DepartamentoDatos()

            depar.Nombre_dep = Request.Form("dep_nombre").ToString()
            depar.Funcion_dep = Request.Form("dep_funcion").ToString()


            depar.Ingresar_Departamento(depar.Nombre_dep, depar.Funcion_dep)

            Return View()

        End Function

        Function MostrarDepartamento() As ActionResult

            Dim mos As New DepartamentoMostrar
            Dim buscar As String



            If Request.Form("buscar") = "" Then
                Return View(mos.DepartamentoDatos(""))
            End If

            buscar = Request.Form("buscar").ToString()
            Return View(mos.DepartamentoDatos(buscar))

        End Function

        ' =============== PUESTO
        Function Puesto() As ActionResult
            Return View()
        End Function

        Function AgregarPuesto() As ActionResult

            Dim pues As New PuestoDatos()

            pues.Nombre_pue = Request.Form("pue_nombre").ToString()

            pues.Ingresar_Puesto(pues.Nombre_pue)


            Return View()

        End Function

        Function MostrarPuesto() As ActionResult

            Dim pues As New PuestoMostrar

            Dim buscar As String



            If Request.Form("buscar") = "" Then
                Return View(pues.PuestoDatos(""))
            End If

            buscar = Request.Form("buscar").ToString()
            Return View(pues.PuestoDatos(buscar))



        End Function

        '==========REPORTE

        Function Reporte() As ActionResult
            Return View()
        End Function

        Function ReporteED() As ActionResult

            Dim RED As New ReporteEDMostrar

            Dim buscar As String



            If Request.Form("buscar") = "" Then
                Return View(RED.ReporteEDDatos(""))
            End If

            buscar = Request.Form("buscar").ToString()
            Return View(RED.ReporteEDDatos(buscar))




            Return View()
        End Function

        Function ReporteFE() As ActionResult

            Dim RED As New ReporteFEMostrar

            Dim buscar As String



            If Request.Form("buscar") = "" Then
                Return View(RED.ReporteFEDatos(""))
            End If

            buscar = Request.Form("buscar").ToString()
            Return View(RED.ReporteFEDatos(buscar))




            Return View()
        End Function


        '==========Gestion de catalogo
        Function Catalogo() As ActionResult
            Return View()
        End Function

        '==========Asignacion
        Function Nomina() As ActionResult
            Return View()
        End Function


    End Class
End Namespace