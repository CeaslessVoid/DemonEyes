using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace DemonEyes
{
    internal static class ModUtils
    {
        public static void Msg(object o)
        {
            Log.Message("[Demon Eyes] " + ((o != null) ? o.ToString() : null));
        }

        public static void Warn(object o)
        {
            Log.Warning("[Demon Eyes] " + ((o != null) ? o.ToString() : null));
        }

        public static void Error(object o)
        {
            Log.Error("[Demon Eyes] " + ((o != null) ? o.ToString() : null));
        }
    }
}
