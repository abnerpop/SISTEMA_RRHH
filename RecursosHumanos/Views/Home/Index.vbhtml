
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/bundles/jqueryvalunobtrusive")
    @Styles.Render("~/Content/css")
</head>
<body>
    <header>
        <div class="wrap">
            <section class="logo">
                <h1 class="tienda">Recursos</h1>
                <h1>Humanos</h1>
            </section>

            <nav class="menu">
                <a href=""></a>
                <a href="">@Html.ActionLink("FICHA EMPLEADO", "Users")</a>
                <a href="">@Html.ActionLink("NOMINAS MENSUALES", "Users")</a>
                <a href="">@Html.ActionLink("EMPLEADOS POR DEPARTAMENTO", "Users")</a>

            </nav>

        </div>
    </header>





    <div id="header">

        <ul class="nav">
            <li>
                <a href="">Puesto</a>
                <ul>
                    
                    <li>@Html.ActionLink("Mostrar Puesto", "Puesto")</li>
                </ul>
            </li>

            <li>
                <a href="">Departamento</a>

                <ul>
                   
                    <li>@Html.ActionLink("Mostrar Departamentos", "Departamento")</li>
                </ul>
            </li>


            <li>
                <a href="">Empleado</a>

                <ul>
                    
                    <li>@Html.ActionLink("Crear empleado", "Empleado")</li>
                </ul>
            </li>

            <li>
                <a href="">Nominas</a>

                <ul>
                    <li><a href="">Pagos y Descuentos</a></li>
                    <li>@Html.ActionLink("Partidas COntable", "Empleado")</li>
                </ul>
            </li>

        </ul>

    </div>



</body>
</html>
