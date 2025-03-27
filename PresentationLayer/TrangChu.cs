﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TrangChu : Form
    {
        private ThongTin tt = null;
        private QuanLyDocGia qldg = null;
        private QuanLySach qls = null;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            this.Show();
            Enabled = false;
            DangNhap dn = new DangNhap();
            DialogResult result = dn.ShowDialog();
            if(result == DialogResult.OK)
            {
                Enabled = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void tsmiThongTin_Click(object sender, EventArgs e)
        {
            if (tt == null || tt.IsDisposed)
            {
                tt = new ThongTin();
                tt.MdiParent = this;
                pictureBox1.Controls.Add(tt);
                tt.Show();
            }
        }

        private void tsmiQLDocGia_Click(object sender, EventArgs e)
        {
            if (qldg == null || qldg.IsDisposed)
            {
                qldg = new QuanLyDocGia();
                qldg.MdiParent = this;
                pictureBox1.Controls.Add(qldg);
                qldg.Show();
            }
        }

        private void tsmiQLSach_Click(object sender, EventArgs e)
        {
            if (qls == null || qls.IsDisposed)
            {
                qls = new QuanLySach();
                qls.MdiParent = this;
                pictureBox1.Controls.Add(qls);
                qls.Show();
            }
        }
    }
}
