using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IAdminRepository
    {
        //Declare Methods :
        Task <int >InsertAdmin(Admin admin);
        Task <int >UpdateAdmin(Admin admin);
        Task <int >DeleteAdmin(int  adminId);        
        
        Task<List <Admin>> GetAllAdmins();
        Task<Admin>GetAdminById(int adminId);

    }
}
