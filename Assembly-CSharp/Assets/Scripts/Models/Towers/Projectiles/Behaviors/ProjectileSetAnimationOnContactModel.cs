namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ProjectileSetAnimationOnContact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileSetAnimationOnContactModel : ProjectileBehaviorModel
{
	public int onContactAnimationId; //Field offset: 0x38

	public ProjectileSetAnimationOnContactModel(string name, int onContactAnimationId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

