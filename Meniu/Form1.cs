using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meniu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void hideSubMeniu()
        {
            if (panelSubAsociatie.Visible == true)
                panelSubAsociatie.Visible = false;
        }
        private void showSubMeniu(Panel subMeniu)
        {
            if (subMeniu.Visible == false)
            {
                hideSubMeniu();
                subMeniu.Visible = true;
            }
            else subMeniu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMeniu(panelSubAsociatie);
        }

        private void btnBloc_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBlocuri());
            
            MessageBox.Show( "Ai selectat butonul blocuri", "Selectie");
            hideSubMeniu();

        }

        private void btnScara_Click(object sender, EventArgs e)
        {
            openChildForm(new scari());
            MessageBox.Show("Selectie", "Ai selectat butonul scari");
            hideSubMeniu();
        }

        private void btnApartamente_Click(object sender, EventArgs e)
        {
            openChildForm(new Apartamente());
           MessageBox.Show("Selectie", "Ai selectat butonul apartamente");
            hideSubMeniu();
        }
        private Form ActiveForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proba_transareDataSet3.TIPURI' table. You can move, or remove it, as needed.
            this.tIPURITableAdapter1.Fill(this.proba_transareDataSet3.TIPURI);
            // TODO: This line of code loads data into the 'proba_transareDataSet2.TIPURI' table. You can move, or remove it, as needed.
            this.tIPURITableAdapter.Fill(this.proba_transareDataSet2.TIPURI);

        }
    }
}
