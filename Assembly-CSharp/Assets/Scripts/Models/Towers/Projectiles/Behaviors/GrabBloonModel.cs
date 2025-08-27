namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(GrabBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GrabBloonModel : ProjectileBehaviorModel
{
	public float grabDuration; //Field offset: 0x38
	public ProjectileModel projectile; //Field offset: 0x40
	public EmissionModel emission; //Field offset: 0x48

	public GrabBloonModel(string name, float grabDuration, ProjectileModel projectile, EmissionModel emission) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

