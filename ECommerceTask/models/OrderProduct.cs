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
        [ForeignKey("product")]
        public int ProductId { get; set; }
        public Product product { get; set; }

        [ForeignKey("order")]
        public int OrderId { get; set; }
        public Order order { get; set; }

        public int Quantity { get; set; }

    }
}
