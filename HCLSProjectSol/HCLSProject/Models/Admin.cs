

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSProject.Models
{

    [Table("Admin")]
    public class Admin
    {

        [Key ]
        public int AdminId { get; set; }

        [Required (ErrorMessage = "Please Enter AdminName...!")]
        public string AdminName { get; set; }
        [Required(ErrorMessage = "Please Enter Gender...!")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter Phone...!")]
        [StringLength (10,ErrorMessage ="Phone Number Must be 10 digits only..!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Enter Email...!")]
        [RegularExpression (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Please Enter Email Format only..!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password...!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Address...!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Id_Proof...!")]
        public string Id_Proof{ get; set; }
        [Required(ErrorMessage = "Please Enter ActiveStatus...!")]
        public bool ActiveStatus { get; set; }

        [ForeignKey ("AdminTypes" )]
        public int AdminTypeId { get; set; }


        public AdminTypes? Admintypes { get; set; }




    }
}
