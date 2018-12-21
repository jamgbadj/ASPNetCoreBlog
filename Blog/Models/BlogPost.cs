using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class BlogPost
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required]
        [MinLength(3), MaxLength(60)]
        public string Author { get; set; }

        [Required]
        [MinLength(3), MaxLength(60)]
        public string Title { get; set; }

        [Required]
        public string PostBody { get; set; }

        [Required]
        public DateTime PostedOn { get; set; }
    }
}
