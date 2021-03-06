using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class ClassCrud
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-281DQ5C3\SQLEXPRESS;Initial Catalog=QuanLyDiemChuanDHQG;Integrated Security=True");
        private void OpenConnect()
        {
            if(con.State ==ConnectionState.Closed)
            {
                con.Open();
            }    
        }
        private void CloseConnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean ExceData(string cmd)
        {
            OpenConnect();
            Boolean check = false;
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                cmds.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            CloseConnect();
            return check;
        }
        public DataTable ReadData (string cmd)
        {
            OpenConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            CloseConnect();
            return dt;
        }

    }
}
