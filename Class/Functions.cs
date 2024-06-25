using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace AnimalManagement.Class
{
    class Functions
    {
        public static SqlConnection con;
        // Tạo phương thức Connect()

        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLDongVatConnectionString;
            //Kiểm tra kết nối
            if (con.State != ConnectionState.Open)
            {
            con.Open();
            MessageBox.Show("Kết nối thành công");
            }
            else MessageBox.Show("Không thể kết nối với dữ liệu");
        }

        // Tạo phương thức Disconnect()
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();   	//Đóng kết nối
                con.Dispose(); 	//Giải phóng tài nguyên
                con = null;
            }
        }
    }
}
