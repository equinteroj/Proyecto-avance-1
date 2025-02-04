using proyecto;

namespace WinFormsApp1
{
    public partial class Formulario_principal : Form
    {
        public static List<Medicamento> ListaMedicamentos = new List<Medicamento>();

        public class Medicamento
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public decimal Costo { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioVenta { get; set; }
            public int Stock { get; set; }
            public DateTime Vencimiento { get; set; }
            public string Instrucciones { get; set; }
            public bool Comprar(int cantidad)
            {
                if (cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad valida.");
                    return false;
                }

                if (Stock >= cantidad)
                {
                    Stock -= cantidad;
                    return true;
                }
                else
                {
                    MessageBox.Show("Stock insuficiente.");
                    return false;
                }
            }
        }

        public Formulario_principal()
        {
            InitializeComponent();
        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            formulario_inventario nuevo1 = new formulario_inventario();
            this.Hide();
            nuevo1.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formulario_personal nuevo3 = new Formulario_personal();
            this.Hide();
            nuevo3.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulario_clientes nuevo2 = new Formulario_clientes();
            this.Hide();
            nuevo2.ShowDialog();
            this.Show();
        }

        private void btcomprar_Click(object sender, EventArgs e)
        {
            string codigoProducto = txtCodigo.Text; // Código del producto a comprar
            int cantidadCompra;

            // Validar que la cantidad ingresada es un número y mayor a 0
            if (!int.TryParse(txtCantidad.Text, out cantidadCompra) || cantidadCompra <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el medicamento en la lista
            Medicamento medicamento = Formulario_principal.ListaMedicamentos.FirstOrDefault(m => m.Codigo == codigoProducto);

            if (medicamento == null)
            {
                MessageBox.Show("Medicamento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el medicamento está vencido
            if (medicamento.Vencimiento < DateTime.Now)
            {
                MessageBox.Show($"No puede comprar el medicamento '{medicamento.Nombre}' porque está vencido.",
                                "Medicamento Vencido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar realizar la compra
            if (medicamento.Comprar(cantidadCompra))
            {
                MessageBox.Show($"Compra realizada con éxito.\nStock restante: {medicamento.Stock}",
                                "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay suficiente stock disponible.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
       
    }
}
