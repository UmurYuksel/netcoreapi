using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Data
{
    public class BlogPost
    {
        [Key]
        public string Slug { get; set; }
        public string PostTitle { get; set; }
        public string PostDescription { get; set; }
        public string PostFooter { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
