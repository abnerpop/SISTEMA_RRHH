@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="Catalogo">

        <h5 class="display-5 ">Gestion de catalogo</h5>
    </a>
</nav>

<ul class="nav justify-content-center">
    <li class="nav-item">
        <a class="nav-link" href="Empleado">Empleado</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="Departamento">Departamentos</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="Puesto">Puestos</a>
    </li>

</ul>






@Code
    Html.RenderPartial("Fooder")
End Code
