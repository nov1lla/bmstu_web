using Api.Contracts;
using BL.Models;
using BL.RepositoryInterfaces;
using BL.Services;

namespace Api.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder app, string prefix)
    {
        app.MapGet($"{prefix}/products", (ProductService service) =>
        {
            var result = service.GetAllProducts().Select(x => x.ToDto());
            return Results.Ok(result);
        });

        app.MapGet($"{prefix}/products/{{id:int}}", (int id, ProductService service) =>
        {
            var product = service.GetProductById(id);
            return product is null ? Results.NotFound(new ErrorDto("Product not found")) : Results.Ok(product.ToDto());
        });

        app.MapPost($"{prefix}/products", (CreateProductRequest request, ProductService service) =>
        {
            try
            {
                var product = new Product(0, request.Name, request.Price, request.Quantity, request.Manufacturer, request.Description);
                service.AddProduct(product);
                var created = service.GetProductByName(request.Name);
                return created is null
                    ? Results.Created($"/api/v1/products", null)
                    : Results.Created($"/api/v1/products/{created.Id}", created.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapPut($"{prefix}/products/{{id:int}}", (int id, UpdateProductRequest request, ProductService service) =>
        {
            try
            {
                var current = service.GetProductById(id);
                if (current is null)
                {
                    return Results.NotFound(new ErrorDto("Product not found"));
                }

                var updated = new Product(id, request.Name, request.Price, request.Quantity, request.Manufacturer, request.Description);
                service.UpdateProduct(updated);
                return Results.Ok(updated.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapMethods($"{prefix}/products/{{id:int}}", new[] { "PATCH" }, (int id, PatchProductRequest request, ProductService service) =>
        {
            try
            {
                var current = service.GetProductById(id);
                if (current is null)
                {
                    return Results.NotFound(new ErrorDto("Product not found"));
                }

                var patched = new Product(
                    id,
                    request.Name ?? current.Name,
                    request.Price ?? current.Price,
                    request.Quantity ?? current.Quantity,
                    request.Manufacturer ?? current.Manufacturer,
                    request.Description ?? current.Description);

                service.UpdateProduct(patched);
                return Results.Ok(patched.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapDelete($"{prefix}/products/{{id:int}}", (int id, IProductRepository repository, ProductService service) =>
        {
            var existing = service.GetProductById(id);
            if (existing is null)
            {
                return Results.NotFound(new ErrorDto("Product not found"));
            }

            repository.DelProduct(existing);
            return Results.NoContent();
        });
    }
}
