namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ProjectileHeight), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileHeightModel : ProjectileBehaviorModel
{
	public Vector3[] heightEase; //Field offset: 0x38

	public ProjectileHeightModel(string name, Vector3[] heightEase) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

