using System;
using System.Collections.Generic;

namespace ThePetStopAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public ThePetStopApplicationUser User { get; set; }

        public ICollection<ProductInOrder> ProductInOrders { get; set; }
    }
}
