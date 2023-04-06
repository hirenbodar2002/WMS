using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSinWeb.Entities.ViewDataModel
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "FirstName is Required")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Addres is Required")]
        public string? Addres { get; set; }

        [Required(ErrorMessage = "Addres is Required")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Addres is Required")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Your email address is not in a valid format")]
        public string EmailId { get; set; } = null!;

        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[$@$!%*?&amp;])[A-Za-z\\d$@$!%*?&amp;]{8,10}", ErrorMessage = "\"Password must contain: Minimum 8 and Maximum 10 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character\"")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "PhoneNumber is Required")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Your Phone is in valid")]
        public long MobileNo { get; set; }

        [Required(ErrorMessage = "Addres is Required")]
        public string? Companyname { get; set; }
    }
}
