namespace DALCodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airplanes",
                c => new
                    {
                        AirplaneId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TakeoffEffort = c.Single(nullable: false),
                        FuelConsumption = c.Single(nullable: false),
                        AirportId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AirplaneId)
                .ForeignKey("dbo.Airports", t => t.AirportId, cascadeDelete: true)
                .Index(t => t.AirportId);
            
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        AirportId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GPS_Latitude = c.Double(nullable: false),
                        GPS_Longitude = c.Double(nullable: false),
                        GPS_Altitude = c.Double(nullable: false),
                        GPS_HorizontalAccuracy = c.Double(nullable: false),
                        GPS_VerticalAccuracy = c.Double(nullable: false),
                        GPS_Speed = c.Double(nullable: false),
                        GPS_Course = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.AirportId);
            
            CreateTable(
                "dbo.Traveltriprecords",
                c => new
                    {
                        TraveltriprecordId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        DepartureAirportId = c.Int(nullable: false),
                        ArrivalAirportId = c.Int(nullable: false),
                        CustomerAirplaneId = c.Int(nullable: false),
                        Distance = c.Double(nullable: false),
                        FlightTime = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TraveltriprecordId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Airplanes", "AirportId", "dbo.Airports");
            DropIndex("dbo.Airplanes", new[] { "AirportId" });
            DropTable("dbo.Traveltriprecords");
            DropTable("dbo.Airports");
            DropTable("dbo.Airplanes");
        }
    }
}
