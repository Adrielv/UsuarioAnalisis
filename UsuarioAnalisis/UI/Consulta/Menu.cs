using UsuarioAnalisis.UI.Consultas;
//using UsuarioAnalisis.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuarioAnalisis
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro re = new Registro();
            re.Show();
        }

      

    /*    private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCargos car = new rCargos();
            car.Show();
        }
        */
       

        private void ConsultaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta co = new Consulta();
            co.Show();
        }

        private void ConsultaCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCargos cc = new ConsultaCargos();
            cc.Show();
        }
    }
}
