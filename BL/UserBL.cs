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
        public static  EmailsEntities db = new EmailsEntities();

        public static UserDTO AddUser(UserDTO userDTO)
        {
            User user = BL.Convert.UserConverter.user(userDTO);
            
            db.Users.Add(user);

            if (db.SaveChanges() > 0)
            {
                return BL.Convert.UserConverter.userDTO(user);
            }
            return null;
        }
       

        public static UserDTO GetUserById(long id)
        {
            User user = db.Users.Where(x => x.id_user == id).FirstOrDefault();
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
