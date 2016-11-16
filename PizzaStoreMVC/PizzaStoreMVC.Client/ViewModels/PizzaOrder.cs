using PizzaStoreMVC.Client.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Client.ViewModels
{
    public class PizzaOrder
    {
        [Required]
        public PizzaOrderOptions options { get; set; }

        [Required]
        public List<PizzaOrderDetail> Details { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public PizzaOrder()
        {
            options = new PizzaOrderOptions();
            Details = new List<PizzaOrderDetail>();
        }
    }
}