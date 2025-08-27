namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class FastUpgradesGameMode : SimulationBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Boolean> <>9__6_0; //Field offset: 0x8
		public static Func<Int32, Boolean> <>9__6_1; //Field offset: 0x10
		public static Func<Int32, Boolean> <>9__6_2; //Field offset: 0x18
		public static Func<Int32, Boolean> <>9__6_3; //Field offset: 0x20
		public static Func<Int32, Boolean> <>9__6_4; //Field offset: 0x28
		public static Predicate<Int32> <>9__6_5; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <FindHighestTierNonBlockedUpgradablePath>b__6_0(int tier) { }

		internal bool <FindHighestTierNonBlockedUpgradablePath>b__6_1(int tier) { }

		internal bool <FindHighestTierNonBlockedUpgradablePath>b__6_2(int tier) { }

		internal bool <FindHighestTierNonBlockedUpgradablePath>b__6_3(int tier) { }

		internal bool <FindHighestTierNonBlockedUpgradablePath>b__6_4(int tier) { }

		internal bool <FindHighestTierNonBlockedUpgradablePath>b__6_5(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public int maxUpgradeableTier; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <FindHighestTierNonBlockedUpgradablePath>b__6(int x) { }

	}

	public FastUpgradesGameModeModel fastUpgradesGameModeModel; //Field offset: 0x58

	public FastUpgradesGameMode() { }

	private int FindHighestTierNonBlockedUpgradablePath(IList<Int32> towerPaths, Dictionary<Int32, Tuple`2<TowerModel, Boolean>> upgradableTowerModelsData) { }

	private Dictionary<Int32, Tuple`2<TowerModel, Boolean>> GenerateUpgradebleTowerTierData(Tower tower) { }

	private TowerModel GetTowerModelForTier(Tower tower, int pathToUpgrade) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

