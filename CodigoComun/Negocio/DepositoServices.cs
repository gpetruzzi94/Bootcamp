using CodigoComun.Datos;
using CodigoComun.Entities;
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


        public Deposito GetDepositoPorId(int id)
        {

            Deposito depositoAuxiliar = depositoRepository.GetDepositoById(id);

            return depositoAuxiliar;
            

        }

        public int AddDeposito(Deposito depositoAAgregar)
        {

            int r = depositoRepository.AddDepositoDb(depositoAAgregar);


            if (r == 1)
            {

                return 1;
            }
            else
            {
                return -1;

            }

        }

        public int EliminarDeposito(int id)
        {
            


            int r = depositoRepository.EliminarDepositoDb(id);


            if (r == 1)
            {

                return 1;
            }
            else
            {
                return -1;

            }

        }



    }
}
