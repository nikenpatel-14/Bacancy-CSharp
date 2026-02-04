using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay3Assignment.Models
{
    class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }

    class OrderItem
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
