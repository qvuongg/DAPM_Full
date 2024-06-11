using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAPM_Full.Models.EF
{

    [Table("tb_QUANAN")]
    public class QuanAn
    {
        public QuanAn()
        {
            this.ThanhToans = new HashSet<ThanhToan>();
            this.DonHangs = new HashSet<DonHang>();
            this.MonAns = new HashSet<MonAn>();
        }
        [Key]
        public int maNH { get; set; }

        [ForeignKey("NguoiDung")]
        public int maChuQuan { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string mota { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<MonAn> MonAns { get; set; }

    }
}