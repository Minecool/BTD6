namespace Assets.Scripts.Data.TrophyStore;

public class TrophyStoreItem : ScriptableObject
{
	[SerializeField]
	private string id; //Field offset: 0x18
	[SerializeField]
	private string walletIdOverride; //Field offset: 0x20
	public TrophyStoreFilter storeFilter; //Field offset: 0x28
	public TrophyItemTypeData[] itemTypes; //Field offset: 0x30
	public TrophyItemSubFilter subFilter; //Field offset: 0x38
	public TrophyItemLootSet lootSetFilter; //Field offset: 0x3C
	public string questId; //Field offset: 0x40
	public SpriteReference icon; //Field offset: 0x48
	public float cosmeticPriority; //Field offset: 0x50
	public string exclusivity; //Field offset: 0x58

	public string Id
	{
		 get { } //Length: 44
	}

	public string OriginalId
	{
		 get { } //Length: 5
	}

	public TrophyStoreItem() { }

	public string get_Id() { }

	public string get_OriginalId() { }

	public string GetLocalizedDescription() { }

	public string GetLocalizedShortName() { }

	public string GetLocalizedTitle() { }

	public string GetPrimaryItemTarget() { }

	public TrophyItemType GetPrimaryItemType() { }

}

