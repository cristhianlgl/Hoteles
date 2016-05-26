Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class FechasDeReserva
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Reservas", "FechaInicio", Function(c) c.DateTime(nullable := False, storeType := "date"))
            AddColumn("dbo.Reservas", "FechaFin", Function(c) c.DateTime(nullable := False, storeType := "date"))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Reservas", "FechaFin")
            DropColumn("dbo.Reservas", "FechaInicio")
        End Sub
    End Class
End Namespace
