using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stream_response_ef_core.Data;
using stream_response_ef_core.Models;
using stream_response_ef_core.Services.Infrastructure;

namespace stream_response_ef_core.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly IAllForOneService _allForOneService;
    public ItemsController(AppDbContext db, IAllForOneService allForOneService)
    {
        _db = db;
        _allForOneService = allForOneService;
    }
    [HttpGet("get-one")]
    public async Task<Item> GetOne()
    {
        return (await _db.Items.FirstOrDefaultAsync())!;
    }

    [HttpGet("seed")]
    public async Task<IActionResult> Seed(CancellationToken cancellationToken = default)
    {
        var items = new List<Item>(20000);
        for (int i = 1; i <= 20000; i++)
        {
            items.Add(new Item
            {
                Name = $"Item {i}",
                Description = $"Description for item {i}",
                IsActive = (i % 2) == 0
            });
        }

        await _db.Items.AddRangeAsync(items, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);

        return Ok(new { inserted = items.Count });
    }

    [HttpGet("get")]
    public IAsyncEnumerable<Item> Get()
    {
        return _db.Items.AsNoTracking().AsAsyncEnumerable();
    }

    [HttpGet("get-full")]
    public async Task<List<Item>> GetStreamingAsync()
    {
        var items = await _db.Items.AsNoTracking().ToListAsync();

        return items;
    }
}
