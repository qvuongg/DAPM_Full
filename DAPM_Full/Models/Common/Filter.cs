using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAPM_Full.Models.Common
{
    public class Filter
    {
        // Mảng chứa các ký tự có dấu và tương ứng không dấu
        private static readonly string[] VietNamChar = new string[]
        {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
        };

        // Hàm chuyển đổi chuỗi có dấu thành không dấu và thay thế khoảng trắng
        public static string RemoveSignFromVietnameseString(string str)
        {
            // Thay thế các ký tự có dấu bằng không dấu
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                {
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
            }

            // Thay thế khoảng trắng bằng dấu gạch ngang
            str = str.Replace(" ", "-");

            // Thay thế chuỗi "--" thành "-"
            while (str.Contains("--"))
            {
                str = str.Replace("--", "-");
            }

            return str;
        }
    }
}