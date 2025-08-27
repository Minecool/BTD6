namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(AddArtifactToSimulation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddArtifactToSimulationModel : SimulationBehaviorModel
{
	public String[] artifactIds; //Field offset: 0x30
	public EnableOptions enableOptions; //Field offset: 0x38

	public AddArtifactToSimulationModel(String[] artifactIds, EnableOptions enableOptions) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

