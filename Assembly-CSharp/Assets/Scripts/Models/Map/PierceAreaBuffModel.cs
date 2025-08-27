namespace Assets.Scripts.Models.Map;

public class PierceAreaBuffModel : AreaBuffModel
{
	public class AreaTowerPierceMutator : BehaviorMutator
	{
		private readonly float pierce; //Field offset: 0x70

		public AreaTowerPierceMutator(bool isUnique, string mutatorId, float pierce, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float pierce; //Field offset: 0x50
	private AreaTowerPierceMutator mutator; //Field offset: 0x58

	public PierceAreaBuffModel(string name, float pierce, string mutatorId, int priority, BuffIndicatorModel buffIndicatorModel, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

