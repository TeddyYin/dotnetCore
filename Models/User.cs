﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        //[ForeignKey("LanguageList")]
        public LanguageList Language { get; set; }
    }
}
