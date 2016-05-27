Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports SitosyHoteles
Imports SitosyHoteles.Models

Namespace Controllers
    Public Class ReservasController
        Inherits System.Web.Mvc.Controller

        Private db As New SitosyHotelesContext

        ' GET: Reservas
        Function Index() As ActionResult
            Dim reservas = db.Reservas.Include(Function(r) r.LLaveHotel).Include(Function(r) r.LLaveUsuario)
            Return View(reservas.ToList())
        End Function

        ' GET: Reservas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reserva As Reserva = db.Reservas.Find(id)
            If IsNothing(reserva) Then
                Return HttpNotFound()
            End If
            Return View(reserva)
        End Function

        ' GET: Reservas/Create
        Function Create(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim miHotel As Hotel = db.Hotels.Find(id)
            Dim listHotel = (From h In db.Hotels Where h.Id = id Select h).ToList()
            If IsNothing(miHotel) Then
                Return HttpNotFound()
            End If
            ViewBag.Costo = miHotel.Costo
            ViewBag.HotelId = New SelectList(listHotel, "Id", "Nombre")
            ViewBag.UusarioId = New SelectList(db.Usuarios, "Identificacion", "NombreCompleto")
            Return View()
        End Function

        ' POST: Reservas/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Habitacion,Costo,FechaInicio,FechaFin,UusarioId,HotelId")> ByVal reserva As Reserva) As ActionResult
            If ModelState.IsValid Then
                db.Reservas.Add(reserva)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.HotelId = New SelectList(db.Hotels, "Id", "Nombre", reserva.HotelId)
            ViewBag.UusarioId = New SelectList(db.Usuarios, "Identificacion", "Nombres", reserva.UusarioId)
            Return View(reserva)
        End Function

        ' GET: Reservas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reserva As Reserva = db.Reservas.Find(id)
            If IsNothing(reserva) Then
                Return HttpNotFound()
            End If
            Return View(reserva)
        End Function

        ' POST: Reservas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim reserva As Reserva = db.Reservas.Find(id)
            db.Reservas.Remove(reserva)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
