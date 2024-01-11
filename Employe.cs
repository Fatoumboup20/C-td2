public class Employe : Personne
{
    public string NumeroEmploye { get; set; }
    public string Departement { get; set; }

    public Employe() { }

    public Employe(string prenom, string nom, int age, string numeroEmploye, string departement)
        : base(prenom, nom, age)
    {
        NumeroEmploye = numeroEmploye;
        Departement = departement;
    }
}
