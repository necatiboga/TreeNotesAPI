using Microsoft.AspNetCore.Mvc;
using TreeNotes.Models;
using TreeNotes.Services.Abstract;

namespace TreeNotes.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubnoteController : Controller
{
    private ISubnoteService _subnoteService;

    public SubnoteController(ISubnoteService subnoteService)
    {
        this._subnoteService = subnoteService;
    }

    [HttpGet]
    public List<Subnotes> Get()
    {
        return _subnoteService.GetAllSubNotes();
    }

    [HttpGet("{Id}")]
    public Subnotes Get(int Id)
    {
        return _subnoteService.GetSubNoteById(Id);

    }
    
    [HttpPost]
    public Subnotes Post([FromBody] Subnotes subnotes)
    {
        return _subnoteService.CreateSubNote(subnotes);
    }
    
    [HttpPut("{id}")]
    public Subnotes Update(int id, [FromBody] Subnotes subnotes)
    {
        Subnotes updateSubnotes = _subnoteService.GetSubNoteById(id);

        updateSubnotes.Title = subnotes.Title;
        updateSubnotes.Description = subnotes.Description;
        updateSubnotes.Author = subnotes.Author;
        updateSubnotes.isDone = subnotes.isDone;
        return _subnoteService.UpdateSubNote(updateSubnotes);
    }

    [HttpDelete("{id}")]
    public void Delete(int Id)
    {
        _subnoteService.DeleteSubNote(Id);
    }



}