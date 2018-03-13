using CarManufacturer.Models;
using CarManufacturer.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManufacturer.WebApp.Services
{
    public interface IOrdersService
    {
        IQueryable<Order> GetOrders(string[] carModels = null, string[] carBody = null, string[] carEngines = null, int? minQuantity = null, int? maxQuantity = null, int? minPrice = null, int? maxPrice = null);
        IQueryable<Model> GetModels();
        IQueryable<Engine> GetEngines();
    }
}