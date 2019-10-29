using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model
{
    /// <summary>
    /// Cette classe indique le pourcentage de résistance pour chaque éléments et chaque status
    /// </summary>
    class UnitResistance
    {
        #region Attributs
        public short Fire { get; set; }
        public short Ice { get; set; }
        public short Lightning { get; set; }
        public short Water { get; set; }
        public short Wind { get; set; }
        public short Earth { get; set; }
        public short Light { get; set; }
        public short Dark { get; set; }

        public byte Poison { get; set; }
        public byte Blind { get; set; }
        public byte Sleep { get; set; }
        public byte Silence { get; set; }
        public byte Paralysis { get; set; }
        public byte Confuse { get; set; }
        public byte Disease { get; set; }
        public byte Petrification { get; set; }
        #endregion

        #region Constructeurs
        public UnitResistance () { }
        #endregion
    }
}
