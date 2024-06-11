using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAPM_Full.Models.EF
{
    [Table("tb_DANHMUC")]
    public class DanhMuc
    {
        public DanhMuc()
        {
            this.MonAns = new HashSet<MonAn>();
        }
        [Key]

        public int maDanhMuc { get; set; }

        [Required(ErrorMessage = "Ten danh muc khong duoc de trong")]
        [StringLength(150)]
        public string tenDanhMuc { get; set; }


        
        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}