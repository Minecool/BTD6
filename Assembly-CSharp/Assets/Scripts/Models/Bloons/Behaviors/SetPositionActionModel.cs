namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SetPositionAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetPositionActionModel : BloonBehaviorActionModel
{
	public float distance; //Field offset: 0x38
	public float speed; //Field offset: 0x3C

	public SetPositionActionModel() { }

	public SetPositionActionModel(string name, string actionId, float distance, float speed) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

