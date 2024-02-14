
using System.ComponentModel.DataAnnotations;

namespace Mission06_Bronson.Models
{
    //The “Edited”, “Lent To”, and “Notes” are not required to create a new
    //record. All other fields must be entered.
    public class Form
    {
        [Key]
        [Required]
        public int FormID { get; set; } //primary key for table 

        [Required(ErrorMessage = "This field is required.")]
        public string MovieCategory { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string MovieTitle { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int MovieYear { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string MovieDirector { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string MovieRating {  get; set; }

        //NOT REQUIRED INPUTS 
        public bool MovieEdited { get; set; }
        public string? MovieLent { get; set; }

        //Notes should be limited to 25 characters
        [StringLength(25, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string? MovieNotes { get; set; }


        //cateogry, title, year, director, rating, edited, lent to, notes
    }
}
