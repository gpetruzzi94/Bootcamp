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

            List<ArticuloDTO> articulosEnLaDb = articuloServices.GetAllArticulos();
            gvArticulos.DataSource = articulosEnLaDb;


            gvArticulos.Columns.Clear();
            gvArticulos.AutoGenerateColumns = false;
            var column1 = new DataGridViewTextBoxColumn()
            {
                Name = "Id column",
                HeaderText = "Id",
                DataPropertyName = "Id"
            };
            var column2 = new DataGridViewTextBoxColumn()
            {
                Name = "Nombre column",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            };
            var column3 = new DataGridViewTextBoxColumn()
            {
                Name = "Marca column",
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            };
            var column4 = new DataGridViewTextBoxColumn()
            {
                Name = "MinimoStock column",
                HeaderText = "MinimoStock",
                DataPropertyName = "MinimoStock"
            };
            var column5 = new DataGridViewTextBoxColumn()
            {
                Name = "Proveedor column",
                HeaderText = "Proveedor",
                DataPropertyName = "Proveedor"
            };
            var column6 = new DataGridViewTextBoxColumn()
            {
                Name = "Precio column",
                HeaderText = "Precio",
                DataPropertyName = "Precio"
            };
            var column7 = new DataGridViewTextBoxColumn()
            {
                Name = "Codigo column",
                HeaderText = "Codigo",
                DataPropertyName = "Codigo"
            };

            this.gvArticulos.Columns.Add(column1);
            this.gvArticulos.Columns.Add(column2);
            this.gvArticulos.Columns.Add(column3);
            this.gvArticulos.Columns.Add(column4);
            this.gvArticulos.Columns.Add(column5);
            this.gvArticulos.Columns.Add(column6);
            this.gvArticulos.Columns.Add(column7);


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
                MessageBox.Show("No se pudo eliminar el Articulo\n" + $"{articuloAuxiliar.Mensaje}");
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
