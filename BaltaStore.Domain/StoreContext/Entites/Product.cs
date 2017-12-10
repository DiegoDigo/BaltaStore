using System;

namespace BaltaStore.Domain.StoreContext.Entites
{
    public class Product
    {
        public Product(string title,
                    string description,
                    string image,
                    Decimal price, 
                    Decimal quantity){
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantity;
        }
        public string Title { get; private set; }
        public string Description { get;  private set; }
        public string Image { get; private  set; }
        public Decimal Price { get; private  set; }
        public Decimal QuantityOnHand { get;  private  set; }

        public override string ToString(){
            return Title;
        }
    }
}
