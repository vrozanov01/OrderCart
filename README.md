# OrderCart
Order Cart using Blazor. Created with .NET 6 to save time on installing .NET 8 SDK 

In progress, all design choices to be explained later


1. For list of products use MudList library component with get endpoint for provided API

https://www.mudblazor.com/api/mudlist#pages

-- Update 10.04 ProductList component created

2. For Cart use a loop of MudList library components and span telling "You have n items in cart"

Before that inject Cart service to feed data into the component

-- Update 11.04 ShoppingCart component created

--Update 13.04

3. ProductList and ShoppingCart components are integrated into index page

The ProductList component is added to one section of the grid to display products.

The ShoppingCart component resides in another section for the cart functionality.

MudContainer and MudGrid are used for clean layout

