namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateEffectFromCollisionToCollision), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectFromCollisionToCollisionModel : ProjectileBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x38
	public float effectLength; //Field offset: 0x40

	public CreateEffectFromCollisionToCollisionModel(string name, EffectModel effectModel, float effectLength) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

