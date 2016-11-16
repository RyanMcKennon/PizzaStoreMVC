using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreMVC.Business.Abstracts
{
    public abstract class AIngredient
    {
        public virtual long IngredientID { get; private set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Quantity { get; set; }

        public AIngredient()
        {
            IngredientID = DateTime.Now.Ticks;
        }

    }
}
