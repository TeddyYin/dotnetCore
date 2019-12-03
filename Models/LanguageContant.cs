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
        [DisplayName("ID")]
        [Description("ID")]
        public Guid ID { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("語言ID")]//欄位名稱
        [Description("語言值")]
        public LanguageList Language { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("敘述此翻譯內容ID")]//欄位名稱
        [Description("語言值")]
        public LanguageDescription Description { get; set; }

        //[Required]//必要欄位=Not Null
        //[DisplayName("記錄ID")]//欄位名稱
        //[Description("語言值")]
        //public LanguageRecord Record { get; set; }

        [Required]//必要欄位=Not Null
        [Display(Name = "語言值")]
        [Description("語言值")]
        public string Value { get; set; }

        [Display(Name = "簡稱1")]
        [Description("簡稱1")]
        public string Abbreviation1 { get; set; }

        [Display(Name = "簡稱2")]
        [Description("簡稱2")]
        public string Abbreviation2 { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "程式開發欄位")]
        [Description("程式開發欄位")]
        public string Connection { get; set; }

        public ICollection<ModuleLanguage> ModuleLanguage { get; set; }
    }
}
