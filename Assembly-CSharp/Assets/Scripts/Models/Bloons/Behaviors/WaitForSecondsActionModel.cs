namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(WaitForSecondsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WaitForSecondsActionModel : BloonBehaviorActionModel
{
	public float delayTime; //Field offset: 0x38
	public String[] actionIds; //Field offset: 0x40

	public WaitForSecondsActionModel() { }

	public WaitForSecondsActionModel(string name, float delayTime, string actionId, String[] actionIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

