using Domain.Dtos;
using Domain.Models;
using Infrostructure.Response;
using Infrostructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]
public class OrderController(IOrderService service): ControllerBase
{
    [HttpPost]
    public async Task<Response<bool>> Create(CreateOrderDto order)
    {
        return await service.Create(order);
    }
    [HttpGet]
    public async Task<Response<List<Order>>> GetAll()
    {
        return await service.GetAll();
    }
    [HttpGet("/by-id")]
    public async Task<Response<Order>> GetById(int id)
    {
        return await service.GetById(id);
    }
[HttpPut]
    public async Task<Response<bool>> Update(Order order)
    {
        return await service.Update(order);
    }
[HttpDelete]
    public async Task<Response<bool>> Delete(int id)
    {
        return await service.Delete(id);
    }
}