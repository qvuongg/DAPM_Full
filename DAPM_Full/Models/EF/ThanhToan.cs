using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAPM_Full.Models.EF
{

    [Table("tb_THANHTOAN")]
    public class ThanhToan
    {
        [Key]
        public int maThanhToan { get; set; }
        public decimal soTien { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public string anhMinhChung { get; set; }
        public int maNH { get; set; }
        [ForeignKey("maNH")]
        public virtual QuanAn QuanAn { get; set; }
    }
}