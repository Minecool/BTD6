namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateLightningEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateLightningEffectModel : ProjectileBehaviorModel
{
	public float lifeSpan; //Field offset: 0x38
	public PrefabReference[] displayPaths; //Field offset: 0x40
	public Single[] displayLengths; //Field offset: 0x48

	public CreateLightningEffectModel(string name, float lifeSpan, PrefabReference displayPath1Small, float displayLength1Small, PrefabReference displayPath2Small, float displayLength2Small, PrefabReference displayPath3Small, float displayLength3Small, PrefabReference displayPath1Medium, float displayLength1Medium, PrefabReference displayPath2Medium, float displayLength2Medium, PrefabReference displayPath3Medium, float displayLength3Medium, PrefabReference displayPath1Large, float displayLength1Large, PrefabReference displayPath2Large, float displayLength2Large, PrefabReference displayPath3Large, float displayLength3Large) { }

	public CreateLightningEffectModel(string name, float lifeSpan, PrefabReference[] displayPaths, Single[] displayLengths) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

