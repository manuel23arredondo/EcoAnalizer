using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion.Data
{
    public class Response
    {
        public int Id { get; set; }

        public TestQuestion TestQuestion { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
