namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateEffectAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectActionModel : BloonBehaviorActionModel
{
	public PrefabReference effect; //Field offset: 0x38
	public float scale; //Field offset: 0x40
	public float lifespan; //Field offset: 0x44

	public CreateEffectActionModel() { }

	public CreateEffectActionModel(string name, string actionId, PrefabReference effect, float scale, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

