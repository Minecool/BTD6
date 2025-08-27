namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(Power), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PowerModel : Model
{
	[DataMember]
	private int cost; //Field offset: 0x30
	public bool canBeActivatedBetweenRounds; //Field offset: 0x34
	public SpriteReference icon; //Field offset: 0x38
	public PowerBehaviorModel[] behaviors; //Field offset: 0x40
	public ApplyModModel[] mods; //Field offset: 0x48
	public TowerModel tower; //Field offset: 0x50
	public bool isDisabledByGameMode; //Field offset: 0x58
	public bool isHidden; //Field offset: 0x59
	public bool showBuffsForTower; //Field offset: 0x5A
	public int quantity; //Field offset: 0x5C
	public bool saveImmediately; //Field offset: 0x60
	public string storeNavigateToId; //Field offset: 0x68
	public int orderPriority; //Field offset: 0x70
	public bool alwaysPlaceAtScreenCentre; //Field offset: 0x74

	public bool CanBePurchasedWithMM
	{
		 get { } //Length: 107
	}

	public int Cost
	{
		 get { } //Length: 101
		 set { } //Length: 4
	}

	public PowerModel(string name, int cost, bool canBeActivatedBetweenRounds, SpriteReference icon, int quantity, PowerBehaviorModel[] behaviors, ApplyModModel[] mods, TowerModel tower, bool isHidden, bool showBuffsForTower, bool saveImmediately, string storeNavigateToId, int orderPriority, bool alwaysPlaceAtScreenCentre, bool isDisabledByGameMode = false) { }

	public virtual Model Clone() { }

	public bool get_CanBePurchasedWithMM() { }

	public int get_Cost() { }

	public string GetDescription(ILocProvider locProvider) { }

	public string GetTitle(ILocProvider locProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Cost(int value) { }

}

