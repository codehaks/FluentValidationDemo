using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationDemo.Data
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }
    }

    public class BookValidation: AbstractValidator<Book>
    {
        public BookValidation()
        {
            RuleFor(u => u.Name).NotEmpty().WithMessage("Name is required.");

            RuleFor(u => u.Year).NotEmpty().WithMessage("Year is required.")
                .InclusiveBetween(2010, 2021).WithMessage("Year must be between 2010 and 2021 ");

            RuleFor(u => u.Price).NotEmpty().WithMessage("Price is required.")
              .InclusiveBetween(1, 1000).WithMessage("Price must be between $1 and $1000 ");
        }
    }
}
