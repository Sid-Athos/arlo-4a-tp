namespace Pizzeria; 

// Facade Pattern
public class Formater 
{

    JsonFormater jsonFormater = new JsonFormater();
    XmlFormater xmlFormater = new XmlFormater();

    public void FormatAndWriteTo(List<PizzaRecipes> input, FormatEnum format)
    {
        switch (format) {
            case FormatEnum.JSON:
                jsonFormater.FormatAndWriteTo(input, "./resources/output." + FormatEnum.JSON.GetDescription());
                break;
            case FormatEnum.XML:
                xmlFormater.FormatAndWriteTo(input, "./resources/output." + FormatEnum.XML.GetDescription());
                break;
            default:
                throw new Exception("Non supported format");
        }
    }
}