using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{

    public enum ElementResistance
    {
        Fire = 0x01,
        Ice = 0x02,
        Lightning = 0x04,
        Water = 0x08,
        Wind = 0x10,
        Earth = 0x20,
        Light = 0x40,
        Dark = 0x80
    }

    public enum AilmentResistance
    {
        Poison = 0x01,
        Blind = 0x02,
        Sleep = 0x04,
        Silence = 0x08,
        Paralysis = 0x10,
        Confuse = 0x20,
        Disease = 0x40,
        Petrification = 0x80,
        Stop = 0x100,
        Charm = 0X200
    }

    class PassiveEffect
    {
        /// <summary>
        /// Text of the passive effect
        /// </summary>
        public string Text { get; set; }


        #region Support Passive - Element Buff
        /// <summary>
        /// If the passive buff element resistance
        /// </summary>
        public bool IsBuffElementResistance { get; set; }

        /// <summary>
        /// Element resistance
        /// </summary>
        public ElementResistance ElementResistance { get; set; }

        /// <summary>
        /// Coefficient of the element resistance
        /// </summary>
        public short CoeffElementResistance { get; set; }
        #endregion
        private PassiveEffect(bool isBuffElementResistance, ElementResistance element, short coeffElementResistance)
        {
            this.IsBuffElementResistance = isBuffElementResistance; this.ElementResistance = element; this.CoeffElementResistance = coeffElementResistance;
        }
        static public PassiveEffect CreateElementResistanceEffect(bool isBuffElementResistance, ElementResistance element, short coeffElementResistance)
        {
            return new PassiveEffect(isBuffElementResistance, element, coeffElementResistance);
        }


        #region Support Passive - Ailment Buff
        /// <summary>
        /// If the passive buff ailment resistance
        /// </summary>
        public bool IsBuffAilmentResistance { get; set; }

        /// <summary>
        /// Ailment resistance
        /// </summary>
        public AilmentResistance AilmentResistance { get; set; }

        /// <summary>
        /// Coefficient of the ailment resistance
        /// </summary>
        public byte CoeffAilmentResistance { get; set; }
        #endregion
        private PassiveEffect(bool isBuffAilmentResistance, AilmentResistance ailment, byte coeffAilmentResistance)
        {
            this.IsBuffAilmentResistance = isBuffAilmentResistance; this.AilmentResistance = ailment; this.CoeffAilmentResistance = coeffAilmentResistance;
        }
        static public PassiveEffect CreateAilmentResistanceEffect(bool isBuffAilmentResistance, AilmentResistance ailment, byte coeffAilmentResistance)
        {
            return new PassiveEffect(isBuffAilmentResistance, ailment, coeffAilmentResistance);
        }
    }
}
