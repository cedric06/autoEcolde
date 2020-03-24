using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Cdrom
    {
        public Cdrom()
        {
            Serie = new HashSet<Serie>();
        }

        public int Numero { get; set; }
        public string NomEditeur { get; set; }

        public virtual ICollection<Serie> Serie { get; set; }
    }
}
