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
            if (Formulario_principal.ListaMedicamentos.Count == 0)
            {
                MessageBox.Show("No hay medicamentos registrados.", "Stock Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje = "Stock de Medicamentos:\n\n";

            foreach (var med in Formulario_principal.ListaMedicamentos)
            {
                mensaje += $"Código: {med.Codigo}, Nombre: {med.Nombre}, Stock: {med.Stock}\n";
            }

            MessageBox.Show(mensaje, "Consultar Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Formulario_principal.ListaMedicamentos.Count == 0)
            {
                MessageBox.Show("No hay medicamentos registrados.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje = "Reporte de Medicamentos:\n\n";

            foreach (var med in Formulario_principal.ListaMedicamentos)
            {
                // Verificar si el medicamento está vencido o no
                string estadoVencimiento = med.Vencimiento < DateTime.Now ? "VENCIDO" : "Vigente";

                // Agregar al mensaje
                mensaje += $"Código: {med.Codigo}, Nombre: {med.Nombre}, Precio: {med.PrecioVenta}, " +
                           $"Stock: {med.Stock}, Vence: {med.Vencimiento.ToShortDateString()}, Estado: {estadoVencimiento}\n";
            }

            MessageBox.Show(mensaje, "Reporte de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void alertas_Click(object sender, EventArgs e)
        {
            var medicamentosBajos = Formulario_principal.ListaMedicamentos.Where(m => m.Stock < 5).ToList();

            if (medicamentosBajos.Count == 0)
            {
                MessageBox.Show("No hay medicamentos con stock bajo.", "Alertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje = " Medicamentos con Stock Bajo:\n\n";

            foreach (var med in medicamentosBajos)
            {
                mensaje += $"{med.Nombre} - Solo quedan {med.Stock} unidades.\n";
            }

            MessageBox.Show(mensaje, "Alertas de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

}
