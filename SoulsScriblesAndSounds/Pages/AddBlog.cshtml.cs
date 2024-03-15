using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoulsScribblesAndSounds.Models;

namespace SoulsScribblesAndSounds.Pages.AddBlog 
{
    public class AddBlogModel : PageModel 
    {
        private readonly BlogDbContext _db; // Replace 'BlogDbContext' with your database context class name

        public AddBlogModel(BlogDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; } = new BlogPost(); 

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors if the model isn't valid
            }

            BlogPost.Date = DateTime.Now; 

            _db.BlogPosts.Add(BlogPost);
            await _db.SaveChangesAsync();

            return RedirectToPage("./ListPosts"); // Redirect to the blog posts listing page
        }
    }
}