namespace Exercicio9;

class Contexto : IDisposable
{
    // ... Definir associação das Threads com esse contexto
    // ... Definir armazeamento de nome e valor das varáveis

    // public Contexto()
    // {
    //     _map.Value = this;
    // }
    // public void Add(string name, object value)
    // {
    //     _hanger[name] = value;
    // }
    // public void Remove(string name)
    // {
    //     if (_hanger.ContainsKey(name))
    //         _hanger.Remove(name);
    // }
    // public static Contexto? Get()
    // {
    //     return _map.Value;
    // }
    // public object? Get(string name)
    // {
    //     return _hanger.GetValueOrDefault(name);
    // }
    public void Dispose()
    {
       // _map.Value = null;
    }
}