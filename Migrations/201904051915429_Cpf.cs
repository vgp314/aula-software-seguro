namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cpf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Cpf", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Cpf");
        }
    }
}
