namespace Pizzeria;

using Newtonsoft.Json;

public class XmlFormater
{
    public void FormatAndWriteTo(List<PizzaRecipes> input, string output)
    {
        // XmlSerializer serializer = new XmlSerializer(typeof(List<PizzaRecipes>));
        // TextWriter writer = new StreamWriter(output);
        // serializer.Serialize(writer, input);
        // writer.Close();

        // string jsonSerializedData = JsonConvert.SerializeObject(input, Formatting.Indented);
        // string serializedData = (XmlDocument)JsonConvert.DeserializeXmlNode(jsonSerializedData);

    }
}