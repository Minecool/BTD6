namespace Assets.Scripts.Simulation.Input;

public class PowerInventory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public string discountName; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <AddPowerDiscount>b__0(PowerDiscount v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public PowerDiscountSaveDataModel d; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal bool <SetPowerDiscountSaveData>b__0(PowerDiscount v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_1
	{
		public PowerDiscount d; //Field offset: 0x10

		public <>c__DisplayClass30_1() { }

		internal bool <SetPowerDiscountSaveData>b__1(PowerDiscountSaveDataModel v) { }

	}

	private int totalPowerCount; //Field offset: 0x10
	public int totalPowerMax; //Field offset: 0x14
	private Dictionary<String, Int32> powerCounts; //Field offset: 0x18
	public Dictionary<String, Int32> powerMaxes; //Field offset: 0x20
	private List<String> powerDisplayOrder; //Field offset: 0x28
	private Dictionary<String, Int32> freePowers; //Field offset: 0x30
	private List<PowerDiscount> powerDiscounts; //Field offset: 0x38

	public PowerInventory() { }

	public void AddFreePowers(string baseId, int numberToAdd) { }

	public void AddPowerDiscount(string discountName, String[] powers, int charges, float multiplier, float subtraction) { }

	public void CreatedPower(PowerModel def) { }

	public void DestroyedPower(PowerModel def) { }

	public bool GetFreePower(PowerModel def, bool useCharge) { }

	public int GetFreePowerCount(PowerModel def) { }

	public Dictionary<String, Int32> GetFreePowers() { }

	public List<FreePowerSaveDataModel> GetFreePowersSaveData() { }

	public float GetPowerCost(PowerModel power) { }

	public void GetPowerDiscount(PowerModel def, ref float outTotalMultiplier, ref float outTotalDirectValueChange, bool useCharge) { }

	public List<PowerDiscount> GetPowerDiscounts() { }

	public List<PowerDiscountSaveDataModel> GetPowerDiscountSaveData() { }

	public int GetPowerInventoryCount(PowerModel def) { }

	public Dictionary<String, Int32> GetPowerInventoryMaxes() { }

	public int GetPowerInventoryMaxes(PowerModel def) { }

	public int GetPowerInventoryRemaining(PowerModel def) { }

	public int GetPowerInventoryRemainingTotal() { }

	public bool HasInventory(PowerModel def) { }

	public void Init(IEnumerable<PowerDetailsModel> allPowersInTheGame) { }

	public List<String> RetrievePowerDisplayOrder() { }

	public void SetFreePowersSaveData(List<FreePowerSaveDataModel> data) { }

	public void SetMaxPowerCount(int maxPowerCount) { }

	public void SetPowerDiscountSaveData(List<PowerDiscountSaveDataModel> data) { }

	public void SetPowerMaxes(IEnumerable<PowerDetailsModel> powers) { }

}

