@ModelType IEnumerable(Of SitosyHoteles.Hotel)
@Code
ViewData("Title") = "Hoteles"
End Code

<h2>Listado de Hoteles</h2>

<div style="margin-bottom: 5px;">
    <a href='@Url.Action("Create", "Hotels")' class="btn btn-success" role="button"> Crear Nuevo Hotel  </a>
</div>

<table class="table  table-hover">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Pais)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Costo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Lugar)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Especialidad)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Idioma)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Clasificacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Caracteristicas)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Imagen)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Nombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Pais)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Costo)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Lugar)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Especialidad)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Idioma)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Clasificacion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Caracteristicas)
            </td>
             <td>
                 @Html.DisplayFor(Function(modelItem) item.Imagen)
             </td>
            <td>
                @Html.ActionLink("Editar", "Edit", New With {.id = item.Id}) |
                @Html.ActionLink("Detalles", "Details", New With {.id = item.Id}) |
                @Html.ActionLink("Eliminar", "Delete", New With {.id = item.Id})
            </td>
        </tr>
    Next

</table>
