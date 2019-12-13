using FFBE_Soft.model;
using FFBE_Soft.model.competence;
using FFBE_Soft.model.equipment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFBE_Soft
{
    public partial class EquipmentDescription : Form
    {
        private readonly Equipment equipment;
        /*
        public EquipmentDescription()
        {
            InitializeComponent();
            CenterToParent();
        }
        */
        public EquipmentDescription(string nom)
        {
            InitializeComponent();
            CenterToParent();

            // ---- TMR
            {
                Equipment S_K = Equipment.CreateEquipment("Storm Kickers", "A pair of sneackers said to have belonged to a warrior of legend. On the right set of feet these stylish shoes are capable of granting its wearer the power to withstand lightning."
                    , "Icon-Storm_Kickers", EquipmentType.Accesory, "TMR Esther");
                S_K.AddFixedStat(StatBuffed.ATK, 45); S_K.AddFixedStat(StatBuffed.DEF, 10);

                PassiveEffect S_K1_1 = PassiveEffect.CreateStatistiquesBuffEffect(true, StatistiquesBuff.HP, 20);
                PassiveEffect S_K1_2 = PassiveEffect.CreateLBDamageEffect(true, 15);
                UnitPassive S_K1 = new UnitPassive(0, 0, "Icon-Ability_276", "Inner Limit");
                S_K1.AddPassiveEffect(S_K1_1);
                S_K1.AddPassiveEffect(S_K1_2);
                S_K.AddEquipmentEffectPassive(S_K1);

                PassiveEffect S_K2_1 = PassiveEffect.CreateAbsorbDamageEffect(ElementDamage.Lightning, TypeDamage.Hybrid);
                UnitPassive S_K2 = new UnitPassive(0, 0, "Icon-Ability_280", "Stormborne"); S_K2.UsableWitheList = true; S_K2.AddUnitToWhiteList("Esther");
                S_K2.AddPassiveEffect(S_K2_1);
                S_K.AddEquipmentEffectPassive(S_K2);

                equipment = S_K;
            }

            Text = equipment.Name;
        }
    }
}
