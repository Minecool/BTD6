namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ProjectileSpeedSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileSpeedSupportModel : SupportModel
{
	public float multiplier; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70

	public ProjectileSpeedSupportModel(string name, bool isUnique, float multiplier, string mutatorId, TowerFilterModel[] filters, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

