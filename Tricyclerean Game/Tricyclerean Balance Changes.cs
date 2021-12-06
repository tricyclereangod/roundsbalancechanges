using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using TricyclereanBalanceChanges.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
 
namespace TricyclereanBalanceChanges
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(net.huh.rounds.TricyclereanBalanceChanges, TricyclereanBalanceChanges, 1.0.0)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class TricyclereanBalanceChanges : BaseUnityPlugin
    {
	
        private const string ModId = "net.huh.rounds.TricyclereanBalanceChanges";
        private const string ModName = "TricyclereanBalanceChanges";
        public const string Version = "0.0.0"; // What version are we on (major.minor.patch)?
	public const string ModInitials = "TBC";
 	public static TricyclereanBalanceChanges instance {get; private set;}
	

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
	    instance = this;
            CustomCard.BuildCard<MyCardName>(); 
        }
    }
}
