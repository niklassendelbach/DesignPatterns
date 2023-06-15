using DesignPatterns.Adapter;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
//Singleton som simulerad "logger"
SingleObject session = SingleObject.GetInstance();
session.GetDetails("Open");
Console.WriteLine("******************");
//Adapter för att hämta fräck meny som använts i annat program
var stranger = new Stranger();
var adapter = new Adapter(stranger);
adapter.Request();
//Factory för att skapa producterna
int pizzaChoice;
Int32.TryParse(Console.ReadLine(), out pizzaChoice);
ProductFactory productFactory = new ProductFactory();
switch (pizzaChoice)
{
    case 1:
        IProduct productA = productFactory.CreateProduct("ProductOne");
        productA.Operation();
        break;
    case 2:
        IProduct productB = productFactory.CreateProduct("ProductTwo");
        productB.Operation();
        break;
    case 3:
        IProduct productC = productFactory.CreateProduct("ProductThree");
        productC.Operation();
        break;
    default:
        break;
}
//Strategy för att räkna ut leveranskostnaden
double pizzaPrice = 100;
//Choice 
Console.WriteLine("Choose delivery method: ");
Console.WriteLine("1. By car ~ delivery time 30min");
Console.WriteLine("2. Green choice, bicycle ~ delivery time 1h");
Console.WriteLine("3. Takeaway ~ order ready in 15-20min");
int deliverChoice;
Int32.TryParse(Console.ReadLine(), out deliverChoice);
switch (deliverChoice)
{
	case 1:
        IDeliveryStrategy strategyPostNord = new ByCarDeliveryStrategy();
        DeliveryContext context1 = new DeliveryContext(strategyPostNord);
        double shippingCost = context1.CalculateShippingCost(pizzaPrice);
        Console.WriteLine("Total cost: " + Math.Round(shippingCost, 2) + " SEK");
        Console.WriteLine("See you in 30min!");
        break;
	case 2:
        IDeliveryStrategy strategyDHL = new ByBicycleDeliveryStrategy();
        DeliveryContext context2 = new DeliveryContext(strategyDHL);
        double shippingCost2 = context2.CalculateShippingCost(pizzaPrice);
        Console.WriteLine("Total cost: " + Math.Round(shippingCost2, 2) + " SEK");
        Console.WriteLine("Hang in there, we will be at your house in 1h");
        break;
	case 3:
        IDeliveryStrategy strategyFED = new TakeawayStrategy();
        DeliveryContext context3 = new DeliveryContext(strategyFED);
        double shippingCost3 = context3.CalculateShippingCost(pizzaPrice);
        Console.WriteLine("Total cost: " + Math.Round(shippingCost3, 2) + " SEK");
        Console.WriteLine("Come by our drive through in 15-20min");
        break;
	default:
		break;
}






