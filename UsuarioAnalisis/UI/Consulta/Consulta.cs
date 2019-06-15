using UsuarioAnalisis.BLL;
using UsuarioAnalisis.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace UsuarioAnalisis.UI.Consultas
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Persona>();

            if(CriteriosTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0:
                        listado = PersonasBLL.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriteriosTextBox.Text);
                        listado = PersonasBLL.GetList(P => P.UsuarioId == id);
                        break;
                    case 2:
                        listado = PersonasBLL.GetList(p => p.Nombres.Contains(CriteriosTextBox.Text));
                        break;
                    case 3:
                        listado = PersonasBLL.GetList(p => p.Email.Contains(CriteriosTextBox.Text));
                        break;

                    case 4:
                        listado = PersonasBLL.GetList(p => p.NivelUsuario.Contains(CriteriosTextBox.Text));
                        break;
                    case 5:
                        listado = PersonasBLL.GetList(p => p.Usuario.Contains(CriteriosTextBox.Text));
                        break;
                    case 6:
                        listado = PersonasBLL.GetList(p => p.Clave.Contains(CriteriosTextBox.Text));
                        break;

                }
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdedateTimePicker.Value.Date && c.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = PersonasBLL.GetList(p => true);

            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;


        }
    }
}
