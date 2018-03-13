using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManufacturer.WebApp.Services
{
    public abstract class FilterService
    {
        public List<int> Ids;
        public abstract void DoFiltering<T>(IQueryable<T> queryable); 
    }
}