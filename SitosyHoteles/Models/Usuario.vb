Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Public Class Usuario

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Identificacion As Integer

    <Required(ErrorMessage:="El Nombre es un campo Obligatorio ")>
    <StringLength(60)>
    Public Property Nombres As String

    <Required(ErrorMessage:="Los Apellidos son un campo Obligatorio ")>
    <StringLength(60)>
    Public Property Apellidos As String

    <Display(Name:="Nombre Completo")>
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Nombres + " " + Apellidos
        End Get
    End Property

    <Column(TypeName:="date")>
    <Display(Name:="Fecha de Naciemiento")>
    <DisplayFormat(DataFormatString:="{0:dd-MM-yyyy}", ApplyFormatInEditMode:=True)>
    Public Property FechaNacimiento As Date?

    Public Property Direccion() As String

    Public Property Telefono() As String

    Public Overridable Property Reservas() As ICollection(Of Reserva)

End Class
