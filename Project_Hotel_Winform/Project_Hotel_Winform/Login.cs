using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform
{
    class Login
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.ChuoiKetNoi == string.Empty)
            {
                return 1;
            }

            SqlConnection _sqlconnect = new SqlConnection(Properties.Settings.Default.ChuoiKetNoi);
            try
            {
                if (_sqlconnect.State == ConnectionState.Closed)
                {
                    _sqlconnect.Open();

                }
                return 0;
            }
            catch
            {
                return 2;
            }

        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from QL_NguoiDung where TenDangNhap ='" + pUser + "' and MatKhau = '" + pPass + "'", Properties.Settings.Default.ChuoiKetNoi);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 30;
            }
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "false")
            {
                return 20;
            }
            return 10;

        }
    }
}
