namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(PropSpawningChallenge), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PropSpawningChallengeModel : SimulationBehaviorModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Int32, Int32[]>, Int32> <>9__13_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<Int32, Int32[]>, Int32[]> <>9__13_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <CloneDictionary>b__13_0(KeyValuePair<Int32, Int32[]> kvp) { }

		internal Int32[] <CloneDictionary>b__13_1(KeyValuePair<Int32, Int32[]> kvp) { }

	}

	public Dictionary<Int32, Int32[]> groupLayerSpawners; //Field offset: 0x30
	public Int32[] propIdsToTrack; //Field offset: 0x38
	public bool defeatOnMaxPropsReached; //Field offset: 0x40
	public bool victoryOnMinPropsReached; //Field offset: 0x41
	public bool showPropCountUi; //Field offset: 0x42
	public int maxSpawnCount; //Field offset: 0x44
	public int propRemovalCost; //Field offset: 0x48
	public string propRemovalCostLoc; //Field offset: 0x50
	public SpriteReference hudIcon; //Field offset: 0x58
	public string defeatLoc; //Field offset: 0x60

	public PropSpawningChallengeModel(Dictionary<Int32, Int32[]> groupLayerSpawners, Int32[] propIdsToTrack, bool defeatOnMaxPropsReached, bool victoryOnMinPropsReached, bool showPropCountUi, int maxSpawnCount, int propRemovalCost, SpriteReference hudIcon, string propRemovalCostLoc, string defeatLoc) { }

	public virtual Model Clone() { }

	private Dictionary<Int32, Int32[]> CloneDictionary(Dictionary<Int32, Int32[]> toClone) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

