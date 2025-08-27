namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DiscountZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DiscountZoneModel : TowerBehaviorBuffModel
{
	public float discountMultiplier; //Field offset: 0x48
	public int stackLimit; //Field offset: 0x4C
	public string stackName; //Field offset: 0x50
	public string groupName; //Field offset: 0x58
	public bool affectSelf; //Field offset: 0x60
	public int tierCap; //Field offset: 0x64
	public string towerBaseIds; //Field offset: 0x68
	public String[] towerBaseIdList; //Field offset: 0x70
	public bool isBuffFromArea; //Field offset: 0x78
	public string upgradeId; //Field offset: 0x80
	public bool dontAffectOthersInCoop; //Field offset: 0x88

	public DiscountZoneModel(string name, float discountMultiplier, int stackLimit, string stackName, string groupName, bool affectSelf, int tierCap, string buffLocsName, string buffIconName, string towerBaseIds, string upgradeId, bool dontAffectOthersInCoop, bool isBuffFromArea = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

