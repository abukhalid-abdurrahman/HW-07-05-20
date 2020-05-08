namespace Day_19.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddArticleToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArticleName = c.String(),
                        ArticleBody = c.String(),
                        ArticleDate = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
