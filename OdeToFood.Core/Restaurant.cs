using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OdeToFood.Core
{
    public partial class Restaurant
    {
        //  Id Will be Used As The Unique Reference In The Database
        public int Id { get; set; }

        /// <summary>
        /// General Properties For Restaurant Data. We Want To Track Useful Insights
        /// Such As The Name, Where It Is Based And What Food It Serves To Get Customers
        /// Visiting. 
        /// </summary>
        /// 

        [Required, StringLength(80)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
