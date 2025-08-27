namespace Assets.Scripts.Models.Map;

public class DamageTypeAreaBuffModel : AreaBuffModel
{
	public class MutatorTower : BehaviorMutator
	{
		private BloonProperties immuneBloonProperties; //Field offset: 0x70

		public MutatorTower(string id, bool isUnique, BuffIndicatorModel buffIndicator, BloonProperties immuneBloonProperties) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private MutatorTower mutator; //Field offset: 0x50
	public BloonProperties immuneBloonProperties; //Field offset: 0x58

	public DamageTypeAreaBuffModel(string name, string mutatorId, int priority, BuffIndicatorModel buffIndicator, BloonProperties immuneBloonProperties, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

