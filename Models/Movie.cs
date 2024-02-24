using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mission06_Pickett.Models
{

    
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        //[ForeignKey("CategoryID")]
        public int? CategoryID { get; set; }
        public Category? CategoryName { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        //[Range(1888, int.MaxValue, ErrorMessage = "The year must be greater than or equal to 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required]
        public bool CopiedtoPlex { get; set; }
        public string? Notes { get; set; }




    }
}
