using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class employee_model
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name must be required")]
        [RegularExpression("^[a-zA-Z0-9_]*$",ErrorMessage ="Invalid Characters")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email must be required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
