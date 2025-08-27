namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CashbackZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CashbackZoneModel : TowerBehaviorBuffModel
{
	public float cashbackZoneMultiplier; //Field offset: 0x48
	public float cashbackMaxPercent; //Field offset: 0x4C
	public string groupName; //Field offset: 0x50
	public int maxStacks; //Field offset: 0x58
	public string baseIds; //Field offset: 0x60
	public String[] baseIdsArray; //Field offset: 0x68

	public CashbackZoneModel(string name, float cashbackZoneMultiplier, float cashbackMaxPercent, string groupName, int maxStacks, string buffLocsName, string buffIconName, string baseIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

