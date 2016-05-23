@ModelType SitosyHoteles.Hotel
@Code
    ViewData("Title") = "Eliminar"
End Code

<h2>Eliminar</h2>

<h3>¿Esta seguro que desea eliminar este Hotel?</h3>
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

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
             <input type="submit" value="Delete" class="btn btn-danger" /> |
            @Html.ActionLink("Volver a la lista", "Index")
        </div>
    End Using
</div>
