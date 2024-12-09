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

        public async Task<int> deleteAdmin(int adminId)
        {
            var admin = await  dbContext.Admins.FindAsync(adminId);
            dbContext.Admins.Remove(admin);
            return await dbContext .SaveChangesAsync(); 
        }

        public async Task<Admin> getAdminById(int adminId)
        {
            return await dbContext.Admins.FindAsync(adminId); 
        }

        public async Task<List<Admin>> getAllAdmins()
        {
         return await  dbContext.Admins.ToListAsync();
        }

        //Define Methods :
        public async Task<int> insertAdmin(Admin admin)
        {
              await  dbContext.Admins.AddAsync(admin);
            return await  dbContext.SaveChangesAsync();
        }

        public async Task<int> updateAdmin(Admin admin)
        {
            dbContext.Admins.Update(admin);
            return await  dbContext.SaveChangesAsync();
        }
    }
}
