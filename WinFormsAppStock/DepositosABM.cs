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



            if (string.IsNullOrEmpty(txtId.Text))
            {

                DepositoDTO depositoAGuardar = new DepositoDTO();
                depositoAGuardar.Nombre = txtNombre.Text;
                depositoAGuardar.Capacidad = Convert.ToDecimal(txtCapacidad.Text);
                depositoAGuardar.Direccion = txtDireccion.Text;

                depositoAGuardar = depositoServices.AddDeposito(depositoAGuardar);


                if (depositoAGuardar.Mensaje == "Deposito agregado")
                {
                     MessageBox.Show("Deposito Agregado con exito");
                     this.Close();
                }
                else
                {
                     MessageBox.Show("Error guardando el Deposito\n"+$"{depositoAGuardar.Mensaje}");
                }

           
            }
            else
            {

                DepositoDTO depositoAGuardar = new DepositoDTO();
              
                depositoAGuardar.Id = Convert.ToInt32(txtId.Text);
                depositoAGuardar.Nombre= txtNombre.Text;
                depositoAGuardar.Capacidad = Convert.ToDecimal(txtCapacidad.Text);
                depositoAGuardar.Direccion = txtDireccion.Text;
                depositoAGuardar = depositoServices.ModificarDeposito(depositoAGuardar);


                if (depositoAGuardar.Mensaje == "Deposito modificado")
                {
                    MessageBox.Show("Deposito Modificado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Modificando el Deposito\n"+$"{depositoAGuardar.Mensaje}");
               
                }

           
            }
        
        }

        public void CargarDatosParaModificar(int articuloId)
        {


            DepositoDTO depositoAuxiliar = new DepositoDTO();
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

