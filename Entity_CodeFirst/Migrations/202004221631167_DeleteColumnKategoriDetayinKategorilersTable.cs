namespace Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnKategoriDetayinKategorilersTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kategorilers", "KategoriDetay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategorilers", "KategoriDetay", c => c.String());
        }
    }
}
