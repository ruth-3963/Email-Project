using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
    class UserConverter
    {
        public static UserDTO userDTO(DAL.User user)
        {
            return new UserDTO
            {
               
                user_name = user.user_name,
                user_mail = user.user_mail
            };
        }

        public static DAL.User user(UserDTO userDTO)
        {
            return new DAL.User
            {
                
                user_name = userDTO.user_name,
                user_mail = userDTO.user_mail
            };
        }
        public static List<DAL.User> Users(List<UserDTO> userDTOs)
        {
            List<User> ud = new List<User>();
            foreach (var item in userDTOs)
            {
                ud.Add(user(item));
            }
            return ud;
        }
        public static List<UserDTO> userDTOs (List<DAL.User> Users)
        {
            List<UserDTO> ud = new List<UserDTO>();
            foreach (var item in Users)
            {
                ud.Add(userDTO(item));
            }
            return ud;
        }

    }
}
