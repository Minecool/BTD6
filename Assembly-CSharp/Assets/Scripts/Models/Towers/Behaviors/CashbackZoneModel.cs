namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CashbackZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CashbackZoneModel : TowerBehaviorBuffModel
{
	public float cashbackZoneMultiplier; //Field offset: 0x48
	public float cashbackMaxPercent; //Field offset: 0x4C
	public string groupName; //Field offset: 0x50
	public int maxStacks; //Field offset: 0x58

	public CashbackZoneModel(string name, float cashbackZoneMultiplier, float cashbackMaxPercent, string groupName, int maxStacks, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

