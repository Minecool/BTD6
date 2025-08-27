namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class RemoveArtifactAfterEndOfGameRerollBehaviorModel : MapArtifactBehaviorModel
{
	public string artifactModelName; //Field offset: 0x30
	private ILegendsDataProvider legendsDataProvider; //Field offset: 0x38

	private RemoveArtifactAfterEndOfGameRerollBehaviorModel(string name, string artifactModelName) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void OnRerolledRogueLoot(RogueLootType type) { }

}

