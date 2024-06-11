using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAPM_Full.Models.EF
{
    [Table("tb_TAIKHOANNGANHANG")]
    public class TaiKhoanNganHang
    {
        [Key]
        public int maTaiKhoan { get; set; }
        public string tenTaiKhoan { get; set; }
        public string soTaiKhoan { get; set; }
        public string tenNganHang { get; set; }
        public int maND { get; set; }

        [ForeignKey("maND")]
        public virtual NguoiDung NguoiDung { get; set; }
    }
}