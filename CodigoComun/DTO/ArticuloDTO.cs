using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Entities;

namespace CodigoComun.DTO
{
    public class ArticuloDTO:BaseDTO
    {

        public Articulo articulo { set; get; }


        public string MostrarError() {

            return this.Mensaje;
        }

    }
}
