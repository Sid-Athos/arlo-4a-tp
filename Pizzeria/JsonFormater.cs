namespace Pizzeria;

using System.Text.Json;

public class JsonFormater
{
    public void FormatAndWriteTo(List<PizzaRecipes> input, string output)
    {
        StreamWriter outputFile = new StreamWriter(output);
        string serializedData = JsonSerializer.Serialize(input);
        outputFile.WriteLine(serializedData);
    }
}