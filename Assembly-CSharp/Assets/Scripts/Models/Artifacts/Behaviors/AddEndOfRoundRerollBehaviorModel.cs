namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class AddEndOfRoundRerollBehaviorModel : MapArtifactBehaviorModel
{
	public int addedRerolls; //Field offset: 0x30

	private AddEndOfRoundRerollBehaviorModel(string name, int addedRerolls) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

