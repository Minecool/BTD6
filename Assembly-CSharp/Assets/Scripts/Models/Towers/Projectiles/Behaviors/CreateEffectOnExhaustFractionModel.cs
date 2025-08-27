namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateEffectOnExhaustFraction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnExhaustFractionModel : ProjectileBehaviorModel
{
	public float lifespan; //Field offset: 0x38
	public Fullscreen fullscreen; //Field offset: 0x3C
	public float fraction; //Field offset: 0x40
	public float durationFraction; //Field offset: 0x44
	public bool randomRotation; //Field offset: 0x48
	public EffectModel effectModel; //Field offset: 0x50

	public CreateEffectOnExhaustFractionModel(string name, EffectModel effectModel, float lifespan, Fullscreen fullscreen, float fraction, float durationFraction, bool randomRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

