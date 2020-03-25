using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Adresse : Model
    {
        public Adresse()
        {
            Eleves = new HashSet<Eleves>();
        }
        public string Adresse1 { get; set; }

        public virtual ICollection<Eleves> Eleves { get; set; }
    }
}
