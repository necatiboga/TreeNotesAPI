using Microsoft.AspNetCore.Mvc;
using TreeNotes.Models;
using TreeNotes.Repositories.Abstract;
using TreeNotes.Services.Abstract;

namespace TreeNotes.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : Controller
    {
        private INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            this._noteService = noteService;
        }

        [HttpGet]
        public List<Notes> Get()
        {
            return _noteService.GetAllNotes();
        }

        [HttpGet("{Id}")]
        public Notes Get(int Id)
        {
            return _noteService.GetNoteById(Id);
        }

        [HttpPost]
        public Notes Post([FromBody] Notes Notes)
        {
            return _noteService.CreateNote(Notes);
        }

       
        [HttpPut("{id}")]
        public Notes Update(int id, [FromBody] Notes notes)
        {
            Notes updateNotes = _noteService.GetNoteById(id);

            updateNotes.Title = notes.Title;
            updateNotes.Description = notes.Description;
            updateNotes.Author = notes.Author;
            updateNotes.isDone = notes.isDone;
            // Diğer not özelliklerini de güncelleme işlemine dahil edebilirsiniz.

            return _noteService.UpdateNote(updateNotes);
        }



        [HttpDelete("{id}")]
        public void Delete(int Id)
        {
            _noteService.DeleteNote(Id);
        }

    }


    }
