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
using CodigoComun.Entities;
using CodigoComun.Datos;
using CodigoComun.Negocio;

namespace WinFormsAppStock
{
    public partial class DepositosForm : Form
    {

        public DepositosForm()
        {
            InitializeComponent();
            CargarDepositos();
        }



        public void CargarDepositos()
        {
            DepositoServices depositoServices = new DepositoServices();
            List<Deposito> depositosEnLaDb = depositoServices.GetTodosLosDepositos();
            gvDepositos.DataSource = depositosEnLaDb;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtDepositoId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }

            int idDepositoAEliminar = Convert.ToInt32(this.txtDepositoId.Text);
            DepositoServices depositoServices = new DepositoServices();
            string r = depositoServices.EliminarDeposito(idDepositoAEliminar);

            if (r == "Deposito eliminado")
            {
                MessageBox.Show("Deposito eliminado");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Deposito");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDepositoId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }
            int depositoId = Convert.ToInt32(txtDepositoId.Text);

            DepositosABM articuloAuxiliar = new DepositosABM(depositoId);
            articuloAuxiliar.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDepositoId.Text) == false)
            {
                MessageBox.Show("El Id ingresado sera ignorado");
            }
            DepositosABM depositoAuxiliar = new DepositosABM();
            depositoAuxiliar.Show();
        }

        private void DepositosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
