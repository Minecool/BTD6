namespace Assets.Scripts.Models.Map;

public class PriceAreaBuffModel : AreaBuffModel
{
	public class AreaTowerPriceMutator : BehaviorMutator
	{

		public AreaTowerPriceMutator(bool isUnique, string mutatorId, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x50
	private AreaTowerPriceMutator mutator; //Field offset: 0x58

	public PriceAreaBuffModel(string name, float multiplier, string mutatorId, int priority, BuffIndicatorModel buffIndicatorModel, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

