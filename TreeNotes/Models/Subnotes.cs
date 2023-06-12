using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreeNotes.Models;

public class Subnotes
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SubnotesId { get; set; }
    
    [StringLength(70)]
    public string Title { get; set; }

    [StringLength(500)]
    public string Description { get; set; }
    
    [StringLength(20)]
    public string Author { get; set; }
    
    public Nullable<Boolean> isDone { get; set; } = false;
    //Add-Migration MyMigrationName -Context Context

    public DateTime CreateDate { get; set; }


    [ForeignKey("Notes")]
    public int NotesId { get; set; }


}