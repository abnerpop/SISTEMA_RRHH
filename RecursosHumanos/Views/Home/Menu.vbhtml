<!doctype html>
<html>

@Imports System.Web.Optimization

<head>
    <title></title>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/css2")
</head>
<body>
  
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="">
            <img src="~/Imagenes/Boostrap_logo.svg" width="30" height="30" class="d-inline-block align-top" alt="">
            RECURSOS HUMANO
        </a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse justify-content-center " id="navbarNavAltMarkup">
            <div class="navbar-nav ">
                <a class="nav-item nav-link" href="Menu">Inicio</a>
                <a class="nav-item nav-link" href="Catalogo">Gestion de Catalago</a>
                <a class="nav-item nav-link" href="Nomina">Nomina</a>
                <a class="nav-item nav-link" href="Reporte">Reportes</a>
            </div>
        </div>
    </nav>
