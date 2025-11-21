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
    public partial class UC_ClienteExiste : UserControl
    {
        public UC_ClienteExiste()
        {
            InitializeComponent();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComplementaryForm form = new ComplementaryForm();
            form.Close();
        }
    }
}
