using System;

namespace Atelier
{
    public class Personne
    {
        // Attributs privés
        private string nom;
        private int age;
        private Adresse adresse;

        // Constructeur par défaut
        public Personne()
        {
            nom = "Inconnu";
            age = 0;
            adresse = new Adresse();
        }

        // Constructeur avec paramètres
        public Personne(string nom, int age, Adresse adresse)
        {
            this.nom = nom;
            this.age = age;
            this.adresse = adresse;
        }

        // Propriétés publiques
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Adresse Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        // Méthode pour afficher les informations de la personne
        public void AfficherInformations()
        {
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Adresse : ");
            adresse.AfficherInformations();
        }
    }
}
