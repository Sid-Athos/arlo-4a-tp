using Newtonsoft.Json;

namespace Pizzeria; 


public class PizzaRecipes: Attribute {
    internal PizzaRecipes(string name, Dictionary<string, Dictionary<string, double>> ingredientsWithQuantities, double price) {
        Name = name;
        Ingredients = ingredientsWithQuantities;
        Price = price;
        Console.WriteLine(Name);
        Console.WriteLine("Préparer la pâte");
        var ingredients = Ingredients.Select(kvp => "Ajouter " + kvp.Key);
        var ingredientsText = string.Join(Environment.NewLine, ingredients);
        Console.WriteLine(ingredientsText);
        var quantities = Ingredients["Tomate"].Select(kvp => kvp.Key + ": " + kvp.Value);
        var quantitiesText = string.Join(Environment.NewLine, quantities);
        Console.WriteLine(quantitiesText);
    }
    
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("price")]
    public double Price { get; set; }
    
    [JsonProperty("ingredients")]
    public Dictionary<string, Dictionary<string, double>> Ingredients { get; set; }


    internal class PizzaRecipesBuilder
    {
        private string name;
        private Dictionary<string, Dictionary<string, double>> ingredients;
        private double price;

        internal PizzaRecipes Build()
        {
            return new PizzaRecipes(name, ingredients, price);
        }

        internal PizzaRecipesBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        internal PizzaRecipesBuilder WithIngredients(Dictionary<string, Dictionary<string, double>> ingredients)
        {
            this.ingredients = ingredients;
            return this;
        }

        internal PizzaRecipesBuilder WithPrice(double price)
        {
            this.price = price;
            return this;
        }
    }
}