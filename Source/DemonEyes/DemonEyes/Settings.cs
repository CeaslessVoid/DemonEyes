using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace DemonEyes
{
    public class NeavaDemonEyes_Settings : ModSettings
    {
        public override void ExposeData()
        {
            base.ExposeData();
        }

        public float CorruptionGainMulti = 1f;
    }

    internal class NeavaDemonEyes_Mod : Mod
    {
        public NeavaDemonEyes_Mod(ModContentPack content) : base(content)
        {
            this._settings = GetSettings<NeavaDemonEyes_Settings>();
        }

        public override string SettingsCategory()
        {
            return "Demon Eyes from /tg/";
        }

        public override void WriteSettings()
        {
            base.WriteSettings();
            LoadedModManager.GetMod<NeavaDemonEyes_Mod>().GetSettings<NeavaDemonEyes_Settings>().Write();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {

        }

        private NeavaDemonEyes_Settings _settings;
    }
}
