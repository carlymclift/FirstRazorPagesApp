using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string ReviewerName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ReviewTitle { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieTitle { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Stars { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ReviewBody { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ReviewHeader { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(ReviewerName))
            {
                ReviewHeader = "";
            }
            else
            {
                ReviewHeader = "Your Review:";
            }
        }
    }
}
