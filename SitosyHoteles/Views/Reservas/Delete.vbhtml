@ModelType SitosyHoteles.Reserva
@Code
    ViewData("Title") = "Eliminar"
End Code

<h2>Eliminar Reservacion</h2>

<h3>¿Esta Seguro que desea Eliminar esta Reservacion?</h3>
<div>
    <hr />
    <dl class="dl-horizontal ">
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Eliminar" class="btn btn-danger" /> |
            @Html.ActionLink("Volver al Listado", "Index")
        </div>
    End Using
</div>
