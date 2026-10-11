# Practical 6 – Product Catalog (ASP.NET MVC 5)

**Subject:** .NET Technologies (01CE1523)  
**Experiment:** Create a Product Catalog application using ASP.NET MVC architecture (Controllers, Models, Views, Routing).

## Features
- Product catalog listing
- Product details page
- MVC controller/model/view structure
- Sample in-memory product data (no database required)

## Important compatibility note
This is a classic **ASP.NET MVC 5 / .NET Framework** project source template, matching the `System.Web.Mvc` style shown in the practical manual. It is intended for **Visual Studio on Windows** with the ASP.NET and web development workload installed. Classic ASP.NET MVC 5 is not directly runnable on macOS using modern .NET.

## Open / run in Visual Studio
1. Create a new **ASP.NET Web Application (.NET Framework)** project in Visual Studio.
2. Choose the **MVC** template and target .NET Framework 4.7.2 or a framework supported by your Visual Studio installation.
3. Name the project `Practical6Mvc`.
4. Copy the `Controllers`, `Models`, and `Views` folders from this package into the project, merging folders if prompted.
5. Ensure the project references `System.Web.Mvc` (MVC 5 NuGet package).
6. Set the default route to `Product/Index` as shown in `App_Start/RouteConfig.cs`.
7. Run with IIS Express.

## Routes
- `/Product` or `/Product/Index` — product catalog
- `/Product/Details/1` — details for product ID 1

## Project contents
- `Controllers/ProductController.cs`
- `Models/Product.cs`
- `Views/Product/Index.cshtml`
- `Views/Product/Details.cshtml`
- `App_Start/RouteConfig.cs`
- `Global.asax`
- `Web.config`

This is a source template, not a fully generated Visual Studio `.sln` with machine-specific IIS Express settings. Follow the steps above to place it inside a Visual Studio MVC 5 project.
