namespace proyecto
{
    partial class registro_medicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro_medicamento));
            pictureBox1 = new PictureBox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Codigo = new TextBox();
            Nombre = new TextBox();
            Costo = new TextBox();
            Precio = new TextBox();
            Instrucciones = new TextBox();
            Stock = new TextBox();
            FechaVencimiento = new DateTimePicker();
            Tipo = new ComboBox();
            Label5 = new Label();
            Cantidad = new NumericUpDown();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            atras = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cantidad).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-28, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(344, 83);
            Label1.Name = "Label1";
            Label1.Size = new Size(68, 21);
            Label1.TabIndex = 1;
            Label1.Text = "Código:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(349, 125);
            Label2.Name = "Label2";
            Label2.Size = new Size(79, 21);
            Label2.TabIndex = 2;
            Label2.Text = "Nombre: ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Label3.Location = new Point(349, 171);
            Label3.Name = "Label3";
            Label3.Size = new Size(63, 21);
            Label3.TabIndex = 3;
            Label3.Text = "Tipo:    ";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Label4.Location = new Point(349, 210);
            Label4.Name = "Label4";
            Label4.Size = new Size(57, 21);
            Label4.TabIndex = 4;
            Label4.Text = "Costo:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Label6.Location = new Point(344, 299);
            Label6.Name = "Label6";
            Label6.Size = new Size(109, 21);
            Label6.TabIndex = 5;
            Label6.Text = " Precio Venta:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Label7.Location = new Point(349, 340);
            Label7.Name = "Label7";
            Label7.Size = new Size(64, 21);
            Label7.TabIndex = 6;
            Label7.Text = " Stock: ";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.Transparent;
            Label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Label8.Location = new Point(349, 376);
            Label8.Name = "Label8";
            Label8.Size = new Size(105, 21);
            Label8.TabIndex = 7;
            Label8.Text = "Vencimiento:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Label9.Location = new Point(349, 410);
            Label9.Name = "Label9";
            Label9.Size = new Size(111, 21);
            Label9.TabIndex = 8;
            Label9.Text = "Instrucciones:";
            Label9.Click += label8_Click;
            // 
            // Codigo
            // 
            Codigo.Location = new Point(434, 81);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(142, 23);
            Codigo.TabIndex = 9;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(435, 127);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(142, 23);
            Nombre.TabIndex = 10;
            // 
            // Costo
            // 
            Costo.Location = new Point(435, 212);
            Costo.Name = "Costo";
            Costo.Size = new Size(142, 23);
            Costo.TabIndex = 11;
            // 
            // Precio
            // 
            Precio.Location = new Point(463, 301);
            Precio.Name = "Precio";
            Precio.Size = new Size(114, 23);
            Precio.TabIndex = 12;
            // 
            // Instrucciones
            // 
            Instrucciones.Location = new Point(468, 412);
            Instrucciones.Name = "Instrucciones";
            Instrucciones.Size = new Size(143, 23);
            Instrucciones.TabIndex = 13;
            // 
            // Stock
            // 
            Stock.Location = new Point(435, 338);
            Stock.Name = "Stock";
            Stock.Size = new Size(142, 23);
            Stock.TabIndex = 14;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.Location = new Point(463, 374);
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.Size = new Size(148, 23);
            FechaVencimiento.TabIndex = 15;
            // 
            // Tipo
            // 
            Tipo.FormattingEnabled = true;
            Tipo.Items.AddRange(new object[] { "Gotas", "Jarabe", "Suspensiones", "Cápsulas", "Comprimidos", "Gránulos", "Elixires", "Píldoras", "Pastillas", "Inyectables" });
            Tipo.Location = new Point(434, 169);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(143, 23);
            Tipo.TabIndex = 16;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Label5.Location = new Point(349, 257);
            Label5.Name = "Label5";
            Label5.Size = new Size(79, 21);
            Label5.TabIndex = 17;
            Label5.Text = "Cantidad:";
            // 
            // Cantidad
            // 
            Cantidad.Location = new Point(434, 255);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(143, 23);
            Cantidad.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Historic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(197, 9);
            label10.Name = "label10";
            label10.Size = new Size(425, 50);
            label10.TabIndex = 19;
            label10.Text = "Registrar Medicamento";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(602, 104);
            button1.Name = "button1";
            button1.Size = new Size(148, 63);
            button1.TabIndex = 20;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(602, 201);
            button2.Name = "button2";
            button2.Size = new Size(148, 65);
            button2.TabIndex = 21;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // atras
            // 
            atras.BackColor = Color.Red;
            atras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atras.ForeColor = Color.White;
            atras.Location = new Point(693, 376);
            atras.Name = "atras";
            atras.Size = new Size(95, 62);
            atras.TabIndex = 22;
            atras.Text = "Atras";
            atras.UseVisualStyleBackColor = false;
            atras.Click += atras_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(602, 292);
            button3.Name = "button3";
            button3.Size = new Size(148, 58);
            button3.TabIndex = 23;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // registro_medicamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(atras);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(Cantidad);
            Controls.Add(Label5);
            Controls.Add(Tipo);
            Controls.Add(FechaVencimiento);
            Controls.Add(Stock);
            Controls.Add(Instrucciones);
            Controls.Add(Precio);
            Controls.Add(Costo);
            Controls.Add(Nombre);
            Controls.Add(Codigo);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(pictureBox1);
            Name = "registro_medicamento";
            Text = "registro_medicamento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Label1;
        private Label Label2;
        private Label Label3;
        private Label Label4;
        private Label Label6;
        private Label Label7;
        private Label Label8;
        private Label Label9;
        private TextBox Codigo;
        private TextBox Nombre;
        private TextBox Costo;
        private TextBox Precio;
        private TextBox Instrucciones;
        private TextBox Stock;
        private DateTimePicker FechaVencimiento;
        private ComboBox Tipo;
        private Label Label5;
        private NumericUpDown Cantidad;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button atras;
        private Button button3;
    }
}