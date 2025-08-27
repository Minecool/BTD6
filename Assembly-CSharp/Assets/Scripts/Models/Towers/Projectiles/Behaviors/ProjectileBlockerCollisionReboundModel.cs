namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ProjectileBlockerCollisionRebound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileBlockerCollisionReboundModel : ProjectileBehaviorModel
{
	public bool clearCollidedWith; //Field offset: 0x38
	public bool changeRotation; //Field offset: 0x39

	public ProjectileBlockerCollisionReboundModel(string name, bool clearCollidedWith, bool changeRotation = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

