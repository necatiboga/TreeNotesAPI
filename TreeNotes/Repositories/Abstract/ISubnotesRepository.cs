using TreeNotes.Models;

namespace TreeNotes.Repositories.Abstract;

public interface ISubnotesRepository
{
    List<Subnotes> GetAllSubNotes();
    Subnotes GetSubNoteById(int id);
    Subnotes CreateSubNote(Subnotes subnotes);
    Subnotes UpdateSubNote(Subnotes subnotes);
    void DeleteSubNote(int id);
}