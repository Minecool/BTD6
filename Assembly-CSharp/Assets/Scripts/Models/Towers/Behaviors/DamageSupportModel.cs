namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DamageSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageSupportModel : SupportModel
{
	public float increase; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70

	public DamageSupportModel(string name, bool isUnique, float increase, string mutatorId, TowerFilterModel[] filters, bool isGlobal, bool isCustomRadius, float customRadius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

