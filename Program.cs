using Newtonsoft.Json;
using RestSharp;

namespace Invoke;

class Program
{
    static void Main(string[] args)
    {
        PokemonGet("gengar");
    }

    private static void PokemonGet(string nome)
    {
        var cliente = new RestClient($"https://pokeapi.co/api/v2/pokemon/{nome}");
        RestRequest request = new RestRequest("", Method.Get);
        var response = cliente.Execute(request);
        Console.WriteLine(response.Content);
        Console.ReadKey();
    }
}