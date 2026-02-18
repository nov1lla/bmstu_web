using Api.Contracts;
using BL.Models;
using BL.RepositoryInterfaces;
using BL.Services;

namespace Api.Endpoints;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this IEndpointRouteBuilder app, string prefix)
    {
        app.MapGet($"{prefix}/orders", (OrderService service) =>
        {
            var orders = service.GetAllOrders().Select(x => x.ToDto());
            return Results.Ok(orders);
        });

        app.MapGet($"{prefix}/orders/{{id:int}}", (int id, OrderService service) =>
        {
            var order = service.GetOrderById(id);
            return order is null ? Results.NotFound(new ErrorDto("Order not found")) : Results.Ok(order.ToDto());
        });

        app.MapGet($"{prefix}/orders/by-user/{{userId:int}}", (int userId, IOrderRepository repository) =>
        {
            var orders = repository.GetAllOrdersByIdUser(userId).Select(x => x.ToDto());
            return Results.Ok(orders);
        });

        app.MapPost($"{prefix}/orders", (CreateOrderRequest request, OrderService service) =>
        {
            try
            {
                var order = new Order(0, request.Status, request.DataCreated, request.UserId, request.PromoId);
                service.AddOrder(order);
                var createdId = service.GetIdOrder(request.Status, request.DataCreated, request.UserId, request.PromoId);
                var created = service.GetOrderById(createdId);
                return created is null
                    ? Results.Created("/api/v1/orders", null)
                    : Results.Created($"/api/v1/orders/{created.Id}", created.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapMethods($"{prefix}/orders/{{id:int}}/status", new[] { "PATCH" }, (int id, UpdateOrderStatusRequest request, OrderService service) =>
        {
            try
            {
                var order = service.GetOrderById(id);
                if (order is null)
                {
                    return Results.NotFound(new ErrorDto("Order not found"));
                }

                var updated = new Order(order.Id, request.Status, order.Data_created, order.Id_user, order.Id_promo);
                service.UpdateOrder(updated);
                return Results.Ok(updated.ToDto());
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ErrorDto(ex.Message));
            }
        });

        app.MapDelete($"{prefix}/orders/{{id:int}}", (int id, OrderService service) =>
        {
            var order = service.GetOrderById(id);
            if (order is null)
            {
                return Results.NotFound(new ErrorDto("Order not found"));
            }

            service.DelOrder(order);
            return Results.NoContent();
        });
    }
}
