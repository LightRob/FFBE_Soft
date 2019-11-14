using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{
    class UnitCompActive
    {
        public byte Star { get; set; }

        public byte Level { get; set; }

        public string ImgURL { get; set; }

        public string Name { get; set; }

        public CompEffect CompEffect { get; set; }
    }
}
