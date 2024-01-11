using System;

class Program
{
    static Employe AjoutEmploye()
    {
        Console.Write("saisir le prenom de l'employe : ");
        string prenom = Console.ReadLine();
        Console.Write("saisir le nom de l'employe : ");
        string nom = Console.ReadLine();
        Console.Write("saisir l age de l'employe : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("saisir le numero de l'employe : ");
        string numeroEmploye = Console.ReadLine();
        Console.Write("saisir le departement de l'employe : ");
        string departement = Console.ReadLine();
        Employe employe = new Employe(prenom, nom, age, numeroEmploye, departement);
        return employe;
    }
    static Employe[] AjoutTableau()
    {
        Console.Write("entrer  le nombre d'employes a saisir: ");
        int nbrEmploye = int.Parse(Console.ReadLine());
        Employe[] tabEmploye = new Employe[nbrEmploye];
        for (int i = 0; i < nbrEmploye; i++)
        {
            Employe employe = AjoutEmploye();
            tabEmploye[i] = employe;
        }
        return tabEmploye;
    }
    static void Main()
    {
        Employe[] employes = AjoutTableau();
        for (int i = 0; i < employes.Length; i++)
        {
            Employe employe = employes[i];
            Console.WriteLine("\nINFORMATIONS DE L'EMPLOYE N:"+i);
            Console.WriteLine("Son prenom:"+employe.Prenom);
            Console.WriteLine("Son nom: "+employe.Nom);
            Console.WriteLine("Son age: "+employe.Age);
            Console.WriteLine("Son numero :"+employe.NumeroEmploye);
            Console.WriteLine("Son departement:"+employe.Departement);
        }

        Console.ReadKey();
    }
}
