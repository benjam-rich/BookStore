using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Infastructure;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class BuyModel : PageModel
    {
        private IBookRepository repository;
        //Constructor
        public BuyModel (IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookID, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.BookID == bookID);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(book, 1);
            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookID, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookID == bookID).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
