# ProductApp2
This is a simple ASP.NET Core MVC app created for class.  
It displays a list of products, allows adding new ones, and uses Tag Helpers and logging.

## Features
- MVC pattern (Models, Views, Controllers)
- `ProductController` with strongly typed `Index` view
- Tag Helpers for navigation and form posts
- ILogger logging useful info in controller actions
- Bootstrap styling for layout and forms

## Requirements
- Visual Studio 2022 (with ASP.NET and web workload installed)
- .NET 6 SDK or newer

## Design note: Separation of Concerns & DI

I introduced a domain service `IPriceCalculator` with an implementation `PriceCalculator`.  
The service is **stateless**, so I registered it as a **Singleton** in `Program.cs`:
```csharp
builder.Services.AddSingleton<IPriceCalculator, PriceCalculator>();


## How to Run
1. Clone the repo:
   ```bash
   git clone https://github.com/jshipl6/ProductApp2.git
