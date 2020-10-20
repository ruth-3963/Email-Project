using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BL;
using DTO;

namespace API.Controllers
{
    
    
    [RoutePrefix("API/User")]
    public class UserController : ApiController
    {
      
     [HttpPost]
     
    public IHttpActionResult AddUser()
    {
            return Ok(BL.UserBL.AddUser(new UserDTO
           {user_email_address="ot9175050",user_passward="1234",user_name="אות וחותם"}));
    }
    [HttpGet]
    [Route("{id}")]

    public IHttpActionResult GetUderById(long id)
    {
            return Ok(BL.UserBL.GetUserById(id));
    }
        [HttpGet]
        [Route("AllUsers")]
        public List<UserDTO> GetAllUsers()
        {
            return BL.UserBL.GetAllUser();
        }
    }
}
