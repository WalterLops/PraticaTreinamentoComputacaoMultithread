namespace Exercicio10;

public static class Program
{
    private static readonly Semaphore ControleAcesso = new (1, 1);
    public static async Task Main()
    {
        // ...
        
        Console.WriteLine("Antes de Fim");

        // ...
        
        Console.WriteLine("FIM");
    }
    private static async Task Imprimir(int i)
    {
        var caracteres = "Hello World! " + i; 
        
        ControleAcesso.WaitOne();
        foreach (var caracter in caracteres)
        {
            Console.Write(caracter);
            await Task.Delay(10); // Simula algum trabalho assíncrono
        }
        Console.WriteLine();
        ControleAcesso.Release();
    }
}
