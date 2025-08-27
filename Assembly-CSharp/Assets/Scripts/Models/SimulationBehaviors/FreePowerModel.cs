namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(FreePower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FreePowerModel : SimulationBehaviorModel
{
	public string basePowerID; //Field offset: 0x30
	public int charges; //Field offset: 0x38

	public FreePowerModel(string name, string basePowerID, int charges) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

