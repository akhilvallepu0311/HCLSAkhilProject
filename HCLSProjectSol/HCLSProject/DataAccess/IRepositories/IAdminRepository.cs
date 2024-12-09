using HCLSProject.Models;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IAdminRepository
    {
        //Declare Methods :
        Task <int >insertAdmin(Admin admin);
        Task <int >updateAdmin(Admin admin);
        Task <int >deleteAdmin(int  adminId);        
        
        Task<List <Admin>> getAllAdmins();
        Task<Admin>getAdminById(int adminId);

    }
}
