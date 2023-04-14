using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CodigoComun.Modelo;
using CodigoComun.Negocio;
using CodigoComun.Entities;

namespace WinFormsAppStock
{
    public partial class StocksForm : Form
    {

        StockService stockService = new StockService();
        public StocksForm()
        {
            InitializeComponent();
            CargarArticulos();
        }


        public void CargarArticulos()
        {


            List<Stock> stocksEnLaDb = stockService.GetAllStocks();
            gvStocks.DataSource = stocksEnLaDb;
            
            gvStocks.Columns.Clear();
            gvStocks.AutoGenerateColumns = false;
            var column1 = new DataGridViewTextBoxColumn()
            {
                Name = "Id column",
                HeaderText = "Id",
                DataPropertyName = "Id"
            };
            var column2 = new DataGridViewTextBoxColumn()
            {
                Name = "IdArticulo column",
                HeaderText = "IdArticulo",
                DataPropertyName = "IdArticulo"
            };
            var column3 = new DataGridViewTextBoxColumn()
            {
                Name = "IdDeposito column",
                HeaderText = "IdDeposito",
                DataPropertyName = "IdDeposito"
            };
            var column4 = new DataGridViewTextBoxColumn()
            {
                Name = "Capacidad column",
                HeaderText = "Capacidad",
                DataPropertyName = "Cantidad"
            };

            this.gvStocks.Columns.Add(column1);
            this.gvStocks.Columns.Add(column2);
            this.gvStocks.Columns.Add(column3);
            this.gvStocks.Columns.Add(column4);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtStockId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }

            int idStockAEliminar = Convert.ToInt32(this.txtStockId.Text);


            string r = stockService.BorrarStock(idStockAEliminar);

            if (r == "Stock eliminado")
            {
                MessageBox.Show("Stock eliminado");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Stock");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtStockId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }
            int stockId = Convert.ToInt32(txtStockId.Text);

            StocksABM stockAuxiliar = new StocksABM(stockId);
            stockAuxiliar.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtStockId.Text) == false)
            {
                MessageBox.Show("El Id ingresado sera ignorado");
            }
            StocksABM stockAuxiliar = new StocksABM();
            stockAuxiliar.Show();
        }

        private void gvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
