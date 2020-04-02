using System.Collections.Generic;

namespace presentacion.Data
{
    public class Contact
    {
        public int Id { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Profile> Profiles { get; set; }
    }
}
