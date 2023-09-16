using Microsoft.AspNetCore.Mvc;

namespace expenses_report_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private readonly ILogger<ReportController> _logger;

    public ReportController(ILogger<ReportController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetReport")]
    public IEnumerable<Report> Get()
    {
        return null;
    }
}
