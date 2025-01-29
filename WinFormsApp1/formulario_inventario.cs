using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace proyecto
{
    public partial class formulario_inventario : Form
    {
        public formulario_inventario()
        {
            InitializeComponent();
        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            registro_medicamento nuevo = new registro_medicamento();
            this.Hide();
            nuevo.ShowDialog();
            this.Show();
        }

        private void consulta_Click(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
