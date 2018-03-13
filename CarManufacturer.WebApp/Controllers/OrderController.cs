using CarManufacturer.Models;
using CarManufacturer.WebApp.Services;
using CarManufacturer.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManufacturer.WebApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrdersService _service;
        public OrderController(IOrdersService service)
        {
            _service = service;
        }

        public ActionResult List(string[] carModels, string[] carBodys, string[] carEngines, int? minQuantity, int? maxQuantity, int? minPrice, int? maxPrice)
        {
            OrdersViewModel model = new OrdersViewModel();
            model.Orders = _service.GetOrders(carModels, carBodys, carEngines,minQuantity, maxQuantity, minPrice, maxPrice);
            model.AvailableModels = _service.GetModels();
            model.AvailableEngines = _service.GetEngines();
            if(Request.IsAjaxRequest())
            {
                return PartialView("_Orders", model);
            }
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Search()
        {
            return View();
        }
    }
}