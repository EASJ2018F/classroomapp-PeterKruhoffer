using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Klasserum
    {
        public string KlasseNavn { get; set; }

        public List<Studerende> Klasseliste { get; set; }

        public DateTime SemesterStart { get; set; }

        public Klasserum()
        { 
        }
    }
}
