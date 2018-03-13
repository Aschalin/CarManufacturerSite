using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer.Models.Cars
{
    public class Engine : IConfigurable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Capacity { get; set; }
        public int HorsePower { get; set; }
        public int Cylinders { get; set; }
        public decimal Price { get; set; }
        public string FullName
        {
            get
            {
                return $"{Capacity}l {HorsePower}HP {Name} V-{Cylinders}";
            }
        }
    }
}
