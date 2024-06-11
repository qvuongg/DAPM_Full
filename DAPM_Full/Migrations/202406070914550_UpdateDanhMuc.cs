namespace DAPM_Full.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDanhMuc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_DANHMUC", "tenDanhMuc", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_DANHMUC", "tenDanhMuc", c => c.String());
        }
    }
}
