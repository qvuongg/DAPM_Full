namespace DAPM_Full.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_DONHANG", "trangThaiHoatDong", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_DONHANG", "trangThaiHoatDong");
        }
    }
}
