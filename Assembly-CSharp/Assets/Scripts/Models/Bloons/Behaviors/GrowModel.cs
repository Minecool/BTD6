namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(Grow), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GrowModel : BloonBehaviorModel
{
	public float rate; //Field offset: 0x30
	public string growToId; //Field offset: 0x38
	public string overrideChildWithColor; //Field offset: 0x40

	public GrowModel() { }

	public GrowModel(string name, float rate, string growToId, string overrideChildWithColor) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

