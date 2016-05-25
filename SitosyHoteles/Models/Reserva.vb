Imports System
Imports System.Collections.Generic

Public Class Reserva

    Private miID As Integer
    Public Property Id() As Integer
        Get
            Return miID
        End Get
        Set(ByVal value As Integer)
            miID = value
        End Set
    End Property


    Private miUsuario As List(Of Usuario)
    Public Property Usuario() As List(Of Usuario)
        Get
            Return miUsuario
        End Get
        Set(ByVal value As List(Of Usuario))
            miUsuario = value
        End Set
    End Property

    Private miHotel As List(Of Hotel)
    Public Property Hotel() As List(Of Hotel)
        Get
            Return miHotel
        End Get
        Set(ByVal value As List(Of Hotel))
            miHotel = value
        End Set
    End Property

    Private miHabitacion As Integer
    Public Property Habitacion() As Integer
        Get
            Return miHabitacion
        End Get
        Set(ByVal value As Integer)
            miHabitacion = value
        End Set
    End Property

    Private miCosto As Double
    Public Property Costo() As Double
        Get
            Return miCosto
        End Get
        Set(ByVal value As Double)
            miCosto = value
        End Set
    End Property

End Class
