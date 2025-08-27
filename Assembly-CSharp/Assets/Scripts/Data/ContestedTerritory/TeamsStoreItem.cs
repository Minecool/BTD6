namespace Assets.Scripts.Data.ContestedTerritory;

public class TeamsStoreItem : ScriptableObject
{
	public string id; //Field offset: 0x18
	[SerializeField]
	private bool isDefault; //Field offset: 0x20
	[SerializeField]
	private bool isEventPower; //Field offset: 0x21
	[SerializeField]
	private bool isEventRelic; //Field offset: 0x22
	[SerializeField]
	private bool isDisabled; //Field offset: 0x23
	[SerializeField]
	private bool isHiddenInStore; //Field offset: 0x24
	public TeamsStoreShopTab filter; //Field offset: 0x28
	[SerializeField]
	private ContestedTerritoryRelicType relicType; //Field offset: 0x2C
	public TeamStoreWorldSlot worldSlot; //Field offset: 0x30
	public PrefabReference worldObject; //Field offset: 0x38
	public SpriteReference icon; //Field offset: 0x40
	public TeamsStoreFlairData[] flairTypes; //Field offset: 0x48

	public bool IsDefault
	{
		 get { } //Length: 5
	}

	public bool IsDisabled
	{
		 get { } //Length: 5
	}

	public bool IsEventPower
	{
		 get { } //Length: 17
	}

	public bool IsEventRelic
	{
		 get { } //Length: 17
	}

	public bool IsHiddenInStore
	{
		 get { } //Length: 5
	}

	public ContestedTerritoryRelicType RelicType
	{
		 get { } //Length: 4
	}

	public TeamsStoreItem() { }

	public bool get_IsDefault() { }

	public bool get_IsDisabled() { }

	public bool get_IsEventPower() { }

	public bool get_IsEventRelic() { }

	public bool get_IsHiddenInStore() { }

	public ContestedTerritoryRelicType get_RelicType() { }

	public string GetLocalizedDescription() { }

	public string GetLocalizedShortName() { }

	public string GetLocalizedTitle() { }

	public string GetPrimaryFlairTarget() { }

	public TeamStoreFlairType GetPrimaryFlairType() { }

}

