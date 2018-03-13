using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer.Models.Cars
{
    public class Configuration
    {
        public int Id { get; set; }
        public Model SelectedModel { get; set; }
        public Engine SelectedEngine { get; set; }
        public BodyType SelectedBodyType { get; set; }
        public virtual decimal Price
        {
            get
            {
                decimal overallPrice = SelectedModel.Price + SelectedEngine.Price;
                return overallPrice;
            }
        }
        public string Name
        {
            get
            {
                return $"{SelectedModel.Name} {SelectedBodyType.ToString()}";
            }
        }
    }
}
