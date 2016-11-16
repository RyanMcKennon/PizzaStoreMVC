using PizzaStoreMVC.Business.Repositories;
using PizzaStoreMVC.Client.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Client.ViewModels
{
    public class PizzaOrderOptions
    {
        [Required]
        [Display(Name = "Your Sauce Options")]
        public List<SelectListItem> Sauces { get; set; }

        [Required]
        [Display(Name = "Your Crust Options")]
        public List<SelectListItem> Crusts { get; set; }
        public List<SelectListItem> Cheeses { get; set; }
        public List<SelectListItem> Sizes { get; set; }
        public List<SelectListItem> Toppings { get; set; }

        public PizzaOrderOptions()
        {
            Sauces = GetSaucesOptions();
            Crusts = new List<SelectListItem>();
            Cheeses = new List<SelectListItem>();
            Sizes = new List<SelectListItem>();
            Toppings = new List<SelectListItem>();
        }

        private List<SelectListItem> GetSaucesOptions()
        {
            var sauces = SauceRepo.GetSauces();
            var sauceOptions = new List<SelectListItem>();

            foreach (var sauce in sauces)
            {
                sauceOptions.Add(new SelectListItem() { Text = sauce.Name, Value = sauce.IngredientID.ToString() });
            }
            return sauceOptions;
        }
    }
}