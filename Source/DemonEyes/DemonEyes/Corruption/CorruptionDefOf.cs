using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonEyes.Corruption
{
    [DefOf]
    public static class CorruptionDefOf
    {
        static CorruptionDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(CorruptionDefOf));
        }

        public static StatDef Neava_Courruption_GainSpeed;
    }
}
