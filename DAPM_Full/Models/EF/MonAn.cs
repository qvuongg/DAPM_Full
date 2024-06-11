using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPM_Full.Models.EF
{
    [Table("tb_MONAN")]
    public class MonAn
    {
        public MonAn()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        public int maMonAn { get; set; }
        public int maNH { get; set; }
        public int maDanhMuc { get; set; }
        public string ten { get; set; }
        public decimal gia { get; set; }
        public string hinhAnh { get; set; }
        [ForeignKey("maNH")]
        public virtual QuanAn QuanAn { get; set; }

        [ForeignKey("maDanhMuc")]
        public virtual DanhMuc DanhMuc { get; set; }

        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
