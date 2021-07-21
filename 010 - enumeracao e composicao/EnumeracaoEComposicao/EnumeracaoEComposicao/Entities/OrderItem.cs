using System;
using System.Collections.Generic;
using System.Text;
using EnumeracaoEComposicao.Entities;

namespace EnumeracaoEComposicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
