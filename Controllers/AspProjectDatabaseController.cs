using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Azure_02_Web_API_Build_Pipeline.Data;
using Azure_02_Web_API_Build_Pipeline.Models;

namespace Azure_02_Web_API_Build_Pipeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AspprojectController : ControllerBase
    {
        private readonly AspProjectDatabaseContext _context;

        public AspprojectController(AspProjectDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetMessages()
        {
            return await _context.Persons.ToListAsync();
        }
    }
}
