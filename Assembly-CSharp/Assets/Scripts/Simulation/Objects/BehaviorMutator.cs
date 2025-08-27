namespace Assets.Scripts.Simulation.Objects;

public abstract class BehaviorMutator
{
	internal struct MutationLimiter
	{
		public string id; //Field offset: 0x0
		public int count; //Field offset: 0x8
		public bool lastAppliesFirst; //Field offset: 0xC

	}

	private static List<BehaviorMutator> bloonMutators; //Field offset: 0x0
	public string id; //Field offset: 0x10
	private bool usesSplitId; //Field offset: 0x18
	private string idMajor; //Field offset: 0x20
	private string idMajorMinor; //Field offset: 0x28
	public bool isExclusiveInMutationList; //Field offset: 0x30
	public int priority; //Field offset: 0x34
	public int glueLevel; //Field offset: 0x38
	public bool dontCopy; //Field offset: 0x3C
	public BuffIndicatorModel buffIndicator; //Field offset: 0x40
	public string saveId; //Field offset: 0x48
	public bool isAreaBuff; //Field offset: 0x50
	public bool isGeraldoBuff; //Field offset: 0x51
	public bool isArtifactMutator; //Field offset: 0x52
	public bool dontRemoveOnBloonDegrade; //Field offset: 0x53
	public bool cantBeAbsorbed; //Field offset: 0x54
	public List<MutationLimiter> limiters; //Field offset: 0x58
	private Dictionary<Model, Model> resultCache; //Field offset: 0x60
	private HashSet<ObjectId> mutated; //Field offset: 0x68

	private static BehaviorMutator() { }

	protected BehaviorMutator(string id, bool isUnique = true, int priority = 1, bool lastAppliesFirst = false, BuffIndicatorModel buffIndicator = null, int stackCount = 0, string saveId = null, bool isArtifactMutator = false, bool dontRemoveOnBloonDegrade = false, bool cantBeAbsorbed = false) { }

	public void AddMutating(Mutable mutable) { }

	public static bool AddOverlayToBloonModel(string overlayType, BloonModel bloonModel) { }

	public override bool CountBuffTowardsAchievement() { }

	protected void Initialise(string id, int stackCount, int priority, bool lastAppliesFirst, BuffIndicatorModel buffIndicator, string saveId, bool isArtifactMutator, bool dontRemoveOnBloonDegrade, bool cantBeAbsorbed) { }

	public bool Match(string checkId) { }

	public override int MaxStackCount(string id) { }

	public override bool Mutate(Model baseModel, Model model) { }

	public Model MutateFromCache(Model baseModel, Model model) { }

	public static void PurgeMutatorCacheForBloons() { }

	public void RemoveMutating(Mutable mutable) { }

	public void SetId(string newId) { }

	public override int StackCount() { }

	public static void StunTower(TowerModel towerModel, PrefabReference stunDisplay = null, bool hideDisplayForSubtowers = false) { }

	public bool WasModelMutated(Mutable mutable) { }

}

