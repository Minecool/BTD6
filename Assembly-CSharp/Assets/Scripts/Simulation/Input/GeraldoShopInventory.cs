namespace Assets.Scripts.Simulation.Input;

public class GeraldoShopInventory
{
	internal class GeraldoStockItem
	{
		private int lastReportedUsed; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public int used; //Field offset: 0x20
		public int remaining; //Field offset: 0x24
		public int replenishingFromRound; //Field offset: 0x28
		public int roundUnlockedAt; //Field offset: 0x2C

		public GeraldoStockItem() { }

		public GeraldoStockItem(GeraldoStockItem toCopy) { }

		public int GetUsedDeltaSinceLastReported() { }

	}

	private int owner; //Field offset: 0x10
	private readonly Dictionary<String, GeraldoItemModel> geraldoItemModelsByName; //Field offset: 0x18
	private readonly List<GeraldoStockItem> stockItems; //Field offset: 0x20
	private bool lvl20GeraldoRestockApplied; //Field offset: 0x28
	private IncreaseTowerWorthOverRoundsModel actionFigureWorthModel; //Field offset: 0x30
	private Simulation sim; //Field offset: 0x38

	public bool Lvl20GeraldoRestockApplied
	{
		 get { } //Length: 5
	}

	public List<GeraldoStockItem> StockItems
	{
		 get { } //Length: 5
	}

	public GeraldoShopInventory() { }

	private void CheckInitialReplenishFromRound(Tower tower, int fromRound) { }

	public void CombineStock(GeraldoShopInventory otherInventory) { }

	public bool DeductStock(string name, int round, int amount = 1) { }

	public bool get_Lvl20GeraldoRestockApplied() { }

	public List<GeraldoStockItem> get_StockItems() { }

	public int GetModifiedCost(string name, bool useRoundBasedModifiers) { }

	public int GetNumberOfPurchasesMade() { }

	public List<GeraldoStockItem> GetSaveData() { }

	public GeraldoStockItem GetStockItem(string name) { }

	public bool HasHitMaxPurchaseLimit(string name) { }

	public bool HasStock(string name) { }

	public void Init(Simulation sim, IEnumerable<GeraldoItemModel> allGeraldoItems, int owner) { }

	private void OnRoundEnd(int round) { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public void ResetStock() { }

	public void SetSaveData(List<GeraldoStockItem> stockItemsFromSave, bool lvl20GeraldoRestockAppliedFromSave) { }

	public void SetStock(string name, int remaining) { }

	public void SetStockToMax(int round, int inputId, bool fromTowerUpgrade) { }

}

