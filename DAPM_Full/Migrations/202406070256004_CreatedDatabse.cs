namespace DAPM_Full.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDatabse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_CHITIETDONHANG",
                c => new
                    {
                        maDonHang = c.Int(nullable: false),
                        maMonAn = c.Int(nullable: false),
                        gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        soLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.maDonHang, t.maMonAn })
                .ForeignKey("dbo.tb_DONHANG", t => t.maDonHang, cascadeDelete: true)
                .ForeignKey("dbo.tb_MONAN", t => t.maMonAn, cascadeDelete: true)
                .Index(t => t.maDonHang)
                .Index(t => t.maMonAn);
            
            CreateTable(
                "dbo.tb_DONHANG",
                c => new
                    {
                        maDonHang = c.Int(nullable: false, identity: true),
                        maND = c.Int(nullable: false),
                        maNH = c.Int(nullable: false),
                        diachi = c.String(),
                        ngayDat = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.maDonHang)
                .ForeignKey("dbo.tb_NGUOIDUNG", t => t.maND, cascadeDelete: true)
                .ForeignKey("dbo.tb_QUANAN", t => t.maNH, cascadeDelete: true)
                .Index(t => t.maND)
                .Index(t => t.maNH);
            
            CreateTable(
                "dbo.tb_NGUOIDUNG",
                c => new
                    {
                        maND = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        hoten = c.String(),
                        soDT = c.String(),
                        diaChi = c.String(),
                        trangThai = c.Boolean(nullable: false),
                        vaiTro = c.String(),
                    })
                .PrimaryKey(t => t.maND);
            
            CreateTable(
                "dbo.tb_QUANAN",
                c => new
                    {
                        maNH = c.Int(nullable: false, identity: true),
                        maChuQuan = c.Int(nullable: false),
                        ten = c.String(),
                        diachi = c.String(),
                        mota = c.String(),
                    })
                .PrimaryKey(t => t.maNH)
                .ForeignKey("dbo.tb_NGUOIDUNG", t => t.maChuQuan, cascadeDelete: false)
                .Index(t => t.maChuQuan);
            
            CreateTable(
                "dbo.tb_MONAN",
                c => new
                    {
                        maMonAn = c.Int(nullable: false, identity: true),
                        maNH = c.Int(nullable: false),
                        maDanhMuc = c.Int(nullable: false),
                        ten = c.String(),
                        gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        hinhAnh = c.String(),
                    })
                .PrimaryKey(t => t.maMonAn)
                .ForeignKey("dbo.tb_DANHMUC", t => t.maDanhMuc, cascadeDelete: true)
                .ForeignKey("dbo.tb_QUANAN", t => t.maNH, cascadeDelete: false)
                .Index(t => t.maNH)
                .Index(t => t.maDanhMuc);
            
            CreateTable(
                "dbo.tb_DANHMUC",
                c => new
                    {
                        maDanhMuc = c.Int(nullable: false, identity: true),
                        tenDanhMuc = c.String(),
                    })
                .PrimaryKey(t => t.maDanhMuc);
            
            CreateTable(
                "dbo.tb_THANHTOAN",
                c => new
                    {
                        maThanhToan = c.Int(nullable: false, identity: true),
                        soTien = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ngayThanhToan = c.DateTime(nullable: false),
                        anhMinhChung = c.String(),
                        maNH = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.maThanhToan)
                .ForeignKey("dbo.tb_QUANAN", t => t.maNH, cascadeDelete: true)
                .Index(t => t.maNH);
            
            CreateTable(
                "dbo.tb_TAIKHOANNGANHANG",
                c => new
                    {
                        maTaiKhoan = c.Int(nullable: false, identity: true),
                        tenTaiKhoan = c.String(),
                        soTaiKhoan = c.String(),
                        tenNganHang = c.String(),
                        maND = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.maTaiKhoan)
                .ForeignKey("dbo.tb_NGUOIDUNG", t => t.maND, cascadeDelete: true)
                .Index(t => t.maND);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.tb_TAIKHOANNGANHANG", "maND", "dbo.tb_NGUOIDUNG");
            DropForeignKey("dbo.tb_THANHTOAN", "maNH", "dbo.tb_QUANAN");
            DropForeignKey("dbo.tb_QUANAN", "maChuQuan", "dbo.tb_NGUOIDUNG");
            DropForeignKey("dbo.tb_MONAN", "maNH", "dbo.tb_QUANAN");
            DropForeignKey("dbo.tb_MONAN", "maDanhMuc", "dbo.tb_DANHMUC");
            DropForeignKey("dbo.tb_CHITIETDONHANG", "maMonAn", "dbo.tb_MONAN");
            DropForeignKey("dbo.tb_DONHANG", "maNH", "dbo.tb_QUANAN");
            DropForeignKey("dbo.tb_DONHANG", "maND", "dbo.tb_NGUOIDUNG");
            DropForeignKey("dbo.tb_CHITIETDONHANG", "maDonHang", "dbo.tb_DONHANG");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.tb_TAIKHOANNGANHANG", new[] { "maND" });
            DropIndex("dbo.tb_THANHTOAN", new[] { "maNH" });
            DropIndex("dbo.tb_MONAN", new[] { "maDanhMuc" });
            DropIndex("dbo.tb_MONAN", new[] { "maNH" });
            DropIndex("dbo.tb_QUANAN", new[] { "maChuQuan" });
            DropIndex("dbo.tb_DONHANG", new[] { "maNH" });
            DropIndex("dbo.tb_DONHANG", new[] { "maND" });
            DropIndex("dbo.tb_CHITIETDONHANG", new[] { "maMonAn" });
            DropIndex("dbo.tb_CHITIETDONHANG", new[] { "maDonHang" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.tb_TAIKHOANNGANHANG");
            DropTable("dbo.tb_THANHTOAN");
            DropTable("dbo.tb_DANHMUC");
            DropTable("dbo.tb_MONAN");
            DropTable("dbo.tb_QUANAN");
            DropTable("dbo.tb_NGUOIDUNG");
            DropTable("dbo.tb_DONHANG");
            DropTable("dbo.tb_CHITIETDONHANG");
        }
    }
}
