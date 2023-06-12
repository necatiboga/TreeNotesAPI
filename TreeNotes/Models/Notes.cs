using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TreeNotes.Models
{
    public class Notes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(70)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public Nullable<int> parentId { get; set; } = 0;

        [StringLength(20)]
        public string Author { get; set; }

        public Nullable<Boolean> isDone { get; set; } = false;

        public DateTime CreateDate { get; set; }
        

  



    }
}
