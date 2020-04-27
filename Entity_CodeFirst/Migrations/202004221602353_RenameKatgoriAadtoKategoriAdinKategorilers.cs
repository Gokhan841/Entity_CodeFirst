namespace Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKatgoriAadtoKategoriAdinKategorilers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategorilers", "KategoriAd", c => c.String());
            Sql("Update Kategorilers Set KategoriAd=KategoriAad ");
            DropColumn("dbo.Kategorilers", "KategoriAad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategorilers", "KategoriAad", c => c.String());
            Sql("Update Kategorilers Set KategoriAad=KategoriAd ");
            DropColumn("dbo.Kategorilers", "KategoriAd");
        }
    }
}
