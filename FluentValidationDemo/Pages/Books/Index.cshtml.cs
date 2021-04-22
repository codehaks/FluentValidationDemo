using System.Collections.Generic;
using FluentValidationDemo.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace FluentValidationDemo.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookDbContext _db;

        public IndexModel(BookDbContext db)
        {
            _db = db;
        }

        public List<Book> Books { get; set; }

        public void OnGet()
        {
            Books = _db.Books.ToList();
        }
    }
}
