using BL.Models;

namespace Api.Contracts;

public record OrderDto(
    int Id,
    Status Status,
    DateTime DataCreated,
    int UserId,
    int PromoId);

public record CreateOrderRequest(
    Status Status,
    DateTime DataCreated,
    int UserId,
    int PromoId);

public record UpdateOrderStatusRequest(Status Status);

public static class OrderMapping
{
    public static OrderDto ToDto(this Order order) =>
        new(order.Id, order.Status, order.Data_created, order.Id_user, order.Id_promo);
}
