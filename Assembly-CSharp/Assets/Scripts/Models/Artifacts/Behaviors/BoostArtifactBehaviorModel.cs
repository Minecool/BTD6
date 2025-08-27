namespace Assets.Scripts.Models.Artifacts.Behaviors;

public abstract class BoostArtifactBehaviorModel : ArtifactBehaviorModelBase
{
	public float multiplier; //Field offset: 0x30

	public BoostArtifactBehaviorModel(string name, float multiplier) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

