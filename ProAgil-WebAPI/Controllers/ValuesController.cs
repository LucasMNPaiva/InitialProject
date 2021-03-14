using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventProject.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    public readonly DataContext _context;
    public ValuesController(DataContext context)
    {
      this._context = context;

    }
    // GET api/values
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      return Ok(await _context.Events.ToListAsync());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
      return Ok(await _context.Events.FirstOrDefaultAsync(result => result.EventId == id));
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  