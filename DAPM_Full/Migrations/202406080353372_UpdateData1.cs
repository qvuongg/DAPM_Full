namespace DAPM_Full.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_DANHMUC", "tenDanhMuc", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.tb_CHITIETDONHANG", "Alias");
            DropColumn("dbo.tb_DONHANG", "Alias");
            DropColumn("dbo.tb_NGUOIDUNG", "Alias");
            DropColumn("dbo.tb_QUANAN", "Alias");
            DropColumn("dbo.tb_MONAN", "Alias");
            DropColumn("dbo.tb_DANHMUC", "Alias");
            DropColumn("dbo.tb_THANHTOAN", "Alias");
            DropColumn("dbo.tb_TAIKHOANNGANHANG", "Alias");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_TAIKHOANNGANHANG", "Alias", c => c.String());
            AddColumn("dbo.tb_THANHTOAN", "Alias", c => c.String());
            AddColumn("dbo.tb_DANHMUC", "Alias", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.tb_MONAN", "Alias", c => c.String());
            AddColumn("dbo.tb_QUANAN", "Alias", c => c.String());
            AddColumn("dbo.tb_NGUOIDUNG", "Alias", c => c.String());
            AddColumn("dbo.tb_DONHANG", "Alias", c => c.String());
            AddColumn("dbo.tb_CHITIETDONHANG", "Alias", c => c.String());
            AlterColumn("dbo.tb_DANHMUC", "tenDanhMuc", c => c.String());
        }
    }
}
