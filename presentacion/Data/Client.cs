using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion.Data
{
    public class Client
    {
        public int Id { get; set; }

        public Response Response { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
