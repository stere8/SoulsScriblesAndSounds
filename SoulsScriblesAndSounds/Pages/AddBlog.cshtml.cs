using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoulsScribblesAndSounds.Models;

namespace SoulsScribblesAndSounds.Pages.AddBlog 
{
    public class AddBlogModel : PageModel 
    {
        private readonly BlogDbContext _context; // Replace 'BlogDbContext' with your database context class name

        public AddBlogModel(BlogDbContext db)
        {
            _context = db;
        }

        [BindProperty]
        public BlogPost blogPost { get; set; } = new BlogPost(); 

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page(); // Return the page with validation errors if the model isn't valid
            //}

            var blogPostToAdd = new BlogPost()
            {
                Content = blogPost.Content,
                Date = DateTime.Now,
                Title = blogPost.Title,
                PictureUrl = "",
                MusicUrl = "",
            };

            _context.BlogPosts.Add(blogPostToAdd);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ListPosts"); // Redirect to the blog posts listing page
        }
    }
}