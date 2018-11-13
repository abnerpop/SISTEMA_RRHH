@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="Puesto">

        <h5 class="display-5 ">Puesto</h5>
    </a>
</nav>

<ul class="nav justify-content-center">
    <li class="nav-item">
        <a class="nav-link" href="MostrarPuesto">Buscar</a>
    </li>
 

</ul>



<form action="../Home/AgregarPuesto" method="post">

    <div class="form-row ">
        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="pue_nombre" placeholder="Nombre Puesto">
        </div>
     


    </div>



    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>






@Code
    Html.RenderPartial("Fooder")
End Code
