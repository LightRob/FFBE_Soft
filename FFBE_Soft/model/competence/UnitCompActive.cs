using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFBE_Soft.model.competence
{
    class UnitCompActive
    {
        #region Attributs
        public byte Star { get; set; }

        public byte Level { get; set; }

        public string ImgURL { get; set; }

        public string Name { get; set; }

        public List<CompEffect> CompEffect { get; set; }
        #endregion

        #region Methodes
        public void AddCompEffect(CompEffect compEffect)
        {
            if(CompEffect != null)
            {
                CompEffect.Add(compEffect);
            }
        }

        /// <summary>
        /// Number of MP needed for the ability
        /// </summary>
        public short MPCost { get; set; }
        #endregion

        #region Constructors
        public UnitCompActive (byte star, byte level, string imgURL, string name, short mpCost)
        {
            this.Star = star; this.Level = level; this.ImgURL = imgURL; this.Name = name; this.MPCost = mpCost;
            this.CompEffect = new List<CompEffect>();
        }
        #endregion
    }
}
