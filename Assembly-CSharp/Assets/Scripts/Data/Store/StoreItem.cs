namespace Assets.Scripts.Data.Store;

public class StoreItem : ScriptableObject
{
	internal class Epic
	{
		public string offerId; //Field offset: 0x10
		public string audienceItemId; //Field offset: 0x18

		public Epic() { }

	}

	public string productID; //Field offset: 0x18
	public ProductModelType productType; //Field offset: 0x20
	public string loot; //Field offset: 0x28
	public bool viewableInStore; //Field offset: 0x30
	public bool availableInGame; //Field offset: 0x31
	public bool viewableInHeroes; //Field offset: 0x32
	public string associatedHeroes; //Field offset: 0x38
	public int notAvailableIfRankOver; //Field offset: 0x40
	public int onlyAvailableIfRankOver; //Field offset: 0x44
	public string overridesProductID; //Field offset: 0x48
	public SpriteReference icon; //Field offset: 0x50
	public SpriteReference icon2; //Field offset: 0x58
	public DateTime endDate; //Field offset: 0x60
	public bool showTimer; //Field offset: 0x68
	public int monkeyMoneyCost; //Field offset: 0x6C
	public int batchId; //Field offset: 0x70
	public bool isOneTimeConsumable; //Field offset: 0x74
	public bool showLootPanel; //Field offset: 0x75
	public bool isPropPack; //Field offset: 0x76
	public bool showRewardsUiImmediately; //Field offset: 0x77
	[TypeSelectionAsString("Assets.Scripts.Unity.Store", typeof(StoreItemCondition))]
	public string conditionalClassType; //Field offset: 0x78
	private StoreItemCondition condition; //Field offset: 0x80
	public bool consumable; //Field offset: 0x88
	[Header("Store Overrides")]
	public Epic epic; //Field offset: 0x90
	public uint steamDlcId; //Field offset: 0x98

	public StoreItem() { }

	[CompilerGenerated]
	private bool <GetStoreCategory>b__36_0(StoreItemSettings x) { }

	[CompilerGenerated]
	private bool <IsActive>b__28_0(IapEvent iapEvent) { }

	public ValueTuple<Boolean, Boolean> CheckCondition(int rank) { }

	public string GetLocalizedDescription(ILocProvider locProvider) { }

	public string GetLocalizedTitle(ILocProvider locProvider) { }

	public LootSet GetLootSet() { }

	public StoreCategoryFilter GetStoreCategory() { }

	public TimeSpan GetTimeRemaining() { }

	public bool HasEndDate() { }

	public bool HasSeenStoreItem() { }

	public bool IsActive() { }

	public bool IsItemForHero(string heroId) { }

	public bool IsNewItem() { }

	public void SetSeenStoreItem() { }

}

