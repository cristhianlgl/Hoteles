@ModelType IEnumerable(Of SitosyHoteles.Usuario)
@Code
    ViewData("Title") = "Usuarios"
End Code

<h2>Listado de Usuarios</h2>

<div style="margin-bottom: 5px;">
    <a href='@Url.Action("Create", "Usuarios")' class="btn btn-success" role="button"> Crear Nuevo Usuario </a>
</div>

<table class="table table-hover">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Identificacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombres)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellidos)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaNacimiento)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
             <td>
                 @Html.DisplayFor(Function(modelItem) item.Identificacion)
             </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Nombres)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Apellidos)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FechaNacimiento)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Direccion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Telefono)
            </td>
            <td>
                @Html.ActionLink("Editar", "Edit", New With {.id = item.Identificacion}) |
                @Html.ActionLink("Detalles", "Details", New With {.id = item.Identificacion}) |
                @Html.ActionLink("Eliminar", "Delete", New With {.id = item.Identificacion})
            </td>
        </tr>
    Next

</table>
