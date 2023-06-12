using TreeNotes.Models;
using TreeNotes.Repositories.Abstract;

namespace TreeNotes.Repositories.Concrete
{
    public class NotesRepository : INotesRepository
    {
        public Notes CreateNote(Notes notes)
        {
            using(var noteDbContext = new Context())
            {
                noteDbContext.Notes.Add(notes);
                noteDbContext.SaveChanges();
                return notes;
            }
        }

        public void DeleteNote(int id)
        {
            using(var noteDbContext = new Context())
            {
                var deleteNote = GetNoteById(id);
                noteDbContext.Notes.Remove(deleteNote);
                noteDbContext.SaveChanges();
            }
        }

        public List<Notes> GetAllNotes()
        {
            using(var noteDbContext = new Context())
            {
                return noteDbContext.Notes.ToList();
            }
        }

        public Notes GetNoteById(int id)
        {
            using(var noteDbContext = new Context())
            {
                return noteDbContext.Notes.Find(id);
            }
        }

        public Notes UpdateNote(Notes notes)
        {
            using(var noteDbContext = new Context())
            {
                noteDbContext.Notes.Update(notes);
                noteDbContext.SaveChanges();
                return notes;
            }
        }
    }
}
