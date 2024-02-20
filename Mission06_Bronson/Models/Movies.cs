
using System.ComponentModel.DataAnnotations;

namespace Mission06_Bronson.Models
{
    //The “Edited”, “Lent To”, and “Notes” are not required to create a new
    //record. All other fields must be entered.
    public class Movies
    {
        [Key]
        [Required]
        public int MovieID { get; set; } //primary key for table 

        [Required(ErrorMessage = "This field is required.")]
        public required string CategoryId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public required string Director { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public required string Rating {  get; set; }

        //NOT REQUIRED INPUTS 
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public int CopiedToPlex { get; set; }

        //Notes should be limited to 25 characters
        [StringLength(25, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string? Notes { get; set; }


        //cateogry, title, year, director, rating, edited, lent to, notes
    }
}
