﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuction4
{
    public partial class ThongtinTruong : UserControl
    {

        public ThongtinTruong()
        {
            InitializeComponent();            
        }
        public string schoolname;
        public string schoolcode;
        private void ThongtinTruong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ThongtinTruong_VisibleChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.UEL;
        }
    }
}