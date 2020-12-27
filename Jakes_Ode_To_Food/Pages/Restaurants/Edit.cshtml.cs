using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace Jakes_Ode_To_Food.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IHtmlHelper _htmlHelper;

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public EditModel(IRestaurantData restaurantData, 
                         IHtmlHelper htmlHelper)
        {
            this._restaurantData = restaurantData;
            this._htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = _restaurantData.GetRestaurantById(restaurantId);
            Cuisines = _htmlHelper.GetEnumSelectList<Restaurant.CuisineType>();

            if (Restaurant == null)
                return RedirectToPage("./NotFound");
            
            return Page();
        }

        public IActionResult OnPost()
        {
            _restaurantData.Update(Restaurant);
            _restaurantData.Commit();

            return Page();
        }
    }
}
