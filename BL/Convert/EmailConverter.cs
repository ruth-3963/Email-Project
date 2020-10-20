using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
    class EmailConverter
    {

        public static EmailDTO EmailDTO(Email email)
        {

            return new EmailDTO
            {
                id_mail = email.id_mail,
                reciever = email.reciever,
                senter = email.senter,
                subject = email.subject,
                context = email.context,
                sent_date = email.sent_date,
                is_read = email.is_read
            };
        }
        public static Email Email(EmailDTO emailDTO)
        {
            return new Email
            {
                id_mail = emailDTO.id_mail,
                reciever = emailDTO.reciever,
                senter = emailDTO.senter,
                subject = emailDTO.subject,
                context = emailDTO.context,
                sent_date = emailDTO.sent_date,
                is_read = emailDTO.is_read
            };
        }
        public static List<DAL.Email> Emails(List<EmailDTO> userDTOs)
        {
            List<Email> ud = new List<Email>();
            foreach (var item in userDTOs)
            {
                ud.Add(Email(item));
            }
            return ud;
        }
        public static List<EmailDTO> EmailDTOs(List<DAL.Email> emails)
        {
            List<EmailDTO> ud = new List<EmailDTO>();
            foreach (var item in emails)
            {
                ud.Add(EmailDTO(item));
            }
            return ud;
        }
    }
}
