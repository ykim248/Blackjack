using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blackjack.Models;

namespace Blackjack.Controllers
{
    public class BlackjackController : Controller
    {
        // A deck to hold the cards
        private Deck deck;

        // Constructor for the controller
        public BlackjackController()
        {
            deck = new Deck();
            deck.Shuffle();
        }

        // Method to get a card from the deck
        public ActionResult GetCard()
        {
            // Get a card from the deck
            Card card = deck.DrawCard();
            // Return the card to the view
            return View(card);
        }
    }
}

// namespace blackjack_C_.Controllers;

// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController> _logger;

//     public HomeController(ILogger<HomeController> logger)
//     {
//         _logger = logger;
//     }

//     public IActionResult Index()
//     {
//         return View();
//     }

//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }
