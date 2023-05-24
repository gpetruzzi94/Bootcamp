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
            List<DepositoDTO> depositosEnLaDb = depositoServices.GetTodosLosDepositos();
            gvDepositos.DataSource = depositosEnLaDb;

            gvDepositos.Columns.Clear();
            gvDepositos.AutoGenerateColumns = false;
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
                Name = "Direccion column",
                HeaderText = "Direccion",
                DataPropertyName = "Direccion"
            };
            var column4 = new DataGridViewTextBoxColumn()
            {
                Name = "Capacidad column",
                HeaderText = "Capacidad",
                DataPropertyName = "Capacidad"
            };

            this.gvDepositos.Columns.Add(column1);
            this.gvDepositos.Columns.Add(column2);
            this.gvDepositos.Columns.Add(column3);
            this.gvDepositos.Columns.Add(column4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositoDTO depositoAuxiliar = new DepositoDTO();
            if (string.IsNullOrEmpty(this.txtDepositoId.Text))
            {
                MessageBox.Show("Ingrese un Id e intente de nuevo");
                return;
            }

            int idDepositoAEliminar = Convert.ToInt32(this.txtDepositoId.Text);
            DepositoServices depositoServices = new DepositoServices();
            depositoAuxiliar = depositoServices.EliminarDeposito(idDepositoAEliminar);

            if (depositoAuxiliar.Mensaje == "Deposito eliminado")
            {
                MessageBox.Show("Deposito eliminado");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Deposito\n"+$"{depositoAuxiliar.Mensaje}");
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
