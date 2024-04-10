namespace ScoreBoard.Models
{
    public static class InitialiseurBD
    {
        /*
         ************************************************************
         ************************************************************
         ***   Pris de S9-Entity framework-2 par Maryse Mongeau   ***
         ************************************************************
         ************************************************************
        */

        public static List<Joueur> _listeJoueurs = new List<Joueur>
        {
             new Joueur {  Nom = "Dupont", Prenom = "Jean", Equipe = "AIGL", Telephone = "514-123-4567", Courriel = "jean.dupont@aigles.com",

             },
             new Joueur { Nom = "Tremblay", Prenom = "Lucie", Equipe = "RNRD", Telephone = "450-987-6543", Courriel = "lucie.tremblay@renards.com",

             },
             new Joueur { Nom = "Gagnon", Prenom = "Alexandre", Equipe = "LION", Telephone = "819-345-6789", Courriel = "alexandre.gagnon@lions.com",

             },
             new Joueur {  Nom = "Lapointe", Prenom = "Sophie", Equipe = "TIGR", Telephone = "418-765-4321", Courriel = "sophie.lapointe@tigres.com",

             },
             new Joueur {  Nom = "Nguyen", Prenom = "Kevin", Equipe = "EPRV", Telephone = "514-876-5432", Courriel = "kevin.nguyen@eperviers.com",

             }
        };

        // Dictionnaire dont les clés sont les noms des joueurs 
        // et dont les valeurs sont les objets Joueur. 
        // Je m'en sert pour faire référence à un joeur dans un ingrédient.
        private static Dictionary<string, Joueur> _NomJoueurDict;
        public static Dictionary<string, Joueur> NomJoueurDict
        {
            get
            {
                _NomJoueurDict = new Dictionary<string, Joueur>();
                foreach (Joueur joueur in _listeJoueurs)
                {
                    _NomJoueurDict.Add(joueur.Nom, joueur);
                }

                return _NomJoueurDict;
            }
        }

        public static List<Jeu> _listeJeux = new List<Jeu>
        {
            
            new Jeu {Nom = "The Legend of Zelda: Breath of the Wild", DateSortie = new DateTime(2017, 3, 3), Description = "Jeu d'action-aventure en monde ouvert", JoueurId = 1, ScoreJoueur = 60, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Super Mario Odyssey", DateSortie = new DateTime(2017, 10, 27), Description = "Jeu de plateforme en monde ouvert", JoueurId = 1, ScoreJoueur = 50, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Red Dead Redemption 2", DateSortie = new DateTime(2018, 10, 26), Description = "Jeu d'action-aventure en monde ouvert dans le Far West", JoueurId = 1, ScoreJoueur = 100, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Assassin's Creed Odyssey", DateSortie = new DateTime(2018, 10, 5), Description = "Jeu d'action-aventure en monde ouvert dans la Grèce antique", JoueurId = 2, ScoreJoueur = 100, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "God of War", DateSortie = new DateTime(2018, 4, 20), Description = "Jeu d'action-aventure en monde ouvert inspiré de la mythologie nordique", JoueurId = 2, ScoreJoueur = 30, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Cyberpunk 2077", DateSortie = new DateTime(2020, 12, 10), Description = "Jeu de rôle en monde ouvert futuriste", JoueurId = 3, ScoreJoueur = 70, DateEnregistrement = DateTime.Now},
            new Jeu {Nom = "The Last of Us Part II", DateSortie = new DateTime(2020, 6, 19), Description = "Jeu d'action-aventure et de survie post-apocalyptique", JoueurId = 4,  ScoreJoueur = 100, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Animal Crossing: New Horizons", DateSortie = new DateTime(2020, 3, 20), Description = "Jeu de simulation de vie en monde ouvert", JoueurId = 4, ScoreJoueur = 10, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Doom Eternal", DateSortie = new DateTime(2020, 3, 20), Description = "Jeu de tir à la première personne", JoueurId = 4, ScoreJoueur = 90, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Ghost of Tsushima", DateSortie = new DateTime(2020, 7, 17), Description = "Jeu d'action-aventure en monde ouvert dans le Japon féodal", JoueurId = 5, ScoreJoueur = 100, DateEnregistrement = DateTime.Now },
            new Jeu {Nom = "Hades", DateSortie = new DateTime(2020, 9, 17), Description = "Jeu de rôle d'action roguelike", JoueurId = 5, ScoreJoueur = 40, DateEnregistrement = DateTime.Now }
            
        };


        /// <summary>
        /// Méthode appelée pour ajouter les données initiales aux tables Joeurs et Jeux.
        /// </summary>
        /// <param name="applicationBuilder">Utilisé pour avoir le DbContext.</param>
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            // On ne peut pas utiliser l'injection de dépendances ici, 
            // le DbContext CatalogueGateauxDbContext sera donc récupéré à partir de applicationBuilder.
            CatalogueJoueurDbContext catalogueJoueurDbContext =
                        applicationBuilder.ApplicationServices.CreateScope()
                        .ServiceProvider.GetRequiredService<CatalogueJoueurDbContext>();

            if (!catalogueJoueurDbContext.Joueurs.Any())
            {
                catalogueJoueurDbContext.Joueurs.AddRange(NomJoueurDict.Values);
            }

            catalogueJoueurDbContext.SaveChanges();

            if (!catalogueJoueurDbContext.Jeus.Any())
            {
                catalogueJoueurDbContext.Jeus.AddRange(_listeJeux);
            }

            catalogueJoueurDbContext.SaveChanges();
        }
    }

}
