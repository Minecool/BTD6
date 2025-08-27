namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class BoostRerollCostModifierModel : MapArtifactBehaviorModel
{
	public float boostRerollModifier; //Field offset: 0x30

	private BoostRerollCostModifierModel(string name, float boostRerollModifier) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

