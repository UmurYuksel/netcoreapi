using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Data
{
    public class Tag
    {
        [Key]
        public string TagSlug { get; set; }
    }
}
