@ModelType IEnumerable(Of SitosyHoteles.Reserva)
@Code
ViewData("Title") = "Reservaciones"
End Code

<h2>Listado de Resercaciones</h2>

<table class="table table-hover">
    <tr>
        <th>
            Hotel
        </th>
        <th>
            Usuario
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
                @Html.DisplayFor(Function(modelItem) item.LLaveUsuario.NombreCompleto)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Habitacion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Costo, New With {.woCurrency = True})
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FechaInicio)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.FechaFin)
            </td>
            <td>
                @Html.ActionLink("Detalles", "Details", New With {.id = item.Id}) |
                @Html.ActionLink("Eliminar", "Delete", New With {.id = item.Id})
            </td>
        </tr>
    Next

</table>
