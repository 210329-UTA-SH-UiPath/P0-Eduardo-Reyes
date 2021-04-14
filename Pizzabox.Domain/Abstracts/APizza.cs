using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    /// <summary>
    /// 
    /// </summary>
    [XmlInclude(typeof(CheesePizza))]
    [XmlInclude(typeof(MeatPizza))]
    [XmlInclude(typeof(PepperoniPizza))]
    [XmlInclude(typeof(VeganPizza))]

    public abstract class APizza
    {
        //XmlIgnoreAttribute();
        public string Crust { get; set; }
        public string Size { get; set; }
        public List<Toppings> Toppings { get; set; }

        public string Name { get; set; }

        public decimal PizzaPrice { get; set; }

        public int PizzaId { get; set; }

        public int PizzaLogId { get; set; }





        public virtual void AddCrust(string CrustType)
        {
            Crust = CrustType;
        }


        public abstract void AddToppings(Toppings toppings);

        public abstract void addPrice();

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}