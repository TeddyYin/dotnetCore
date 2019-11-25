using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class DefaultLanguage
    {
        [Key]
        public Guid ID { get; set; }
        public Guid Type { get; set; }
        public string en_US { get; set; }
        public string zh_TW { get; set; }
    }
}
