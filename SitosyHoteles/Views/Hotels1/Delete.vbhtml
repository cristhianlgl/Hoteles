@ModelType SitosyHoteles.Hotel
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
