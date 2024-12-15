using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSProject.Models
{
    [Table("AdminTypes")]
    public class AdminTypes
    {
        [Key ]

        [Required (ErrorMessage = "Please Enter AdminTypeId...!")]
        public int AdminTypeId { get; set; }


        [Required (ErrorMessage = "Please Enter Name .....!")]
        public string AdminTypeName { get; set; }


        public ICollection <Admin>? Admins { get; set; }

      
    }
}
