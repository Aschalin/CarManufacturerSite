using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer.Models.Cars
{
    public interface IConfigurable
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; }
    }
}
