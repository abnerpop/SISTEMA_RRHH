@ModelType IEnumerable(Of RecursosHumanos.ReporteFEDatosModel)


@Code
    Html.RenderPartial("Menu")
End Code

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="ReporteFE">

        <h5 class="display-5 ">Fichas de Empleados</h5>
    </a>
</nav>


<form action="../Home/ReporteFE" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="buscar" placeholder="Nombre">
        </div>


    </div>

    <button type="submit" class="btn btn-primary mt-5">Buscar</button>
</form>




<p>
    @Html.ActionLink("Atras", "Reporte")
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
                    @Html.DisplayNameFor(Function(model) model.EMPRESA)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.DEPARTAMENTO)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.JORNADA)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.HORA_JORNADA)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.PUESTO)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.SALARIO)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.CANTIDAD_SALARIO)
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
                        @Html.DisplayFor(Function(modelItem) item.EMPRESA)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.DEPARTAMENTO)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.JORNADA)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.HORA_JORNADA)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.PUESTO)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.SALARIO)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.CANTIDAD_SALARIO)
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
