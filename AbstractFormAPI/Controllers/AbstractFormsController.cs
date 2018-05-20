using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AbstractFormAPI.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class AbstractFormsController : ControllerBase
    {
        private readonly AbstractFormContext _context;

        public AbstractFormsController(AbstractFormContext context)
        {
            _context = context;

            if (_context.AbstractForms.Count() == 0)
            {
                AbstractForm form = new AbstractForm();
                form.Name="Display Type 1";
                AbstractSection section = new AbstractSection();
                section.Label="Demographics";

                AbstractDataItem item = new AbstractDataItem();
                item.Label="First Name";
                section.DataItems.Add(item);

                item = new AbstractDataItem();
                item.Label="Last Name";
                section.DataItems.Add(item);

                item = new AbstractDataItem();
                item.Label="Birth Date";
                section.DataItems.Add(item);

                item = new AbstractDataItem();
                item.Label="Street Address";
                section.DataItems.Add(item);

                item = new AbstractDataItem();
                item.Label="City";
                section.DataItems.Add(item);

                item = new AbstractDataItem();
                item.Label="State";
                section.DataItems.Add(item);

                form.Sections.Add(section);

                _context.AbstractForms.Add(form);

                _context.SaveChanges();
            }
        }    

        [HttpGet]
public List<AbstractForm> GetAll()
{
    return _context.AbstractForms.ToList();
}

[HttpGet("{id}", Name = "GetTodo")]
public IActionResult GetById(long id)
{
    var item = _context.AbstractForms.Find(id);
    if (item == null)
    {
        return NotFound();
    }
    return Ok(item);
}
[HttpPost]
public IActionResult Create([FromBody] AbstractForm item)
{
    if (item == null)
    {
        return BadRequest();
    }

    _context.AbstractForms.Add(item);
    _context.SaveChanges();

    return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
}   
[HttpPut("{id}")]
public IActionResult Update(long id, [FromBody] AbstractForm item)
{
    if (item == null || item.Id != id)
    {
        return BadRequest();
    }

    var form = _context.AbstractForms.Find(id);
    if (form == null)
    {
        return NotFound();
    }

    form.Name=item.Name;
    

    _context.AbstractForms.Update(form);
    _context.SaveChanges();
    return NoContent();
}

[HttpDelete("{id}")]
public IActionResult Delete(long id)
{
    var todo = _context.AbstractForms.Find(id);
    if (todo == null)
    {
        return NotFound();
    }

    _context.AbstractForms.Remove(todo);
    _context.SaveChanges();
    return NoContent();
}
    }
}