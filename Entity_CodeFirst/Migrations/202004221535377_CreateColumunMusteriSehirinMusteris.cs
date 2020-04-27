namespace Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateColumunMusteriSehirinMusteris : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MusteriSehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "MusteriSehir");
        }
    }
}
