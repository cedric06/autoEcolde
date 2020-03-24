using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Adresse
    {
        public Adresse()
        {
            Eleves = new HashSet<Eleves>();
        }

        public int Id { get; set; }
        public string Adresse1 { get; set; }

        public virtual ICollection<Eleves> Eleves { get; set; }
    }
}
