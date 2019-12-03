using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class LanguageRecord
    {
        [Key]
        public Guid ID { get; set; }
        public LanguageDescription Description { get; set; }
        public LanguageList Language { get; set; }
        public ICollection<LanguageContant> LanguageContant { get; set; }
    }
}
