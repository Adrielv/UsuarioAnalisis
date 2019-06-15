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


namespace UsuarioAnalisis
{
    public partial class Registro : Form
    {
        public Registro()
        {
         
            InitializeComponent();
        }


        private void Button3_Click(object sender, EventArgs e) // Eliminar
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            if (PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IDNumericUpDown, "No se puede eliminar una persona que no existe");

        }
        private void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            EmailmaskedTextBox.Text = string.Empty;
            NivelUsuariomaskedTextBox.Text = string.Empty;
            UsuariosmaskedTextBox.Text = string.Empty;
            ClavemaskedTextBox.Text = string.Empty;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)//Nuevo Button
        {
            Limpiar();

        }

        private Persona LlenaClase()
        {
            Persona persona = new Persona();
            persona.UsuarioId = Convert.ToInt32(IDNumericUpDown.Value);
            persona.Nombres = NombreTextBox.Text;
            persona.Email = EmailmaskedTextBox.Text;
            persona.NivelUsuario = NivelUsuariomaskedTextBox.Text;
            persona.Usuario = UsuariosmaskedTextBox.Text;
            persona.Clave = ClavemaskedTextBox.Text;
            persona.FechaIngreso = FechaIngresoDateTimePicker.Value;

            return persona;
        }
        private void LlenarCampo(Persona persona)
        {
            IDNumericUpDown.Value = persona.UsuarioId;
            NombreTextBox.Text = persona.Nombres;
            EmailmaskedTextBox.Text = persona.Email;
            NivelUsuariomaskedTextBox.Text = persona.NivelUsuario;
            UsuariosmaskedTextBox.Text = persona.Usuario;
            ClavemaskedTextBox.Text = persona.Clave;
            FechaIngresoDateTimePicker.Value = persona.FechaIngreso;
        }

        private void Guardarbutton_Click_Click(object sender, EventArgs e)//Guardar Button
        {
            Persona persona;
            bool paso = false;

            if (!Validar())
                return;
            persona = LlenaClase();
           

            if(IDNumericUpDown.Value == 0)
            {
                paso = PersonasBLL.Guardar(persona);
            }
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonasBLL.Modificar(persona);
            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Persona persona = PersonasBLL.Buscar((int)IDNumericUpDown.Value);
            return (persona != null);

        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if(NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuariosmaskedTextBox.Text))
            {
                MyErrorProvider.SetError(UsuariosmaskedTextBox, "El campo Usuario no puede estar vacio");
                UsuariosmaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ClavemaskedTextBox.Text))
            {
                MyErrorProvider.SetError(ClavemaskedTextBox, "El campo Clave no puede estar vacio");
                UsuariosmaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailmaskedTextBox.Text))
            {
                MyErrorProvider.SetError(EmailmaskedTextBox, "El campo Email no puede estar vacio");
                EmailmaskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NivelUsuariomaskedTextBox.Text))
            {
                MyErrorProvider.SetError(NivelUsuariomaskedTextBox, "El campo NivelUsuario no puede estar vacio");
                NivelUsuariomaskedTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Persona persona = new Persona();
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            persona = PersonasBLL.Buscar(id);

            if (persona != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenarCampo(persona);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }

     /*   private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.ClientSize = new System.Drawing.Size(359, 291);
            this.Name = "Registro";
            this.ResumeLayout(false);

        }*/
    }
    }
