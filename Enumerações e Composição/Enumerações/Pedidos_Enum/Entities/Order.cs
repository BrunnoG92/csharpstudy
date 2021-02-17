using System;
using Pedidos_Enum.Entities.Enums;

namespace Pedidos_Enum.Entities
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ID
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
