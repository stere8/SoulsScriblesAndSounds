using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace SoulsScribblesAndSounds.Controllers 
{
    public class SpotifyController : Controller
    {
        public IActionResult Login()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/spotify-callback" }, "Spotify");
        }

        public async Task<IActionResult> Callback() 
        {
            // Handle the OAuth callback, exchange code for tokens, and store them
            // ... (We'll implement this soon) ...
            return RedirectToAction("Index", "AddBlog"); // Redirect back to Add Blog form
        }
    }
}