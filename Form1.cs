using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroMascotasGUI
{
    public partial class Form1 : Form
    {
        private List<Dueño> m_dueños = new List<Dueño>();
        private List<Mascota> m_mascotas = new List<Mascota>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarDueño_Click(object sender, EventArgs e)
        {
            try
            {
                string m_nombre = txtNombreDueño.Text;
                string m_direccion = txtDireccion.Text;
                string m_telefono = txtTelefono.Text;

                if (string.IsNullOrEmpty(m_nombre) || string.IsNullOrEmpty(m_direccion) || string.IsNullOrEmpty(m_telefono))
                {
                    throw new ArgumentException("Por favor, complete todos los cuadros");
                }

                Dueño m_dueño = new Dueño(m_nombre, m_direccion, m_telefono);
                m_dueños.Add(m_dueño);

                cbDueños.Items.Add(m_dueño.Nombre);

                MessageBox.Show("Registro de dueño exitoso!");
                txtNombreDueño.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                string m_nombre = txtNombreMascota.Text;
                int m_edad = int.Parse(txtEdad.Text);
                string m_raza = txtRaza.Text;
                string m_nombreDueño = cbDueños.SelectedItem.ToString();

                if (string.IsNullOrEmpty(m_nombre) || string.IsNullOrEmpty(m_raza) || string.IsNullOrEmpty(m_nombreDueño))
                {
                    throw new ArgumentException("Por favor, complete todos los cuadros");
                }

                Dueño m_dueño = m_dueños.Find(d => d.Nombre == m_nombreDueño);
                if (m_dueño == null)
                {
                    throw new ArgumentException("Dueño no encontrado.");
                }

                Mascota m_mascota = new Mascota(m_nombre, m_edad, m_raza, m_dueño);
                m_mascotas.Add(m_mascota);

                MessageBox.Show("Registro de mascota exitoso");
                txtNombreMascota.Clear();
                txtEdad.Clear();
                txtRaza.Clear();
                cbDueños.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                string m_nombre = txtBuscarNombreMascota.Text;

                Mascota m_mascota = m_mascotas.Find(m => m.Nombre.Equals(m_nombre, StringComparison.OrdinalIgnoreCase));

                if (m_mascota != null)
                {
                    MessageBox.Show($"Mascota encontrada: {m_mascota.Nombre}, {m_mascota.Edad} años, {m_mascota.Raza}, Dueño: {m_mascota.Dueño.Nombre}");
                }
                else
                {
                    MessageBox.Show("Mascota no registrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Dueños registrados:");
            foreach (var dueño in m_dueños)
            {
                datos.AppendLine($"Nombre: {dueño.Nombre}, Dirección: {dueño.Direccion}, Teléfono: {dueño.Telefono}");
            }

            datos.AppendLine("\nMascotas registradas:");
            foreach (var mascota in m_mascotas)
            {
                datos.AppendLine($"Nombre: {mascota.Nombre}, Edad: {mascota.Edad}, Raza: {mascota.Raza}, Dueño: {mascota.Dueño.Nombre}");
            }

            richTextBoxDatos.Text = datos.ToString();
        }

        private void btnSalir_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Dueño
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Dueño(string m_nombre, string m_direccion, string m_telefono)
        {
            Nombre = m_nombre;
            Direccion = m_direccion;
            Telefono = m_telefono;
        }
    }

    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public Dueño Dueño { get; set; }

        public Mascota(string m_nombre, int m_edad, string m_raza, Dueño m_dueño)
        {
            Nombre = m_nombre;
            Edad = m_edad;
            Raza = m_raza;
            Dueño = m_dueño;
        }
    }
}
