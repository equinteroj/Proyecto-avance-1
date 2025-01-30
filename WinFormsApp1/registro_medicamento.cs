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
using static WinFormsApp1.Formulario_principal;

namespace proyecto
{
    public partial class registro_medicamento : Form
    {
        public registro_medicamento()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Codigo.Text) ||
            string.IsNullOrWhiteSpace(Nombre.Text) ||
            string.IsNullOrWhiteSpace(Costo.Text) ||
            string.IsNullOrWhiteSpace(Precio.Text) ||
            string.IsNullOrWhiteSpace(Stock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo objeto Medicamento
            Medicamento nuevoMedicamento = new Medicamento
            {
                Codigo = Codigo.Text,
                Nombre = Nombre.Text,
                Tipo = Tipo.SelectedItem?.ToString(),
                Costo = Convert.ToDecimal(Costo.Text),
                Cantidad = Convert.ToInt32(Cantidad.Value),
                PrecioVenta = Convert.ToDecimal(Precio.Text),
                Stock = Convert.ToInt32(Stock.Text),
                Vencimiento = FechaVencimiento.Value,
                Instrucciones = Instrucciones.Text
            };

            // Agregarlo a la lista
            Formulario_principal.ListaMedicamentos.Add(nuevoMedicamento);

            // Mostrar mensaje de éxito
            MessageBox.Show("Medicamento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos después de guardar
            Codigo.Clear();
            Nombre.Clear();
            Tipo.SelectedIndex = -1;
            Costo.Clear();
            Cantidad.Value = 0;
            Precio.Clear();
            Stock.Clear();
            Instrucciones.Clear();
        }
        

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
