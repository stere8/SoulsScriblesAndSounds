using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoulsScribblesAndSounds.Models;

namespace SoulsScribblesAndSounds.Pages.ListBlogs
{
    public class ListBlogsModel : PageModel
    {
        private readonly BlogDbContext _db;

        public ListBlogsModel(BlogDbContext db)
        {
            _db = db;
        }

        public IList<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();


        public async Task OnGetAsync()
        {
            BlogPosts = await _db.BlogPosts.ToListAsync();
        }
    }
}