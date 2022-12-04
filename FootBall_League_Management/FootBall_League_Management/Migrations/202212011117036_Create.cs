namespace FootBall_League_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootBallLeagues",
                c => new
                    {
                        MatchID = c.Int(nullable: false),
                        TeamName1 = c.String(),
                        TeamName2 = c.String(),
                        status = c.String(),
                        winningteam = c.String(),
                        points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FootBallLeagues");
        }
    }
}
