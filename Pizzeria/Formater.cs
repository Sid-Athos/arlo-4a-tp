namespace Pizzeria; 

// Facade Pattern
public class Formater 
{

    JsonFormater jsonFormater = new JsonFormater();
    XmlFormater xmlFormater = new XmlFormater();

    public void FormatAndWriteTo(List<PizzaRecipes> input, string output, FormatEnum format)
    {
        switch (format) {
            case FormatEnum.JSON:
                jsonFormater.FormatAndWriteTo(input, output);
                break;
            case FormatEnum.XML:
                xmlFormater.FormatAndWriteTo(input, output);
                break;
            default:
                throw new Exception("Non supported format");
        }
    }
}