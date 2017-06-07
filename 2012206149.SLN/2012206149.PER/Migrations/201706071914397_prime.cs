namespace _2012206149.PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        busId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.busId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        clienteId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.clienteId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        empleadoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.empleadoId);
            
            CreateTable(
                "dbo.Encomiendas",
                c => new
                    {
                        encomiendaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.encomiendaId);
            
            CreateTable(
                "dbo.LugarViajes",
                c => new
                    {
                        lugarviajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.lugarviajeId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        servicioId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.servicioId);
            
            CreateTable(
                "dbo.TipoLugars",
                c => new
                    {
                        tipoLugarId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.tipoLugarId);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        tipoPagoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.tipoPagoId);
            
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        transporteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.transporteId);
            
            CreateTable(
                "dbo.Tripulacions",
                c => new
                    {
                        tripulacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.tripulacionId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        ventaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ventaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ventas");
            DropTable("dbo.Tripulacions");
            DropTable("dbo.Transportes");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoLugars");
            DropTable("dbo.Servicios");
            DropTable("dbo.LugarViajes");
            DropTable("dbo.Encomiendas");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Buses");
        }
    }
}
