using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class BANCO
    {
        public BANCO()
        {
            CLIENTES = new List<CLIENTE>();
        }
        public List<CLIENTE> CLIENTES { get; set; }
    }
}
