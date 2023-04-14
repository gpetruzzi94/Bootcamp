using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoComun.Modelo;
using CodigoComun.Negocio;
using CodigoComun.Entities;

using Deposito = CodigoComun.Entities.Deposito;
using CodigoComun.Datos;

namespace WinFormsAppStock
{
    public partial class StocksABM : Form
    {
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
            articuloAMostrar = articuloServicesAuxiliar.GetItems();



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
            
            int resultado;



            stockAGuardar.ArticuloGuardado.Id = articuloAuxiliar.Id;
            stockAGuardar.DepositoDondeEstaGuardado.Id = depositoAuxiliar.Id;
            stockAGuardar.Cantidad = Convert.ToDecimal(txtCantidad.Text);

            if (string.IsNullOrEmpty(txtId.Text))
            {


                resultado = stockAGuardar.AgregarEnDb();


                if (resultado == 1)
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


                Stock stockAuxiliar = new Stock();
                stockAGuardar.Id = Convert.ToInt32(txtId.Text);
                resultado = stockAuxiliar.ActualizarEnDb(stockAGuardar);

                if (resultado == 1)
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

            Stock StockAuxiliar = new Stock();

            Stock stockAMostrar = StockAuxiliar.GetItemsPorId(stockId);
            txtId.Text = Convert.ToString(stockAMostrar.Id);
            txtCantidad.Text = Convert.ToString(stockAMostrar.Cantidad);
            txtId.Enabled = false;



        }
    }
}
