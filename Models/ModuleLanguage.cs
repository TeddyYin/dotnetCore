using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class ModuleLanguage
    {
        [Key]
        [DisplayName("ID")]
        [Description("ID")]
        public Guid ID { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("模組ID")]//欄位名稱
        [Description("模組ID")]
        public ModuleList Module { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("語言內容ID")]//欄位名稱
        [Description("語言內容ID")]
        public LanguageContant LanguageContant { get; set; }

        [DisplayName("別名")]//欄位名稱
        [Description("別名")]
        public string Alias { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "狀態")]
        [Description("狀態")]
        public string Status { get; set; }
    }
}
