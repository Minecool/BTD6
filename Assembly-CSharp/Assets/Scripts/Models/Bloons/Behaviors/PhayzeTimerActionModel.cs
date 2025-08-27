namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PhayzeTimerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PhayzeTimerActionModel : BloonBehaviorActionModel
{
	public bool restore; //Field offset: 0x38

	public PhayzeTimerActionModel() { }

	public PhayzeTimerActionModel(string name, bool restore, string actionId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

