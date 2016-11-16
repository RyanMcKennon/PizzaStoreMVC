using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Client.DomainModels
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public Phone Phone { get; set; }
        public Email Email { get; set; }
        public List<Order> History { get; set; }
    }
}