using CodigoComun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.DTO
{
    public class StockDTO:BaseDTO
    {
        public Stock stock { set; get; }


        public string MostrarError()
        {

            return this.Mensaje;
        }

    }
}
