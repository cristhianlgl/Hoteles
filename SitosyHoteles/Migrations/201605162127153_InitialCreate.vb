Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Hotels",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(),
                        .Pais = c.String(),
                        .Costo = c.Int(nullable := False),
                        .Lugar = c.String(),
                        .Especialidad = c.String(),
                        .Idioma = c.String(),
                        .Clasificacion = c.String(),
                        .Caracteristicas = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Hotels")
        End Sub
    End Class
End Namespace
