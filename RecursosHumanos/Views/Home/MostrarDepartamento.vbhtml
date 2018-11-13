@ModelType IEnumerable(Of RecursosHumanos.DepartamentoDatosModel)

@Code
    Html.RenderPartial("Menu")
End Code

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="MostrarDepartamento">

        <h5 class="display-5 ">Mostrar Departamento</h5>
    </a>
</nav>

<form action="../Home/MostrarDepartamento" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="buscar" placeholder="Nombre">
        </div>


    </div>

    <button type="submit" class="btn btn-primary mt-5">Buscar</button>
</form>




<p>
    @Html.ActionLink("Atras", "Departamento")
</p>

    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.NOMBRE_DEP)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.FUNCION_DEP)
                </th>
                <th></th>
            </tr>
        </thead>
            @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.NOMBRE_DEP)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.FUNCION_DEP)
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

