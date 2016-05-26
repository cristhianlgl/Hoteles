Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Public Class Reserva

    Public Property Id() As Integer

    <Required(ErrorMessage:="Digite el numero de Habitacion")>
    Public Property Habitacion() As Integer

    Public Property Costo() As Double

    <Required(ErrorMessage:="Debe Especificar la Fecha Inical de la Reserva")>
    <Column(TypeName:="date")>
    <Display(Name:="Fecha Inicial")>
    <DisplayFormat(DataFormatString:="{0:dd-MM-yyyy}", ApplyFormatInEditMode:=True)>
    Public Property FechaInicio As Date

    <Required(ErrorMessage:="Debe Especificar la Fecha Final de la Reserva")>
    <Column(TypeName:="date")>
    <Display(Name:="Fecha Final")>
    <DisplayFormat(DataFormatString:="{0:dd-MM-yyyy}", ApplyFormatInEditMode:=True)>
    Public Property FechaFin As Date

    <ForeignKey("LLaveUsuario")>
    <Display(Name:="Usuario")>
    Public Property UusarioId() As Integer
    Public Overridable Property LLaveUsuario() As Usuario

    <ForeignKey("LLaveHotel")>
    <Display(Name:="Hotel")>
    Public Property HotelId() As Integer
    Public Overridable Property LLaveHotel() As Hotel

End Class
