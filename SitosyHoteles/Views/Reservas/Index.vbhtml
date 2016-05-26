@ModelType IEnumerable(Of SitosyHoteles.Reserva)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.LLaveHotel.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LLaveUsuario.Nombres)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Habitacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Costo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaInicio)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaFin)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LLaveHotel.Nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LLaveUsuario.Nombres)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Habitacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Costo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FechaInicio)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FechaFin)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
