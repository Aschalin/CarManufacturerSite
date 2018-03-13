using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer.Models.Cars
{
    public class Model : IConfigurable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Engine> CompatibileEngines { get; set; }
        public List<BodyType> CompatibileBodyTypes { get; set; }
        public List<Accessory> CompatibileAccessories { get; set; }
    }
}
