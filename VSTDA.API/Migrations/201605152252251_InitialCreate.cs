namespace VSTDA.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoes",
                c => new
                    {
                        ToDoId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoes");
        }
    }
}
