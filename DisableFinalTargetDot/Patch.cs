using HarmonyLib;
using PlayerRoles;
using PlayerRoles.PlayableScps.HumanTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mirror;

namespace DisableFinalTargetDot
{
    [HarmonyPatch(typeof(LastHumanTracker), "ServerUpdateLastHumanTracking")]
    public class BlockTrackingPatch()
    {
        private static bool Prefix(LastHumanTracker __instance)
        {
            __instance.Network_lastTargetNetId = 0U;
            __instance.Network_lastTargetPos = null;
            return false;
        }
    }
}