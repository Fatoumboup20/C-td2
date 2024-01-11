public class Personne
{
    public string Prenom { get; set; }
    public string Nom { get; set; }
    public int Age { get; set; }

    public Personne() { }

    public Personne(string prenom, string nom, int age)
    {
        Prenom = prenom;
        Nom = nom;
        Age = age;
    }
}
