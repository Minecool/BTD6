namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class AddMonkeyMoneyBehaviorModel : MapArtifactBehaviorModel
{
	public int monkeyMoneyPerStage; //Field offset: 0x30

	private AddMonkeyMoneyBehaviorModel(string name, int monkeyMoneyPerStage) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

