namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "transportdb.city",
                c => new
                    {
                        id = c.Int(nullable: false),
                        latitude = c.Int(),
                        longitude = c.Int(),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        picture = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "transportdb.t_planning",
                c => new
                    {
                        id = c.Int(nullable: false),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                        heureDepart = c.DateTime(precision: 0),
                        city_fk = c.Int(),
                        driver_fk = c.Int(),
                        transportationMean_fk = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("transportdb.city", t => t.city_fk)
                .ForeignKey("transportdb.transportationmean", t => t.transportationMean_fk)
                .ForeignKey("transportdb.user", t => t.driver_fk)
                .Index(t => t.city_fk)
                .Index(t => t.driver_fk)
                .Index(t => t.transportationMean_fk);
            
            CreateTable(
                "transportdb.transportationmean",
                c => new
                    {
                        id = c.Int(nullable: false),
                        circulation_date = c.DateTime(precision: 0),
                        fuel = c.String(maxLength: 255, storeType: "nvarchar"),
                        km = c.Int(),
                        mark = c.String(maxLength: 255, storeType: "nvarchar"),
                        model = c.String(maxLength: 255, storeType: "nvarchar"),
                        nmbrPlaces = c.Int(),
                        picture = c.String(maxLength: 255, storeType: "nvarchar"),
                        registrationNumber = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "transportdb.user",
                c => new
                    {
                        id = c.Int(nullable: false),
                        myDType = c.String(nullable: false, maxLength: 31, storeType: "nvarchar"),
                        address = c.String(maxLength: 255, storeType: "nvarchar"),
                        birth_date = c.DateTime(precision: 0),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        mail = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        picture = c.String(maxLength: 255, storeType: "nvarchar"),
                        profession = c.String(maxLength: 255, storeType: "nvarchar"),
                        fax = c.String(maxLength: 255, storeType: "nvarchar"),
                        phoneNumber = c.Int(),
                        drivingLicence = c.Int(),
                        matricule = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "transportdb.message",
                c => new
                    {
                        id = c.Int(nullable: false),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        subject = c.String(maxLength: 255, storeType: "nvarchar"),
                        type = c.String(maxLength: 255, storeType: "nvarchar"),
                        client_fk = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("transportdb.user", t => t.client_fk)
                .Index(t => t.client_fk);
            
            CreateTable(
                "transportdb.t_personaltrans",
                c => new
                    {
                        id = c.Int(nullable: false),
                        arrivalPlace = c.String(maxLength: 255, storeType: "nvarchar"),
                        description = c.String(unicode: false),
                        startPlace = c.String(maxLength: 255, storeType: "nvarchar"),
                        client_fk = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("transportdb.user", t => t.client_fk)
                .Index(t => t.client_fk);
            
            CreateTable(
                "transportdb.t_subscription",
                c => new
                    {
                        id = c.Int(nullable: false),
                        expiration_date = c.DateTime(precision: 0),
                        picture = c.Binary(),
                        price = c.Single(nullable: false),
                        sector = c.Int(),
                        start_date = c.DateTime(precision: 0),
                        titel = c.String(maxLength: 255, storeType: "nvarchar"),
                        typeSub = c.Int(),
                        client_fk = c.Int(),
                        manager_fk = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("transportdb.user", t => t.client_fk)
                .ForeignKey("transportdb.user", t => t.manager_fk)
                .Index(t => t.client_fk)
                .Index(t => t.manager_fk);
            
            CreateTable(
                "transportdb.t_paiement",
                c => new
                    {
                        id = c.Int(nullable: false),
                        codeCVV2 = c.Int(),
                        confidentialCode = c.Int(),
                        numberCarteBancaire = c.Int(),
                        reference = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("transportdb.t_planning", "driver_fk", "transportdb.user");
            DropForeignKey("transportdb.t_subscription", "manager_fk", "transportdb.user");
            DropForeignKey("transportdb.t_subscription", "client_fk", "transportdb.user");
            DropForeignKey("transportdb.t_personaltrans", "client_fk", "transportdb.user");
            DropForeignKey("transportdb.message", "client_fk", "transportdb.user");
            DropForeignKey("transportdb.t_planning", "transportationMean_fk", "transportdb.transportationmean");
            DropForeignKey("transportdb.t_planning", "city_fk", "transportdb.city");
            DropIndex("transportdb.t_subscription", new[] { "manager_fk" });
            DropIndex("transportdb.t_subscription", new[] { "client_fk" });
            DropIndex("transportdb.t_personaltrans", new[] { "client_fk" });
            DropIndex("transportdb.message", new[] { "client_fk" });
            DropIndex("transportdb.t_planning", new[] { "transportationMean_fk" });
            DropIndex("transportdb.t_planning", new[] { "driver_fk" });
            DropIndex("transportdb.t_planning", new[] { "city_fk" });
            DropTable("transportdb.t_paiement");
            DropTable("transportdb.t_subscription");
            DropTable("transportdb.t_personaltrans");
            DropTable("transportdb.message");
            DropTable("transportdb.user");
            DropTable("transportdb.transportationmean");
            DropTable("transportdb.t_planning");
            DropTable("transportdb.city");
        }
    }
}
