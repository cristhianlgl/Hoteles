@ModelType SitosyHoteles.Hotel
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Hotel</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Pais)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Pais)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Costo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Costo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Lugar)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Lugar)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Especialidad)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Especialidad)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Idioma)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Idioma)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Clasificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Clasificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Caracteristicas)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Caracteristicas)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Imagen)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Imagen)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
