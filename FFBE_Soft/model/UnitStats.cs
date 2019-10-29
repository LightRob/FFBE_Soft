using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model
{
    class UnitStats
    {
        #region Attributs
        public byte Star { get; set; }
        public short HP { get; set; }
        public short MP { get; set; }
        public short ATK { get; set; }
        public short DEF { get; set; }
        public short MAG { get; set; }
        public short SPR { get; set; }
        public byte AttackHits { get; set; }
        public byte LimitDrop { get; set; }
        public byte ExpPattern { get; set; }
        #endregion

        #region Constructors
        public UnitStats () { }
        #endregion
    }
}
