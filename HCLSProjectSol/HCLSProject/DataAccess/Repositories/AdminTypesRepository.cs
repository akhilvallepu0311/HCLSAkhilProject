using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace HCLSProject.DataAccess.Repositories
{
    public class AdminTypesRepository : IAdminTypesRepository
    {

        public HCLSDBContext dbContext;

        public AdminTypesRepository(HCLSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<int> DeleteAdminTypes(int adminTypeId)
        {
            var admin =await  dbContext.AdminTypes.FindAsync(adminTypeId);
            dbContext.AdminTypes.Remove(admin);
            return await  dbContext.SaveChangesAsync();  
        }

        public async Task<AdminTypes> getAdminTypebyId(int adminTypeId)
        {
          return await  dbContext.AdminTypes.FindAsync(adminTypeId);
        }

        public async Task<List<AdminTypes>> GetAllAdminTypes()
        {
           return await dbContext.AdminTypes.ToListAsync();
        }


        //Define Methods :
        public async Task<int> InsertAdminTypes(AdminTypes admin)
        {
          await dbContext .AdminTypes.AddAsync (admin);
          return await dbContext .SaveChangesAsync ();
            
        }

        public async Task<int> UpdateAdminTypes(AdminTypes admin)
        {
            dbContext.AdminTypes.Update(admin);
            return await dbContext.SaveChangesAsync();
        }
    }
}
