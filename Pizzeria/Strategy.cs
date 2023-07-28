
namespace Pizzeria
{
   // The Context defines the interface of interest to clients.
    class Bill
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IStrategy _strategy;

        public Bill()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Bill(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetDiscountStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void ComputeDiscounts(List<PizzaRecipes> pizzasInBill)
        {
            switch (pizzasInBill.Count)
            {
                case 1:

                    SetDiscountStrategy(new SinglePizzaDiscount());
                    _strategy.ApplyDiscount(pizzasInBill);
                    break;
                case > 1 when pizzasInBill.Count % 3 == 0:
                    SetDiscountStrategy(new PizzaPackDiscount());
                    _strategy.ApplyDiscount(new List<PizzaRecipes> ());
                    break;
            }
        }
    }

    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface IStrategy
    {
        void ApplyDiscount(List<PizzaRecipes> data);
    }

    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    class SinglePizzaDiscount : IStrategy
    {
        public void ApplyDiscount(List<PizzaRecipes> data) {
            data[0].Price *= 0.8;
        }
    }

    class PizzaPackDiscount : IStrategy
    {
        public void ApplyDiscount(List<PizzaRecipes> data) {
             data.Min(pizza => pizza.Price);
             var forFree = data.Find(pizza => pizza.Price == data.Min(pizza => pizza.Price));
             forFree.Price = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var bill = new Bill();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            bill.SetDiscountStrategy(new SinglePizzaDiscount());
            bill.ComputeDiscounts(new List<PizzaRecipes>());
            
            Console.WriteLine();
            
            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            bill.SetDiscountStrategy(new PizzaPackDiscount());
            bill.ComputeDiscounts(new List<PizzaRecipes>());
        }
    }
}