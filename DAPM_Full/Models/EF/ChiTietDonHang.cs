using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPM_Full.Models.EF
{
    [Table("tb_CHITIETDONHANG")]
    public class ChiTietDonHang
    {
        [Key, Column(Order = 0)]
        public int maDonHang { get; set; }

        [Key, Column(Order = 1)]
        public int maMonAn { get; set; }
        public decimal gia { get; set; }
        public int soLuong { get; set; }

        [ForeignKey("maDonHang")]
        public virtual DonHang DonHang { get; set; }

        [ForeignKey("maMonAn")]
        public virtual MonAn MonAn { get; set; }
  

    }
}
