using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using Verse.Noise;

namespace DemonEyes.HarmonyMain
{
    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            Main.HarmonyInstance.Patch(
                original: AccessTools.Method(typeof(ChoiceLetter_BabyToChild), "Start"),
                postfix: new HarmonyMethod(typeof(HarmonyPatches), nameof(GrantDemonEyes_Baby))
            );
        }

        public static void GrantDemonEyes_Baby(ChoiceLetter_BabyBirth __instance)
        {
            // First Methord Of Getting Demon Eyes: Being Born With It
            // Take effect after age 7
            // Natrual borns will have more control, however stictly more 'weaker' sins

            Pawn baby = __instance.lookTargets.TryGetPrimaryTarget().Thing as Pawn;

            EffecterDefOf.VoidStructureActivatedAmbience.Spawn(baby, baby.Map, 1f);
            CompGlower comp = baby.GetComp<CompGlower>();
            if (comp != null)
            {
                comp.GlowRadius = comp.Props.glowRadius + 1f;
                comp.GlowColor = new ColorInt(240, 160, 184);
            }
        }

    }
}
