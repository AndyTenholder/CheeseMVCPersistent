using CheeseMVC.Data;
using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }

        // foreign key to represent Category of cheese
        public int CategoryID { get; set; }
        // Navigation Prop that corresponds to Category ID
        public CheeseCategory Category { get; set; }

        public IList<CheeseMenu> CheeseMenus { get; set; }
    }
}
