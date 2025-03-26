using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("x-api-key", "SUA_API_KEY");

        var response = await client.GetAsync("https://api.sintegrapi.com.br/consultas/sintegra/15436940000103");
        string result = await response.Content.ReadAsStringAsync();

        Console.WriteLine(result);
        // dotnet watch
    }
}
