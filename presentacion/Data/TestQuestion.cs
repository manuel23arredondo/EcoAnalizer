using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion.Data
{
    public class TestQuestion
    {
        public int Id { get; set; }

        public Question Question { get; set; }
        public ICollection<Response> Responses { get; set; }
        public Test Test { get; set; }
    }
}
