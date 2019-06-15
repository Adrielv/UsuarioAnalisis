namespace UsuarioAnalisis
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EmailmaskedTextBox = new System.Windows.Forms.TextBox();
            this.UsuariosmaskedTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton_Click = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClavemaskedTextBox = new System.Windows.Forms.TextBox();
            this.NivelUsuariomaskedTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Ingreso";
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.AllowDrop = true;
            this.FechaIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(151, 264);
            this.FechaIngresoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(153, 22);
            this.FechaIngresoDateTimePicker.TabIndex = 10;
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(151, 41);
            this.IDNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(65, 22);
            this.IDNumericUpDown.TabIndex = 11;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(151, 79);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(153, 22);
            this.NombreTextBox.TabIndex = 12;
            // 
            // EmailmaskedTextBox
            // 
            this.EmailmaskedTextBox.Location = new System.Drawing.Point(151, 122);
            this.EmailmaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailmaskedTextBox.Name = "EmailmaskedTextBox";
            this.EmailmaskedTextBox.Size = new System.Drawing.Size(153, 22);
            this.EmailmaskedTextBox.TabIndex = 14;
        
            // 
            // UsuariosmaskedTextBox
            // 
            this.UsuariosmaskedTextBox.Location = new System.Drawing.Point(151, 195);
            this.UsuariosmaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsuariosmaskedTextBox.Name = "UsuariosmaskedTextBox";
            this.UsuariosmaskedTextBox.Size = new System.Drawing.Size(153, 22);
            this.UsuariosmaskedTextBox.TabIndex = 15;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
      //      this.BuscarButton.Image = global::UsuarioAnalisis.Properties.Resources.find;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(231, 28);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(105, 43);
            this.BuscarButton.TabIndex = 9;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
    //       this.EliminarButton.Image = global::UsuarioAnalisis.Properties.Resources.delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(250, 316);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 65);
            this.EliminarButton.TabIndex = 8;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Guardarbutton
            // 
      //      this.Guardarbutton.Image = global::UsuarioAnalisis.Properties.Resources.save_as;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(141, 316);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 65);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_Click);
            // 
            // Nuevobutton_Click
            // 
     //       this.Nuevobutton_Click.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton_Click.Image")));
            this.Nuevobutton_Click.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton_Click.Location = new System.Drawing.Point(19, 316);
            this.Nuevobutton_Click.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevobutton_Click.Name = "Nuevobutton_Click";
            this.Nuevobutton_Click.Size = new System.Drawing.Size(75, 65);
            this.Nuevobutton_Click.TabIndex = 6;
            this.Nuevobutton_Click.Text = "Nuevo";
            this.Nuevobutton_Click.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton_Click.UseVisualStyleBackColor = true;
            this.Nuevobutton_Click.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "NivelUsuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Clave";
            // 
            // ClavemaskedTextBox
            // 
            this.ClavemaskedTextBox.Location = new System.Drawing.Point(151, 227);
            this.ClavemaskedTextBox.Name = "ClavemaskedTextBox";
            this.ClavemaskedTextBox.Size = new System.Drawing.Size(153, 22);
            this.ClavemaskedTextBox.TabIndex = 20;
            // 
            // NivelUsuariomaskedTextBox
            // 
            this.NivelUsuariomaskedTextBox.Location = new System.Drawing.Point(151, 155);
            this.NivelUsuariomaskedTextBox.Name = "NivelUsuariomaskedTextBox";
            this.NivelUsuariomaskedTextBox.Size = new System.Drawing.Size(153, 22);
            this.NivelUsuariomaskedTextBox.TabIndex = 21;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 404);
            this.Controls.Add(this.NivelUsuariomaskedTextBox);
            this.Controls.Add(this.ClavemaskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuariosmaskedTextBox);
            this.Controls.Add(this.EmailmaskedTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton_Click);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registro";
            this.Text = "rUsuario";
           
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Nuevobutton_Click;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox EmailmaskedTextBox;
        private System.Windows.Forms.TextBox UsuariosmaskedTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox ClavemaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NivelUsuariomaskedTextBox;
    }
}

