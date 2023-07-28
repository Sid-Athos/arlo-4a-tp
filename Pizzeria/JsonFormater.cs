namespace Pizzeria;

using System.Text.Json;

public class JsonFormater
{
    public void FormatAndWriteTo(List<PizzaRecipes> input, string output)
    {
        StreamWriter outputFile = new StreamWriter(output);
        // string serializedData = JsonConvert.Serialize
        string serializedData = JsonSerializer.Serialize(input, new JsonSerializerOptions {WriteIndented = true});
        outputFile.WriteLine(serializedData);
    }
}