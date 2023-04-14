using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppStock.Vistas;



namespace WinFormsAppStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticulosForm articulosForm = new ArticulosForm();
            articulosForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepositosForm depositosForm = new DepositosForm();
            depositosForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StocksForm stocksForm = new StocksForm();
            stocksForm.Show();

        }
    }
}