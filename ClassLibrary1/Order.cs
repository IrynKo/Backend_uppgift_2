using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public DateTime? DateCreated { get; set; } = DateTime.Now;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    
        
}
}
