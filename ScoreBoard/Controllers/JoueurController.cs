using Microsoft.AspNetCore.Mvc;
using ScoreBoard.Models;

namespace ScoreBoard.Controllers
{
    public class JoueurController : Controller
    {
        private IJoueurRepository _Joueurs;

        public JoueurController(IJoueurRepository Joeurs)
        {
            _Joueurs = Joeurs;
        }

        public IActionResult Index()
        {
            return View(_Joueurs.ListeJoueurs);
        }
    }
}
