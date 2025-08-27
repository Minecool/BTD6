namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SellIncreaseZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SellIncreaseZoneModel : TowerBehaviorBuffModel
{
	public TowerFilterModel[] filters; //Field offset: 0x48
	public float sellMultiplier; //Field offset: 0x50
	public string towerBaseIds; //Field offset: 0x58
	public String[] towerBaseIdsList; //Field offset: 0x60

	public SellIncreaseZoneModel(string name, float sellMultiplier, TowerFilterModel[] filters, string buffLocsName, string towerBaseIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

