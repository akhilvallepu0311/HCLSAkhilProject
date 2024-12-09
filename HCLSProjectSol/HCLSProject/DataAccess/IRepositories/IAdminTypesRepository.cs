using HCLSProject.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace HCLSProject.DataAccess.IRepositories
{
    public interface IAdminTypesRepository
    {

        //Declare Methods :
        Task <int> InsertAdminTypes(AdminTypes admin);
        Task <List<AdminTypes>>GetAllAdminTypes();
        Task<int> UpdateAdminTypes(AdminTypes admin);
        Task<int> DeleteAdminTypes(int adminTypeId);
        Task<AdminTypes>getAdminTypebyId(int adminTypeId);
       
    }
}
