namespace FootBall_League_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FootBallLeagues", "StausYype");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FootBallLeagues", "StausYype", c => c.Int(nullable: false));
        }
    }
}
