@ModelType SitosyHoteles.Reserva
@Code
    ViewData("Title") = "Detalles"
End Code

<h2>Detalles de la Reservacion</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Hotel
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LLaveHotel.Nombre)
        </dd>

        <dt>
           Usuario 
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
     @Html.ActionLink("Volver al Listado", "Index")
</p>
