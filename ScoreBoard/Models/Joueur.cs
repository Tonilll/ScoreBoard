using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ScoreBoard.Models
{
    public class Joueur
    {
        [Required(ErrorMessage = "Il doit avoir un identifiant.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il doit avoir un nom.")]
        [Range(2,20, ErrorMessage = "Le nom doit être composé de 2 à 20 lettre.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Il doit avoir un prénom.")]
        public string Prenom { get; set; }

        [Range(2,4, ErrorMessage = "L'équipe doit contenir entre 2 et 4 lettre.")]
        public string? Equipe { get; set; }
        public string? Telephone { get; set; }

        [Required(ErrorMessage = "Il doit avoir un courriel.")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "Il doit avoir une liste de jeu.")]
        public List<Jeu>? Jeux { get; set; }
    }
}
