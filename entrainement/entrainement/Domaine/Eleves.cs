using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Eleves
    {
        public Eleves()
        {
            ElevesHasSeance = new HashSet<ElevesHasSeance>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Birth { get; set; }
        public int AdresseId { get; set; }
        public int ExamenId { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Examen Examen { get; set; }
        public virtual ICollection<ElevesHasSeance> ElevesHasSeance { get; set; }
    }
}
