Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addImagen
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Hotels", "Imagen", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Hotels", "Imagen")
        End Sub
    End Class
End Namespace
