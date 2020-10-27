using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace API.Controllers
{
    [RoutePrefix("API/Email")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        [HttpPost]
        [ResponseType(typeof(EmailDTO))]
        [Route("create")]
        public void CreateEmail(EmailDTO email)
        {
            EmailBL.CreateEmail(email);
        }
    }
    
    }
