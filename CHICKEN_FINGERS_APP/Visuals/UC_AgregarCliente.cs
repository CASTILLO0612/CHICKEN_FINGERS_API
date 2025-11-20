using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHICKEN_FINGERS_APP.Visuals
{
    public partial class UC_AgregarCliente : UserControl
    {
        public UC_AgregarCliente()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAñadirCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComplementaryForm form = new ComplementaryForm();
            form.Close();
        }
    }
}
