using System;
using BaltaStore.Domain.StoreContext.Enums;

namespace BaltaStore.Domain.StoreContext.Entites
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            EstimatedDeliveryDate = estimatedDeliveryDate;
            CreateDate = DateTime.Now;
            Status = EDeliveryStatus.waiting;
        }
        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set;}
        public EDeliveryStatus Status { get; private set; }
    }
}

