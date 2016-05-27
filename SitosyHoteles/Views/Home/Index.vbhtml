@ModelType IEnumerable(Of SitosyHoteles.Hotel)
@Code
    ViewData("Title") = "Pagina Principal"
    Dim cont = 1
    Dim imagen As String = "0.jgp"
End Code

<div class="jumbotron">
    <h1>Hoteles Turisticos</h1>
    <p class="lead">
        Este es un listado completo de nuestros hoteles turisticos, donde encontraras informacion
        Importante de cada uno de ellos
    </p>
</div>

<div class="row">
    @For Each item In Model
        @<div class="col-md-4">
            <div class="thumbnail">                
                @If item.Imagen Is Nothing Then
                    @<img src="../img/0.jpg" class="img-responsive img-rounded" style="height: 280px; width: 100%; display: block;" alt="Imagen">
        Else
                    @<img src="../img/@(item.Imagen)" class="img-responsive img-rounded" style="height: 280px; width: 100%; display: block;" alt="Imagen">
        End If
                <div class="caption">
                    <h2>@Html.DisplayFor(Function(modelItem) item.Nombre)</h2>
                    <p>
                        <b>Pais:</b>@Html.DisplayFor(Function(modelItem) item.Pais) <br />
                        <b>Idioma:</b>@Html.DisplayFor(Function(modelItem) item.Idioma) <br />
                        <b>Costo:</b>@String.Format("{0:c}", item.Costo) <br />
                        <b>Clasificacion:</b>@Html.DisplayFor(Function(modelItem) item.Clasificacion)
                    </p>
                    <p>@Html.DisplayFor(Function(modelItem) item.Caracteristicas)</p>

                    <a class="btn btn-info" href='@Url.Action("Details", "Hotels", New With {.id = item.Id})'>Detalles &raquo;</a>
                    <a class="btn btn-success" href='@Url.Action("Create", "Reservas", New With {.id = item.Id})'>Reservar &raquo;</a>

                </div>
            </div>
        </div>
    Next
</div>
