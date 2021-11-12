using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class CreateProduct
    {
        
        [Required(ErrorMessage = "Please enter a title")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Title must be between {1} and {2} character in length.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Description must be between {1} and {2} character in length.")]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; } = "https://via.placeholder.com/300x300";

        [Required]
        public int Price { get; set; }


    }
}
