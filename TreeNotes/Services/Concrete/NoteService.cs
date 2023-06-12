using TreeNotes.Models;
using TreeNotes.Repositories.Abstract;
using TreeNotes.Services.Abstract;

namespace TreeNotes.Services.Concrete
{

    public class NoteService : INoteService
    {
        private INotesRepository _notesRepository;

        public NoteService(INotesRepository notesRepository)
        {
            this._notesRepository = notesRepository;
        }
        public Notes CreateNote(Notes notes)
        {
            return _notesRepository.CreateNote(notes);
        }

        public void DeleteNote(int id)
        {
            _notesRepository.DeleteNote(id);
        }

        public List<Notes> GetAllNotes()
        {
            return _notesRepository.GetAllNotes();
        }

        public Notes GetNoteById(int id)
        {
               return _notesRepository.GetNoteById(id);
        }

        public Notes UpdateNote(Notes notes)
        {
            return _notesRepository.UpdateNote(notes);
        }
    }
}
