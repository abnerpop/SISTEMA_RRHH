@ModelType IEnumerable(Of RecursosHumanos.PuestosDatosModel)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Puesto</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
        @Html.ActionLink("INICIO", "Index")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.ID_PUESTO)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.NOMBRE_PUESTO)
            </th>
            <th></th>
        </tr>
    
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
</body>
</html>
