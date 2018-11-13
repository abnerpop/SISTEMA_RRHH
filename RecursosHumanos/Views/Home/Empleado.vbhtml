@Code
    Html.RenderPartial("Menu")
End Code
@ModelType RecursosHumanos.ListasDatos 


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="Empleado">

        <h5 class="display-5 ">Empleado</h5>
    </a>
</nav>

<ul class="nav justify-content-center">
    <li class="nav-item">
        <a class="nav-link" href="MostrarEmpleado">Buscar</a>
    </li>

</ul>



<form action="../Home/AgregarEmpleado" method="post">

    <div class="form-row ">
        <div class="form-group col-md-3">
            <input type="text" class="form-control" name="nombre" placeholder="Nombre">
        </div>
        <div class="form-group col-md-3">
            <input type="text" class="form-control" name="apellido" placeholder="Apellido">
        </div>
        <div class="form-group col-md-3">
            <input type="text" class="form-control" name="dpi" placeholder="DPI">
        </div>
        <div class="form-group col-md-3">
            <input type="text" class="form-control" name="nit" placeholder="Nit">
        </div>
        <div class="form-group col-md-3">
            <input type="text" class="form-control" name="edad" placeholder="Edad">
        </div>
        <div class="form-group col-md-3">
        
            <select class="custom-select my-1 mr-sm-2" id="inlineFormCustomSelectPref" name="nacionalidad">
                <option selected>Nacionalidad</option>
                <option value="Guatemalteco">Guatemalteco</option>
                <option value="Guatemalteca">Guatemalteca</option>

            </select>
        </div>
        <div class="form-group col-md-3">
            <input type="text" class="form-control" name="fecha_nac" placeholder="Fecha Nacimiento">
        </div>
        <div class="form-group col-md-3">
            <input type="text" class="form-control" name="telefono" placeholder="Telefono">
        </div>
        <div class="form-group col-md-3">
            <select class="custom-select my-1 mr-sm-2" id="inlineFormCustomSelectPref" name="sexo">
                <option selected>Sexo</option>
                <option value="Masculino">Masculino</option>
                <option value="Masculino">Femenino</option>
            </select>
        </div>
        <div class="form-group col-md-3">
            <select class="custom-select my-1 mr-sm-2" id="inlineFormCustomSelectPref" name="estado_civil">
                <option selected>estado Civil</option>
                <option value="Soltero">Soltero</option>
                <option value="Soltera">Soltera</option>
                <option value="Casado">Casado</option>
                <option value="Casada">Casada</option>
             
            </select>
        </div>

        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id_3", New SelectList(Model.salarioList, "Value", "Text"), "Salario")
            </div>

        </div>
        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id_2", New SelectList(Model.jornadaList, "Value", "Text"), "Jornada")
            </div>

        </div>

    </div>
     

    <nav class="navbar navbar-dark bg-primary justify-content-center ">
        <a class="navbar-brand" href="Empleado">

            <h5 class="display-5 ">Asignar Empleado a Departamento y Puesto</h5>
        </a>
    </nav>

    <div class="form-row ">
       
        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id", New SelectList(Model.puestoList, "Value", "Text"), "Puestos")
            </div>

        </div>

        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id_1", New SelectList(Model.departamentoList, "Value", "Text"), "Departamento")
            </div>

        </div>

    </div>

 




        <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>












@Code
    Html.RenderPartial("Fooder")
End Code
