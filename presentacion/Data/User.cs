using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion.Data
{
    public class User
    {
        public int Id { get; set; }

        public Client Client { get; set; }
        public Expert Expert { get; set; }
    }
}
