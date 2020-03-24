using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class Questions
    {
        public Questions()
        {
            QuestionsHasSerie = new HashSet<QuestionsHasSerie>();
        }

        public int Id { get; set; }
        public string Intitulé { get; set; }
        public string Reponse { get; set; }
        public string Difficulty { get; set; }
        public string Theme { get; set; }

        public virtual ICollection<QuestionsHasSerie> QuestionsHasSerie { get; set; }
    }
}
