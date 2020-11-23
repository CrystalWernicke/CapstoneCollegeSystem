using System.ComponentModel.DataAnnotations;

namespace CollegeSystem.Models
{
    public class StatesModel
    {
        [Range(1, 50, ErrorMessage = "The id is not correct")]
        [Display(Name = "State ID")]
        [Required(ErrorMessage = "You forgot the id")]
        public int StateId { get; set; }

        [Display(Name = "State Name")]
        [Required(ErrorMessage = "You forgot the state's name")]
        public string StateName { get; set; }

        [Display(Name = "State Code")]
        [Required(ErrorMessage = "You forgot the state's code")]
        public string StateCode { get; set; }
    }
}
//[Range(min, max, errormessage)] Really good for the userid for right now
//[Compare("Password", ErrorMessage = "The passwords must match.")] - good for password.
// Also [DataType(DataType.Password)] is also good to store the password.
// "" [StringLength(100, MinimumLength = 10, ErrorMessage = "You need a longer password")]
// [Datatype(DataType.EmailAddress)] Good for email