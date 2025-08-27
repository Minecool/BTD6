namespace Assets.Scripts.Models.Map;

public class RateAreaBuffModel : AreaBuffModel
{
	public class AreaTowerRateMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public AreaTowerRateMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x50
	private AreaTowerRateMutator mutator; //Field offset: 0x58

	public RateAreaBuffModel(string name, float multiplier, string mutatorId, int priority, BuffIndicatorModel buffIndicatorModel, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

