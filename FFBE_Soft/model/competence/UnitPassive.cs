using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{
    class UnitPassive
    {
        #region Attributs
        public byte Star { get; set; }

        public byte Level { get; set; }

        public string ImgURL { get; set; }

        public string Name { get; set; }

        public List<PassiveEffect> PassiveEffect { get; set; }
        #endregion


        #region Methodes
        public void AddPassiveEffect(PassiveEffect passiveEffect)
        {
            if (PassiveEffect != null)
            {
                PassiveEffect.Add(passiveEffect);
            }
        }

        public string GetEffectsToString()
        {
            string s = "";
            foreach (PassiveEffect passive in PassiveEffect)
            {
                if (!s.Equals(""))
                    s += Environment.NewLine;

                s += passive.Text;
            }
            return s;
        }

        #endregion

        #region Constructors
        public UnitPassive(byte star, byte level, string imgURL, string name)
        {
            this.Star = star; this.Level = level; this.ImgURL = imgURL; this.Name = name;
            this.PassiveEffect = new List<PassiveEffect>();
        }
        #endregion
    }
}
