namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DamageTypeSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageTypeSupportModel : SupportModel
{
	public string mutatorId; //Field offset: 0x60
	public BloonProperties immuneBloonProperties; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x6C

	public DamageTypeSupportModel(string name, bool isUnique, string mutatorId, BloonProperties immuneBloonProperties, TowerFilterModel[] filters, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

