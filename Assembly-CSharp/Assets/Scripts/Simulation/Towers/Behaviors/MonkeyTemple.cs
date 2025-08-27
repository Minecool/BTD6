namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MonkeyTemple : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<TowerSet, Single>, Single> <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <StartSacrifice>b__21_0(KeyValuePair<TowerSet, Single> pair) { }

	}

	public static String[] black; //Field offset: 0x0
	public MonkeyTempleModel monkeyTempleModel; //Field offset: 0x68
	public int lastSacrificed; //Field offset: 0x70
	public int lastTransformed; //Field offset: 0x74
	public Dictionary<String, Int32> weaponLastEmission; //Field offset: 0x78
	private Dictionary<TowerSet, Single> selectedTowers; //Field offset: 0x80
	private SortedListLite<BehaviorMutator> mutatorsToApply; //Field offset: 0x88
	public Dictionary<TowerSet, Single> templeTowers; //Field offset: 0x90
	public Dictionary<TowerSet, Single> trueTempleTowers; //Field offset: 0x98
	private bool runSacrifice; //Field offset: 0xA0
	private bool placed; //Field offset: 0xA1
	public List<ObjectId> towersToApplyTCBOOTo; //Field offset: 0xA8
	private bool templeCreatedEventInvoked; //Field offset: 0xB0
	private bool checkTCBOO; //Field offset: 0xB1
	private List<TimedMutator> mutatorsToRemove; //Field offset: 0xB8
	private bool createdTCBOO; //Field offset: 0xC0

	private static MonkeyTemple() { }

	public MonkeyTemple() { }

	public void ApplyTCBOO() { }

	public bool CanFire() { }

	public void CheckTCBOO() { }

	public bool ContainsTowerSet(TowerSet towerSet) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public Dictionary<TowerSet, Single> GetTempleTowerData() { }

	public float GetTowerSetWorth(TowerSet towerSet) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnUpgrade(bool playUpgradeEffect) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void PlayEffect(EffectModel effectModel, Vector3 position) { }

	private void PlayEffectLocal(EffectModel effectModel, Vector3 position) { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	public void RunTempleLoadSacrifice(Dictionary<TowerSet, Single> sacrificedTowers, bool trueTemple) { }

	private void SacrificeBatmanAndRoboCop(Tower mostTerrifyingTechTerror, Tower darkestOfDarkKnights) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private static int SortMutators(BehaviorMutator a, BehaviorMutator b) { }

	private static Tower[] SortTowersForSacrifice(List<Tower> towersToSacrifice) { }

	private void StartSacrifice() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

