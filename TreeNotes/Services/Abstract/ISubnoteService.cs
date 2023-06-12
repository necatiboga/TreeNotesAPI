using TreeNotes.Models;

namespace TreeNotes.Services.Abstract;

public interface ISubnoteService
{
    List<Subnotes> GetAllSubNotes();
    Subnotes GetSubNoteById(int id);
    Subnotes CreateSubNote(Subnotes subnotes);
    Subnotes UpdateSubNote(Subnotes subnotes);
    void DeleteSubNote(int id);
    
}