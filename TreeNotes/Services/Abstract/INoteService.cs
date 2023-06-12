using Microsoft.AspNetCore.Mvc;
using TreeNotes.Models;

namespace TreeNotes.Services.Abstract
{
    public interface INoteService
    {
        List<Notes> GetAllNotes();
        Notes GetNoteById(int id);
        Notes CreateNote(Notes notes);
        Notes UpdateNote(Notes notes);
        void DeleteNote(int id);

    }
}
