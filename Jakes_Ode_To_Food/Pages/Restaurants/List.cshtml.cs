using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Jakes_Ode_To_Food.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _config;
        public string Message { get; set; }

        public ListModel(IConfiguration config)
        {
            this._config = config;
        }

        public void OnGet()
        {
            Message = _config["Message"];
        }
    }
}
