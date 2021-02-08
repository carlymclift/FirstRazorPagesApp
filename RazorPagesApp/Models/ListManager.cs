using System;
using System.Collections.Generic;

namespace RazorPagesApp.Models
{
    public class ListManager
    {
        public static List<Movie> LoadSampleData()
        {
            List<Movie> output = new List<Movie>();

            output.Add(new Movie { Id = 694919, Title = "Money Plane", Backdrop = "https://image.tmdb.org/t/p/original//pq0JSpwyT2URytdFG0euztQPAyR.jpg", Poster = "https://image.tmdb.org/t/p/original//6CoRTJTmijhBLJTUNoVSUNxZMEI.jpg", Rating = 6, ReleaseDate = "2020-09-29" });
            output.Add(new Movie { Id = 337401, Poster = "https://image.tmdb.org/t/p/original//aKx1ARwG55zZ0GpRvU2WrGrCG9o.jpg", Backdrop = "https://image.tmdb.org/t/p/original//zzWGRw277MNoCs3zhyG3YmYQsXv.jpg", Title = "Mulan", Rating = 5, ReleaseDate = "2020-09-04" });
            output.Add(new Movie { Id = 718444, Title = "Rogue", Backdrop = "https://image.tmdb.org/t/p/original//x4UkhIQuHIJyeeOTdcbZ3t3gBSa.jpg", Poster = "https://image.tmdb.org/t/p/original//uOw5JD8IlD546feZ6oxbIjvN66P.jpg", Rating = 6, ReleaseDate = "2020-08-20" });
            output.Add(new Movie { Id = 539885, Title = "Ava", Backdrop = "https://image.tmdb.org/t/p/original//54yOImQgj8i85u9hxxnaIQBRUuo.jpg", Poster = "https://image.tmdb.org/t/p/original//qzA87Wf4jo1h8JMk9GilyIYvwsA.jpg", Rating = 5, ReleaseDate = "2020-07-02" });
            output.Add(new Movie { Id = 581392, Title = "Peninsula", Backdrop = "https://image.tmdb.org/t/p/original//gEjNlhZhyHeto6Fy5wWy5Uk3A9D.jpg", Poster = "https://image.tmdb.org/t/p/original//sy6DvAu72kjoseZEjocnm2ZZ09i.jpg", Rating = 7, ReleaseDate = "2020-07-15" });
            output.Add(new Movie { Id = 726739, Title = "Cats & Dogs 3: Paws Unite", Backdrop = "https://image.tmdb.org/t/p/original//t22fWbzdnThPseipsdpwgdPOPCR.jpg", Poster = "https://image.tmdb.org/t/p/original//4BgSWFMW2MJ0dT5metLzsRWO7IJ.jpg", Rating = 7, ReleaseDate = "2020-10-02" });
            output.Add(new Movie { Id = 627290, Title = "Antebellum", Backdrop = "https://image.tmdb.org/t/p/original//pGqBDYycGWsMYc57sYv5M9GAQoW.jpg", Poster = "https://image.tmdb.org/t/p/original//irkse1FMm9dWemwlxKJ7RINT9Iy.jpg", Rating = 7, ReleaseDate = "2020-09-02" });
            output.Add(new Movie { Id = 613504, Title = "After We Collided", Backdrop = "https://image.tmdb.org/t/p/original//r5srC0cqU36n38azFnCyReEksiR.jpg", Poster = "https://image.tmdb.org/t/p/original//kiX7UYfOpYrMFSAGbI6j1pFkLzQ.jpg", Rating = 5, ReleaseDate = "2020-09-02" });
            output.Add(new Movie { Id = 659986, Title = "The Owners", Backdrop = "https://image.tmdb.org/t/p/original//xUUtcxWC6H48UCrpRwwSPQz69XC.jpg", Poster = "https://image.tmdb.org/t/p/original//gzFatNrw0lhKD5NxaU6zC7S2KjP.jpg", Rating = 5, ReleaseDate = "2020-09-04" });
            output.Add(new Movie { Id = 632618, Title = "The Crimes That Bind", Backdrop = "https://image.tmdb.org/t/p/original//cVdYaAQmd5DZNdo0KFJruz7JpUs.jpg", Poster = "https://image.tmdb.org/t/p/original//sDi6wKgECUjDug2gn4uODSqZ3yC.jpg", Rating = 5, ReleaseDate = "2020-08-20" });
            output.Add(new Movie { Id = 446893, Title = "Trolls World Tour", Backdrop = "https://image.tmdb.org/t/p/original//qsxhnirlp7y4Ae9bd11oYJSX59j.jpg", Poster = "https://image.tmdb.org/t/p/original//7W0G3YECgDAfnuiHG91r8WqgIOe.jpg", Rating = 6, ReleaseDate = "2020-03-12" });
            output.Add(new Movie { Id = 508439, Title = "Onward", Backdrop = "https://image.tmdb.org/t/p/original//xFxk4vnirOtUxpOEWgA1MCRfy6J.jpg", Poster = "https://image.tmdb.org/t/p/original//f4aul3FyD3jv3v4bul1IrkWZvzq.jpg", Rating = 6, ReleaseDate = "2020-02-29" });
            output.Add(new Movie { Id = 479259, Title = "Lost Girls & Love Hotels", Backdrop = "https://image.tmdb.org/t/p/original//wUP0KIAXcRevjjJpoSKT7LLhiaK.jpg", Poster = "https://image.tmdb.org/t/p/original//vQgXwuJrlpzGDI8169tRQRy71Nv.jpg", Rating = 5, ReleaseDate = "2020-09-18" });
            
            return output;
        }
    }
}
