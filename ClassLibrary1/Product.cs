using SharedLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Title must be between {1} and {2} character in length.")]
        [Column(TypeName = "nvarchar(200)")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "Description must be between {1} and {2} character in length.")]
        [Column(TypeName = "nvarchar(1000)")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a image link")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Please enter a price")]
        public int Price { get; set; }

        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public  List<OrderDetail> OrderDetail { get; set; }
    }
}
