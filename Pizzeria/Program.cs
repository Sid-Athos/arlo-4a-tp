using Pizzeria;

Console.Clear();
var regina = new PizzaRecipes(
    "Regina",
    new Dictionary<string, Dictionary<string, double>>() {
        { "Tomate", new Dictionary<string, double>() { { "g", 150 } } },
        { "Mozzarella", new Dictionary<string, double>() { { "g", 125 } } },
        { "Fromage râpé", new Dictionary<string, double>() { { "g", 100 } } },
        { "Jambon", new Dictionary<string, double>() { { "tranches", 2 } } },
        { "Champignons frais", new Dictionary<string, double>() { { "g", 150 } } },
        { "Huile d'olive", new Dictionary<string, double>() { { "cuillères à soupe", 150 } } }
    }, 
    8
);

var fourSeasons = new PizzaRecipes(
    "4 saisons",
    new Dictionary<string, Dictionary<string, double>>() {
        { "Tomate", new Dictionary<string, double>() { { "g", 150 } } },
        { "Mozzarella", new Dictionary<string, double>() { { "g", 125 } } },
        { "Champignons frais", new Dictionary<string, double>() { { "g", 100 } } },
        { "Jambon", new Dictionary<string, double>() { { "tranches", 2 } } },
        { "Poivron", new Dictionary<string, double>() { { "", 0.5 } } },
        { "Olives", new Dictionary<string, double>() { { "poignée", 1 } } }
    }, 
    8
);

var vege = new PizzaRecipes(
    "Végétarienne",
    new Dictionary<string, Dictionary<string, double>>() {
        { "Tomate", new Dictionary<string, double>() { { "g", 150 } } },
        { "Mozzarella", new Dictionary<string, double>() { { "g", 125 } } },
        { "Courgette", new Dictionary<string, double>() { { "", 0.5 } } },
         { "Tomates cerise", new Dictionary<string, double>() { { "", 6 } } },
        { "Poivron jaune", new Dictionary<string, double>() { { "", 1 } } },
        { "Olives", new Dictionary<string, double>() { { "quelques", 0} } },
    }, 
    7.5
);

PizzaRecipes margherita = 
    new PizzaRecipes
        .PizzaRecipesBuilder()
            .WithName("Margherita")
            .WithIngredients(new Dictionary<string, Dictionary<string, double>>()
                {
                    {"Tomate", new Dictionary<string, double>() { {"g", 150}}},
                    {"Mozzarella", new Dictionary<string, double>() { {"g", 200}}},
                    {"Basilic", new Dictionary<string, double>() { {"quelques", 0}}}
                })
            .WithPrice(7)
            .Build();


var list = new List<PizzaRecipes>();
list.Add(regina);
list.Add(fourSeasons);
list.Add(vege);
list.Add(margherita);
while (true) {
    var input = Console.ReadLine();
    
}