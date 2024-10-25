using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La mia prima calcolatrice con C#");
        Console.WriteLine("Inserisci il primo numero:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Inserisci il secondo numero:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Scegli un'operazione: +, -, *, /");
        string operazione = Console.ReadLine();

        double risultato = 0;

        switch (operazione)
        {
            case "+":
                risultato = num1 + num2;
                break;
            case "-":
                risultato = num1 - num2;
                break;
            case "*":
                risultato = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    risultato = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Errore: Divisione per zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operazione non valida!");
                return;
        }

        Console.WriteLine($"Il risultato di {num1} {operazione} {num2} è: {risultato}");
    }
}
