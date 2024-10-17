namespace ConsoleApp1;
using System;
using System.Collections.Generic;

public interface IShoppingCartState
{
    string GetState();
}

public class EmptyCart : IShoppingCartState
{
    public string GetState() => "EmptyCart";
}

public class UnvalidatedCart : IShoppingCartState
{
    public List<CartItem> Items { get; }

    public UnvalidatedCart(List<CartItem> items)
    {
        this.Items = items;
    }
    public string GetState() => "UnvalidatedCart";
}

public class ValidatedCart : IShoppingCartState
{
    public List<CartItem> Items { get; }
    public Address ShippingAddress { get; }

    public ValidatedCart(List<CartItem> items, Address shippingAddress)
    {
        Items = items;
        ShippingAddress = shippingAddress;
    }
    public string GetState() => "ValidatedCart";
}

public class PaidCart : IShoppingCartState
{
    public List<CartItem> Items { get; }
    public Address ShippingAddress { get; }
    public PaidCart(List<CartItem> items, Address shippingAddress)
    {
        Items=items;
        ShippingAddress=shippingAddress;
    }
    public string GetState() => "PaidCart";
}