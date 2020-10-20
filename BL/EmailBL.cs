using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EmailBL
    {
        public static  EmailsEntities db=new EmailsEntities();
        public static EmailDTO GetEmailById(long id)
        {
            DAL.Email e = (DAL.Email)db.Emails.Where(x => x.id_mail==id).FirstOrDefault();

            return Convert.EmailConverter.EmailDTO(e);
        }
        public static List<EmailDTO> GetAllEmails()
        {
            List<Email> users = db.Emails.Select(x => x).ToList();

            return BL.Convert.EmailConverter.EmailDTOs(users);
        }
    }
}
