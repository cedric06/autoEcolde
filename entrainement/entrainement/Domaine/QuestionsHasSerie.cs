using System;
using System.Collections.Generic;

namespace entrainement.Domaine
{
    public partial class QuestionsHasSerie
    {
        public int QuestionsId { get; set; }
        public int SerieId { get; set; }

        public virtual Questions Questions { get; set; }
        public virtual Serie Serie { get; set; }
    }
}
