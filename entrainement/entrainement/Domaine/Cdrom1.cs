using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Cdrom1
    {
        public Cdrom1()
        {
            Serie = new HashSet<Serie>();
        }

        public int Numero { get; set; }
        public string NomEditeur { get; set; }

        public virtual ICollection<Serie> Serie { get; set; }
    }
}
