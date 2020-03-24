using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Examen
    {
        public Examen()
        {
            Eleves = new HashSet<Eleves>();
        }

        public int Id { get; set; }

        public virtual ICollection<Eleves> Eleves { get; set; }
    }
}
