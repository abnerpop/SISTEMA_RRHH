@ModelType IEnumerable(Of RecursosHumanos.DepartaDatosModel)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Departamento</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
        @Html.ActionLink("INICIO", "Index")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.NOMBRE_DEP)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.FUNCION_DEP)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.FECHA_INGRESO)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.NOMBRE_DEP)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FUNCION_DEP)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FECHA_INGRESO)
            </td>
            <td>
                @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
