using System;
using System.Text;

class Condition
{
    public static void condition(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Entrez votre salaire brut annuel: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        
        if (!int.TryParse(input, out int SalaireBrutAnnuel))
        {
            Console.WriteLine("Votre réponse n'est pas acceptée, veuillez réessayer.");
        }
        
        int SalaireBrutMensuel = SalaireBrutAnnuel / 12;
        
        if (SalaireBrutAnnuel > 50000)
        {
            Console.WriteLine("Votre salaire brut annuel est trop élevé, nous vous conseillons de faire des dons pour réduire vos impôts.");
        }

        if (SalaireBrutAnnuel >= 30000 && SalaireBrutAnnuel <= 40000)
        {
            Console.WriteLine("Votre salaire est trop bas 🫵🤣, venez à CESI pour un Bac+5 en développement 😎!");
        }

        if (SalaireBrutMensuel < 1500)
        {
            Console.WriteLine("Ne vous inquiétez pas, votre salaire est normal pour un alternant.");
        }
    }
}
