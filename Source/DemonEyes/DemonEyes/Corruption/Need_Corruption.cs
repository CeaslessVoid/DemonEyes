using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace DemonEyes.Corruption
{
    public class Need_Corruption : Need
    {
        public Need_Corruption(Pawn pawn) : base(pawn) 
        {
            this.threshPercents = new List<float>();

            this.threshPercents.Add(0.9f);
        }
        public override int GUIChangeArrow
        {
            get
            {
                if (this.CurLevel == 0) return 0;

                return StatExtension.GetStatValue(this.pawn, CorruptionDefOf.Neava_Courruption_GainSpeed, true, -1) < 0 ? 1 : -1;
            }
        }

        public override bool ShowOnNeedList
        {
            get
            {
                return !this.Disabled;
            }
        }

        private bool Disabled
        {
            get
            {
                return this.pawn.Dead;
            }
        }
            
        public override void SetInitialLevel()
        {
            this.CurLevel = 0f;
        }

        public override void NeedInterval()
        {
            if (!this.IsFrozen && CurLevel > 0)
            {
                this.CurLevel -= 0.0025f * StatExtension.GetStatValue(this.pawn, CorruptionDefOf.Neava_Courruption_GainSpeed, true, -1) * LoadedModManager.GetMod<NeavaDemonEyes_Mod>().GetSettings<NeavaDemonEyes_Settings>().CorruptionGainMulti;
            }
        }

    }
}
