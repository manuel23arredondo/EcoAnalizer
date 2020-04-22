using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion.Data
{
    public class Test
    {
        public int Id { get; set; }

        public Expert Expert { get; set; }
        public ICollection<TestQuestion> TestQuestions { get; set; }
    }
}
