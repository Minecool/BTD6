namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateEffectOnExpire), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnExpireModel : ProjectileBehaviorModel
{
	public PrefabReference assetId; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40
	public Fullscreen fullscreen; //Field offset: 0x44
	public bool randomRotation; //Field offset: 0x48
	public EffectModel effectModel; //Field offset: 0x50
	public bool useTargetPosition; //Field offset: 0x58

	public CreateEffectOnExpireModel(string name, PrefabReference assetId, float lifespan, Fullscreen fullscreen, bool randomRotation, EffectModel effectModel, bool useTargetPosition) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

