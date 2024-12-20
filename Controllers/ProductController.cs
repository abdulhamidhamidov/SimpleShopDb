using Domain.Dtos;
using Domain.Models;
using Infrostructure.Response;
using Infrostructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController(IProductService service): ControllerBase
{
    [HttpPost]
    public async Task<Response<bool>> Create(CreateOrderDto product)
    {
        return await service.Create(product);
    }
    [HttpGet]
    public async Task<Response<List<Product>>> GetAll()
    {
        return await service.GetAll();
    }
    [HttpGet("/by-id")]
    public async Task<Response<Product>> GetById(int id)
    {
        return await service.GetById(id);
    }
    [HttpPut]
    public async Task<Response<bool>> Update(Product product)
    {
        return await service.Update(product);
    }
    [HttpDelete]
    public async Task<Response<bool>> Delete(int id)
    {
        return await service.Delete(id);
    }
}