Imports System.ComponentModel.DataAnnotations

Public Class Usuario

    <Key>
    Private miIdentificacion As Integer
    Public Property Identificacion() As Integer
        Get
            Return miIdentificacion
        End Get
        Set(ByVal value As Integer)
            miIdentificacion = value
        End Set
    End Property

    <Required>
    Private misNombres As String
    Public Property Nombres() As String
        Get
            Return misNombres
        End Get
        Set(ByVal value As String)
            misNombres = value
        End Set
    End Property

    <Required>
    Private misApellidos As String
    Public Property Apellidos() As String
        Get
            Return misApellidos
        End Get
        Set(ByVal value As String)
            misApellidos = value
        End Set
    End Property

    Private miFechaNacimiento As DateTime
    Public Property FechaNacimiento() As DateTime
        Get
            Return miFechaNacimiento
        End Get
        Set(ByVal value As DateTime)
            miFechaNacimiento = value
        End Set
    End Property

    Private miDireccion As String
    Public Property Direccion() As String
        Get
            Return miDireccion
        End Get
        Set(ByVal value As String)
            miDireccion = value
        End Set
    End Property

    Private miTelefono As String
    Public Property Telefono() As String
        Get
            Return miTelefono
        End Get
        Set(ByVal value As String)
            miTelefono = value
        End Set
    End Property


End Class
