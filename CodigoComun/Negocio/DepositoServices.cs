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

        public List<Deposito> GetTodosLosDepositos()
        {
            DepositoRepository depositoRepository = new DepositoRepository();
            List <Deposito> depositos = depositoRepository.GetAllDepositos();

            return depositos;


        }


        public Deposito GetDepositoPorId(int id)
        {

            DepositoRepository depositoRepository = new DepositoRepository();
            Deposito depositoAuxiliar = depositoRepository.GetDepositoById(id);

            return depositoAuxiliar;
            

        }

        public int AddDeposito(Deposito depositoAAgregar)
        {

            DepositoRepository depositoRepository = new DepositoRepository();

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
            DepositoRepository depositoRepository = new DepositoRepository();


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
