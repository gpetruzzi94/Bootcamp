using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Entities;

namespace CodigoComun.DTO
{
    public class DepositoDTO:BaseDTO
    {
        public Deposito deposito { set; get; }


        public string MostrarError()
        {

            return this.Mensaje;
        }

    }
}
