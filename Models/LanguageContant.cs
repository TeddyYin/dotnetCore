using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class LanguageContant
    {
        [Key]
        public Guid ID { get; set; }
        public LanguageList Language { get; set; }
        public LanguageDescription Description { get; set; }
        public LanguageRecord Record { get; set; }
        public string Value { get; set; }
    }
}
