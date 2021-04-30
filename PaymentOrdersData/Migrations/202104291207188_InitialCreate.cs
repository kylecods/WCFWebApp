namespace PaymentOrdersData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentOrder",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrigConID = c.String(),
                        PaymentNotes = c.String(),
                        RemitterID = c.Int(nullable: false),
                        TransactionID = c.Int(nullable: false),
                        RecipientID = c.Int(nullable: false),
                        Remitter_Name = c.String(),
                        Remitter_Address = c.String(),
                        Remitter_PhoneNumber = c.String(),
                        Remitter_IdType = c.String(),
                        Remitter_IdNo = c.String(),
                        Remitter_Country = c.String(),
                        Remitter_ccy = c.Int(nullable: false),
                        Remitter_Financial = c.String(),
                        Remitter_Funds = c.String(),
                        Remitter_principalActivity = c.String(),
                        Recipient_Name = c.String(),
                        Recipient_Address = c.String(),
                        Recipient_Email = c.String(),
                        Recipient_PhoneNumber = c.String(),
                        Recipient_MCC = c.Int(nullable: false),
                        Recipient_IdType = c.String(),
                        Recipient_IdNo = c.String(),
                        Recipient_ccy = c.Int(nullable: false),
                        Recipient_Financial = c.String(),
                        Recipient_Purpose = c.String(),
                        Recipient_InstitutionID = c.String(),
                        Recipient_PriAcc = c.String(),
                        Transaction_routeID = c.String(),
                        Transaction_Amount = c.Int(nullable: false),
                        Transaction_Reference = c.String(),
                        Transaction_SystemTraceANO = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentOrder");
        }
    }
}
