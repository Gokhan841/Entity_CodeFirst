namespace Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateColumnKategoriDetayinKategoris : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategorilers", "KategoriDetay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategorilers", "KategoriDetay");
        }
    }
}
