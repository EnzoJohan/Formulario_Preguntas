using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Preguntas
{
    /// <summary>
    /// comentario de prueba 2
    /// Comentario modificado el 3 de septiembre de 2023
    /// COMENTARIO3
    /// COMENTARIOOOOOOO
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click_Click(object sender, EventArgs e)
        {
            string genero = cmbGenero.SelectedItem.ToString();
            string edad = cmbEdad.SelectedItem.ToString();
            string equipo = cmbEquipo.SelectedItem.ToString();
            string mensaje = $"Género: {genero}\nEdad: {edad}\nEquipo: {equipo}";
            MessageBox.Show(mensaje, "Respuestas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
