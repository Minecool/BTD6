namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(WingmonkeySimulation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WingmonkeySimulationModel : SimulationBehaviorModel
{
	public float spacingX; //Field offset: 0x30
	public float spacingY; //Field offset: 0x34

	public WingmonkeySimulationModel(string name, float spacingX, float spacingY) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

