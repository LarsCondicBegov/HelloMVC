using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            return "Hello from index in homecontroller";
        }

        public string About()
        {
            return "this is the about page";
        }
        public string Contact()
        {
            return "this is the contact page";
        }
    }
}