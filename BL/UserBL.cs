using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class UserBL

    {
        public static  EmailsEntities1 db = new EmailsEntities1();

        public static void AddUser(UserDTO userDTO)
        {
            User user = BL.Convert.UserConverter.user(userDTO);
            
            db.Users.Add(user);
            db.SaveChanges();

        }
       

        public static UserDTO GetUserById(string user_mail)
        {
            User user = db.Users.Where(x => x.user_mail == user_mail).FirstOrDefault();
            if (user == null)
                return null;
            return BL.Convert.UserConverter.userDTO(user);
        }
        public static List<UserDTO> GetAllUser()
        {
            List<User> users = db.Users.Select(x=>x).ToList();
            
            return BL.Convert.UserConverter.userDTOs(users);
        }

    }
}
