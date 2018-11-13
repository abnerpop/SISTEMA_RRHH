@ModelType IEnumerable(Of RecursosHumanos.PuestoDatosModel)

@Code
    Html.RenderPartial("Menu")
End Code

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="MostrarPuesto">

        <h5 class="display-5 ">Mostrar Puesto</h5>
    </a>
</nav>

<form action="../Home/MostrarPuesto" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="buscar" placeholder="Nombre">
        </div>


    </div>

    <button type="submit" class="btn btn-primary mt-5">Buscar</button>
</form>


    <p>
        @Html.ActionLink("Atras", "Puesto")
    </p>
    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.ID_PUESTO)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.NOMBRE_PUESTO)
                </th>
                <th></th>
            </tr>
        </thead>
            @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.ID_PUESTO)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.NOMBRE_PUESTO)
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
