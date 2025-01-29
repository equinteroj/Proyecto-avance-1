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
    public partial class Formulario_personal : Form
    {
        public Formulario_personal()
        {
            InitializeComponent();
            
        }

        private void Formulario_personal_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario_farmaceuticos nuevo = new Formulario_farmaceuticos();
            this.Hide();
            nuevo.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulario_pagos nuevo1 = new Formulario_pagos();
            this.Hide();
            nuevo1.ShowDialog();
            this.Show();

        }
    }
}
