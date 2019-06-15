using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioAnalisis.BLL;
using UsuarioAnalisis.DAL;
using UsuarioAnalisis.Entidades;

namespace UsuarioAnalisis
{
    public partial class rAnalisis : Form
    {
        public List<AnalisisDetalle> Detalle { get; set; }
        public rAnalisis()
        {
            InitializeComponent();
            LlenarComboBox();
            LLenarComboBox2();
            this.Detalle = new List<AnalisisDetalle>();

        }

        private void LlenarComboBox()
        {
            var listado = new List<Persona>();
            listado = PersonasBLL.GetList(p => true);
            UsuariocomboBox.DataSource = listado;
            UsuariocomboBox.DisplayMember = "UsuarioId";
            UsuariocomboBox.ValueMember = "UsuarioId";


        }

        private void LLenarComboBox2()
        {
            var listado2 = new List<TipoAnalisis>();
            listado2 = TipoAnalisisBLL.GetList(l => true);
            TipoAnalisiscomboBox.DataSource = listado2;
            TipoAnalisiscomboBox.DisplayMember = "TipoAnalisisId";
            TipoAnalisiscomboBox.ValueMember = "TipoAnalisisId";


        }



        private void Limpiar()
        {
            AnalisisIdNumericUpDown.Value = 0;
            UsuariocomboBox.Text = string.Empty;
            MyErrorProvider.Clear();
            this.Detalle = new List<AnalisisDetalle>();
            CargarGrid();

        }

        private Analisis LlenaClase()
        {
            Analisis analisis = new Analisis();
            analisis.AnalisisId = Convert.ToInt32(AnalisisIdNumericUpDown.Value);
            analisis.UsuarioId = Convert.ToInt32(UsuariocomboBox.Text);
            analisis.FechaAnalisis = FechadateTimePicker.Value;
            analisis.Resultado = this.Detalle;
            return analisis;

        }

        private void LlenaCampo(Analisis analisis)
        {
            AnalisisIdNumericUpDown.Value = analisis.AnalisisId;
            FechadateTimePicker.Value = analisis.FechaAnalisis;
            UsuariocomboBox.Text = analisis.UsuarioId.ToString();
            this.Detalle = analisis.Resultado;
            CargarGrid();



        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Analisis analisis = AnalisisBLL.Buscar((int)AnalisisIdNumericUpDown.Value);
            return (analisis != null);

        }

        private void CargarGrid()
        {
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = Detalle;
        }

        private bool Validar()
        {

            bool paso = true;
            MyErrorProvider.Clear();


            if (UsuariocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuariocomboBox, "El campo Nivel de Usuario no puede estar vacio");
                UsuariocomboBox.Focus();
                paso = false;

            }

            if (TipoAnalisiscomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TipoAnalisiscomboBox, "El campo Nivel de Usuario no puede estar vacio");
                TipoAnalisiscomboBox.Focus();
                paso = false;

            }

            if (ResultadotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ResultadotextBox, "El campo Usuario no puede estar vacio");
                ResultadotextBox.Focus();
                paso = false;
            }
            return paso;

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Analisis analisis = new Analisis();

            int.TryParse(AnalisisIdNumericUpDown.Text, out id);
            Limpiar();

            analisis = AnalisisBLL.Buscar(id);

            if (analisis != null)
            {
                MessageBox.Show("Producto encontrado");
                LlenaCampo(analisis);

            }
            else
            {
                MessageBox.Show("Producto no existe");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Analisis analisis;
            bool paso = false;

            if (!Validar())
                return;

            analisis = LlenaClase();


            if (AnalisisIdNumericUpDown.Value == 0)
            {
                paso = AnalisisBLL.Guardar(analisis);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = AnalisisBLL.Modificar(analisis);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(AnalisisIdNumericUpDown.Text, out id);
            Limpiar();
            if (AnalisisBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MyErrorProvider.SetError(AnalisisIdNumericUpDown, "No se puede elimina, porque no existe");
            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.Rows.Count > 0 && detalleDataGridView.CurrentRow != null)
            {

                Detalle.RemoveAt(detalleDataGridView.CurrentRow.Index);


            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.DataSource != null)
                this.Detalle = (List<AnalisisDetalle>)detalleDataGridView.DataSource;

            this.Detalle.Add(
                new AnalisisDetalle(
                    id: 0,
                    analisisid: (int)AnalisisIdNumericUpDown.Value,
                    tipoanalisisid: Convert.ToInt32(TipoAnalisiscomboBox.Text),
                    resultado: ResultadotextBox.Text
                    )
               );

            CargarGrid();
        }
    }
}
