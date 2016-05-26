Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class ReservaUsuario
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Reservas",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Habitacion = c.Int(nullable := False),
                        .Costo = c.Double(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Usuarios",
                Function(c) New With
                    {
                        .Identificacion = c.Int(nullable := False),
                        .Nombres = c.String(nullable := False, maxLength := 60),
                        .Apellidos = c.String(nullable := False, maxLength := 60),
                        .FechaNacimiento = c.DateTime(storeType := "date"),
                        .Direccion = c.String(),
                        .Telefono = c.String(),
                        .Reserva_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Identificacion) _
                .ForeignKey("dbo.Reservas", Function(t) t.Reserva_Id) _
                .Index(Function(t) t.Reserva_Id)
            
            AddColumn("dbo.Hotels", "Reserva_Id", Function(c) c.Int())
            CreateIndex("dbo.Hotels", "Reserva_Id")
            AddForeignKey("dbo.Hotels", "Reserva_Id", "dbo.Reservas", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Usuarios", "Reserva_Id", "dbo.Reservas")
            DropForeignKey("dbo.Hotels", "Reserva_Id", "dbo.Reservas")
            DropIndex("dbo.Usuarios", New String() { "Reserva_Id" })
            DropIndex("dbo.Hotels", New String() { "Reserva_Id" })
            DropColumn("dbo.Hotels", "Reserva_Id")
            DropTable("dbo.Usuarios")
            DropTable("dbo.Reservas")
        End Sub
    End Class
End Namespace
