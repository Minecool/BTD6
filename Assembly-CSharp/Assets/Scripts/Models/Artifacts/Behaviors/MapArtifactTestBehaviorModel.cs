namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class MapArtifactTestBehaviorModel : MapArtifactBehaviorModel
{
	public string activateText; //Field offset: 0x30
	public string deactivateText; //Field offset: 0x38

	private MapArtifactTestBehaviorModel(string name, string activateText, string deactivateText) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

