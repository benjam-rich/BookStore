using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;
        public NavigationMenuViewComponent (IBookRepository r)
        {
            repository = r;
        }

        //This allows the database to be filtered by category
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCat = RouteData?.Values["category"];
            //Basically a SQL script to select only the distinct items by category
            return View(repository.Books
                .Select(x => x.Cat)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
