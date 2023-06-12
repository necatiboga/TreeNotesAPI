using Microsoft.AspNetCore.Mvc;
using TreeNotes.Models;

namespace TreeNotes.Repositories.Abstract
{
    public interface INotesRepository
    {
        List<Notes> GetAllNotes();
        Notes GetNoteById(int id);
        Notes CreateNote(Notes notes);
        Notes UpdateNote(Notes notes);
        void DeleteNote(int id);
    }
}
