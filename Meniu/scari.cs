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
    public partial class scari : Form
    {
        public scari()
        {
            InitializeComponent();
        }

        private void scari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proba_transareDataSet1.articole_new' table. You can move, or remove it, as needed.
            this.articole_newTableAdapter.Fill(this.proba_transareDataSet1.articole_new);

        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
