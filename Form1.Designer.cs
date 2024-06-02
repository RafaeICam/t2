namespace RegistroMascotasGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRegistrarDueño = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.cbDueños = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscarNombreMascota = new System.Windows.Forms.TextBox();
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir_Click = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBoxDatos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del dueño";
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(185, 40);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDueño.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(185, 74);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(186, 105);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // btnRegistrarDueño
            // 
            this.btnRegistrarDueño.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistrarDueño.Location = new System.Drawing.Point(186, 139);
            this.btnRegistrarDueño.Name = "btnRegistrarDueño";
            this.btnRegistrarDueño.Size = new System.Drawing.Size(99, 27);
            this.btnRegistrarDueño.TabIndex = 6;
            this.btnRegistrarDueño.Text = "Registra Dueño";
            this.btnRegistrarDueño.UseVisualStyleBackColor = false;
            this.btnRegistrarDueño.Click += new System.EventHandler(this.btnRegistrarDueño_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de la Mascota";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(186, 177);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMascota.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dueño";
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarMascota.Location = new System.Drawing.Point(185, 323);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(115, 27);
            this.btnRegistrarMascota.TabIndex = 12;
            this.btnRegistrarMascota.Text = "Registrar Mascota";
            this.btnRegistrarMascota.UseVisualStyleBackColor = false;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // cbDueños
            // 
            this.cbDueños.FormattingEnabled = true;
            this.cbDueños.Location = new System.Drawing.Point(185, 287);
            this.cbDueños.Name = "cbDueños";
            this.cbDueños.Size = new System.Drawing.Size(121, 21);
            this.cbDueños.TabIndex = 14;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(185, 215);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Edad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(185, 253);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre de la Mascota";
            // 
            // txtBuscarNombreMascota
            // 
            this.txtBuscarNombreMascota.Location = new System.Drawing.Point(563, 40);
            this.txtBuscarNombreMascota.Name = "txtBuscarNombreMascota";
            this.txtBuscarNombreMascota.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNombreMascota.TabIndex = 20;
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscarMascota.Location = new System.Drawing.Point(563, 73);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(82, 28);
            this.btnBuscarMascota.TabIndex = 21;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.UseVisualStyleBackColor = false;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMostrarDatos.Location = new System.Drawing.Point(372, 125);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(103, 41);
            this.btnMostrarDatos.TabIndex = 22;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = false;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir_Click
            // 
            this.btnSalir_Click.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir_Click.Location = new System.Drawing.Point(696, 405);
            this.btnSalir_Click.Name = "btnSalir_Click";
            this.btnSalir_Click.Size = new System.Drawing.Size(92, 33);
            this.btnSalir_Click.TabIndex = 24;
            this.btnSalir_Click.Text = "Salir";
            this.btnSalir_Click.UseVisualStyleBackColor = false;
            this.btnSalir_Click.Click += new System.EventHandler(this.btnSalir_Click_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroMascotasGUI.Properties.Resources.seguros_sura_las_mascotas_son_peligrosas_para_la_salud;
            this.pictureBox1.Location = new System.Drawing.Point(515, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBoxDatos
            // 
            this.richTextBoxDatos.Location = new System.Drawing.Point(372, 172);
            this.richTextBoxDatos.Name = "richTextBoxDatos";
            this.richTextBoxDatos.Size = new System.Drawing.Size(416, 152);
            this.richTextBoxDatos.TabIndex = 26;
            this.richTextBoxDatos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxDatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir_Click);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnBuscarMascota);
            this.Controls.Add(this.txtBuscarNombreMascota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cbDueños);
            this.Controls.Add(this.btnRegistrarMascota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrarDueño);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegistrarDueño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.ComboBox cbDueños;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscarNombreMascota;
        private System.Windows.Forms.Button btnBuscarMascota;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir_Click;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDatos;
    }
}

