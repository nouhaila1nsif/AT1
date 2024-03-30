namespace atelier
{
    public class Class1
    {
      namespace Atelier
    {
          Console.WriteLine("Le nom est nouhaila");
        public class Class1
        {
            // Déclaration d'une variable de type string
            private string nom;

            // Constructeur par défaut
            public Class1()
            {
                // Initialisation de la variable nom
                nom = "Inconnu";
            }

            // Méthode pour afficher le nom
            public void AfficherNom()
            {
                Console.WriteLine("Le nom est : " + nom);
            }

            // Méthode pour modifier le nom
            public void ModifierNom(string nouveauNom)
            {
                // Vérification de la longueur du nouveau nom
                if (nouveauNom.Length > 20)
                {
                    Console.WriteLine("Le nom est trop long. Veuillez entrer un nom de 20 caractères maximum.");
                }
                else
                {
                    // Affectation du nouveau nom
                    nom = nouveauNom;
                }
            }
        }
    }

}
}
