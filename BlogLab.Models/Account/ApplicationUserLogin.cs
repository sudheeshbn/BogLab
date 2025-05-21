using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage ="Username Required")]
        [MinLength(5,ErrorMessage ="At least 5-12")]
        [MaxLength(20, ErrorMessage = "At least 5-12")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Pwd Required")]
        [MinLength(10, ErrorMessage = "At least 10-50")]
        [MaxLength(50, ErrorMessage = "At least 10-50")]
        public string Password { get; set; }
    }
}
