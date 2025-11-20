using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHICKEN_FINGERS_APP.Visuals
{
    public partial class UC_Ventas : UserControl
    {

        public UC_Ventas()
        {
            InitializeComponent();

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {



        }

        private void pbAgregarCliente_Click(object sender, EventArgs e)
        {
            ComplementaryForm form = new ComplementaryForm();
            form.ShowDialog();
        }
    }
}
