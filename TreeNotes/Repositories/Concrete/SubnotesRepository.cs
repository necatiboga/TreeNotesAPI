using TreeNotes.Models;
using TreeNotes.Repositories.Abstract;

namespace TreeNotes.Repositories.Concrete;

public class SubnotesRepository : ISubnotesRepository
{
    public List<Subnotes> GetAllSubNotes()
    {
        using(var subnoteDbContext = new SubnetContextDb())
        {
            return subnoteDbContext.Subnotes.ToList();
        }
    }

    public Subnotes GetSubNoteById(int id)
    {
        using(var subnoteDbContext = new SubnetContextDb())
        {
            return subnoteDbContext.Subnotes.Find(id);
        }
    }

    public Subnotes CreateSubNote(Subnotes subnotes)
    {
        using(var subnoteDbContext = new SubnetContextDb())
        {
            subnoteDbContext.Subnotes.Add(subnotes);
            subnoteDbContext.SaveChanges();
            return subnotes;
        }
    }

    public Subnotes UpdateSubNote(Subnotes subnotes)
    {
        using(var subnoteDbContext = new SubnetContextDb())
        {
            subnoteDbContext.Subnotes.Update(subnotes);
            subnoteDbContext.SaveChanges();
            return subnotes;
        }
    }

    public void DeleteSubNote(int id)
    {
        using(var subnoteDbContext = new SubnetContextDb())
        {
            var deleteNote = GetSubNoteById(id);
            subnoteDbContext.Subnotes.Remove(deleteNote);
            subnoteDbContext.SaveChanges();
        }    
    }
}