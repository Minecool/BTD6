namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class AddBanAmountBehaviorModel : MapArtifactBehaviorModel
{
	public int addedBanAmounts; //Field offset: 0x30

	private AddBanAmountBehaviorModel(string name, int addedRerolls) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

