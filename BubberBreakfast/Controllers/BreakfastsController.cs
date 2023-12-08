using BubberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BubberBreakfast.Controllers;

[ApiController]
public class BreakfastsController : ControllerBase
{
    [HttpPost("/breakfast")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        //TODO: Store the breakfast in the repository
        return Ok(request);
    }

    [HttpGet("/breakfast/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        //TODO: retrieve the breakfast from the database
        return Ok(id);
    }

    [HttpPut("/breakfast/{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
    {
        //TODO: Perform the upsert on the database
        return Ok(request);
    }

    [HttpDelete("/breakfast/{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        //TODO: Perform the actual deleting in the database
        return Ok(id);
    }
}