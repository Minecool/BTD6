namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateTextEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateTextEffectModel : ProjectileBehaviorModel
{
	public PrefabReference assetId; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40
	public bool useTowerPosition; //Field offset: 0x44

	public CreateTextEffectModel(string name, PrefabReference assetId, float lifespan, bool useTowerPosition) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

