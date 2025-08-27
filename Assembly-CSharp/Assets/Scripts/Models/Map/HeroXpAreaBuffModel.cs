namespace Assets.Scripts.Models.Map;

public class HeroXpAreaBuffModel : AreaBuffModel
{
	public class MutatorTower : BehaviorMutator
	{
		public float multiplier; //Field offset: 0x70

		public MutatorTower(bool isUnique, string mutatorId, BuffIndicatorModel buffIndicator, float multiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private MutatorTower mutator; //Field offset: 0x50
	public float multiplier; //Field offset: 0x58

	public HeroXpAreaBuffModel(string name, string mutatorId, int priority, BuffIndicatorModel buffIndicator, float multiplier, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

