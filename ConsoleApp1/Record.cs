namespace ConsoleApp1;

public record ProductCode(String Value);
public record Quantity(int Value);
public record Address(string Street, string City, string PostalCode);
public record CartItem(ProductCode Code, Quantity Quantity);