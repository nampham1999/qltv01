﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.GUI;

namespace QLTV.GUI.MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_QL_Sach_Click(object sender, EventArgs e)
        {
            SACH.Form1 ql_Sach = new SACH.Form1();
            ql_Sach.ShowDialog();
        }

        private void btn_QL_DocGia_Click(object sender, EventArgs e)
        {
            DOCGIA.QL_DocGia qL_DocGia = new DOCGIA.QL_DocGia();
            qL_DocGia.ShowDialog();
        }

        private void btn_QL_MuonTra_Click(object sender, EventArgs e)
        {
            MUONTRA.QL_MuonTra ql_MuonTra = new MUONTRA.QL_MuonTra();
            ql_MuonTra.ShowDialog();
        }

        private void btn_QL_Kho_Click(object sender, EventArgs e)
        {
            KHO.QL_Kho qL_Kho = new KHO.QL_Kho();
            qL_Kho.ShowDialog();
        }
    }
}
