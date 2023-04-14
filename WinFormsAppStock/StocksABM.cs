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

using Deposito = CodigoComun.Entities.Deposito;
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
            Stock stockAGuardar = new Stock();

            Articulo articuloAuxiliar = (Articulo)cbIdArticulo.SelectedItem;
            Deposito depositoAuxiliar = (Deposito)cbIdDeposito.SelectedItem;
            
            string resultado;



            stockAGuardar.IdArticulo = articuloAuxiliar.Id;
            stockAGuardar.IdDeposito = depositoAuxiliar.Id;
            stockAGuardar.Cantidad = Convert.ToDecimal(txtCantidad.Text);

            if (string.IsNullOrEmpty(txtId.Text))
            {


                resultado = stockService.AgregarStock(stockAGuardar);


                if (resultado == "Stock agregado")
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
                resultado = stockService.ActualizarStock(stockAGuardar);

                if (resultado == "Stock modificado")
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


            Stock stockAMostrar = stockService.BuscarId(stockId);
            txtId.Text = Convert.ToString(stockAMostrar.Id);
            txtCantidad.Text = Convert.ToString(stockAMostrar.Cantidad);
            txtId.Enabled = false;



        }
    }
}
