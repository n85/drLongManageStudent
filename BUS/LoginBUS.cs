using QLDiemSV.DAO;
using QLDiemSV.Entities;
using System.Data;

namespace QLDiemSV.BUS
{
    public class LoginBUS
    {
        DataHelper dh;
        public LoginBUS(string sqlcon)
        {
            dh = new DataHelper(sqlcon);
            
        }

        /// <summary>
        /// Khi đăng nhập, kiểm tra danh sách người dùng, nếu có người dùng và mật khẩu phù hợp
        /// Trả về một đối tượng người dùng, nếu không trả về null
        /// </summary>
        /// <param name="un">Tên đăng nhập người dùng</param>
        /// <param name="pw">mật khẩu</param>
        /// <returns></returns>
        public Users GetUsers(string un, string pw)
        {
            DataTable dt = dh.FillDataTable($"SELECT * from UserList WHERE UserID = '{un}' and Password = '{pw}'");
            if (dt.Rows.Count > 0)
                return new Users
                {
                    UserID = dt.Rows[0]["UserID"].ToString(),
                    Password = dt.Rows[0]["Password"].ToString(),
                    Role = dt.Rows[0]["Role"].ToString()
                };
            return null;
        }

        //public void UpdateUserInfo()


        //UserDAO ud = new UserDAO(sqlcon);
    }
}
