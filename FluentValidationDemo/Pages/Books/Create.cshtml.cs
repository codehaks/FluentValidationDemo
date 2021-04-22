using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidationDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FluentValidationDemo.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookDbContext _db;

        public CreateModel(BookDbContext db)
        {
            _db = db;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(Book);
                _db.SaveChanges();
                return RedirectToPage("./index");
            }

            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
    }
}
