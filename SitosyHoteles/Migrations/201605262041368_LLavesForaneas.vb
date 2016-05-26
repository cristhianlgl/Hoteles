Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class LLavesForaneas
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Hotels", "Reserva_Id", "dbo.Reservas")
            DropForeignKey("dbo.Usuarios", "Reserva_Id", "dbo.Reservas")
            DropIndex("dbo.Hotels", New String() { "Reserva_Id" })
            DropIndex("dbo.Usuarios", New String() { "Reserva_Id" })
            AddColumn("dbo.Reservas", "UusarioId", Function(c) c.Int(nullable := False))
            AddColumn("dbo.Reservas", "HotelId", Function(c) c.Int(nullable := False))
            CreateIndex("dbo.Reservas", "UusarioId")
            CreateIndex("dbo.Reservas", "HotelId")
            AddForeignKey("dbo.Reservas", "HotelId", "dbo.Hotels", "Id", cascadeDelete := True)
            AddForeignKey("dbo.Reservas", "UusarioId", "dbo.Usuarios", "Identificacion", cascadeDelete := True)
            DropColumn("dbo.Hotels", "Reserva_Id")
            DropColumn("dbo.Usuarios", "Reserva_Id")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Usuarios", "Reserva_Id", Function(c) c.Int())
            AddColumn("dbo.Hotels", "Reserva_Id", Function(c) c.Int())
            DropForeignKey("dbo.Reservas", "UusarioId", "dbo.Usuarios")
            DropForeignKey("dbo.Reservas", "HotelId", "dbo.Hotels")
            DropIndex("dbo.Reservas", New String() { "HotelId" })
            DropIndex("dbo.Reservas", New String() { "UusarioId" })
            DropColumn("dbo.Reservas", "HotelId")
            DropColumn("dbo.Reservas", "UusarioId")
            CreateIndex("dbo.Usuarios", "Reserva_Id")
            CreateIndex("dbo.Hotels", "Reserva_Id")
            AddForeignKey("dbo.Usuarios", "Reserva_Id", "dbo.Reservas", "Id")
            AddForeignKey("dbo.Hotels", "Reserva_Id", "dbo.Reservas", "Id")
        End Sub
    End Class
End Namespace
