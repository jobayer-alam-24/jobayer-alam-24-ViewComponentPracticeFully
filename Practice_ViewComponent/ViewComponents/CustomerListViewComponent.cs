using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice_ViewComponent.Models;
namespace Practice_ViewComponent.ViewComponents
{
    public class CustomerListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View(Customer.GetCustomerByID(id));
        }
    }
}