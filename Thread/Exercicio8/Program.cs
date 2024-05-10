namespace Exercicio8;

internal static class Program
{
    private static readonly object ControleAcesso = new();
    public static void Main()
    {
        // ...
    }

    static void Imprimir(object? param)
    {
        var id = (int)(param ?? 0);
        var caracteres = $"Hello World! {id}";

        lock (ControleAcesso)
        {
            foreach (var caracter in caracteres)
                Console.Write(caracter);
            Console.WriteLine();
        }
    }
}