using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{
    class UnitAbility
    {
        #region Attributs
        public byte Star { get; set; }

        public byte Level { get; set; }

        public string ImgURL { get; set; }

        public string Name { get; set; }

        public List<AbilityEffect> CompEffect { get; set; }

        /// <summary>
        /// Number of MP needed for the ability
        /// </summary>
        public short MPCost { get; set; }

        /// <summary>
        /// If the ability is usable only by certains units
        /// </summary>
        public bool UsableWitheList { get; set; }

        /// <summary>
        /// WhiteList of the ability
        /// </summary>
        public List<string> WhiteList { get; set; }
        
        #endregion

        #region Methodes
        public void AddCompEffect(AbilityEffect compEffect)
        {
            if(CompEffect != null)
            {
                CompEffect.Add(compEffect);
            }
        }

        public string GetEffectsToString()
        {
            string s = "";
            foreach (AbilityEffect comp in CompEffect)
            {
                if (!s.Equals(""))
                    s += Environment.NewLine;

                s += comp.Text;
            }
            return s;
        }


        public string GetHitsToString()
        {
            string s = "";
            foreach (AbilityEffect comp in CompEffect)
            {
                if (comp.Hits > 0)
                {
                    if (!s.Equals(""))
                        s += Environment.NewLine;

                    s += comp.Hits;
                }
            }
            return s;
        }

        public void AddUnitToWhiteList(string s)
        {
            if (WhiteList != null)
                WhiteList.Add(s);
        }
        public string GetWhiteListString()
        {
            string r = "";
            foreach (string s in WhiteList)
            {
                r += s + ", ";
            }
            if (r != null && r.Length > 2)
                r = r.Remove(r.Length - 2);

            return r;
        }
        #endregion

        #region Constructors
        public UnitAbility()
        {

        }
        public UnitAbility (byte star, byte level, string imgURL, string name, short mpCost)
        {
            this.Star = star; this.Level = level; this.ImgURL = imgURL; this.Name = name; this.MPCost = mpCost;
            this.CompEffect = new List<AbilityEffect>();
        }
        #endregion
    }
}
