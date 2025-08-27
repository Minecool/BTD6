namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(IncreaseWorthTextEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncreaseWorthTextEffectModel : BloonBehaviorModel
{
	public PrefabReference assetId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public bool displayFullPayout; //Field offset: 0x3C

	public IncreaseWorthTextEffectModel() { }

	public IncreaseWorthTextEffectModel(string name, PrefabReference assetId, float lifespan, bool displayFullPayout) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

