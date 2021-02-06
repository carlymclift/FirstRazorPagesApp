using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.Forms
{
    public class AddReviewModel : PageModel
    {
        [BindProperty]
        public ReviewModel Review { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
            return RedirectToPage("/Index", new
                {
                    ReviewTitle = Review.ReviewTitle,
                    ReviewerName = Review.ReviewerName,
                    MovieTitle = Review.MovieTitle,
                    Stars = Review.Stars,
                    ReviewBody = Review.ReviewBody
                });

            }

            return Page();
        }
    }
}
