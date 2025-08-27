namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateEffectFollowProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectFollowProjectileModel : ProjectileBehaviorModel
{
	public Vector3 offset; //Field offset: 0x38
	public EffectModel effectModel; //Field offset: 0x48

	public CreateEffectFollowProjectileModel(string name, EffectModel effectModel, Vector3 offset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

