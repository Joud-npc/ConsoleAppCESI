using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Entrer votre salaire brute annuel: ");
        int SalaireBruteAnnuel = int.Parse(Console.ReadLine());
        Console.Write("Entrer votre taux d'imposition: ");
        int TauxImposition = int.Parse(Console.ReadLine());
        
        int SalaireNetAnnuel = SalaireBruteAnnuel - (SalaireBruteAnnuel  * TauxImposition / 100);
        int SalaireNetMensuel = SalaireNetAnnuel / 12;
        Console.WriteLine();
        Console.WriteLine("Salire mensuel: " + SalaireNetMensuel);
    }
}