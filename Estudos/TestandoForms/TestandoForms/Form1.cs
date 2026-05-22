using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestandoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Aplicação";
            this.label1.Visible = false;
            this.button1.Text = "OK";
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Olá Mundo";
            this.label1.ForeColor = Color.Black;
            this.button1.ForeColor = Color.Black;
            this.button1.BackColor = Color.White;
            this.label1.Visible = true;
            this.Text = "Quero aprender a programar";

        }
    }
}
