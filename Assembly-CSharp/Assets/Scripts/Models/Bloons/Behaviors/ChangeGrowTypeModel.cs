namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(ChangeGrowType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChangeGrowTypeModel : BloonBehaviorModel
{
	public BloonModel bloon; //Field offset: 0x30
	public BloonModel regenTo; //Field offset: 0x38

	public ChangeGrowTypeModel() { }

	public ChangeGrowTypeModel(string name, BloonModel bloon, BloonModel regenTo) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

