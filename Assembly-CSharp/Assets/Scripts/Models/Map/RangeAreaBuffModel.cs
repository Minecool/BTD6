namespace Assets.Scripts.Models.Map;

public class RangeAreaBuffModel : AreaBuffModel
{
	public class AreaTowerRangeMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public AreaTowerRangeMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x50
	private AreaTowerRangeMutator mutator; //Field offset: 0x58

	public RangeAreaBuffModel(string name, float multiplier, string mutatorId, int priority, BuffIndicatorModel buffIndicator, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

