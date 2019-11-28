using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class LanguageDescription
    {
        [Key]
        public Guid ID { get; set; }
        public string Description { get; set; }
        public ICollection<LanguageContant> LanguageContant { get; set; }
    }
}
