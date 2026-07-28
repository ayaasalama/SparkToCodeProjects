using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceTask.models
{
    [PrimaryKey(nameof(ProductId), nameof(OrderId))]
    public class OrderProduct
    {
        [ForeignKey("products")]
        public int ProductId { get; set; }
        public List<Product> products { get; set; }

        [ForeignKey("orders")]
        public int OrderId { get; set; }
        public List<Order> orders { get; set; }

        public int Quantity { get; set; }

    }
}
