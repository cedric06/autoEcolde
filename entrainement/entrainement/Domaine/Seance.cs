using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Seance
    {
        public Seance()
        {
            ElevesHasSeance = new HashSet<ElevesHasSeance>();
        }

        public int Id { get; set; }
        public string Date { get; set; }
        public int SerieId { get; set; }

        public virtual Serie Serie { get; set; }
        public virtual ICollection<ElevesHasSeance> ElevesHasSeance { get; set; }
    }
}
