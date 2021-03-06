﻿Imports System
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
    Public Class HotelsController
        Inherits System.Web.Mvc.Controller

        Private db As New SitosyHotelesContext

        ' GET: Hotels
        Function Index() As ActionResult
            Return View(db.Hotels.ToList())
        End Function

        ' GET: Hotels/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hotel As Hotel = db.Hotels.Find(id)
            If IsNothing(hotel) Then
                Return HttpNotFound()
            End If
            Return View(hotel)
        End Function


        ' GET: Hotels/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Hotels/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        Function Create(<Bind(Include:="Id,Nombre,Pais,Costo,Lugar,Especialidad,Idioma,Clasificacion,Caracteristicas,Imagen")> ByVal hotel As Hotel, image As HttpPostedFileBase) As ActionResult
            If ModelState.IsValid Then
                If image IsNot Nothing Then
                    hotel.Imagen = image.FileName
                    image.SaveAs(Server.MapPath("~/Img/" + image.FileName))
                End If
                db.Hotels.Add(hotel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hotel)
        End Function

        'Public Function GetThumbnailImage(IdHotel As Integer) As FileContentResult
        '    Dim hotel As Hotel = db.Hotels.FirstOrDefault(Function(p) p.Id = IdHotel)
        '    If hotel IsNot Nothing Then
        '        Return File(art.ArtworkThumbnail, art.ImageMimeType.ToString())
        '    Else
        '        Return Nothing
        '    End If
        'End Function

        ' GET: Hotels/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hotel As Hotel = db.Hotels.Find(id)
            If IsNothing(hotel) Then
                Return HttpNotFound()
            End If
            ViewBag.Imagen = hotel.Imagen
            Return View(hotel)
        End Function

        ' POST: Hotels/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        Function Edit(<Bind(Include:="Id,Nombre,Pais,Costo,Lugar,Especialidad,Idioma,Clasificacion,Caracteristicas,Imagen")> ByVal hotel As Hotel, image As HttpPostedFileBase) As ActionResult
            If ModelState.IsValid Then
                If image IsNot Nothing Then
                    hotel.Imagen = image.FileName
                    image.SaveAs(Server.MapPath("~/Img/" + image.FileName))
                End If
                db.Entry(hotel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hotel)
        End Function

        ' GET: Hotels/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hotel As Hotel = db.Hotels.Find(id)
            If IsNothing(hotel) Then
                Return HttpNotFound()
            End If
            Return View(hotel)
        End Function

        ' POST: Hotels/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim hotel As Hotel = db.Hotels.Find(id)
            db.Hotels.Remove(hotel)
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
