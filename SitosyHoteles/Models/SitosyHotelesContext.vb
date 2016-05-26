Imports System.Data.Entity

Namespace Models
    
    Public Class SitosyHotelesContext
        Inherits DbContext
    
        ' You can add custom code to this file. Changes will not be overwritten.
        ' 
        ' If you want Entity Framework to drop and regenerate your database
        ' automatically whenever you change your model schema, please use data migrations.
        ' For more information refer to the documentation:
        ' http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        Public Sub New()
            MyBase.New("name=SitosyHotelesContext")
        End Sub
    
        Public Property Hotels As System.Data.Entity.DbSet(Of Hotel)
        Public Property Usuarios As System.Data.Entity.DbSet(Of Usuario)
        Public Property Reservas As System.Data.Entity.DbSet(Of Reserva)
    End Class
    
End Namespace
