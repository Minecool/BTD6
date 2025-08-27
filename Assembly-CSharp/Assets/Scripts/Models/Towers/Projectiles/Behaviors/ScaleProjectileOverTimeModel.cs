namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ScaleProjectileOverTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ScaleProjectileOverTimeModel : ProjectileBehaviorModel
{
	public float baseScale; //Field offset: 0x38
	public float maxScale; //Field offset: 0x3C
	public float scalePerSecond; //Field offset: 0x40
	public EffectModel effectModel; //Field offset: 0x48
	public ProjectileModel bonusProjectileModel; //Field offset: 0x50
	public EmissionModel emission; //Field offset: 0x58
	public float effectOffset; //Field offset: 0x60

	public ScaleProjectileOverTimeModel(string name, float baseScale, float maxScale, float scalePerSecond, EffectModel effectModel, ProjectileModel bonusProjectileModel, EmissionModel emission, float effectOffset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

