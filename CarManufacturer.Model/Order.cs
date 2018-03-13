using CarManufacturer.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Configuration Car { get; set; }
        public List<Accessory> SelectedAccessories { get; set; }
        public Client Buyer { get; set; }
        public int Quantity { get; set; }

        public decimal UnitPrice
        {
            get
            {
                decimal unitPrice = Car.Price + SelectedAccessories.Sum(x=> x.Price);
                return unitPrice;
            }
        }

        public decimal OverallPrice {  get { return UnitPrice * Quantity; } }
    }
}
