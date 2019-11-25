using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class LanguageContant
    {
        [Key]
        public Guid ID { get; set; }
        public Guid Type { get; set; }
        public Guid Origin { get; set; }
        public string Value { get; set; }
    }
}
