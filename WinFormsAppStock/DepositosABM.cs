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
using CodigoComun.Datos;
using CodigoComun.Entities;
using CodigoComun.Negocio;

namespace WinFormsAppStock
{
    public partial class DepositosABM : Form
    {
        public DepositosABM()
        {
            InitializeComponent();
            txtId.Enabled = false;

        }

        public DepositosABM(int depositoId)
        {
            InitializeComponent();
            CargarDatosParaModificar(depositoId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositoServices depositoServices = new DepositoServices();

            int resultado;

            if (string.IsNullOrEmpty(txtId.Text))
            {

                CodigoComun.Entities.Deposito depositoAGuardar = new CodigoComun.Entities.Deposito();
                depositoAGuardar.Nombre = txtNombre.Text;
                depositoAGuardar.Capacidad = Convert.ToDecimal(txtCapacidad.Text);
                depositoAGuardar.Direccion = txtDireccion.Text;

                resultado = depositoServices.AddDeposito(depositoAGuardar);


                if (resultado == 1)
                {
                     MessageBox.Show("Deposito Agregado con exito");
                     this.Close();
                }
                else
                {
                     MessageBox.Show("Error guardando el Deposito");
                }

           
            }
            else
            {

                CodigoComun.Modelo.Deposito depositoAGuardar = new CodigoComun.Modelo.Deposito();

                CodigoComun.Modelo.Deposito depositoAuxiliar = new CodigoComun.Modelo.Deposito();               
                depositoAGuardar.Id = Convert.ToInt32(txtId.Text);               
                resultado = depositoAuxiliar.ActualizarEnDb(depositoAGuardar);

               
                if (resultado == 1)
                {                  
                    MessageBox.Show("Deposito Modificado con exito");                   
                    this.Close();               
                }
                else
                {
                    MessageBox.Show("Error Modificando el Deposito");
               
                }

           
            }
        
        }

        public void CargarDatosParaModificar(int articuloId)
        {


            CodigoComun.Entities.Deposito depositoAuxiliar = new CodigoComun.Entities.Deposito();
            DepositoServices depositoServices = new DepositoServices();

           depositoAuxiliar = depositoServices.GetDepositoPorId(articuloId);
           txtId.Text = Convert.ToString(depositoAuxiliar.Id);
           txtNombre.Text = depositoAuxiliar.Nombre;
           txtDireccion.Text = depositoAuxiliar.Direccion;
           txtCapacidad.Text = Convert.ToString(depositoAuxiliar.Capacidad);
           txtId.Enabled = false;



        }


    }
}

