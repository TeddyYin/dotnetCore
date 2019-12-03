using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class LanguageContant
    {
        [Key]//主鍵
        [Required]//必要欄位=Not Null
        [DisplayName("ID")]//欄位名稱
        public Guid ID { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("語言ID")]//欄位名稱
        public LanguageList Language { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("敘述此翻譯內容ID")]//欄位名稱
        public LanguageDescription Description { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("記錄ID")]//欄位名稱
        public LanguageRecord Record { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("翻譯內容")]//欄位名稱
        public string Value { get; set; }

        [DisplayName("簡稱1")]//欄位名稱
        public string Abbreviation1 { get; set; }

        [DisplayName("簡稱2")]//欄位名稱
        public string Abbreviation2 { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("程式對應Key")]//欄位名稱
        public string Connection { get; set; }
    }
}
