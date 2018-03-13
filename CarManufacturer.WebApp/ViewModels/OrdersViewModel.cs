using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManufacturer.Models;
using CarManufacturer.Models.Cars;

namespace CarManufacturer.WebApp.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        public IQueryable<Model> AvailableModels { get; set; }
        public IQueryable<Engine> AvailableEngines { get; set; }

        public OrdersViewModel()
        {
            Title = "TransactionList";
        }
        public IQueryable<Order> Orders { get; set; }
    }
}
