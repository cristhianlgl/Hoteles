@ModelType SitosyHoteles.Usuario
@Code
    ViewData("Title") = "Detalles"
End Code

<h2>Detalles del Usuario</h2>

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
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.Identificacion}) |
    @Html.ActionLink("Volver a la lista", "Index")
</p>
