using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DBContext;
using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DataAccess.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public HCLSDBContext dbContext;

        public AdminRepository(HCLSDBContext _dbContext){ this.dbContext = _dbContext; }

        public async Task<int> DeleteAdmin(int adminId)
        {
            var admin = await  dbContext.Admins.FindAsync(adminId);
            dbContext.Admins.Remove(admin);
            return await dbContext .SaveChangesAsync(); 
        }

        public async Task<Admin> GetAdminById(int adminId)
        {
            return await dbContext.Admins.FindAsync(adminId); 
        }

        public async Task<List<Admin>> GetAllAdmins()
        {
         return await  dbContext.Admins.ToListAsync();
        }

        //Define Methods :
        public async Task<int> InsertAdmin(Admin admin)
        {
              await  dbContext.Admins.AddAsync(admin);
            return await  dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAdmin(Admin admin)
        {
            dbContext.Admins.Update(admin);
            return await  dbContext.SaveChangesAsync();
        }
    }
}
