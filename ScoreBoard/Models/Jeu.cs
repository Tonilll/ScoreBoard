using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ScoreBoard.Models
{
    public class Jeu
    {
        [Required(ErrorMessage = "Il doit avoir un identifiant.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il doit avoir un nom.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Il doit avoir une date.")]
        public DateTime DateSortie { get; set; }

        [Required(ErrorMessage = "Il doit avoir une description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "L'identifiant du joueur est obligatoire.")]
        public int JoueurId { get; set; }

        [Required(ErrorMessage = "Le joueur est requis.")]
        public Joueur Joueur { get; set; }

        [Required(ErrorMessage = "Le score du joueur est obligatoire.")]
        public int ScoreJoueur { get; set; }

        [Required(ErrorMessage = "La date d'enregistrement est obligatoire.")]
        public DateTime DateEnregistrement { get; set; }
    }
}
