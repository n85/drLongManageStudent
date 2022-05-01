using System.Data;
using System.Data.SqlClient;

namespace QLDiemSV.DAO
{
    public class DataHelper
    {
        readonly string sqlcon;
        readonly SqlConnection conn = null;
        public DataHelper(string sqlcon)
        {
            conn = new SqlConnection(sqlcon);
            this.sqlcon = sqlcon;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlselect"></param>
        /// <returns>Trả về một Datatable</returns>
        public DataTable FillDataTable(string sqlselect)
        {
            DataTable dt = new DataTable();
            // Tạo một SqlAdapter kết nối vói CSDL thông qua câu lệnh sqlselect và chuỗi kết nối sqlcon
            // Dùng phương thức Fill của DataTable để điền dữ liệu vào bảng 
            new SqlDataAdapter(sqlselect, sqlcon).Fill(dt);
            return dt;
        }
        /// <summary>
        /// Phương thức thêm một dòng vào DataTable
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="values">Các giá trị được truyền vào</param>
        public void AddRow(DataTable dt, params object[] values)
        {
            DataRow dr = dt.NewRow();
            for (int i = 0; i < values.Length; i++)
                dr[i] = values[i];
            dt.Rows.Add(dr);
        }
        /// <summary>
        /// Phương thức lọc bản ghi thỏa mãn điều kiện
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="dk">Điều kiện lọc</param>
        /// <returns></returns>
        public DataView Filter(DataTable dt, string dk)
        {
            return new DataView(dt)
            {
                RowFilter = dk
            };
        }
        /// <summary>
        /// Thay thế một dòng trong DataTable theo điều kiện
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="dk">Điều kiện lọc</param>
        /// <param name="values">Các giá trị truyền vào thay thế dòng được lọc</param>
        public void EditRow(DataTable dt, string dk, params object[] values)
        {
            DataView dv = Filter(dt, dk);
            dv.AllowEdit = true;
            if (dv.Count > 0)
                for (int i = 0; i < values.Length; i++)
                    dv[0][i] = values[i];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt">DataTable được cập nhật lên CSDL</param>
        /// <param name="tenbang">Tên bảng trong CSDL cần cập nhật</param>
        public void UpdateDataTableToDatabase(DataTable dt, string tenbang)
        {
            // tạo mới một instance SqlDataAdapter với câu lệnh lấy dữ liệu trong từ bảng trong CSDL
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tenbang, conn);
            // SqlCommandBuilder sẽ đọc câu SQL select (lấy từ SqlDataAdapter),
            // từ đó suy ra các lệnh insert, update và delete, sau đó gán các lệnh mới
            // vào các property Insert, Update, Delete của SqlDataAdapter tương ứng.
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Update(dt);
        }
        public void DeleteRows(DataTable dt, string dk)
        {
            DataView dv = Filter(dt, dk);
            dv.AllowDelete = true;
            while (dv.Count > 0)
                dv[0].Delete();
        }

    }
}
