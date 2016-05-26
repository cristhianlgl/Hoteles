@ModelType SitosyHoteles.Reserva
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
