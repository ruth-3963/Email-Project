using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BL;
using DTO;

namespace API.Controllers
{


    [RoutePrefix("API/User")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {

        [HttpPost]
        [ResponseType (typeof(UserDTO))]
        [Route("create")]
        public void CreateUser(UserDTO userDTO)
        {
            BL.UserBL.AddUser(userDTO);
        } 
        [HttpGet]
        [Route("{id}")]

        public IHttpActionResult GetUderById(string user_mail)
        {
            return Ok(BL.UserBL.GetUserById(user_mail));
        }
        [HttpGet]
        [Route("AllUsers")]
        //API/User/AllUsers
        public List<UserDTO> GetAllUsers()
        {
            return BL.UserBL.GetAllUser();
        }
        
    }
}
