using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class LanguageDescription
    {
        [Key]
        [DisplayName("ID")]
        [Description("ID")]
        public Guid ID { get; set; }

        [Required]//必要欄位=Not Null
        [DisplayName("敘述此翻譯內容")]//欄位名稱
        [Description("語言值")]
        public string Description { get; set; }

        //[Required]//必要欄位=Not Null
        [DisplayName("語言ID")]//欄位名稱
        [Description("語言ID")]
        public LanguageList Language { get; set; }
        
        public ICollection<LanguageContant> LanguageContant { get; set; }
    }
}
