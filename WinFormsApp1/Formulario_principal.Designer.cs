namespace WinFormsApp1
{
    partial class Formulario_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_principal));
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSalir = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            btcomprar = new Button();
            txtCodigo = new TextBox();
            txtCantidad = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.Font = new Font("Lucida Calligraphy", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(417, 25);
            label6.Name = "label6";
            label6.Size = new Size(499, 17);
            label6.TabIndex = 4;
            label6.Text = "\"Donde la tecnología se encuentra con el cuidado de la salud\". ";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(67, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 473);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Imprint MT Shadow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(60, 3);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 9;
            label1.Text = "\"SaludNova\"";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(129, 365);
            label5.Name = "label5";
            label5.Size = new Size(49, 14);
            label5.TabIndex = 12;
            label5.Text = "SALIR";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 297);
            label4.Name = "label4";
            label4.Size = new Size(81, 14);
            label4.TabIndex = 11;
            label4.Text = "PERSONAL";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 213);
            label3.Name = "label3";
            label3.Size = new Size(197, 14);
            label3.TabIndex = 10;
            label3.Text = "CLIENTES Y PROVEEDORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 129);
            label2.Name = "label2";
            label2.Size = new Size(103, 14);
            label2.TabIndex = 9;
            label2.Text = "lNVENTARIOS";
            label2.Click += label2_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.MediumSeaGreen;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalir.Location = new Point(60, 382);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(188, 49);
            btnSalir.TabIndex = 8;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(60, 314);
            button3.Name = "button3";
            button3.Size = new Size(188, 47);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(62, 231);
            button2.Name = "button2";
            button2.Size = new Size(188, 48);
            button2.TabIndex = 6;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(60, 146);
            button1.Name = "button1";
            button1.Size = new Size(188, 54);
            button1.TabIndex = 5;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(83, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btcomprar
            // 
            btcomprar.BackColor = Color.MediumAquamarine;
            btcomprar.FlatStyle = FlatStyle.Flat;
            btcomprar.Location = new Point(561, 375);
            btcomprar.Name = "btcomprar";
            btcomprar.Size = new Size(75, 23);
            btcomprar.TabIndex = 5;
            btcomprar.Text = "Comprar";
            btcomprar.UseVisualStyleBackColor = false;
            btcomprar.Click += btcomprar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(530, 346);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(530, 375);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(25, 23);
            txtCantidad.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumAquamarine;
            label7.Location = new Point(478, 349);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 8;
            label7.Text = "Codigo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MediumAquamarine;
            label8.Location = new Point(469, 379);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 9;
            label8.Text = "Cantidad";
            // 
            // Formulario_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 497);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCantidad);
            Controls.Add(txtCodigo);
            Controls.Add(btcomprar);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Formulario_principal";
            Text = "formulario principal ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnSalir;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Button btcomprar;
        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private Label label7;
        private Label label8;
    }
}
