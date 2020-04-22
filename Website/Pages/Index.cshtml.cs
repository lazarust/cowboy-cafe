/*
 * Author: Thomas Lazarus
 */
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Sets properties when form is submitted
        /// </summary>
        /// <param name="CaloriesMax"></param>
        /// <param name="CaloriesMin"></param>
        /// <param name="PriceMin"></param>
        /// <param name="PriceMax"></param>
        public void OnGet(int? CaloriesMax, int? CaloriesMin, double? PriceMin, double? PriceMax)
        {
            this.CaloriesMax = CaloriesMax;
            this.CaloriesMin = CaloriesMin;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            SearchTerms = Request.Query["SearchTerms"];
            ItemTypes = Request.Query["ItemTypes"];

            EntreeItems = Menu.Search(EntreeItems, SearchTerms, "Entree");
            SideItems = Menu.Search(SideItems, SearchTerms, "Side");
            DrinkItems = Menu.Search(DrinkItems, SearchTerms, "Drink");

            EntreeItems = Menu.FilterByCategory(EntreeItems, ItemTypes, "Entree");
            SideItems = Menu.FilterByCategory(SideItems, ItemTypes, "Side");
            DrinkItems = Menu.FilterByCategory(DrinkItems, ItemTypes, "Drink");

            EntreeItems = Menu.FilterByCalories(EntreeItems, CaloriesMin, CaloriesMax);
            SideItems = Menu.FilterByCalories(SideItems, CaloriesMin, CaloriesMax);
            DrinkItems = Menu.FilterByCalories(DrinkItems, CaloriesMin, CaloriesMax);

            EntreeItems = Menu.FilterByPrice(EntreeItems, PriceMin, PriceMax);
            SideItems = Menu.FilterByPrice(SideItems, PriceMin, PriceMax);
            DrinkItems = Menu.FilterByPrice(DrinkItems, PriceMin, PriceMax);

        }

        /// <summary>
        /// The current search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The filtered item types 
        /// </summary>
        [BindProperty]
        public string[] ItemTypes { get; set; } = { "Entree", "Side", "Drink" };

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The miniumum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// IEnumberable for the entrees
        /// </summary>
        public IEnumerable<IOrderItem> EntreeItems { get; protected set; } = Menu.Entrees();

        /// <summary>
        /// IEnumberable for the sides
        /// </summary>
        public IEnumerable<IOrderItem> SideItems { get; protected set; } = Menu.Sides();

        /// <summary>
        /// IEnumberable for the drinks
        /// </summary>
        public IEnumerable<IOrderItem> DrinkItems { get; protected set; } = Menu.Drinks();

    }
}
