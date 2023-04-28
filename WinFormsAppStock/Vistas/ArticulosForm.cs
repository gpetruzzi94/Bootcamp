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
using CodigoComun.Entities;
using CodigoComun.Negocio;

namespace WinFormsAppStock.Vistas
{
    public partial class ArticulosForm : Form
    {

        ArticuloServices articuloServices = new ArticuloServices();
        public ArticulosForm()
        {
            InitializeComponent();
            CargarArticulos();
        }


        public void CargarArticulos()
        {

            List<Articulo> articulosEnLaDb = articuloServices.GetAllArticulos();
            gvArticulos.DataSource = articulosEnLaDb;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticuloDTO articuloAuxiliar = new ArticuloDTO();

            if (string.IsNullOrEmpty(this.txtArticuloId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }

            int idArticuloAEliminar = Convert.ToInt32(this.txtArticuloId.Text);


            articuloAuxiliar = articuloServices.BorrarArticulo(idArticuloAEliminar);

            if (articuloAuxiliar.Mensaje == "Articulo eliminado")
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
