using System;

namespace BaltaStore.Domain.StoreContext.Entites
{
    public class OrderItem
    {
        public OrderItem(Product product, Decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;
        }
        public Product Product { get; private set; }
        public Decimal Quantity { get; private set; }
        public Decimal Price { get; private set; }
    }
}
