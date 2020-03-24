using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class ElevesHasSeance
    {
        public int SeanceId { get; set; }
        public int? Nbfaute { get; set; }
        public int Id { get; set; }
        public int ElevesId { get; set; }

        public virtual Eleves Eleves { get; set; }
        public virtual Seance Seance { get; set; }
    }
}
