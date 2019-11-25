using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid Language { get; set; }
    }
}
