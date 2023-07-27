namespace Pizzeria;

using System.Xml.Serialization;

public class XmlFormater
{
    public void FormatAndWriteTo(List<PizzaRecipes> input, string output)
    {
        XmlSerializer serializer = new XmlSerializer(input.GetType());
        TextWriter writer = new StreamWriter(output);
        serializer.Serialize(writer, input);
    }
}