using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class User
    {
        [Key]
        [DisplayName("ID")]//欄位名稱
        [Description("ID")]
        public Guid ID { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "使用者名稱")]
        [Description("使用者名稱")]
        public string Name { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("使用語言")]//欄位名稱
        [Description("使用語言")]
        public LanguageList Language { get; set; }
    }
}
