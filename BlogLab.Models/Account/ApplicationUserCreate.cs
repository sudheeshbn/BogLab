using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate
    {

        [Required(ErrorMessage = "UFullnamename Required")]
        [MinLength(10, ErrorMessage = "At least 10-30")]
        [MaxLength(30, ErrorMessage = "At least 10-30")]
        public string Fullname { get; set; }


        [Required(ErrorMessage = "UFullnamename Required")]
      
        [MaxLength(30, ErrorMessage = "At least 10-30")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }
    }
}
