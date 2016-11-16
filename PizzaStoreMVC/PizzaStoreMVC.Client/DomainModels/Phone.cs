using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC.Client.DomainModels
{
    public class Phone
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Number { get; set; }
    }
}