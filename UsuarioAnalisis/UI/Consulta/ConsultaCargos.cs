using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioAnalisis.Entidades;
using UsuarioAnalisis.BLL;

namespace UsuarioAnalisis.UI.Consultas
{
    public partial class ConsultaCargos : Form
    {
        public ConsultaCargos()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cargos>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = CargoBLL.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = CargoBLL.GetList(p => p.CargoId == id);
                        break;

                    case "Descripcion":
                        listado = CargoBLL.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;

                }

            }
            else
            {
                listado = CargoBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }

        
    }
}
