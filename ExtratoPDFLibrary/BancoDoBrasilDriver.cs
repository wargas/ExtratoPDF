using System.Text.Json;
using System.Text.RegularExpressions;

namespace ExtratoPDFLibrary;

class BancoDoBrasilDriver : IExtractorDriver
{
    public string Process(string text)
    {
        var matches = Regex.Matches(text, @"(\d+\.)?\d+,\d+ \([\+-]\)\n\d{2}\/\d{2}\/\d{4}\n.*");
        List<ExtratoItem> list = new();
        foreach (var item in matches)
        {
            var partes = item.ToString()?.Split("\n");

            if (partes != null && partes[2] != null)
            {
                //5.904,80 (+)
                var valor = Regex.Replace(partes[0], @"\.", "");
                valor = Regex.Replace(valor, @"(\d+),(\d+) \(([\+-])\)", "$3$1,$2");
                valor = Regex.Replace(valor, @"\+", "");
                ExtratoItem extratoItem = new(
                    Date: partes[1], 
                    Description: partes[2], 
                    Value: float.Parse(valor));

                list.Add(extratoItem);
            }
        }
        return JsonSerializer.Serialize(list);
    }
}