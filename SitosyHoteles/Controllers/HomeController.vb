Imports SitosyHoteles.Models
Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Private db As New SitosyHotelesContext

    Function Index() As ActionResult
        Return View(db.Hotels.ToList())
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Esta aplicacion lista hoteles y sitios turisticos creados en una base de datos. Tambien permite crear nuevos Sitios Turisticos o Hoteles"

        Return View()
    End Function

End Class
