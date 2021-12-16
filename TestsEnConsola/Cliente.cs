using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEnConsola
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
    public class CollectionSample
    {
        public static Cliente GetCustomer(Cliente[] customers, int index)
        {
            return customers[index];
        }
    }
}
