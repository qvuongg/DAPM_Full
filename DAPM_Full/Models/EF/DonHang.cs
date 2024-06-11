using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPM_Full.Models.EF
{
    [Table("tb_DONHANG")]
    public class DonHang
    {
        public DonHang()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        public int maDonHang { get; set; }

        public int maND { get; set; }
        public int maNH { get; set; }
        public string diachi { get; set; }
        public DateTime ngayDat { get; set; }
        public bool trangThaiHoatDong { get; set; }

        [ForeignKey("maND")]
        public virtual NguoiDung NguoiDung { get; set; }

        [ForeignKey("maNH")]
        public virtual QuanAn QuanAn { get; set; }

        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
