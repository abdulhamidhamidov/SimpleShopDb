using Domain.Dtos;
using Infrostructure.Response;
using Infrostructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
[ApiController]
[Route("[controller]")]
public class QueryController(IQueryService queryService): ControllerBase
{
    [HttpGet("/Get-Count-Of-Orders-By-Date")]
    public async Task<Response<List<GetCountOfOrdersByDateDto>>> GetCountOfOrdersByDate()
    {
        return await queryService.GetCountOfOrdersByDate();
    }
    [HttpGet("/Get-Max-Product")]
    public async Task<Response<GetMaxProductDto>> GetMaxProduct()
    {
        return await queryService.GetMaxProduct();
    }
    [HttpGet("/Get-Orders-By-Start-And-EndDate")]
    public async Task<Response<List<GetOrdersByStartAndEndDateDto>>> GetOrdersByStartAndEndDate(DateTime startDate,DateTime endDate)
    {
        return await queryService.GetOrdersByStartAndEndDate(startDate,endDate);
    }
    [HttpGet("/Get-Sum-Of-Order-By-ProductId")]
    public async Task<Response<GetSumOfOrderByProductIdDto>> GetSumOfOrderByProductId(int productId)
    {
        return await queryService.GetSumOfOrderByProductId(productId);
    }
    [HttpGet("/Get-Ten-Min-Product-By-Stock")]
    public async Task<Response<List<GetTenMinProductByStockDto>>> GetTenMinProductByStock()
    {
        return await queryService.GetTenMinProductByStock();
    }
    [HttpGet("/Get-Tree-Top-Orders-By-Order")]
    public async Task<Response<List<GetTreeTopOrdersByOrderDto>>> GetTreeTopOrdersByOrder()
    {
        return await queryService.GetTreeTopOrdersByOrder();
    }
}