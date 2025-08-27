namespace Assets.Scripts.Data.GeraldoItems;

public class GeraldoItem : ScriptableObject
{
	public string locsId; //Field offset: 0x18
	public int cost; //Field offset: 0x20
	public bool canBeActivatedBetweenRounds; //Field offset: 0x24
	public SpriteReference icon; //Field offset: 0x28
	public string towerId; //Field offset: 0x30
	public bool onlyReplenishIfNonePlaced; //Field offset: 0x38
	public bool showBuffsForTower; //Field offset: 0x39
	public int startingQuantity; //Field offset: 0x3C
	public int maxQuantity; //Field offset: 0x40
	public int roundsToReplenish; //Field offset: 0x44
	public int amountToReplenish; //Field offset: 0x48
	public int levelUnlockedAt; //Field offset: 0x4C
	public string bannedForModes; //Field offset: 0x50
	public int maxPurchases; //Field offset: 0x58
	public float costIncreasePerRoundPercent; //Field offset: 0x5C
	public bool showGeraldoRangeCircle; //Field offset: 0x60
	public string blockPurchaseIfTowerPlaced; //Field offset: 0x68
	public SpriteReference[] iconSwaps; //Field offset: 0x70
	public Int32[] iconSwapLevels; //Field offset: 0x78
	[SerializeField]
	[SerializeReference]
	private IUIBehavior[] behaviours; //Field offset: 0x80
	private GeraldoItemModel def; //Field offset: 0x88

	public GeraldoItemModel Def
	{
		 get { } //Length: 627
	}

	public GeraldoItem() { }

	public GeraldoItemModel get_Def() { }

}

