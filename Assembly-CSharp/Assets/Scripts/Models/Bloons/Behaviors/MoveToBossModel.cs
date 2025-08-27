namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(MoveToBoss), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoveToBossModel : BloonBehaviorModel
{
	public float speedMultiplier; //Field offset: 0x30
	public float offsetMin; //Field offset: 0x34
	public float offsetMax; //Field offset: 0x38

	public MoveToBossModel() { }

	public MoveToBossModel(string name, float speedMultiplier, float offsetMin, float offsetMax) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

