using System.Collections.Generic;

namespace presentacion.Data
{
    public class Expert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Degree { get; set; }

        public ICollection<Profile> Profiles { get; set; }
    }
}
