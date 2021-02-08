using System;
namespace RazorPagesApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Poster { get; set; }
        public string Backdrop { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string ReleaseDate { get; set; }
    }
}
