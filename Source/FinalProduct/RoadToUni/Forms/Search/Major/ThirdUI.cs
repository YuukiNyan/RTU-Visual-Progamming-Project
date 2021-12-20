﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace RoadToUni.Forms.Search.Major.ChoosingMajor
{
    public partial class ThirdUI : Form
    {
        string Nnganh = string.Empty;
        string Nganh = string.Empty;
        int nam=2021;
        public ThirdUI(string name, string jname)
        {
            InitializeComponent();
            Nnganh = name;
            Nganh = jname;
        }

 
        private void ThirdUI_Load(object sender, EventArgs e)
        {
            customLabel2.Text = Nganh;
            comboBox1.SelectedIndex = 0;
            Dgv_Load();
            
            
        }
        private void Dgv_Load()
        {
            dgvNganh.DataSource = null;
            dgvNganh.Refresh();
            using (SqlCeConnection con = new SqlCeConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("SELECT TRUONG.MATRUONG AS [Mã trường], TENTRUONG AS [Tên trường], NGANH.MANGANH AS [Mã ngành], TENNGANH AS [Tên ngành], DIEMCHUAN AS [Điểm chuẩn] FROM TRUONG, XET, NGANH WHERE TRUONG.MATRUONG = XET.MATRUONG AND NGANH.MANGANH = XET.MANGANH AND NAM = " + nam.ToString() + " AND EXISTS( SELECT * FROM NGANHCHUNG, NHOMNGANH WHERE TENNGANH LIKE '%' + TENNGANHCHUNG + '%' AND NGANHCHUNG.MANHNGANH = NHOMNGANH.MANHNGANH AND TENNGANHCHUNG = N'" + Nganh + "') ORDER BY TRUONG.MATRUONG DESC", con);
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNganh.DataSource = dt;

                con.Close();
            }
            dgvNganh.Columns[0].Width = 100; 
            dgvNganh.Columns[1].Width = 300;
            dgvNganh.Columns[2].Width = 150;
            dgvNganh.Columns[3].Width = 150;
            dgvNganh.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumTurquoise;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                nam = 2021;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                nam = 2020;
            }
            else
            {
                nam = 2019;
            }
            Dgv_Load();
        }
    }
}
