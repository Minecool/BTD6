namespace Assets.Scripts.Simulation.Input;

public class TowerInventory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<FreeTowerInInventory> <>9__36_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <AddFreeTowers>b__36_0(FreeTowerInInventory a, FreeTowerInInventory b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public string discountName; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal bool <AddTowerDiscount>b__0(TowerDiscount v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public TowerDiscountSaveDataModel d; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal bool <SetTowerDiscountSaveData>b__0(TowerDiscount v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_1
	{
		public TowerDiscount d; //Field offset: 0x10

		public <>c__DisplayClass43_1() { }

		internal bool <SetTowerDiscountSaveData>b__1(TowerDiscountSaveDataModel v) { }

	}

	private const int pathMax = 3; //Field offset: 0x0
	private const int tierMax = 7; //Field offset: 0x0
	private const int heroPathMax = 1; //Field offset: 0x0
	private const int heroTierMax = 21; //Field offset: 0x0
	private int totalTowerCount; //Field offset: 0x10
	public int totalTowerMax; //Field offset: 0x14
	private Dictionary<String, Int32> towerCounts; //Field offset: 0x18
	public Dictionary<String, Int32> towerMaxes; //Field offset: 0x20
	private Dictionary<String, Int32[2]> towerTierCounts; //Field offset: 0x28
	private Dictionary<String, Int32[2]> towerTierMaxes; //Field offset: 0x30
	private List<String> towerDisplayOrder; //Field offset: 0x38
	private List<FreeTowerInInventory> freeTowers; //Field offset: 0x40
	private List<TowerDiscount> towerDiscounts; //Field offset: 0x48

	public TowerInventory() { }

	public void AddFreeTowers(string baseId, int numberToAdd, string mutuallyExclusiveWith, int priority, Simulation sim) { }

	public void AddTierRestriction(string baseId, int path, int tier, int change) { }

	public void AddTowerDiscount(string discountName, String[] towers, int charges, float multiplier, float subtraction) { }

	public void CreatedTower(TowerModel def) { }

	public void DestroyedTower(TowerModel def) { }

	public void DisableTowers(IEnumerable<String> towerIds) { }

	public int GetFreeTowerCount(TowerModel towerModel) { }

	public List<FreeTowerSaveDataModel> GetFreeTowersSaveData() { }

	public float GetTowerCost(TowerModel tower) { }

	public void GetTowerDiscount(TowerModel def, ref float outTotalMultiplier, ref float outTotalDirectValueChange, bool useCharge) { }

	public List<TowerDiscount> GetTowerDiscounts() { }

	public List<TowerDiscountSaveDataModel> GetTowerDiscountSaveData() { }

	public int GetTowerInventoryCount(TowerModel def) { }

	public Dictionary<String, Int32> GetTowerInventoryMaxes() { }

	public int GetTowerInventoryRemaining(TowerModel def) { }

	public int GetTowerInventoryRemainingTotal() { }

	public bool HasInventory(TowerModel def) { }

	public bool HasUpgradeInventory(TowerModel def) { }

	public void Init(IEnumerable<TowerDetailsModel> allTowersInTheGame) { }

	public bool IsFreeTowerAvailable(TowerModel towerModel) { }

	public bool IsParagonLocked(Tower tower) { }

	public bool IsPathTierLocked(Tower tower, int path, int tier) { }

	public List<String> RetrieveTowerDisplayOrder() { }

	public void SetFreeTowersSaveData(List<FreeTowerSaveDataModel> freeTowersFromSave, Simulation sim) { }

	public void SetHero(string hero) { }

	public void SetMaxTowerCount(int maxTowerCount) { }

	public void SetTowerDiscountSaveData(List<TowerDiscountSaveDataModel> data) { }

	public void SetTowerMaxes(IEnumerable<TowerDetailsModel> towers) { }

	public void SetTowerTierRestrictions(IEnumerable<TowerDetailsModel> towers) { }

	public void UpdatedTower(TowerModel oldDef, TowerModel def) { }

	public void UseFreeTowerCharge(TowerModel towerModel) { }

}

