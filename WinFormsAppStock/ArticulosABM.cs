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
    public partial class ArticulosABM : Form
    {

        public ArticulosABM()
        {
            InitializeComponent();
            txtId.Enabled = false;

        }

        public ArticulosABM(int articuloId)
        {
            InitializeComponent();
            CargarDatosParaModificar(articuloId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo articuloAGuardar = new Articulo();
            ArticuloServices articuloServices = new ArticuloServices();
            string resultado;


            articuloAGuardar.Nombre = txtNombre.Text;
            articuloAGuardar.Marca = txtMarca.Text;
            articuloAGuardar.MinimoStock = Convert.ToDecimal(txtMinimoStock.Text);
            articuloAGuardar.Proveedor = txtProveedor.Text;
            articuloAGuardar.Precio = (decimal)Convert.ToDecimal(txtPrecio.Text);
            articuloAGuardar.Codigo = txtCodigo.Text;

            if (!string.IsNullOrEmpty(txtCodigo.Text)) {

                List<Articulo> listaAuxiliar = articuloServices.GetAllArticulos();

                foreach (Articulo art in listaAuxiliar) {
                    if (art.Codigo == articuloAGuardar.Codigo) {
                        MessageBox.Show($"El codigo ingresado ya existe({art.Codigo})");
                        return;            
                    
                    }
                
                }
            }

            if (string.IsNullOrEmpty(txtId.Text))
            {


                resultado = articuloServices.AgregarArticulo(articuloAGuardar);


                if (resultado == "Articulo agregado")
                {
                    MessageBox.Show("Articulo Agregado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error guardando el Articulo");
                }


            }
            else
            {


                ArticuloServices articuloServicesAuxiliar = new ArticuloServices();
                articuloAGuardar.Id = Convert.ToInt32(txtId.Text);
                resultado = articuloServicesAuxiliar.ActualizarArticulo(articuloAGuardar);

                if (resultado == "Articulo modificado")
                {
                    MessageBox.Show("Articulo Modificado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Modificando el Articulo");
                }



            }
        }

        public void CargarDatosParaModificar(int articuloId)
        {

            ArticuloServices articuloServicesAuxiliar = new ArticuloServices();

            Articulo articuloAMostrar = articuloServicesAuxiliar.BuscarId(articuloId);
            txtId.Text = Convert.ToString(articuloAMostrar.Id);
            txtNombre.Text = articuloAMostrar.Nombre;
            txtMarca.Text = articuloAMostrar.Marca;
            txtMinimoStock.Text = Convert.ToString(articuloAMostrar.MinimoStock);
            txtProveedor.Text = articuloAMostrar.Proveedor;
            txtPrecio.Text = Convert.ToString(articuloAMostrar.Precio);
            txtPrecio.Text = Convert.ToString(articuloAMostrar.Codigo);
            txtId.Enabled = false;



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
