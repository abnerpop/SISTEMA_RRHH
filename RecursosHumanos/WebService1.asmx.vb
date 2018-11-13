Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Xml

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function

    <WebMethod()>
    Public Function Departamento(Buscar As String) As XmlDocument

        Dim obj As New DepartamentoMostrar()

        Dim list As New List(Of String)

        For Each dato In obj.DepartamentoDatos(Buscar)
            list.Add("<departamento>" + "<nombre>" + dato.NOMBRE_DEP + "</nombre>")
            list.Add("<funcion>" + dato.FUNCION_DEP + "</funcion>" + "</departamento>")
        Next

        Dim value As String = String.Join("", list)

        Dim _xml As String
        _xml = "<departamentos>" + value + "</departamentos>"

        Dim xmldoc As New XmlDocument

        xmldoc.LoadXml(_xml)


        Return xmldoc

    End Function


    <WebMethod()>
    Public Function Empleados(Buscar As String) As XmlDocument

        Dim obj As New EmpleadoMostrar

        Dim list As New List(Of String)

        For Each dato In obj.EmpleadoDatos(Buscar)
            list.Add("<empleado>" + "<nombre>" + dato.NOMBRE + "</nombre>")
            list.Add("<apellido>" + dato.APELLIDO + "</apellido>")
            list.Add("<dpi>" + dato.DPI + "</dpi>")
            list.Add("<nit>" + dato.NIT + "</nit>")
            list.Add("<edad>" + dato.EDAD.ToString + "</edad>")
            list.Add("<nacionalidad>" + dato.NACIONALIDAD + "</nacionalidad>")
            list.Add("<fecha_nacimiento>" + dato.FECHA_NACI + "</fecha_nacimiento>")
            list.Add("<telefono>" + dato.TELEFONO + "</telefono>")
            list.Add("<sexo>" + dato.SEXO + "</sexo>")
            list.Add("<civil>" + dato.CIVIL + "</civil>" + "</empleado>")
        Next

        Dim value As String = String.Join("", list)

        Dim _xml As String
        _xml = "<Empleados>" + value + "</Empleados>"

        Dim xmldoc As New XmlDocument

        xmldoc.LoadXml(_xml)


        Return xmldoc

    End Function




    <WebMethod()>
    Public Function Reporte_Empleado_X_Departamento(buscar As String) As XmlDocument

        Dim reporteED As New ReporteEDMostrar()

        Dim listED As New List(Of String)

        For Each datos In reporteED.ReporteEDDatos(buscar)
            listED.Add("<reporteED>" + "<nombre>" + datos.NOMBRE + "</nombre>")
            listED.Add("<apellido>" + datos.APELLIDO + "</apellido>")
            listED.Add("<dpi>" + datos.DPI + "</dpi>")
            listED.Add("<nit>" + datos.NIT + "</nit>")
            listED.Add("<nombreD>" + datos.NOMBRE_DEPARTAMENTO + "</nombreD>")
            listED.Add("<funcionD>" + datos.FUNCION_DEPARTAMENTO + "</funcionD>" + "</reporteED>")
        Next

        Dim value As String = String.Join("", listED)

        Dim _xml As String
        _xml = "<ReportesED>" + value + "</ReportesED>"

        Dim xmldoc As New XmlDocument

        xmldoc.LoadXml(_xml)


        Return xmldoc

    End Function


End Class