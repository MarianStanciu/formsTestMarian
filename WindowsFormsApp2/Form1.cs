﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proba_transareDataSetTabelUtilizatori.Tabel_Utilizatori' table. You can move, or remove it, as needed.
            this.tabel_UtilizatoriTableAdapter.Fill(this.proba_transareDataSetTabelUtilizatori.Tabel_Utilizatori);

        }
    }
}
