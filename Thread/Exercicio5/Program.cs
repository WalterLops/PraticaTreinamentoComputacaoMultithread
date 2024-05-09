namespace Exercicio5;

public static class Program
{
    private static bool _deveContinuar = true;

    public static void Main()
    {
        Console.WriteLine("Aperte uma tecla para iniciar a thread.");
        Console.WriteLine("Aperte novamente uma tecla para finalizar a thread.");
        
        Console.ReadKey();
        
        // ...
        
        Console.WriteLine("FIM");
        Console.ReadKey();
    }

    static void Rodar()
    {
        // ...
    }
}