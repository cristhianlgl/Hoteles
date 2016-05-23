Public Class Hotel

    Private miId As Integer
    Public Property Id() As Integer
        Get
            Return miId
        End Get
        Set(ByVal value As Integer)
            miId = value
        End Set
    End Property

    Private miNombre As String
    Public Property Nombre() As String
        Get
            Return miNombre
        End Get
        Set(ByVal value As String)
            miNombre = value
        End Set
    End Property

    Private miPais As String
    Public Property Pais() As String
        Get
            Return miPais
        End Get
        Set(ByVal value As String)
            miPais = value
        End Set
    End Property

    Private miCosto As Integer
    Public Property Costo() As Integer
        Get
            Return miCosto
        End Get
        Set(ByVal value As Integer)
            miCosto = value
        End Set
    End Property

    Private miLugar As String
    Public Property Lugar() As String
        Get
            Return miLugar
        End Get
        Set(ByVal value As String)
            miLugar = value
        End Set
    End Property

    Private miEspecialidad As String
    Public Property Especialidad() As String
        Get
            Return miEspecialidad
        End Get
        Set(ByVal value As String)
            miEspecialidad = value
        End Set
    End Property

    Private miIdioma As String
    Public Property Idioma() As String
        Get
            Return miIdioma
        End Get
        Set(ByVal value As String)
            miIdioma = value
        End Set
    End Property

    Private miClasiicacion As String
    Public Property Clasificacion() As String
        Get
            Return miClasiicacion
        End Get
        Set(ByVal value As String)
            miClasiicacion = value
        End Set
    End Property

    Private miCaracteristicas As String
    Public Property Caracteristicas() As String
        Get
            Return miCaracteristicas
        End Get
        Set(ByVal value As String)
            miCaracteristicas = value
        End Set
    End Property

    Private miImagen As String
    Public Property Imagen() As String
        Get
            Return miImagen
        End Get
        Set(ByVal value As String)
            miImagen = value
        End Set
    End Property


End Class
