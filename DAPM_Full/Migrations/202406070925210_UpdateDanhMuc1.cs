namespace DAPM_Full.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDanhMuc1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_DANHMUC", "tenDanhMuc", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_DANHMUC", "tenDanhMuc", c => c.String(nullable: false));
        }
    }
}
