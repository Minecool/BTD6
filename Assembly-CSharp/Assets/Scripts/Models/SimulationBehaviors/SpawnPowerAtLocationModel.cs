namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SpawnPowerAtLocation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnPowerAtLocationModel : SimulationBehaviorModel
{
	public string powerId; //Field offset: 0x30
	public EnableOptions enableOptions; //Field offset: 0x38
	public Vector2 location; //Field offset: 0x50

	public SpawnPowerAtLocationModel(string powerId, EnableOptions enableOptions, Vector2 location) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

