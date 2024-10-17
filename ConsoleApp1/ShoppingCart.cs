namespace ConsoleApp1;

public class ShoppingCart
{
    private IShoppingCartState _state;

    public ShoppingCart()
    {
        _state = new EmptyCart();
    }
    
    public void AddItems(List<CartItem>items)
    {
        _state = new UnvalidatedCart(items);
    }
    public void ValidateCart(Address address)
    {
        if (_state is UnvalidatedCart unvalidatedCart)
        {
            _state = new ValidatedCart(unvalidatedCart.Items, address);
        }
    }

    public void PayCart()
    {
        if (_state is ValidatedCart validatedCart)
        {
            _state = new PaidCart(validatedCart.Items, validatedCart.ShippingAddress);
        }
    }

    public string GetCartState()
    {
        return _state.GetState();
    }
}

// Entitatea pentru client
public class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
    
}