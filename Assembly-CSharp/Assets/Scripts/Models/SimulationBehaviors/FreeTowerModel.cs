namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(FreeTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FreeTowerModel : SimulationBehaviorModel
{
	public string baseTowerID; //Field offset: 0x30
	public int charges; //Field offset: 0x38
	public string mutuallyExclusiveWith; //Field offset: 0x40
	public int priority; //Field offset: 0x48

	public FreeTowerModel(string name, string baseTowerID, int charges, string mutuallyExclusiveWith, int priority) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

