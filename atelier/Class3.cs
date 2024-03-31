using System;

namespace Atelier
{
    public class Adresse
    {
        // Attributs privés
        private string rue;
        private string codePostal;
        private string ville;

        // Constructeur par défaut
        public Adresse()
        {
            rue = "Inconnu";
            codePostal = "Inconnu";
            ville = "Inconnu";
        }

        // Constructeur avec paramètres
        public Adresse(string rue, string codePostal, string ville)
        {
            this.rue = rue;
            this.codePostal = codePostal;
            this.ville = ville;
        }

        // Propriétés publiques
        public string Rue
        {
            get { return rue; }
            set { rue = value; }
        }

        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        // Méthode pour afficher les informations de l'adresse
        public void AfficherInformations()
        {
            Console.WriteLine("Rue : " + rue);
            Console.WriteLine("Code postal : " + codePostal);
            Console.WriteLine("Ville : " + ville);
        }
    }
}
