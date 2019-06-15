using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UsuarioAnalisis.UI.Registros;

namespace UsuarioAnalisis.UI.Consulta
{
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void RegistroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro re = new Registro();
            re.Show();
        }

        private void AnalisisUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAnalisis ra = new rAnalisis();
            ra.Show();
        }

        private void TipoAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
          rTipoAnalisis rt = new rTipoAnalisis();
            rt.Show();
        }
    }
}
