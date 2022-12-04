namespace FootBall_League_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FootBallLeagues", "StausYype", c => c.Int(nullable: false));
            AlterColumn("dbo.FootBallLeagues", "TeamName1", c => c.String(nullable: false));
            AlterColumn("dbo.FootBallLeagues", "TeamName2", c => c.String(nullable: false));
            AlterColumn("dbo.FootBallLeagues", "status", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FootBallLeagues", "status", c => c.String());
            AlterColumn("dbo.FootBallLeagues", "TeamName2", c => c.String());
            AlterColumn("dbo.FootBallLeagues", "TeamName1", c => c.String());
            DropColumn("dbo.FootBallLeagues", "StausYype");
        }
    }
}
