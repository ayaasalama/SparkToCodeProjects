using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceTask.models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public float Rating { get; set; }
        public string Comment { get; set; }

        // has 
        [ForeignKey("order")]
        public int OrderId { get; set; }
        public Order order { get; set; }
    }
}
