using System;
using System.Collections.Generic;
using BaltaStore.Domain.StoreContext.Enums;

namespace BaltaStore.Domain.StoreContext.Entites
{
    public class Order
    {

        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            Items = new List<OrderItem>();
            Delivery = new List<Delivery>();
        }
        public Customer Customer { get;  private set; }
        public string Number { get;  private set; }
        public DateTime CreateDate { get;  private set; }
        public EOrderStatus Status { get;  private set; }
        public IReadOnlyCollection<OrderItem> Items { get;  private set; }
        public IList<Delivery> Delivery { get;  private set; }

        public void AddItem(OrderItem item){

        }

        public void Place(){ }
        
    }
}
