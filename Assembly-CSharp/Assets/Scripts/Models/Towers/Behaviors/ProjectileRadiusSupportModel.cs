namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ProjectileRadiusSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileRadiusSupportModel : SupportModel
{
	public float multiplier; //Field offset: 0x60
	public String[] filterTowers; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70
	public string mutatorId; //Field offset: 0x78

	public ProjectileRadiusSupportModel(string name, float multiplier, bool isUnique, string mutatorId, bool isGlobal, TowerFilterModel[] filters, String[] filterTowers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

