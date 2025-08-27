namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(GeraldoItem), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GeraldoItemModel : TowerBasedShopItemModel
{
	public GeraldoItemBehaviorModel[] behaviorModels; //Field offset: 0x50
	public int cost; //Field offset: 0x58
	public bool canBeActivatedBetweenRounds; //Field offset: 0x5C
	public string towerId; //Field offset: 0x60
	public bool onlyReplenishIfNonePlaced; //Field offset: 0x68
	public bool showBuffsForTower; //Field offset: 0x69
	public int startingQuantity; //Field offset: 0x6C
	public int maxQuantity; //Field offset: 0x70
	public int roundsToReplenish; //Field offset: 0x74
	public int amountToReplenish; //Field offset: 0x78
	public int levelUnlockedAt; //Field offset: 0x7C
	public string bannedForModes; //Field offset: 0x80
	public String[] bannedForModesList; //Field offset: 0x88
	public int maxPurchases; //Field offset: 0x90
	public bool showGeraldoRangeCircle; //Field offset: 0x94
	public string blockPurchaseIfTowerPlaced; //Field offset: 0x98

	public GeraldoItemModel(string name, string locsId, GeraldoItemBehaviorModel[] behaviorModels, int cost, bool canBeActivatedBetweenRounds, SpriteReference icon, string towerId, bool onlyReplenishIfNonePlaced, bool showBuffsForTower, int startingQuantity, int maxQuantity, int roundsToReplenish, int amountToReplenish, int levelUnlockedAt, string bannedForModes, int maxPurchases, bool showGeraldoRangeCircle, string blockPurchaseIfTowerPlaced, SpriteReference[] iconSwaps, Int32[] iconSwapLevels) { }

	public virtual Model Clone() { }

	public bool DoesTowerIdMatch(string towerIdToCheck, Simulation sim, int owner) { }

	public TowerModel GetGeraldoItemTowerModel(Simulation sim, int owner, string towerName = "") { }

	public TowerModel GetGeraldoItemTowerModel(TowerModel original, int owner) { }

	private TowerModel GetOriginalGeraldoItemTowerModel(Simulation sim, int owner, string towerName) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

