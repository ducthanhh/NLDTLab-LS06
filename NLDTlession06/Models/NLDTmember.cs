using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLDTlession06.Models
{
    public class NLDTmember
    {
        // cách 1 và cách 2 ta sửu dụng thuộc tính khai báo như sau
        // public int id { get; set; }
        //public string username { get; set; }
        // public string fullname { get; set; }

        //public string password { get; set; }
        //public int age { get; set; }
        //public string email { get; set; }
        [Required(ErrorMessage ="hay nhap ma so ")]
        [DataType(DataType.Currency)]
        public int id { get; set; }
        [Required(ErrorMessage = "hay nhap ten dang nhap  ")]
        public string username { get; set; }
        [Required(ErrorMessage = "hay nhap ho va ten  ")]
        public string fullname { get; set; }
        [Required(ErrorMessage ="hay nhap mat khau")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "hay nhap tuoi ")]
        [Range(18,50,ErrorMessage ="tuoi tu 18-50")]
        public int age { get; set; }
        [Required(ErrorMessage = "hay nhap email ")]
        [RegularExpression(@"A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage ="email pha dung dinh dang")]
        public string email { get; set; }

    }
}