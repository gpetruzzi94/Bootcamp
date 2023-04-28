using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoComun.DTO;
using CodigoComun.Negocio;
using CodigoComun.Entities;
using CodigoComun.Datos;

namespace WinFormsAppStock
{
    public partial class StocksABM : Form
    { 

        StockService stockService = new StockService();


        public StocksABM()
        {
            InitializeComponent();
            CargarComboBox();
            txtId.Enabled = false;

        }

        public StocksABM(int stockId)
        {
            InitializeComponent();
            CargarComboBox();
            CargarDatosParaModificar(stockId);

        }

        public void CargarComboBox() { 
            List<Deposito> depositoAMostrar = new List<Deposito>();
            List<Articulo> articuloAMostrar = new List<Articulo>();

            Deposito depositoAuxiliar = new Deposito();
            DepositoServices depositoServices = new DepositoServices();
            depositoAMostrar = depositoServices.GetTodosLosDepositos();

            ArticuloServices articuloServicesAuxiliar = new ArticuloServices();
            articuloAMostrar = articuloServicesAuxiliar.GetAllArticulos();


            cbIdDeposito.DataSource = new BindingSource(depositoAMostrar, null);
            cbIdArticulo.DataSource = new BindingSource(articuloAMostrar, null);
            cbIdDeposito.DisplayMember = "IdDeposito";
            cbIdDeposito.ValueMember = "Id";
            cbIdArticulo.DisplayMember = "IdArticulo";
            cbIdArticulo.ValueMember = "Id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockDTO stockAGuardar = new StockDTO();
            Articulo articuloAuxiliar = (Articulo)cbIdArticulo.SelectedItem;
            Deposito depositoAuxiliar = (Deposito)cbIdDeposito.SelectedItem;
            
            string resultado;

            stockAGuardar.IdArticulo = articuloAuxiliar.Id;
            stockAGuardar.IdDeposito = depositoAuxiliar.Id;
            stockAGuardar.Cantidad = Convert.ToDecimal(txtCantidad.Text);

            if (string.IsNullOrEmpty(txtId.Text))
            {

                stockAGuardar = stockService.AgregarStock(stockAGuardar);

                if (stockAGuardar.Mensaje == "Stock agregado")
                {
                    MessageBox.Show("Stock Agregado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error guardando el Stock");
                }

            }
            else
            {

                stockAGuardar.Id = Convert.ToInt32(txtId.Text);
                stockAGuardar = stockService.ActualizarStock(stockAGuardar);

                if (stockAGuardar.Mensaje == "Stock modificado")
                {
                    MessageBox.Show("Stock Modificado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Modificando el Stock");
                }

            }
        }

        public void CargarDatosParaModificar(int stockId)
        {


            StockDTO stockAMostrar = stockService.BuscarId(stockId);
            txtId.Text = Convert.ToString(stockAMostrar.Id);
            txtCantidad.Text = Convert.ToString(stockAMostrar.Cantidad);
            txtId.Enabled = false;



        }
    }
}
