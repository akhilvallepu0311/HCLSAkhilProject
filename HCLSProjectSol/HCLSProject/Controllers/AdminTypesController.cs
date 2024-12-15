using HCLSProject.DataAccess.IRepositories;
using HCLSProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Diagnostics.Eventing.Reader;

namespace HCLSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminTypesController : ControllerBase
    {
        public IAdminTypesRepository AdminTypesRef;

        public AdminTypesController(IAdminTypesRepository adminTypesRef)
        {
            AdminTypesRef = adminTypesRef;
        }


        [HttpPost ]
        [Route("InsertAdminTypes")]
        public async Task <IActionResult>InsertAdminTypes(AdminTypes admin )
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var count = await AdminTypesRef.InsertAdminTypes(admin);
                    if (count > 0)
                    {
                        return Ok(count + " Record Inserted.....!");
                    }
                    else
                    {
                        return BadRequest("Data Not Inserted");
                    }
                }
                else
                {
                    return BadRequest("modelState ");
                }
            }
            catch(Exception ex) 
            { 
              return BadRequest ("sorry for inconvinces...!\n We will solve this issue soon...!\n"+ex.Message);
            }
        }
        
        [HttpGet ]
        [Route ("GetAllAdminTypes")]
        public async Task <IActionResult> GetAllAdminTypes()
        {
            try
            {
                var AdminTypes = await AdminTypesRef .GetAllAdminTypes();
                if (AdminTypes.Count > 0)
                {
                    return Ok (AdminTypes);
                }
                else
                {
                    return NotFound("There is no data available..!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }

        }
        [HttpPut]
        [Route ("UpdateAdminTypes")]
        public async Task<IActionResult>UpdateAdminTypes(AdminTypes admin)
        {
            try
            {
                var count = await AdminTypesRef.UpdateAdminTypes (admin);
                if (count > 0)
                {
                    return Ok(count + "Record Updated");
                }
                else
                {
                    return BadRequest("Data not Updated...!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }

        [HttpDelete ]
        [Route("DeleteAdminTypes")]
        public async Task<IActionResult>DeleteAdminTypes(int  adminTypeId)
        {
            try
            {
                var count = await AdminTypesRef.DeleteAdminTypes(adminTypeId);
                if (count > 0)
                {
                    return Ok(count + "Record Deleted ");
                }
                else
                {
                    return BadRequest("Data not Deleted...!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAdminTypebyId")]
        public async Task<IActionResult> GetAdminTypebyId(int adminTypeId)
        {
            try
            {
                var AdminType = await AdminTypesRef.GetAdminTypebyId(adminTypeId);
                if (AdminType  != null )
                {
                    return Ok(AdminType );
                }
                else
                {
                    return BadRequest("AdminTypes with adminTypeId : "+ adminTypeId + "is not available....!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvinces...!\n We will solve this issue soon...!\n" + ex.Message);
            }
        }




    }
}
