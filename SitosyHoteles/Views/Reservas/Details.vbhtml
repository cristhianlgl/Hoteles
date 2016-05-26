@ModelType SitosyHoteles.Reserva
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Reserva</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.LLaveHotel.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LLaveHotel.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LLaveUsuario.Nombres)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LLaveUsuario.Nombres)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Habitacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Habitacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Costo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Costo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaInicio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaInicio)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaFin)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaFin)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
