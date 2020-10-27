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
        public static  EmailsEntities1 db=new EmailsEntities1();
        public static EmailDTO GetEmailById(long id)
        {
            DAL.Email e = (DAL.Email)db.Emails.Where(x => x.id_mail==id).FirstOrDefault();

            return Convert.EmailConverter.EmailDTO(e);
        }
        public static List<EmailDTO> GetAllEmails()
        {
            List<Email> emails = db.Emails.Select(x => x).ToList();

            return Convert.EmailConverter.EmailDTOs(emails);
        }
        public static void CreateEmail(EmailDTO emailRequest)
        {
            EmailDTO newEmail = new EmailDTO();
           // newEmail.user.user_name = emailRequest.user.user_name;
            newEmail.subject = emailRequest.subject;
            newEmail.context = emailRequest.context;
            newEmail.sent_date = DateTime.Now;
            newEmail.senter = emailRequest.senter;
            newEmail.reciever = emailRequest.reciever;
            Email e=Convert.EmailConverter.Email(newEmail);
            db.Emails.Add(e);
            db.SaveChanges();
        }
    }
}
