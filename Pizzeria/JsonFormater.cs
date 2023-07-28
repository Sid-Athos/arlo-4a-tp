namespace Pizzeria;

using Newtonsoft.Json;

public class JsonFormater
{
    public void FormatAndWriteTo(List<PizzaRecipes> input, string output)
    {
        StreamWriter outputFile = new StreamWriter(output);
        string serializedData = JsonConvert.SerializeObject(input, Formatting.Indented);
        outputFile.WriteLine(serializedData);
        outputFile.Close();
    }
}