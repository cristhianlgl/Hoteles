Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Inicial
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
                        .Caracteristicas = c.String(),
                        .Imagen = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Reservas",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Habitacion = c.Int(nullable := False),
                        .Costo = c.Double(nullable := False),
                        .FechaInicio = c.DateTime(nullable := False),
                        .FechaFin = c.DateTime(nullable := False),
                        .UusarioId = c.Int(nullable := False),
                        .HotelId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Hotels", Function(t) t.HotelId, cascadeDelete := True) _
                .ForeignKey("dbo.Usuarios", Function(t) t.UusarioId, cascadeDelete := True) _
                .Index(Function(t) t.UusarioId) _
                .Index(Function(t) t.HotelId)
            
            CreateTable(
                "dbo.Usuarios",
                Function(c) New With
                    {
                        .Identificacion = c.Int(nullable := False),
                        .Nombres = c.String(nullable := False, maxLength := 60),
                        .Apellidos = c.String(nullable := False, maxLength := 60),
                        .FechaNacimiento = c.DateTime(),
                        .Direccion = c.String(),
                        .Telefono = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Identificacion)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Reservas", "UusarioId", "dbo.Usuarios")
            DropForeignKey("dbo.Reservas", "HotelId", "dbo.Hotels")
            DropIndex("dbo.Reservas", New String() { "HotelId" })
            DropIndex("dbo.Reservas", New String() { "UusarioId" })
            DropTable("dbo.Usuarios")
            DropTable("dbo.Reservas")
            DropTable("dbo.Hotels")
        End Sub
    End Class
End Namespace
