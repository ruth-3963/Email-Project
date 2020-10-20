using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("API/Email")]
    public class EmailController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetEmailById(long id)
        {
            return Ok(BL.EmailBL.GetEmailById(id));
        }
        [HttpGet]
        [Route("AllEmails")]
        public List<EmailDTO> GetEmails()
        {
            return BL.EmailBL.GetAllEmails();
        }
    }
    
    }
