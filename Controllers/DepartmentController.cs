using Microsoft.AspNetCore.Mvc;

namespace expenses_department_api.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
    private readonly ILogger<DepartmentController> _logger;
    private readonly IRepository repo;

    public DepartmentController(IRepository repo) {
        this.repo = repo;
    }

    [HttpGet(Name = "GetDepartment")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var departments = await repo.GetAllDepartmentsAsync();
            return Ok(departments);
        }
        catch (System.Exception)
        {
            return BadRequest();
        }
    }
}
