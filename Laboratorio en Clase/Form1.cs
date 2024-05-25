using Laboratorio_en_Clase.Data;
using Laboratorio_en_Clase.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Laboratorio_en_Clase
{
    public partial class Form1 : Form
    {

        Conexion Clscone = new Conexion();
        consolas usr = new consolas();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttongrabar_Click(object sender, EventArgs e)
        {
            Clscone.Insertar(usr);
            MessageBox.Show("Ya estuvo");
        }

        private void buttonmodel_Click(object sender, EventArgs e)
        {
            usr.ID = int.Parse(textBoxID.Text);
            usr.nombre_consola = textBoxnombre.Text;
            usr.compania = textBoxcompania.Text;
            usr.anio_lanzamiento = dateTimePicker.Value;
            usr.generacion= int.Parse(textBoxgeneracion.Text);
            Clscone.Insertar(usr);
            MessageBox.Show("Ya estuvo");
        }

        private void buttontodos_Click(object sender, EventArgs e)
        {
            List<consolas> todos =Clscone.ObtenerTodosLosUsuarios(); 
            dataGridView1.DataSource = todos;
        }
    
    }
}
