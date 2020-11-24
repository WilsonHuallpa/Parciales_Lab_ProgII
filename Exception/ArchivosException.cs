using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    public class ArchivosException : Exception
    {
        public ArchivosException(string mensaje):base(mensaje)
        {

        }
    }
}
