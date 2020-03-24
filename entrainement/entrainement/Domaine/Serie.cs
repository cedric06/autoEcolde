using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Serie
    {
        public Serie()
        {
            QuestionsHasSerie = new HashSet<QuestionsHasSerie>();
            Seance = new HashSet<Seance>();
        }

        public int Id { get; set; }
        public int CdromId { get; set; }

        public virtual Cdrom Cdrom { get; set; }
        public virtual ICollection<QuestionsHasSerie> QuestionsHasSerie { get; set; }
        public virtual ICollection<Seance> Seance { get; set; }
    }
}
