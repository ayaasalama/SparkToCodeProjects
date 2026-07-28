using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceTask.models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName {  get; set; }
        public double ProductPrice { get; set; }

        // belongs_to 
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // orderproduct
        public List<OrderProduct> orderProducts { get; set; }

    }
}
