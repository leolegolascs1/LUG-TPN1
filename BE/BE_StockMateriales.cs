using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_StockMateriales
    {
        private BE_Materiales _materiales;
        private int _cantidad;

        public BE_Materiales Materiales { get => _materiales; set => _materiales = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
