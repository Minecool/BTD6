namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateEffectOnExhausted), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnExhaustedModel : ProjectileBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x38
	public PrefabReference assetId; //Field offset: 0x40
	public float lifespan; //Field offset: 0x48
	public Fullscreen fullscreen; //Field offset: 0x4C
	public bool randomRotation; //Field offset: 0x50

	public CreateEffectOnExhaustedModel(string name, PrefabReference assetId, float lifespan, Fullscreen fullscreen, bool randomRotation, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

