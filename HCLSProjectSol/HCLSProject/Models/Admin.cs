

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

        public string AdminName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Id_Proof{ get; set; }
        public bool ActiveStatus { get; set; }

        [ForeignKey ("AdminTypes" )]
        public int AdminTypeId { get; set; }


        public AdminTypes Admintypes { get; set; }




    }
}
