namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(RemoveAllDotAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveAllDotActionModel : BloonBehaviorActionModel
{
	public PrefabReference effect; //Field offset: 0x38
	public float effectOffsetY; //Field offset: 0x40
	public float effectLifespan; //Field offset: 0x44

	public RemoveAllDotActionModel() { }

	public RemoveAllDotActionModel(string name, string actionId, PrefabReference effect, float effectOffsetY, float effectLifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

