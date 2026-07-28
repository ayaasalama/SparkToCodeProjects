using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceTask.models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }


        // placed
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public User Customer { get; set; }

        // has
        public Review review { get; set; }
    }
}
