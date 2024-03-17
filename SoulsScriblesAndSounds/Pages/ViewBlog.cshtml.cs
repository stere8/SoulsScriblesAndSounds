using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoulsScribblesAndSounds.Models;

namespace SoulsScribblesAndSounds.Pages.ViewBlog
{
    public class ViewBlogModel : PageModel
    {
        private readonly BlogDbContext _db;

        public ViewBlogModel(BlogDbContext db)
        {
            _db = db;
        }

        public BlogPost BlogPost { get; set; } = null!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogPost = await _db.BlogPosts.FirstOrDefaultAsync(p => p.Id == id);

            if (BlogPost == null)
            {
                return NotFound();
            }

            return Page(); // Return the Page itself
        }
    }
}