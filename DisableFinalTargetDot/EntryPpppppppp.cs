using HarmonyLib;
using LabApi;
using LabApi.Loader.Features.Plugins;
using System.Reflection;

namespace DisableFinalTargetDot
{
    public class EntryPpppppppp : Plugin
    {
        public override string Name => "DisableFinalTargetDot";
        public override string Description => "Disables red dot for final human player";
        public override string Author => "Denty";
        public override Version RequiredApiVersion => new Version("1.0.0");

        public static Harmony Harmony;

        public override void Disable()
        {
            Harmony.UnpatchAll(Harmony.Id);
        }

        public override void Enable()
        {
            Harmony = new Harmony($"{Author}.{Name}");
            Harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}