Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult

            Return View()
        End Function


        Function Login() As ActionResult

            Return View()
        End Function

        Function EvaluarIndex() As ActionResult
            Dim user, pass As String

            user = Request.Form("usuario").ToString
            pass = Request.Form("password").ToString

            If user = "Abner" And pass = "12345" Then

                Return View("Index")
            Else
                Return View("Login")

            End If


        End Function

        Function Empleado() As ActionResult

            Return View()
        End Function

        Function Ingresar_Empleado() As ActionResult

            Dim EDAD, NIT, TELEFONO As Integer
            Dim NOMBRE, APELLIDO, DPI, NACIONALIDAD, FECHA_NACI, SEXO, CIVIL As String





            EDAD = Convert.ToInt32(Request.Form("edad"))
            NIT = Convert.ToInt32(Request.Form("nit"))
            TELEFONO = Convert.ToInt32(Request.Form("telefono"))

            NOMBRE = Request.Form("nombre").ToString()
            APELLIDO = Request.Form("apellido").ToString()
            DPI = Request.Form("dpi").ToString()
            NACIONALIDAD = Request.Form("nacionalidad").ToString()
            FECHA_NACI = Request.Form("nacimiento").ToString()
            CIVIL = Request.Form("civil").ToString()
            SEXO = Request.Form("sexo").ToString()

            Dim obj1 As New Datos
            obj1.Ingresar_Empleado(NOMBRE, APELLIDO, DPI,
                                      NIT, EDAD, NACIONALIDAD,
                                      FECHA_NACI, TELEFONO, SEXO,
                                      CIVIL)
            Return View()
        End Function

        Function Users() As ActionResult
            Dim obj As New UsersDatos()

            Return View(obj.UserDatos)
        End Function

        Function Departamento() As ActionResult
            Dim obj As New DepartaDatos()

            Return View(obj.DepartaDatos)
        End Function

        Function Puesto() As ActionResult
            Dim obj As New PuestosDatos()

            Return View(obj.PuestosDatos)
        End Function


    End Class
End Namespace