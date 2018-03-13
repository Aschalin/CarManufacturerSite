using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarManufacturer.Models;
using CarManufacturer.Models.Cars;

namespace CarManufacturer.WebApp.Services
{
    public class OrdersServiceMock : IOrdersService
    {
        private static List<Order> _orders;
        private static List<Client> _buyers;
        private static List<Accessory> _accesories;
        private static List<Engine> _engines;
        private static List<Model> _models;
        private static List<Configuration> _cars;

        public OrdersServiceMock()
        {
            _buyers = new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "John Smith",
                    Address = "ul.NamedAfterSomething 0, Krakow, Poland"
                },
                new Client
                {
                    Id = 2,
                    Name = "GE Digital",
                    Address = "ul.Życzkowskiego 20, Krakow, Poland"
                },
                new Client
                {
                    Id = 3,
                    Name = "Some Car Salon",
                    Address = "ul.Name 0, Krakow, Poland"
                }
            };
            _accesories = new List<Accessory>
            {
                new Accessory
                {
                    Id = 1,
                    Name = "Heated front seats",
                    Description = "Heaters in front seats",
                    Price = 1250.99m
                },
                new Accessory
                {
                    Id = 2,
                    Name = "Automatic Front windows",
                    Description = "One can open front windows using button",
                    Price = 333.33m
                },
                new Accessory
                {
                    Id = 3,
                    Name = "Automatic Back windows",
                    Description = "One can open back windows using button",
                    Price = 475.95m
                },
                new Accessory
                {
                    Id = 4,
                    Name = "Heated front window",
                    Description = "For Winter time",
                    Price = 799.99m
                },
                new Accessory
                {
                    Id = 5,
                    Name = "Radio",
                    Description = "with usb port and SD card reader",
                    Price = 125.99m
                }
            };
            _engines = new List<Engine>
            {
                new Engine
                {
                    Id=1,
                    Name = "EcoBoost",
                    Capacity = 1.5f,
                    Cylinders = 4,
                    HorsePower = 100,
                    Price = 15000
                },
                new Engine
                {
                    Id=2,
                    Name = "EcoBoost",
                    Capacity = 1.0f,
                    Cylinders = 3,
                    HorsePower = 80,
                    Price = 10000
                },
                new Engine
                {
                    Id=3,
                    Name = "TDI",
                    Capacity = 1.5f,
                    Cylinders = 6,
                    HorsePower = 120,
                    Price = 15000
                },
                new Engine
                {
                    Id=4,
                    Name = "Turbo Charged",
                    Capacity = 2.0f,
                    Cylinders = 8,
                    HorsePower = 180,
                    Price = 30000
                }
            };
            _models = new List<Model>
            {
                new Model
                {
                    Id = 1,
                    Name = "Fokus",
                    Price = 50000,
                    CompatibileAccessories = _accesories,
                    CompatibileBodyTypes = new List<BodyType>
                    {
                        BodyType.Estate,
                        BodyType.HatchBack,
                        BodyType.FastBack
                    },
                    CompatibileEngines = new List<Engine>
                    {
                        _engines[1],
                        _engines[2],
                    }
                },
                new Model
                {
                    Id = 2,
                    Name = "Fiesta",
                    Price = 40000,
                    CompatibileAccessories = new List<Accessory>
                    {
                        _accesories[0],
                        _accesories[1],
                        _accesories[4]
                    },
                    CompatibileBodyTypes = new List<BodyType>
                    {
                        BodyType.Estate,
                        BodyType.HatchBack,
                        BodyType.FastBack
                    },
                    CompatibileEngines = new List<Engine>
                    {
                        _engines[0],
                        _engines[1],
                    }
                },
                new Model
                {
                    Id = 3,
                    Name = "Mustang",
                    Price = 90000,
                    CompatibileAccessories = _accesories,
                    CompatibileBodyTypes = new List<BodyType>
                    {
                        BodyType.Convertible,
                        BodyType.Coupe,
                    },
                    CompatibileEngines = new List<Engine>
                    {
                        _engines[3],
                    }
                }
            };
            _cars = new List<Configuration>
            {
                new Configuration
                {
                    Id = 1,
                    SelectedModel = _models[0],
                    SelectedBodyType = _models[0].CompatibileBodyTypes[0],
                    SelectedEngine = _models[0].CompatibileEngines[0],
                },
                new Configuration
                {
                    Id = 2,
                    SelectedModel = _models[1],
                    SelectedBodyType = _models[1].CompatibileBodyTypes[0],
                    SelectedEngine = _models[1].CompatibileEngines[1],
                },
                new Configuration
                {
                    Id = 3,
                    SelectedModel = _models[0],
                    SelectedBodyType = _models[0].CompatibileBodyTypes[1],
                    SelectedEngine = _models[0].CompatibileEngines[0],
                },
                new Configuration
                {
                    Id = 4,
                    SelectedModel = _models[0],
                    SelectedBodyType = _models[0].CompatibileBodyTypes[1],
                    SelectedEngine = _models[0].CompatibileEngines[1],
                },
                new Configuration
                {
                    Id = 5,
                    SelectedModel = _models[0],
                    SelectedBodyType = _models[0].CompatibileBodyTypes[2],
                    SelectedEngine = _models[0].CompatibileEngines[0],
                },
                new Configuration
                {
                    Id = 6,
                    SelectedModel = _models[0],
                    SelectedBodyType = _models[0].CompatibileBodyTypes[2],
                    SelectedEngine = _models[0].CompatibileEngines[1],
                },
                new Configuration
                {
                    Id = 7,
                    SelectedModel = _models[1],
                    SelectedBodyType = _models[1].CompatibileBodyTypes[0],
                    SelectedEngine = _models[1].CompatibileEngines[0],
                },
                new Configuration
                {
                    Id = 8,
                    SelectedModel = _models[1],
                    SelectedBodyType = _models[1].CompatibileBodyTypes[1],
                    SelectedEngine = _models[1].CompatibileEngines[0],
                },
                new Configuration
                {
                    Id = 9,
                    SelectedModel = _models[1],
                    SelectedBodyType = _models[1].CompatibileBodyTypes[1],
                    SelectedEngine = _models[1].CompatibileEngines[1],
                },
                new Configuration
                {
                    Id = 10,
                    SelectedModel = _models[1],
                    SelectedBodyType = _models[1].CompatibileBodyTypes[2],
                    SelectedEngine = _models[1].CompatibileEngines[1],
                },
                new Configuration
                {
                    Id = 11,
                    SelectedModel = _models[2],
                    SelectedBodyType = _models[2].CompatibileBodyTypes[0],
                    SelectedEngine = _models[2].CompatibileEngines[0],
                },
                new Configuration
                {
                    Id = 12,
                    SelectedModel = _models[2],
                    SelectedBodyType = _models[2].CompatibileBodyTypes[1],
                    SelectedEngine = _models[2].CompatibileEngines[0],
                }
            };
            _orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Buyer = _buyers[0],
                    Car = _cars[11],
                    Quantity = 1,
                    SelectedAccessories = _cars[11].SelectedModel.CompatibileAccessories
                },
                new Order
                {
                    Id = 2,
                    Buyer = _buyers[1],
                    Car = _cars[4],
                    Quantity = 12,
                    SelectedAccessories = _cars[4].SelectedModel.CompatibileAccessories
                },
                new Order
                {
                    Id = 3,
                    Buyer = _buyers[2],
                    Car = _cars[11],
                    Quantity = 1,
                    SelectedAccessories = new List<Accessory>()
                },
                new Order
                {
                    Id = 4,
                    Buyer = _buyers[2],
                    Car = _cars[7],
                    Quantity = 3,
                    SelectedAccessories = new List<Accessory>()
                },
                new Order
                {
                    Id = 5,
                    Buyer = _buyers[2],
                    Car = _cars[7],
                    Quantity = 1,
                    SelectedAccessories = new List<Accessory>
                    {
                        _cars[7].SelectedModel.CompatibileAccessories[0]
                    }
                },
                new Order
                {
                    Id = 6,
                    Buyer = _buyers[2],
                    Car = _cars[3],
                    Quantity = 1,
                    SelectedAccessories = new List<Accessory>
                    {
                        _cars[3].SelectedModel.CompatibileAccessories[3],
                        _cars[3].SelectedModel.CompatibileAccessories[4]
                    }
                }
            };
        }


        public IQueryable<Order> GetOrders(string[] carModels = null, string[] carBodys = null, string[] carEngines = null, int? minQuantity = null, int? maxQuantity = null, int? minPrice = null, int? maxPrice = null)
        {
            return _orders.AsQueryable()
                .Where(o => carModels != null ? carModels.Contains(o.Car.SelectedModel.Id.ToString()) : true)
                .Where(o => carBodys != null ? carBodys.Contains(o.Car.SelectedBodyType.ToString()) : true)
                .Where(o => carEngines != null ? carEngines.Contains(o.Car.SelectedEngine.Id.ToString()) : true)
                .Where(o => minQuantity != null ? minQuantity <= o.Quantity : true)
                .Where(o => maxQuantity != null ? maxQuantity >= o.Quantity : true)
                .Where(o => minPrice != null ? minPrice <= o.OverallPrice : true)
                .Where(o => maxPrice != null ? maxPrice >= o.OverallPrice : true);
        }

        public IQueryable<Model> GetModels()
        {
            return _models.AsQueryable();
        }

        public IQueryable<Engine> GetEngines()
        {
            return _engines.AsQueryable();
        }
    }
}