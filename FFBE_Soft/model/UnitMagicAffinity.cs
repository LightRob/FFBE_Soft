using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model
{
    class UnitMagicAffinity
    {
        #region Attributs
        public byte WhiteMagicLvl { get; set; }
        public byte BlackMagicLvl { get; set; }
        public byte GreenMagicLvl { get; set; }
        public byte BlueMagicLvl  { get; set; }
        #endregion

        #region Constructors
        public UnitMagicAffinity () { }
        #endregion
    }
}
