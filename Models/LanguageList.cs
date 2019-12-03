using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class LanguageList
    {
        [Key]
        [DisplayName("ID")]
        [Description("ID")]
        public Guid ID { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "語言名稱")]
        [Description("語言名稱")]
        public string Name { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "語言位置")]
        [Description("語言位置")]
        public string Position { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "程式開發欄位")]
        [Description("程式開發欄位")]
        public string Connection { get; set; }

        [Required]//必要欄位=Not Null
        [StringLength(2, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "狀態")]
        [Description("狀態")]
        public string Status { get; set; }
        
        public ICollection<User> User { get; set; }
        
        public ICollection<LanguageContant> LanguageContant { get; set; }
    }
}
