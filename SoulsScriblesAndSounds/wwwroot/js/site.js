// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Placeholder: Simulate a logged in state with a variable
let isLoggedIn = false;  // Replace this with real login check later

window.addEventListener('DOMContentLoaded', (event) => {
    const loginButton = document.getElementById('login-spotify-button');
    const searchSection = document.getElementById('search-section');

    function toggleSpotifyElements() {
        if (isLoggedIn) {
            loginButton.style.display = 'none';
            searchSection.style.display = 'block';
        } else {
            loginButton.style.display = 'block';
            searchSection.style.display = 'none';
        }
    }

    // Initial visibility setup on page load
    toggleSpotifyElements();
});

// Write your JavaScript code.
