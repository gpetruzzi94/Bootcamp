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

namespace WinFormsAppStock.Vistas
{
    public partial class ArticulosForm : Form
    {
        public ArticulosForm()
        {
            InitializeComponent();
            CargarArticulos();
        }


        public void CargarArticulos()
        {

            ArticuloServices articuloServicesAuxiliar = new ArticuloServices();
            List<Articulo> articulosEnLaDb = articuloServicesAuxiliar.GetItems();
            gvArticulos.DataSource = articulosEnLaDb;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtArticuloId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }

            int idArticuloAEliminar = Convert.ToInt32(this.txtArticuloId.Text);

            ArticuloServices articuloServicesAuxiliar = new ArticuloServices();

            int r = articuloServicesAuxiliar.BorrarArticulo(idArticuloAEliminar);

            if (r == 1)
            {
                MessageBox.Show("Articulo eliminado");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Articulo");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtArticuloId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }
            int articuloId = Convert.ToInt32(txtArticuloId.Text);

            ArticulosABM articuloAuxiliar = new ArticulosABM(articuloId);
            articuloAuxiliar.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtArticuloId.Text) == false)
            {
                MessageBox.Show("El Id ingresado sera ignorado");
            }
            ArticulosABM articuloAuxiliar = new ArticulosABM();
            articuloAuxiliar.Show();
        }
    }
}
