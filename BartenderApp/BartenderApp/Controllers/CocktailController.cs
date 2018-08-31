using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApp.Models;
namespace BartenderApp.Controllers
{
    public class CocktailController : Controller
    {
     
           
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult OrderOption()
        {
            
            return View();
        }
        [HttpPost]
        public ViewResult OrderOption(CocktailMenu menu)
        {
            
            return View("OrderQueue", menu);
        }
                    
        public ViewResult OrderQueue(CocktailMenu menu)
        {
            return View("OrderQueue", menu);
        }
        
    }
}