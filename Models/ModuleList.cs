using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class ModuleList
    {
        [Key]
        [DisplayName("ID")]
        [Description("ID")]
        public Guid ID { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "模組名稱")]
        [Description("模組名稱")]
        public string Name { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "狀態")]
        [Description("狀態")]
        public string Status { get; set; }

        public ICollection<ModuleLanguage> ModuleLanguage { get; set; }
    }
}
