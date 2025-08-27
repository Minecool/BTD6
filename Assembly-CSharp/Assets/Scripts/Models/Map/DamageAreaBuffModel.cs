namespace Assets.Scripts.Models.Map;

public class DamageAreaBuffModel : AreaBuffModel
{
	public class AreaTowerDamageMutator : BehaviorMutator
	{
		private readonly float increase; //Field offset: 0x70

		public AreaTowerDamageMutator(float increase, bool isUnique, string mutatorId, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float increase; //Field offset: 0x50
	private AreaTowerDamageMutator mutator; //Field offset: 0x58

	public DamageAreaBuffModel(string name, float increase, string mutatorId, int priority, BuffIndicatorModel buffIndicatorModel, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

