using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Models
{
    public class ReviewModel
    {
        [Required(ErrorMessage ="Please include a name so we know who reviewed this movie"),
            MinLength(2)]
        public string ReviewerName { get; set; }
        [Required(ErrorMessage ="You must specify the movie you are reviewing"),
            MinLength(2)]
        public string MovieTitle { get; set; }
        [Required(ErrorMessage ="Give your review a title"),
            MinLength(2)]
        public string ReviewTitle { get; set; }
        public string Stars { get; set; }
        [Required(ErrorMessage ="Please include your review"),
            MinLength(20, ErrorMessage ="Your review must be at least 20 charaters long. Don't be shy! Tell us what you think."),
            MaxLength(300, ErrorMessage ="Your review must be less than 300 charaters.")]
        public string ReviewBody { get; set; }
    }
}
