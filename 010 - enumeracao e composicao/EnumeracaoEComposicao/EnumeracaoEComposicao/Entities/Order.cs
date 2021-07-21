using System;
using System.Collections.Generic;
using System.Text;
using EnumeracaoEComposicao.Entities.Enums;

namespace EnumeracaoEComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; }
        public Client Client { get; set; }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }
        public double Total()
        {
            double total = 0.0;
            foreach(OrderItem item in Itens)
            {
                total += item.Product.Price;
            }
            return total;
        }
    }
}
