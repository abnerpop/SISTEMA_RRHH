@ModelType IEnumerable(Of RecursosHumanos.EmpleadoDatosModel)

@Code
    Html.RenderPartial("Menu")
End Code

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="MostrarEmpleado">

        <h5 class="display-5 ">Mostrar Empleado</h5>
    </a>
</nav>



<form action="../Home/MostrarEmpleado" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="buscar" placeholder="Nombre">
        </div>


    </div>

    <button type="submit" class="btn btn-primary mt-5">Buscar</button>
</form>



    <p>
        @Html.ActionLink("Atras", "Empleado")
    </p>
    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.NOMBRE)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.APELLIDO)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.DPI)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.NIT)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.EDAD)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.NACIONALIDAD)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.FECHA_NACI)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.TELEFONO)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.SEXO)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.CIVIL)
                </th>
                <th></th>
            </tr>
        </thead>
            @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.NOMBRE)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.APELLIDO)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DPI)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.NIT)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.EDAD)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.NACIONALIDAD)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.FECHA_NACI)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.TELEFONO)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.SEXO)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CIVIL)
                </td>
                <td>
                    @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
                </td>
            </tr>
            Next

</table>



@Code
    Html.RenderPartial("Fooder")
End Code


