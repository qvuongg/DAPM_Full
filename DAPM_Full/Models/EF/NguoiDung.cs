using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAPM_Full.Models.EF
{
    [Table("tb_NGUOIDUNG")]
    public class NguoiDung
    {
        public NguoiDung()
        {
            this.DonHangs = new HashSet<DonHang>();
            this.QuanAns = new HashSet<QuanAn>();
            this.TaiKhoanNganHangs = new HashSet<TaiKhoanNganHang>();
        }
        [Key]
        public int maND { get; set; }

        public string email { get; set; }
        public string hoten { get; set; }
        public string soDT { get; set; }
        public string diaChi { get; set; }
        public bool trangThai { get; set; }
        public string vaiTro { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<QuanAn> QuanAns { get; set; }
        public virtual ICollection<TaiKhoanNganHang> TaiKhoanNganHangs { get; set; }
    }
}