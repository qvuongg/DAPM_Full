using DAPM_Full.Models.EF;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

public class ApplicationUser : IdentityUser
{
    // Add additional user properties if needed
}

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext()
        : base("DefaultConnection", throwIfV1Schema: false)
    {
    }
    public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
    public DbSet<DanhMuc> DanhMucs { get; set; }
    public DbSet<DonHang> DonHangs { get; set; }
    public DbSet<MonAn> MonAns { get; set; }
    public DbSet<NguoiDung> NguoiDungs { get; set; }
    public DbSet<QuanAn> QuanAns { get; set; }
    public DbSet<TaiKhoanNganHang> TaiKhoanNganHangs { get; set; }
    public DbSet<ThanhToan> ThanhToans { get; set; }

    public static ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }
}
