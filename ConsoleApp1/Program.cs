namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMeniu:");
            Console.WriteLine("1. Afiseaza starea cosului");
            Console.WriteLine("2. Adauga produse în cos");
            Console.WriteLine("3. Valideaza cosul");
            Console.WriteLine("4. Plateste cosul");
            Console.WriteLine("5. Iesire");

            Console.Write("Alege o optiune: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(cart.GetCartState());
                    break;
                case "2":
                    AddProductsToCart(cart);
                    break;
                case "3":
                    ValidateCart(cart);
                    break;
                case "4":
                    cart.PayCart();
                    Console.WriteLine("Cosul a fost platit.");
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Optiune invalida. Incearca din nou.");
                    break;
            }
        }
    }

    static void AddProductsToCart(ShoppingCart cart)
    {
        List<CartItem> items = new List<CartItem>();

        Console.Write("Câte produse vrei să adaugi? ");
        int numProducts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numProducts; i++)
        {
            Console.Write($"Codul produsului {i + 1}: ");
            string productCode = Console.ReadLine();

            Console.Write($"Cantitatea produsului {i + 1}: ");
            int quantity = int.Parse(Console.ReadLine());

            items.Add(new CartItem(new ProductCode(productCode), new Quantity(quantity)));
        }

        cart.AddItems(items);
        Console.WriteLine("Produsele au fost adăugate în coș.");
    }

    static void ValidateCart(ShoppingCart cart)
    {
        Console.Write("Introduceți strada: ");
        string street = Console.ReadLine();

        Console.Write("Introduceți orașul: ");
        string city = Console.ReadLine();

        Console.Write("Introduceți codul poștal: ");
        string postalCode = Console.ReadLine();

        Address address = new Address(street, city, postalCode);
        cart.ValidateCart(address);
        Console.WriteLine("Coșul a fost validat.");
    }
}
