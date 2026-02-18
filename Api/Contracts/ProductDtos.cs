using BL.Models;

namespace Api.Contracts;

public record ProductDto(
    int Id,
    string Name,
    int Price,
    int Quantity,
    string Manufacturer,
    string Description);

public record CreateProductRequest(
    string Name,
    int Price,
    int Quantity,
    string Manufacturer,
    string Description);

public record UpdateProductRequest(
    string Name,
    int Price,
    int Quantity,
    string Manufacturer,
    string Description);

public record PatchProductRequest(
    string? Name,
    int? Price,
    int? Quantity,
    string? Manufacturer,
    string? Description);

public static class ProductMapping
{
    public static ProductDto ToDto(this Product product) =>
        new(product.Id, product.Name, product.Price, product.Quantity, product.Manufacturer, product.Description);
}
