namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class AddRewardChoiceBehaviorModel : MapArtifactBehaviorModel
{
	public int choiceAdditionAmount; //Field offset: 0x30

	private AddRewardChoiceBehaviorModel(string name, int choiceAdditionAmount) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

