@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="Departamento">

        <h5 class="display-5 ">Departamento</h5>
    </a>
</nav>

<ul class="nav justify-content-center">
    <li class="nav-item">
        <a class="nav-link" href="MostrarDepartamento">Buscar</a>
    </li>
   

</ul>


<form action="../Home/AgregarDepartamento" method="post">

    <div class="form-row ">
        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="dep_nombre" placeholder="Nombre Departamento">
        </div>
        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="dep_funcion" placeholder="Funcion Departamento">
        </div>



    </div>



    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>






@Code
    Html.RenderPartial("Fooder")
End Code
