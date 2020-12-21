using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;

namespace Jakes_Ode_To_Food.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        public Restaurant Restaurant { get; set; }   
        public void OnGet(int restaurantId)
        {
            Restaurant = new Restaurant();
            Restaurant.Id = restaurantId;
        }
    }
}
