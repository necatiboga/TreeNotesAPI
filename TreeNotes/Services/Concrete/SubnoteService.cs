using TreeNotes.Models;
using TreeNotes.Repositories.Abstract;
using TreeNotes.Services.Abstract;

namespace TreeNotes.Services.Concrete;

public class SubnoteService:ISubnoteService
{
    private ISubnotesRepository _subnotesRepository;

    public SubnoteService(ISubnotesRepository subnotesRepository)
    {
        _subnotesRepository = subnotesRepository;
    }
    
    public List<Subnotes> GetAllSubNotes()
    {
        return _subnotesRepository.GetAllSubNotes();
    }

    public Subnotes GetSubNoteById(int id)
    {
        return _subnotesRepository.GetSubNoteById(id);
    }

    public Subnotes CreateSubNote(Subnotes subnotes)
    {
    return _subnotesRepository.CreateSubNote(subnotes);
    }

    public Subnotes UpdateSubNote(Subnotes subnotes)
    {
        return _subnotesRepository.UpdateSubNote(subnotes);
    }

    public void DeleteSubNote(int id)
    {
        _subnotesRepository.DeleteSubNote(id);
    }
}