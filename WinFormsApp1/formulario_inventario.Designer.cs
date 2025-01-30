namespace proyecto
{
    partial class formulario_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario_inventario));
            medico2 = new PictureBox();
            label1 = new Label();
            registrar = new Button();
            consulta = new Button();
            alertas = new Button();
            button1 = new Button();
            atras = new Button();
            ((System.ComponentModel.ISupportInitialize)medico2).BeginInit();
            SuspendLayout();
            // 
            // medico2
            // 
            medico2.BackColor = Color.Transparent;
            medico2.Image = (Image)resources.GetObject("medico2.Image");
            medico2.Location = new Point(-16, 62);
            medico2.Name = "medico2";
            medico2.Size = new Size(266, 453);
            medico2.SizeMode = PictureBoxSizeMode.AutoSize;
            medico2.TabIndex = 0;
            medico2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 27);
            label1.Name = "label1";
            label1.Size = new Size(450, 31);
            label1.TabIndex = 1;
            label1.Text = " Sistema de Gestión de Medicamentos ";
            // 
            // registrar
            // 
            registrar.BackColor = Color.FromArgb(192, 255, 192);
            registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrar.ForeColor = SystemColors.ActiveCaptionText;
            registrar.Location = new Point(270, 100);
            registrar.Name = "registrar";
            registrar.Size = new Size(216, 75);
            registrar.TabIndex = 2;
            registrar.Text = "Registrar Medicamento";
            registrar.UseVisualStyleBackColor = false;
            registrar.Click += registrar_Click;
            // 
            // consulta
            // 
            consulta.BackColor = Color.FromArgb(192, 192, 255);
            consulta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            consulta.Location = new Point(562, 100);
            consulta.Name = "consulta";
            consulta.Size = new Size(219, 75);
            consulta.TabIndex = 3;
            consulta.Text = "Consultar Stock";
            consulta.UseVisualStyleBackColor = false;
            consulta.Click += consulta_Click;
            // 
            // alertas
            // 
            alertas.BackColor = Color.FromArgb(255, 255, 128);
            alertas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            alertas.Location = new Point(270, 245);
            alertas.Name = "alertas";
            alertas.Size = new Size(216, 75);
            alertas.TabIndex = 4;
            alertas.Text = "Ver Alertas";
            alertas.UseVisualStyleBackColor = false;
            alertas.Click += alertas_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(565, 245);
            button1.Name = "button1";
            button1.Size = new Size(216, 75);
            button1.TabIndex = 6;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // atras
            // 
            atras.BackColor = Color.Red;
            atras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atras.ForeColor = Color.White;
            atras.Location = new Point(641, 389);
            atras.Name = "atras";
            atras.Size = new Size(140, 53);
            atras.TabIndex = 7;
            atras.Text = "Atras ";
            atras.UseVisualStyleBackColor = false;
            atras.Click += atras_Click;
            // 
            // formulario_inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(atras);
            Controls.Add(button1);
            Controls.Add(alertas);
            Controls.Add(consulta);
            Controls.Add(registrar);
            Controls.Add(label1);
            Controls.Add(medico2);
            DoubleBuffered = true;
            Name = "formulario_inventario";
            Padding = new Padding(5);
            Text = "formulario_inventario";
            ((System.ComponentModel.ISupportInitialize)medico2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox medico2;
        private Label label1;
        private Button registrar;
        private Button consulta;
        private Button alertas;
        private Button button1;
        private Button atras;
    }
}