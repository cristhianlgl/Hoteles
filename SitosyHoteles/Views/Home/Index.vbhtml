@ModelType IEnumerable(Of SitosyHoteles.Hotel)
@Code
    ViewData("Title") = "Pagina Principal"
    Dim cont = 1
End Code

<div class="jumbotron">
    <h1>Hoteles Turisticos</h1>
    <p class="lead">Este es un listado completo de nuestros hoteles turisticos, donde encontraras informacion 
    Importante de cada uno de ellos </p>   
</div>
  
<div class="row">
@For Each item In Model
    @<div class="col-md-4">
    <h2>@Html.DisplayFor(Function(modelItem) item.Nombre)</h2>
         <img src="../img/@(item.Imagen).jpg" class="img-thumbnail" height="250" width="350" alt="Imagen">
    <p><b>Pais:</b>@Html.DisplayFor(Function(modelItem) item.Pais) <br/>
    <b>Idioma:</b>@Html.DisplayFor(Function(modelItem) item.Idioma) <br/>
    <b>Costo:</b>@String.Format("{0:c}", item.Costo) <br />
    <b>Clasificacion:</b>@Html.DisplayFor(Function(modelItem) item.Clasificacion)</p>
    <p>@Html.DisplayFor(Function(modelItem) item.Caracteristicas)</p>
    <p><a class="btn btn-info" href='@Url.Action("Details", "Hotels", New With {.id = item.Id})'>Detalles &raquo;</a></p>
    </div>
Next
</div>
