using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{
    class UnitLimit
    {
        #region Attributs
        public byte Star { get; set; }

        public string Name { get; set; }

        public List<LimitEffect> LimitEffect { get; set; }

        public short LBCost { get; set; }
        #endregion


        #region Methodes
        public void AddLimitEffect(LimitEffect limitEffect)
        {
            if (LimitEffect != null)
            {
                LimitEffect.Add(limitEffect);
            }
        }

        public string GetEffectsToString()
        {
            string s = "";
            foreach (LimitEffect limit in LimitEffect)
            {
                if (!s.Equals(""))
                    s += Environment.NewLine;

                s += limit.Text;
            }
            return s;
        }

        public string GetHitsToString()
        {
            string s = "";
            foreach (LimitEffect limit in LimitEffect)
            {
                if (limit.Hits > 0)
                {
                    if (!s.Equals(""))
                        s += Environment.NewLine;

                    s += limit.Hits;
                }
            }
            return s;
        }
        #endregion

        #region Constructors
        public UnitLimit(byte star, string name, short lbCost)
        {
            this.Star = star; this.Name = name;
            this.LimitEffect = new List<LimitEffect>();
            this.LBCost = lbCost;
        }
        #endregion
    }
}
