using Xunit;
using Bunit;
using System.Collections.Generic;
using MudBlazor;
using System.Linq;

public class ShoppingCartTests
{
    [Fact]
    public void AddToCart_AddsProductToCart()
    {
        
        using var context = new TestContext();
        var cartProducts = new List<Product>();
        
        var product = new Product
        {
            Id = 1,
            Title = "Test Product",
            Description = "Test Description",
            UnitPrice = 50
        };

        
        var component = context.RenderComponent<ShoppingCart>();
        component.InvokeAsync(() => component.Instance.AddToCart(product));
        cartProducts = component.Instance.CartProducts;

        
        Assert.Contains(cartProducts, p => p.Id == product.Id && p.Title == product.Title);
    }
}

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int UnitPrice { get; set; }
}
