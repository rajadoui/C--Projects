using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    // By introducing the interface, we have decoupled the order class from the specific implementation of the notification service
    // allowing different imolementations to be easy substituted without modifying the order class --> it improves the flexibility
    // and maintainability of the code base.
    public class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            //Place order logic ...
            notificationService.SendNotification("Order placed successfully");

        }
    }
}