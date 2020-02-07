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
    public partial class FormBlocuri : Form
    {
        public FormBlocuri()
        {
            InitializeComponent();
        }

        private void FormBlocuri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proba_transareDataSet.Tabel_Utilizatori' table. You can move, or remove it, as needed.
            this.tabel_UtilizatoriTableAdapter.Fill(this.proba_transareDataSet.Tabel_Utilizatori);

        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
