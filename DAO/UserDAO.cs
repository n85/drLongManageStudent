using QLDiemSV.Entities;
using System.Collections.Generic;
using System.Data;

namespace QLDiemSV.DAO
{

    public class UserDAO
    {
        // Tạo một đối tượng DataHelper để làm việc với Database
        DataHelper dh;
        DataTable dt;

        /// <summary>
        /// Hàm tạo UserDao
        /// </summary>
        /// <param name="sqlcon">connection string</param>
        public UserDAO (string sqlcon)
        {
            dh = new DataHelper(sqlcon);
        }
        public List<Users> LayUsers()
        {
            List<Users> l = new List<Users>();
            dt = dh.FillDataTable("select * from UserList");
            foreach (DataRow dr in dt.Rows)
            {
                Users user = new Users();
                user.UserID = dr["UserID"].ToString();
                user.Password = dr["Password"].ToString();
                user.Sex = dr["Sex"].ToString();
                user.FullName = dr["FullName"].ToString();
                user.Role = dr["Role"].ToString();
                user.PhoneNumber = dr["Phone"].ToString() ;
                l.Add(user);
            }    
            return l;
        }
        
        public void SuaUser(Users u)
        {
            //dt = dh.FillDataTable("select * from UserList");
            dh.EditRow(dt, "UserID = '" + u.UserID + "'", u.UserID, u.Password, u.FullName, u.Sex, u.PhoneNumber, u.Email, u.Role);
            dh.UpdateDataTableToDatabase(dt, "UserList");
        }

        public void ThemUser(Users nuser)
        {
            dh.AddRow(dt, nuser.UserID, nuser.Password, nuser.FullName, nuser.Sex, nuser.PhoneNumber, nuser.Email, nuser.Role);
            dh.UpdateDataTableToDatabase(dt, "UserList");
        }

        public void XoaUser(string userID)
        {
            dh.DeleteRows(dt, "UserID = '" + userID + "'");
            dh.UpdateDataTableToDatabase(dt, "UserList");
        }

        //(string sqlcon)


    }
}
