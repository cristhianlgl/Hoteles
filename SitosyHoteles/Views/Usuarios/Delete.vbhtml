@ModelType SitosyHoteles.Usuario
@Code
    ViewData("Title") = "Eliminar"
End Code

<h2>Eliminar</h2>

<h3>¿Esta seguro que desea eliminar este Usuario?</h3>
<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Identificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Identificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombres)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombres)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Apellidos)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Apellidos)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaNacimiento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaNacimiento)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telefono)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
             <input type="submit" value="Eliminar" class="btn btn-danger" /> |
            @Html.ActionLink("Volver a la lista", "Index")
        </div>
    End Using
</div>
