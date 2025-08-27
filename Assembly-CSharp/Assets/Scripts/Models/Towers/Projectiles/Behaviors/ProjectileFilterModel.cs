namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ProjectileFilter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileFilterModel : ProjectileBehaviorModel
{
	[SerializeReference]
	public FilterModel[] filters; //Field offset: 0x38

	public ProjectileFilterModel(string name, FilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

