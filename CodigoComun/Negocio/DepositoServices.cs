using CodigoComun.Datos;
using CodigoComun.Entities;
using CodigoComun.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Negocio
{
    public class DepositoServices
    {
        DepositoRepository depositoRepository = new DepositoRepository();

        public List<Deposito> GetTodosLosDepositos()
        {
            List <Deposito> depositos = depositoRepository.GetAllDepositos();

            return depositos;


        }


        public DepositoDTO GetDepositoPorId(int id)
        {
            DepositoDTO depositoAuxiliar = new DepositoDTO();
            depositoAuxiliar =depositoAuxiliar.GetDepositoDTO(depositoRepository.GetDepositoById(id));

            return depositoAuxiliar;
            

        }

        public DepositoDTO AddDeposito(DepositoDTO depositoAAgregar)
        {
            Deposito deposito = depositoAAgregar.GetDeposito(depositoAAgregar);
            int r = depositoRepository.AddDepositoDb(deposito);


            if (r == 1)
            {
                depositoAAgregar.Mensaje = "Deposito agregado";
                return depositoAAgregar;
            }
            else
            {
                depositoAAgregar.HuboError = true;
                depositoAAgregar.Mensaje = "No se pudo agregar el deposito";
                return depositoAAgregar;

            }

        }

        public DepositoDTO EliminarDeposito(int id)
        {
            

            DepositoDTO deposito = new DepositoDTO();
            int r = depositoRepository.EliminarDepositoDb(id);


            if (r == 1)
            {
                deposito.Mensaje = "Deposito agregado";
                return deposito;
            }
            else
            {
                deposito.HuboError = true;
                deposito.Mensaje = "No se pudo agregar el deposito";
                return deposito;

            }

        }


        public DepositoDTO ModificarDeposito(DepositoDTO depositoAModificar) {


            Deposito deposito = depositoAModificar.GetDeposito(depositoAModificar);
            int r = depositoRepository.UpdateDeposito(deposito);

            if (r == 1)
            {
                depositoAModificar.Mensaje = "Deposito modificado";
                return depositoAModificar;
            }
            else 
            {
                depositoAModificar.HuboError = true;
                depositoAModificar.Mensaje = "No se pudo modificar el deposito";
                return depositoAModificar;
            }
        
        }



    }
}
