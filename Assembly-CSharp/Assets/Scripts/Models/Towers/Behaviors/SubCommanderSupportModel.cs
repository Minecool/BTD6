namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SubCommanderSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SubCommanderSupportModel : SupportModel
{
	public bool isUnique; //Field offset: 0x60
	public int pierceIncrease; //Field offset: 0x64
	public int damageIncrease; //Field offset: 0x68
	public float damageScale; //Field offset: 0x6C

	public SubCommanderSupportModel(string name, bool isUnique, int pierceIncrease, int damageIncrease, float damageScale, TowerFilterModel[] filters, bool appliesToOwningTower, string buffLocsName, string buffIconName, bool isGlobal) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

