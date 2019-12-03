using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class ModuleLanguage
    {
        [Key]
        public Guid ID { get; set; }
        public ModuleList Module { get; set; }
        public LanguageContant LanguageContant { get; set; }
        public string Alias { get; set; }
        public string Status { get; set; }
    }
}
