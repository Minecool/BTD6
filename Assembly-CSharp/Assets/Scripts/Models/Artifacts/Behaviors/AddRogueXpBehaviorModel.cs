namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class AddRogueXpBehaviorModel : MapArtifactBehaviorModel
{
	public int xpPerStage; //Field offset: 0x30

	private AddRogueXpBehaviorModel(string name, int xpPerStage) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

