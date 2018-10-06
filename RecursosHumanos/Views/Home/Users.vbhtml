@ModelType IEnumerable(Of RecursosHumanos.UsersDatosModel)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Users</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
        @Html.ActionLink("INICIO", "Index")
    </p>
    <table class="table">
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
</body>
</html>
