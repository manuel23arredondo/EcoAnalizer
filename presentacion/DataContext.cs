using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using presentacion.Data;

namespace presentacion
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name : App")
        {

        }


    }
}
