using HCLSProject.DataAccess.IRepositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public IAdminRepository AdminRef;

        public AdminController(IAdminRepository adminRef)
        {
            AdminRef = adminRef;
        }

        [HttpPost]
        [Route("InsertAdmin")]
        public async Task<IActionResult> InsertAdmin([FromBody] Admin admin)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var count = await AdminRef.InsertAdmin(admin);
                    if (count > 0)
                    {
                        return Ok(count + "Record Inserted ...!");
                    }
                    else
                    {
                        return BadRequest("Not Inserted");
                    }
                }
                else
                {
                    return BadRequest("ModelState");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin([FromBody] Admin admin)
        {
            try
            {
                var count = await AdminRef.UpdateAdmin(admin);
                if (count > 0)
                {
                    return Ok(count + "Record Updated ...!");
                }
                else
                {
                    return BadRequest("Not Updated");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(int adminId)
        {
            try
            {
                var count = await AdminRef.DeleteAdmin(adminId);
                if (count > 0)
                {
                    return Ok(count + "Record Deleted ...!");
                }
                else
                {
                    return BadRequest(" Record Is Not Deleted");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }


        [HttpGet]
        [Route("GetallAdmins")]
        public async Task<IActionResult> GetAllAdmins()
        {
            try
            {
                var  admins  = await AdminRef.GetAllAdmins();
                if (admins.Count>0)
                {
                    return Ok(admins);
                }
                else
                {
                    return BadRequest(" Records Are Not Available");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }


        [HttpGet]
        [Route("GetAdminbyId")]
        public async Task<IActionResult>GetAdminbyId(int adminId)
        {
            try
            {
                var admins = await AdminRef.GetAdminById (adminId);
                if (admins != null)
                {
                    return Ok(admins);
                }
                else
                {
                    return BadRequest(" Record Is Not Available");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }


        [HttpGet]
        [Route("CheckAdminLogin")]
        public async Task<IActionResult>CheckAdminLogin(string Email, string Password)
        {
            try
            {
                var admin= await AdminRef.CheckAdminLogin(Email,Password);
                if (admin != null)
                {
                    return Ok(admin);
                }
                else
                {
                    return BadRequest(" Data not found...!");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }

    }
}